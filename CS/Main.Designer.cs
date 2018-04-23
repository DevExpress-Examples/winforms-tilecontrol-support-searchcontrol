// Developer Express Code Central Example:
// How to implement the ISearchControlClient interface
// 
// We have SearchControl
// (https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSearchControltopic)
// (added in v14.1), which provides the search and filter functionality for the
// attached object. SearchControl can be attached to objects that support the
// ISearchControlClient interface. You can find a list of our controls that support
// this interface out of the box in the SearchControl
// (https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSearchControltopic)
// help topic.
// However, this list can be extended by your own. This example
// illustrates how to implement the ISearchControlClient interface for a Form for
// searching and highlighting controls by their names.
// 
// To introduce the
// ISearchControlClient interface into your project, implement the following
// members: - SetSearchControl - this method is invoked when you attach/detach your
// object from the SearchControl.Client
// (https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsSearchControl_Clienttopic)
// property. - IsAttachedToSearchControl - this property determines whether your
// object is attached to SearchControl. - ApplyFindFilter - this method is invoked
// when filtering is performed. Here you need to implement your own logic for
// filtering. - CreateSearchProvider - this method must return
// SearchControlProviderBase's descendant. This provider contains SearchText and
// FilterCondition obtained from the RepositoryItemSearchControl.FilterCondition
// (https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItemSearchControl_FilterConditiontopic)
// property.
// It is necessary to override the
// SearchControlProviderBase.GetCriteriaInfoCore method to return SearchInfoBase's
// descendant. This instance should contain all required information for your
// filtering. It is passed to the ApplyFindFilter method as a parameter.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T162421

namespace dxExample
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            this.customTileControl1 = new dxExample.CustomTileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem9 = new DevExpress.XtraEditors.TileItem();
            this.tileItem10 = new DevExpress.XtraEditors.TileItem();
            this.tileItem11 = new DevExpress.XtraEditors.TileItem();
            this.tileItem12 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileItem6 = new DevExpress.XtraEditors.TileItem();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            this.tileItem8 = new DevExpress.XtraEditors.TileItem();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customTileControl1
            // 
            this.customTileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.customTileControl1.Groups.Add(this.tileGroup2);
            this.customTileControl1.Groups.Add(this.tileGroup3);
            this.customTileControl1.Location = new System.Drawing.Point(0, 22);
            this.customTileControl1.MaxId = 12;
            this.customTileControl1.Name = "customTileControl1";
            this.customTileControl1.Size = new System.Drawing.Size(801, 465);
            this.customTileControl1.TabIndex = 0;
            this.customTileControl1.Text = "customTileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Items.Add(this.tileItem3);
            this.tileGroup2.Items.Add(this.tileItem9);
            this.tileGroup2.Items.Add(this.tileItem10);
            this.tileGroup2.Items.Add(this.tileItem11);
            this.tileGroup2.Items.Add(this.tileItem12);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem1
            // 
            tileItemElement1.Text = "tileItem1";
            this.tileItem1.Elements.Add(tileItemElement1);
            this.tileItem1.Id = 0;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem1.Name = "tileItem1";
            // 
            // tileItem2
            // 
            tileItemElement2.Text = "tileItem2";
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 1;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem3
            // 
            tileItemElement3.Text = "tileItem3";
            this.tileItem3.Elements.Add(tileItemElement3);
            this.tileItem3.Id = 2;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem9
            // 
            tileItemElement4.Text = "tileItem9";
            this.tileItem9.Elements.Add(tileItemElement4);
            this.tileItem9.Id = 8;
            this.tileItem9.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem9.Name = "tileItem9";
            // 
            // tileItem10
            // 
            tileItemElement5.Text = "tileItem10";
            this.tileItem10.Elements.Add(tileItemElement5);
            this.tileItem10.Id = 9;
            this.tileItem10.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem10.Name = "tileItem10";
            // 
            // tileItem11
            // 
            tileItemElement6.Text = "tileItem11";
            this.tileItem11.Elements.Add(tileItemElement6);
            this.tileItem11.Id = 10;
            this.tileItem11.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem11.Name = "tileItem11";
            // 
            // tileItem12
            // 
            tileItemElement7.Text = "tileItem12";
            this.tileItem12.Elements.Add(tileItemElement7);
            this.tileItem12.Id = 11;
            this.tileItem12.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem12.Name = "tileItem12";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItem4);
            this.tileGroup3.Items.Add(this.tileItem5);
            this.tileGroup3.Items.Add(this.tileItem6);
            this.tileGroup3.Items.Add(this.tileItem7);
            this.tileGroup3.Items.Add(this.tileItem8);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // tileItem4
            // 
            tileItemElement8.Text = "tileItem4";
            this.tileItem4.Elements.Add(tileItemElement8);
            this.tileItem4.Id = 3;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem4.Name = "tileItem4";
            // 
            // tileItem5
            // 
            tileItemElement9.Text = "tileItem5";
            this.tileItem5.Elements.Add(tileItemElement9);
            this.tileItem5.Id = 4;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem5.Name = "tileItem5";
            // 
            // tileItem6
            // 
            tileItemElement10.Text = "tileItem6";
            this.tileItem6.Elements.Add(tileItemElement10);
            this.tileItem6.Id = 5;
            this.tileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem6.Name = "tileItem6";
            // 
            // tileItem7
            // 
            tileItemElement11.Text = "tileItem7";
            this.tileItem7.Elements.Add(tileItemElement11);
            this.tileItem7.Id = 6;
            this.tileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem7.Name = "tileItem7";
            // 
            // tileItem8
            // 
            tileItemElement12.Text = "tileItem8";
            this.tileItem8.Elements.Add(tileItemElement12);
            this.tileItem8.Id = 7;
            this.tileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem8.Name = "tileItem8";
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.customTileControl1;
            this.searchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchControl1.Location = new System.Drawing.Point(0, 0);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.customTileControl1;
            this.searchControl1.Size = new System.Drawing.Size(801, 22);
            this.searchControl1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 487);
            this.Controls.Add(this.customTileControl1);
            this.Controls.Add(this.searchControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTileControl customTileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem9;
        private DevExpress.XtraEditors.TileItem tileItem10;
        private DevExpress.XtraEditors.TileItem tileItem11;
        private DevExpress.XtraEditors.TileItem tileItem12;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem tileItem6;
        private DevExpress.XtraEditors.TileItem tileItem7;
        private DevExpress.XtraEditors.TileItem tileItem8;
        private DevExpress.XtraEditors.SearchControl searchControl1;

    }
}