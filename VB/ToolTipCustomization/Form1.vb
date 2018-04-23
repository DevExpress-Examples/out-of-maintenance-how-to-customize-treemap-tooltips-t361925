Imports DevExpress.Utils
Imports DevExpress.XtraTreeMap
Imports System
Imports System.Windows.Forms

Namespace ToolTipCustomization
    Partial Public Class Form1
        Inherits Form

        Private Const GroupToolTipText As String = "Place the cursor over an item to obtain information about it."
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            chkShowTooltip.Checked = treeMap.ShowToolTips

            treeMap.ToolTipLeafPattern = "{L} : {V:C1} trillions"
            treeMap.ToolTipGroupPattern = GroupToolTipText
        End Sub

        Private Sub chkShowTooltip_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowTooltip.CheckedChanged
            treeMap.ShowToolTips = chkShowTooltip.Checked
        End Sub

        Private Sub chkTooltipController_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkTooltipController.CheckedChanged
            treeMap.ToolTipController = If(chkTooltipController.Checked, toolTipController1, Nothing)
        End Sub

        Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs) Handles toolTipController1.BeforeShow
            Dim item As TreeMapItem = TryCast(e.SelectedObject, TreeMapItem)
            If item Is Nothing Then
                Return
            End If
            If item.IsGroup Then
                Return
            End If

            Dim superTip As SuperToolTip = New SuperToolTip With {.AllowHtmlText = DefaultBoolean.True}
            superTip.Items.Add(New ToolTipTitleItem With {.Text = String.Format("{0} statistics", item.Label)})
            superTip.Items.Add(New ToolTipSeparatorItem())
            superTip.Items.Add(New ToolTipItem With {.Text = String.Format("<b>GDP (2014):</b> {0:C1} trillions", item.Value)})
            e.SuperTip = superTip

        End Sub
    End Class
End Namespace
