using DevExpress.Utils;
using DevExpress.XtraTreeMap;
using System;
using System.Windows.Forms;

namespace ToolTipCustomization {
    public partial class Form1 : Form {
        const String GroupToolTipText = "Place the cursor over an item to obtain information about it.";
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            chkShowTooltip.Checked = treeMap.ShowToolTips;

            treeMap.ToolTipLeafPattern = "{L} : {V:C1} trillions";
            treeMap.ToolTipGroupPattern = GroupToolTipText;
        }

        private void chkShowTooltip_CheckedChanged(object sender, EventArgs e) {
            treeMap.ShowToolTips = chkShowTooltip.Checked;
        }

        private void chkTooltipController_CheckedChanged(object sender, EventArgs e) {
            treeMap.ToolTipController = (chkTooltipController.Checked) ? toolTipController1 : null;
        }

        private void toolTipController1_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            TreeMapItem item = e.SelectedObject as TreeMapItem;
            if(item == null) return;
            if(item.IsGroup) return;

            SuperToolTip superTip = new SuperToolTip { AllowHtmlText = DefaultBoolean.True };
            superTip.Items.Add(new ToolTipTitleItem { Text = String.Format("{0} statistics", item.Label) });
            superTip.Items.Add(new ToolTipSeparatorItem());
            superTip.Items.Add(new ToolTipItem { Text = String.Format("<b>GDP (2014):</b> {0:C1} trillions", item.Value) });
            e.SuperTip = superTip;

        }
    }
}
