using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using Qlik.Engine;
using Qlik.Sense.Client;
using Qlik.Sense.Client.Visualizations;

namespace QlikWord
{
    public partial class Ribbon1
    {
       
        private ILocation _location;
        private void QlikSenseLocation()
        {
            _location = Qlik.Engine.Location.FromUri(new Uri("ws://127.0.0.1:4848"));            
        }

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private RibbonDropDownItem CreateRibbonDropDownItem()
        {
            return this.Factory.CreateRibbonDropDownItem();
        }

        private void buttonConnectToEngine_Click(object sender, RibbonControlEventArgs e)
        {
            // Single Qlik Sense Desktop with no special settings            
            QlikSenseLocation();
            // Defining the location as a direct connection to Qlik Sense Personal
            _location.AsDirectConnectionToPersonalEdition();            
            using (IHub hub = _location.Hub())
            {
                editBox1.Text = hub.ProductVersion();
            }

            bindingSource1.DataSource = _location.GetAppIdentifiers();

            foreach (IAppIdentifier appIdentifier in _location.GetAppIdentifiers())
            {
                dropDown1.Items.Add(CreateRibbonDropDownItem());
                dropDown1.Items.Last().Label = appIdentifier.AppName;
            }                  

        }

        private void dropDown1_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
         
          Document nativeDocument = Globals.ThisAddIn.Application.ActiveDocument;                        
            nativeDocument.Paragraphs[1].Range.InsertParagraphAfter();  
            nativeDocument.Paragraphs[1].Range.Text = dropDown1.SelectedItem.Label;
            Microsoft.Office.Interop.Word.Range firstRange = nativeDocument.Paragraphs[1].Range;
            firstRange.Font.Size = 20;           
            dropDown2.Items.Clear();
            listSheets(dropDown1.SelectedItem.Label);
        }

        private void listSheets(string appName)
        {
            
            IAppIdentifier foundAppIdentifier = _location.AppWithNameOrDefault(appName);
            IApp application = _location.App(foundAppIdentifier);
            ISheetList sheetList = application.GetSheetList();
            foreach (ISheetObjectViewListContainer item in sheetList.Items)
            {
                dropDown2.Items.Add(CreateRibbonDropDownItem());
                dropDown2.Items.Last().Label = item.Data.Title;
            }

        }

        private void listObjects(string sheetName, string appName)
        {
            IAppIdentifier foundAppIdentifier = _location.AppWithNameOrDefault(appName);
            IApp application = _location.App(foundAppIdentifier);

            IEnumerable<ISheet> sheets = application.GetSheets();

            foreach (ISheet sheet1 in sheets)
            {
                if(sheet1.MetaAttributes.Title == sheetName) {
                    foreach (IGenericObject child in sheet1.Children)
                    {                        
                        dropDown3.Items.Add(CreateRibbonDropDownItem());
                        dropDown3.Items.Last().Label = child.GetLayout().As<VisualizationBaseLayout>().Title + " <" + child.Info.Type.ToString() + ">";
                        dropDown3.Items.Last().Tag = child.Info.Id;
                    }                   
                }   
            }            
        }

        private void dropDown2_SelectionChanged(object sender, RibbonControlEventArgs e)
        {            
            Document nativeDocument = Globals.ThisAddIn.Application.ActiveDocument;
            nativeDocument.Paragraphs[1].Range.InsertParagraphAfter();
            nativeDocument.Paragraphs[1].Range.Text += dropDown2.SelectedItem.Label;
            Microsoft.Office.Interop.Word.Range secondRange = nativeDocument.Paragraphs[1].Range.Next();                          
            secondRange.Font.Size = 20;
            dropDown3.Items.Clear();
            listObjects(dropDown2.SelectedItem.Label, dropDown1.SelectedItem.Label);
        }

        void showChart(string urlToQlikObject)
        {
            System.Diagnostics.Process.Start(urlToQlikObject);
        }



        private void group4_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            string showQlikObject = "http://localhost:4848/single?appid=" + dropDown1.SelectedItem.Label + "&obj=" + dropDown3.SelectedItem.Tag + "&select=clearall";
            showChart(showQlikObject);
        }

        private void toggleButton1_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
