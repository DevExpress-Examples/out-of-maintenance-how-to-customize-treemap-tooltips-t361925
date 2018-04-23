Namespace ToolTipCustomization
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim treeMapPaletteColorizer1 As New DevExpress.XtraTreeMap.TreeMapPaletteColorizer()
            Dim treeMapItemStorage1 As New DevExpress.XtraTreeMap.TreeMapItemStorage()
            Dim treeMapItem1 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem2 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem3 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem4 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem5 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem6 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem7 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem8 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem9 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem10 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem11 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem12 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem13 As New DevExpress.XtraTreeMap.TreeMapItem()
            Me.treeMap = New DevExpress.XtraTreeMap.TreeMapControl()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.chkShowTooltip = New DevExpress.XtraEditors.CheckEdit()
            Me.chkTooltipController = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            DirectCast(Me.treeMap, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.chkShowTooltip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chkTooltipController.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeMap
            ' 
            Me.treeMap.BackColor = System.Drawing.Color.White
            treeMapPaletteColorizer1.ColorizeGroups = True
            treeMapPaletteColorizer1.Palette = DevExpress.XtraTreeMap.Palette.Office2016Palette
            Me.treeMap.Colorizer = treeMapPaletteColorizer1
            treeMapItem2.Label = "United States"
            treeMapItem2.Value = 17.418R
            treeMapItem3.Label = "Brazil"
            treeMapItem3.Value = 2.353R
            treeMapItem1.Children.AddRange(New DevExpress.XtraTreeMap.TreeMapItem() { treeMapItem2, treeMapItem3})
            treeMapItem1.Label = "Americas"
            treeMapItem5.Label = "China"
            treeMapItem5.Value = 10.38R
            treeMapItem6.Label = "Japan"
            treeMapItem6.Value = 4.616R
            treeMapItem7.Label = "India"
            treeMapItem7.Value = 2.049R
            treeMapItem4.Children.AddRange(New DevExpress.XtraTreeMap.TreeMapItem() { treeMapItem5, treeMapItem6, treeMapItem7})
            treeMapItem4.Label = "Asia"
            treeMapItem9.Label = "Germany"
            treeMapItem9.Value = 3.859R
            treeMapItem10.Label = "United Kingdom"
            treeMapItem10.Value = 2.945R
            treeMapItem11.Label = "France"
            treeMapItem11.Value = 2.846R
            treeMapItem12.Label = "Italy"
            treeMapItem12.Value = 2.147R
            treeMapItem13.Label = "Russia"
            treeMapItem13.Value = 1.857R
            treeMapItem8.Children.AddRange(New DevExpress.XtraTreeMap.TreeMapItem() { treeMapItem9, treeMapItem10, treeMapItem11, treeMapItem12, treeMapItem13})
            treeMapItem8.Label = "Europe"
            treeMapItemStorage1.Items.AddRange(New DevExpress.XtraTreeMap.TreeMapItem() { treeMapItem1, treeMapItem4, treeMapItem8})
            Me.treeMap.DataAdapter = treeMapItemStorage1
            Me.treeMap.GroupStyle.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.treeMap.LeafStyle.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.treeMap.LeafTextPattern = "{L} : {V:C1} trillions"
            Me.treeMap.Location = New System.Drawing.Point(6, 6)
            Me.treeMap.Name = "treeMap"
            Me.treeMap.Size = New System.Drawing.Size(483, 309)
            Me.treeMap.TabIndex = 0
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.chkShowTooltip)
            Me.layoutControl1.Controls.Add(Me.chkTooltipController)
            Me.layoutControl1.Controls.Add(Me.treeMap)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(624, 321)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' chkShowTooltip
            ' 
            Me.chkShowTooltip.Location = New System.Drawing.Point(493, 6)
            Me.chkShowTooltip.Name = "chkShowTooltip"
            Me.chkShowTooltip.Properties.Caption = "Show Tooltip"
            Me.chkShowTooltip.Size = New System.Drawing.Size(125, 19)
            Me.chkShowTooltip.StyleController = Me.layoutControl1
            Me.chkShowTooltip.TabIndex = 5
            ' 
            ' chkTooltipController
            ' 
            Me.chkTooltipController.Location = New System.Drawing.Point(493, 29)
            Me.chkTooltipController.Name = "chkTooltipController"
            Me.chkTooltipController.Properties.Caption = "Use Tooltip Controller"
            Me.chkTooltipController.Size = New System.Drawing.Size(125, 19)
            Me.chkTooltipController.StyleController = Me.layoutControl1
            Me.chkTooltipController.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(624, 321)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.treeMap
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(487, 313)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.chkTooltipController
            Me.layoutControlItem2.Location = New System.Drawing.Point(487, 23)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(129, 290)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chkShowTooltip
            Me.layoutControlItem3.Location = New System.Drawing.Point(487, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(129, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' toolTipController1
            ' 
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 321)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.treeMap, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.chkShowTooltip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chkTooltipController.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private treeMap As DevExpress.XtraTreeMap.TreeMapControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents chkShowTooltip As DevExpress.XtraEditors.CheckEdit
        Private WithEvents chkTooltipController As DevExpress.XtraEditors.CheckEdit
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
    End Class
End Namespace

