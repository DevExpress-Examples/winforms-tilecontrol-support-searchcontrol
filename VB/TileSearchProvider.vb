Imports Microsoft.VisualBasic
Imports DevExpress.Data.Filtering
Imports DevExpress.Utils
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace dxExample
	Public Class TileSearchProvider
		Inherits SearchControlProviderBase
		Public Sub New()
		End Sub
		Protected Overrides Sub DisposeCore()
		End Sub
		Protected Overrides Function GetCriteriaInfoCore(ByVal args As SearchControlQueryParamsEventArgs) As SearchInfoBase
			Return New TileSearchInfo(args.SearchText, args.FilterCondition)
		End Function
	End Class

	Public Class TileSearchInfo
		Inherits SearchInfoBase
		Private text As String
		Public Sub New(ByVal t As String, ByVal condition As FilterCondition)
			text = t
			FilterCondition = condition
		End Sub
		Public Overrides ReadOnly Property SearchText() As String
			Get
				Return text
			End Get
		End Property
		Public Property FilterCondition() As FilterCondition
	End Class
End Namespace
