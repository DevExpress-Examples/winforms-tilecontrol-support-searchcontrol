<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617818/15.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T273248)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to use WinForms SearchControl with TileControl

This example creates a custom tile control that implements the `ISearchControlClient` interface to allow users to use the [WinForms SearchControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.SearchControl). 

### Implementation Details

Implement the following members:

 - `SetSearchControl` - this method is invoked when you attach/detach your object from the `SearchControl.Client` property.
 - `IsAttachedToSearchControl` - this property specifies whether your object is attached to the SearchControl.
 - `ApplyFindFilter` - this method is called to filter items. You should implement your own logic to filter items.
 - `CreateSearchProvider` - this method must return a `SearchControlProviderBase` descendant. This provider contains `SearchText` and `FilterCondition` obtained from the `RepositoryItemSearchControl.FilterCondition` property.

You should also override the `SearchControlProviderBase.GetCriteriaInfoCore` method to return a `SearchInfoBase` descendant. This object is passed to the `ApplyFindFilter` method as a parameter.


## Files to Review

* [CustomTileControl.cs](./CS/CustomTileControl.cs) (VB: [CustomTileControl.vb](./VB/CustomTileControl.vb))
* [TileSearchProvider.cs](./CS/TileSearchProvider.cs) (VB: [TileSearchProvider.vb](./VB/TileSearchProvider.vb))
