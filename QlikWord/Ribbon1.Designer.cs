namespace QlikWord
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.buttonConnectToEngine = this.Factory.CreateRibbonButton();
            this.editBox1 = this.Factory.CreateRibbonEditBox();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.dropDown1 = this.Factory.CreateRibbonDropDown();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.dropDown2 = this.Factory.CreateRibbonDropDown();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.dropDown3 = this.Factory.CreateRibbonDropDown();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.group4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group4);
            this.tab1.Label = "Qlik";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.buttonConnectToEngine);
            this.group1.Items.Add(this.editBox1);
            this.group1.Label = "Connection";
            this.group1.Name = "group1";
            // 
            // buttonConnectToEngine
            // 
            this.buttonConnectToEngine.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonConnectToEngine.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnectToEngine.Image")));
            this.buttonConnectToEngine.Label = "Connect";
            this.buttonConnectToEngine.Name = "buttonConnectToEngine";
            this.buttonConnectToEngine.ShowImage = true;
            this.buttonConnectToEngine.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonConnectToEngine_Click);
            // 
            // editBox1
            // 
            this.editBox1.Label = "Server";
            this.editBox1.Name = "editBox1";
            this.editBox1.Text = null;
            // 
            // group2
            // 
            this.group2.Items.Add(this.dropDown1);
            this.group2.Label = "Apps";
            this.group2.Name = "group2";
            // 
            // dropDown1
            // 
            this.dropDown1.Label = " ";
            this.dropDown1.Name = "dropDown1";
            this.dropDown1.ScreenTip = "List of Apps";
            this.dropDown1.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDown1_SelectionChanged);
            // 
            // group3
            // 
            this.group3.Items.Add(this.dropDown2);
            this.group3.Label = "Sheets";
            this.group3.Name = "group3";
            // 
            // dropDown2
            // 
            this.dropDown2.Label = " ";
            this.dropDown2.Name = "dropDown2";
            this.dropDown2.ScreenTip = "List of Sheets";
            this.dropDown2.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDown2_SelectionChanged);
            // 
            // group4
            // 
            ribbonDialogLauncherImpl1.Image = global::QlikWord.Properties.Resources.qlik_sense_logo;
            ribbonDialogLauncherImpl1.SuperTip = "Show as Single";
            this.group4.DialogLauncher = ribbonDialogLauncherImpl1;
            this.group4.Items.Add(this.dropDown3);
            this.group4.Label = "Objects";
            this.group4.Name = "group4";
            this.group4.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.group4_DialogLauncherClick);
            // 
            // dropDown3
            // 
            this.dropDown3.Label = " ";
            this.dropDown3.Name = "dropDown3";
            this.dropDown3.ScreenTip = "List of Objects";
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonConnectToEngine;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        private System.Windows.Forms.BindingSource bindingSource1;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown2;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown3;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
