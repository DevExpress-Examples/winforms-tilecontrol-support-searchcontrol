using DevExpress.Data.Filtering;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace dxExample {
    public class CustomTileControl : TileControl, ISearchControlClient {
        public CustomTileControl() {

        }
        ISearchControl srchControl;
        public void ApplyFindFilter(SearchInfoBase searchInfo) {
            if (searchInfo == null) {
                foreach (TileGroup group in this.Groups) {
                    foreach (TileItem item in group.Items)
                        item.Visible = true;
                }
            }
            else {
                TileSearchInfo info = searchInfo as TileSearchInfo;
                switch (info.FilterCondition) {
                    case FilterCondition.StartsWith:
                        foreach (TileGroup group in this.Groups) {
                            foreach (TileItem item in group.Items)
                                item.Visible = item.Text.ToUpper().StartsWith(info.SearchText.ToUpper());
                        }
                        break;
                    case FilterCondition.Contains:
                    case FilterCondition.Like:
                    case FilterCondition.Default:
                        foreach (TileGroup group in this.Groups) {
                            foreach (TileItem item in group.Items)
                                item.Visible = item.Text.ToUpper().Contains(info.SearchText.ToUpper());
                        }
                        break;
                    case FilterCondition.Equals:
                        foreach (TileGroup group in this.Groups) {
                            foreach (TileItem item in group.Items)
                                item.Visible = item.Text.ToUpper().Equals(info.SearchText.ToUpper());
                        }
                        break;
                }
            }
        }

        public SearchControlProviderBase CreateSearchProvider() {
            return new TileSearchProvider();
        }

        public bool IsAttachedToSearchControl {
            get { return srchControl != null; }
        }

        public void SetSearchControl(ISearchControl searchControl) {
            if (srchControl == searchControl) return;
            srchControl = searchControl;
            ApplyFindFilter(null);
        }
    }
}
