' Developer Express Code Central Example:
' How to implement the ISearchControlClient interface
' 
' We have SearchControl
' (https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSearchControltopic)
' (added in v14.1), which provides the search and filter functionality for the
' attached object. SearchControl can be attached to objects that support the
' ISearchControlClient interface. You can find a list of our controls that support
' this interface out of the box in the SearchControl
' (https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSearchControltopic)
' help topic.
' However, this list can be extended by your own. This example
' illustrates how to implement the ISearchControlClient interface for a Form for
' searching and highlighting controls by their names.
' 
' To introduce the
' ISearchControlClient interface into your project, implement the following
' members: - SetSearchControl - this method is invoked when you attach/detach your
' object from the SearchControl.Client
' (https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsSearchControl_Clienttopic)
' property. - IsAttachedToSearchControl - this property determines whether your
' object is attached to SearchControl. - ApplyFindFilter - this method is invoked
' when filtering is performed. Here you need to implement your own logic for
' filtering. - CreateSearchProvider - this method must return
' SearchControlProviderBase's descendant. This provider contains SearchText and
' FilterCondition obtained from the RepositoryItemSearchControl.FilterCondition
' (https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItemSearchControl_FilterConditiontopic)
' property.
' It is necessary to override the
' SearchControlProviderBase.GetCriteriaInfoCore method to return SearchInfoBase's
' descendant. This instance should contain all required information for your
' filtering. It is passed to the ApplyFindFilter method as a parameter.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T162421


Imports Microsoft.VisualBasic
Imports System
Namespace dxExample
	Partial Public Class Main
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
			Dim tileItemElement1 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement2 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement3 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement4 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement5 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement6 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement7 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement8 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement9 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement10 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement11 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement12 As New DevExpress.XtraEditors.TileItemElement()
			Me.customTileControl1 = New dxExample.CustomTileControl()
			Me.tileGroup2 = New DevExpress.XtraEditors.TileGroup()
			Me.tileItem1 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem2 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem3 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem9 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem10 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem11 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem12 = New DevExpress.XtraEditors.TileItem()
			Me.tileGroup3 = New DevExpress.XtraEditors.TileGroup()
			Me.tileItem4 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem5 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem6 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem7 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem8 = New DevExpress.XtraEditors.TileItem()
			Me.searchControl1 = New DevExpress.XtraEditors.SearchControl()
			CType(Me.searchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customTileControl1
			' 
			Me.customTileControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.customTileControl1.DragSize = New System.Drawing.Size(0, 0)
			Me.customTileControl1.Groups.Add(Me.tileGroup2)
			Me.customTileControl1.Groups.Add(Me.tileGroup3)
			Me.customTileControl1.Location = New System.Drawing.Point(0, 22)
			Me.customTileControl1.MaxId = 12
			Me.customTileControl1.Name = "customTileControl1"
			Me.customTileControl1.Size = New System.Drawing.Size(801, 465)
			Me.customTileControl1.TabIndex = 0
			Me.customTileControl1.Text = "customTileControl1"
			' 
			' tileGroup2
			' 
			Me.tileGroup2.Items.Add(Me.tileItem1)
			Me.tileGroup2.Items.Add(Me.tileItem2)
			Me.tileGroup2.Items.Add(Me.tileItem3)
			Me.tileGroup2.Items.Add(Me.tileItem9)
			Me.tileGroup2.Items.Add(Me.tileItem10)
			Me.tileGroup2.Items.Add(Me.tileItem11)
			Me.tileGroup2.Items.Add(Me.tileItem12)
			Me.tileGroup2.Name = "tileGroup2"
			' 
			' tileItem1
			' 
			tileItemElement1.Text = "tileItem1"
			Me.tileItem1.Elements.Add(tileItemElement1)
			Me.tileItem1.Id = 0
			Me.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
			Me.tileItem1.Name = "tileItem1"
			' 
			' tileItem2
			' 
			tileItemElement2.Text = "tileItem2"
			Me.tileItem2.Elements.Add(tileItemElement2)
			Me.tileItem2.Id = 1
			Me.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
			Me.tileItem2.Name = "tileItem2"
			' 
			' tileItem3
			' 
			tileItemElement3.Text = "tileItem3"
			Me.tileItem3.Elements.Add(tileItemElement3)
			Me.tileItem3.Id = 2
			Me.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
			Me.tileItem3.Name = "tileItem3"
			' 
			' tileItem9
			' 
			tileItemElement4.Text = "tileItem9"
			Me.tileItem9.Elements.Add(tileItemElement4)
			Me.tileItem9.Id = 8
			Me.tileItem9.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			Me.tileItem9.Name = "tileItem9"
			' 
			' tileItem10
			' 
			tileItemElement5.Text = "tileItem10"
			Me.tileItem10.Elements.Add(tileItemElement5)
			Me.tileItem10.Id = 9
			Me.tileItem10.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			Me.tileItem10.Name = "tileItem10"
			' 
			' tileItem11
			' 
			tileItemElement6.Text = "tileItem11"
			Me.tileItem11.Elements.Add(tileItemElement6)
			Me.tileItem11.Id = 10
			Me.tileItem11.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			Me.tileItem11.Name = "tileItem11"
			' 
			' tileItem12
			' 
			tileItemElement7.Text = "tileItem12"
			Me.tileItem12.Elements.Add(tileItemElement7)
			Me.tileItem12.Id = 11
			Me.tileItem12.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			Me.tileItem12.Name = "tileItem12"
			' 
			' tileGroup3
			' 
			Me.tileGroup3.Items.Add(Me.tileItem4)
			Me.tileGroup3.Items.Add(Me.tileItem5)
			Me.tileGroup3.Items.Add(Me.tileItem6)
			Me.tileGroup3.Items.Add(Me.tileItem7)
			Me.tileGroup3.Items.Add(Me.tileItem8)
			Me.tileGroup3.Name = "tileGroup3"
			' 
			' tileItem4
			' 
			tileItemElement8.Text = "tileItem4"
			Me.tileItem4.Elements.Add(tileItemElement8)
			Me.tileItem4.Id = 3
			Me.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
			Me.tileItem4.Name = "tileItem4"
			' 
			' tileItem5
			' 
			tileItemElement9.Text = "tileItem5"
			Me.tileItem5.Elements.Add(tileItemElement9)
			Me.tileItem5.Id = 4
			Me.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			Me.tileItem5.Name = "tileItem5"
			' 
			' tileItem6
			' 
			tileItemElement10.Text = "tileItem6"
			Me.tileItem6.Elements.Add(tileItemElement10)
			Me.tileItem6.Id = 5
			Me.tileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			Me.tileItem6.Name = "tileItem6"
			' 
			' tileItem7
			' 
			tileItemElement11.Text = "tileItem7"
			Me.tileItem7.Elements.Add(tileItemElement11)
			Me.tileItem7.Id = 6
			Me.tileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			Me.tileItem7.Name = "tileItem7"
			' 
			' tileItem8
			' 
			tileItemElement12.Text = "tileItem8"
			Me.tileItem8.Elements.Add(tileItemElement12)
			Me.tileItem8.Id = 7
			Me.tileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			Me.tileItem8.Name = "tileItem8"
			' 
			' searchControl1
			' 
			Me.searchControl1.Client = Me.customTileControl1
			Me.searchControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.searchControl1.Location = New System.Drawing.Point(0, 0)
			Me.searchControl1.Name = "searchControl1"
			Me.searchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
			Me.searchControl1.Properties.Client = Me.customTileControl1
			Me.searchControl1.Size = New System.Drawing.Size(801, 22)
			Me.searchControl1.TabIndex = 1
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(801, 487)
			Me.Controls.Add(Me.customTileControl1)
			Me.Controls.Add(Me.searchControl1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Main"
			Me.Text = "Main"
			CType(Me.searchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customTileControl1 As CustomTileControl
		Private tileGroup2 As DevExpress.XtraEditors.TileGroup
		Private tileItem1 As DevExpress.XtraEditors.TileItem
		Private tileItem2 As DevExpress.XtraEditors.TileItem
		Private tileItem3 As DevExpress.XtraEditors.TileItem
		Private tileItem9 As DevExpress.XtraEditors.TileItem
		Private tileItem10 As DevExpress.XtraEditors.TileItem
		Private tileItem11 As DevExpress.XtraEditors.TileItem
		Private tileItem12 As DevExpress.XtraEditors.TileItem
		Private tileGroup3 As DevExpress.XtraEditors.TileGroup
		Private tileItem4 As DevExpress.XtraEditors.TileItem
		Private tileItem5 As DevExpress.XtraEditors.TileItem
		Private tileItem6 As DevExpress.XtraEditors.TileItem
		Private tileItem7 As DevExpress.XtraEditors.TileItem
		Private tileItem8 As DevExpress.XtraEditors.TileItem
		Private searchControl1 As DevExpress.XtraEditors.SearchControl

	End Class
End Namespace