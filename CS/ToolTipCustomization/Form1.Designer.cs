namespace ToolTipCustomization {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraTreeMap.TreeMapPaletteColorizer treeMapPaletteColorizer1 = new DevExpress.XtraTreeMap.TreeMapPaletteColorizer();
            DevExpress.XtraTreeMap.TreeMapItemStorage treeMapItemStorage1 = new DevExpress.XtraTreeMap.TreeMapItemStorage();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem1 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem2 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem3 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem4 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem5 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem6 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem7 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem8 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem9 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem10 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem11 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem12 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem13 = new DevExpress.XtraTreeMap.TreeMapItem();
            this.treeMap = new DevExpress.XtraTreeMap.TreeMapControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkShowTooltip = new DevExpress.XtraEditors.CheckEdit();
            this.chkTooltipController = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowTooltip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTooltipController.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // treeMap
            // 
            this.treeMap.BackColor = System.Drawing.Color.White;
            treeMapPaletteColorizer1.ColorizeGroups = true;
            treeMapPaletteColorizer1.Palette = DevExpress.XtraTreeMap.Palette.Office2016Palette;
            this.treeMap.Colorizer = treeMapPaletteColorizer1;
            treeMapItem2.Label = "United States";
            treeMapItem2.Value = 17.418D;
            treeMapItem3.Label = "Brazil";
            treeMapItem3.Value = 2.353D;
            treeMapItem1.Children.AddRange(new DevExpress.XtraTreeMap.TreeMapItem[] {
            treeMapItem2,
            treeMapItem3});
            treeMapItem1.Label = "Americas";
            treeMapItem5.Label = "China";
            treeMapItem5.Value = 10.38D;
            treeMapItem6.Label = "Japan";
            treeMapItem6.Value = 4.616D;
            treeMapItem7.Label = "India";
            treeMapItem7.Value = 2.049D;
            treeMapItem4.Children.AddRange(new DevExpress.XtraTreeMap.TreeMapItem[] {
            treeMapItem5,
            treeMapItem6,
            treeMapItem7});
            treeMapItem4.Label = "Asia";
            treeMapItem9.Label = "Germany";
            treeMapItem9.Value = 3.859D;
            treeMapItem10.Label = "United Kingdom";
            treeMapItem10.Value = 2.945D;
            treeMapItem11.Label = "France";
            treeMapItem11.Value = 2.846D;
            treeMapItem12.Label = "Italy";
            treeMapItem12.Value = 2.147D;
            treeMapItem13.Label = "Russia";
            treeMapItem13.Value = 1.857D;
            treeMapItem8.Children.AddRange(new DevExpress.XtraTreeMap.TreeMapItem[] {
            treeMapItem9,
            treeMapItem10,
            treeMapItem11,
            treeMapItem12,
            treeMapItem13});
            treeMapItem8.Label = "Europe";
            treeMapItemStorage1.Items.AddRange(new DevExpress.XtraTreeMap.TreeMapItem[] {
            treeMapItem1,
            treeMapItem4,
            treeMapItem8});
            this.treeMap.DataAdapter = treeMapItemStorage1;
            this.treeMap.GroupStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeMap.LeafStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeMap.LeafTextPattern = "{L} : {V:C1} trillions";
            this.treeMap.Location = new System.Drawing.Point(6, 6);
            this.treeMap.Name = "treeMap";
            this.treeMap.Size = new System.Drawing.Size(483, 309);
            this.treeMap.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkShowTooltip);
            this.layoutControl1.Controls.Add(this.chkTooltipController);
            this.layoutControl1.Controls.Add(this.treeMap);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(624, 321);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkShowTooltip
            // 
            this.chkShowTooltip.Location = new System.Drawing.Point(493, 6);
            this.chkShowTooltip.Name = "chkShowTooltip";
            this.chkShowTooltip.Properties.Caption = "Show Tooltip";
            this.chkShowTooltip.Size = new System.Drawing.Size(125, 19);
            this.chkShowTooltip.StyleController = this.layoutControl1;
            this.chkShowTooltip.TabIndex = 5;
            this.chkShowTooltip.CheckedChanged += new System.EventHandler(this.chkShowTooltip_CheckedChanged);
            // 
            // chkTooltipController
            // 
            this.chkTooltipController.Location = new System.Drawing.Point(493, 29);
            this.chkTooltipController.Name = "chkTooltipController";
            this.chkTooltipController.Properties.Caption = "Use Tooltip Controller";
            this.chkTooltipController.Size = new System.Drawing.Size(125, 19);
            this.chkTooltipController.StyleController = this.layoutControl1;
            this.chkTooltipController.TabIndex = 4;
            this.chkTooltipController.CheckedChanged += new System.EventHandler(this.chkTooltipController_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(624, 321);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.treeMap;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(487, 313);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkTooltipController;
            this.layoutControlItem2.Location = new System.Drawing.Point(487, 23);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(129, 290);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkShowTooltip;
            this.layoutControlItem3.Location = new System.Drawing.Point(487, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(129, 23);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // toolTipController1
            // 
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkShowTooltip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTooltipController.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeMap.TreeMapControl treeMap;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.CheckEdit chkShowTooltip;
        private DevExpress.XtraEditors.CheckEdit chkTooltipController;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}

