<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617818/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T273248)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# How to use WinForms SearchControl with TileControl

This example creates a custom tile control that implements the `ISearchControlClient` interface to allow users to use the [WinForms SearchControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.SearchControl). 

### Implementation Details

Implement the following members:

 - `SetSearchControl` - This method is invoked when you attach/detach your object to/from the `SearchControl.Client` property.
 - `IsAttachedToSearchControl` - This property specifies whether your object is attached to the SearchControl.
 - `ApplyFindFilter` - This method is called to filter items. You should implement your own logic to filter items.
 - `CreateSearchProvider` - This method must return a `SearchControlProviderBase` descendant. This provider contains `SearchText` and `FilterCondition` obtained from the `RepositoryItemSearchControl.FilterCondition` property.

You should also override the `SearchControlProviderBase.GetCriteriaInfoCore` method to return a `SearchInfoBase` descendant. This object is passed to the `ApplyFindFilter` method as a parameter.


## Files to Review

* [CustomTileControl.cs](./CS/CustomTileControl.cs) (VB: [CustomTileControl.vb](./VB/CustomTileControl.vb))
* [TileSearchProvider.cs](./CS/TileSearchProvider.cs) (VB: [TileSearchProvider.vb](./VB/TileSearchProvider.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-tilecontrol-support-searchcontrol&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-tilecontrol-support-searchcontrol&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
