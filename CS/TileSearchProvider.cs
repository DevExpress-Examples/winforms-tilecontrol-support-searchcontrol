using DevExpress.Data.Filtering;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dxExample
{
    public class TileSearchProvider : SearchControlProviderBase
    {
        public  TileSearchProvider() {
        }
        protected override void DisposeCore() {
        }
        protected override SearchInfoBase GetCriteriaInfoCore(SearchControlQueryParamsEventArgs args){
            return new TileSearchInfo(args.SearchText, args.FilterCondition);
        }
    }

    public class TileSearchInfo : SearchInfoBase
    {
        string text;
        public TileSearchInfo(string t, FilterCondition condition) {
            text = t;
            FilterCondition = condition;
        }
        public override string SearchText {
            get { return text; }
        }
        public FilterCondition FilterCondition {
            get;
            set;
        }
    }
}
