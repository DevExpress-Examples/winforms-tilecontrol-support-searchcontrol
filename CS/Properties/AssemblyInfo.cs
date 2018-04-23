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

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("dxExample")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("dxExample")]
[assembly: AssemblyCopyright("Copyright ©  2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("1ffaf3c1-2e98-4667-89f7-19a34d95b01e")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
