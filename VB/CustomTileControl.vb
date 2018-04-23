Imports Microsoft.VisualBasic
Imports DevExpress.Data.Filtering
Imports DevExpress.Utils
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace dxExample
	Public Class CustomTileControl
		Inherits TileControl
		Implements ISearchControlClient
		Public Sub New()

		End Sub
		Private srchControl As ISearchControl
        Public Sub ApplyFindFilter(ByVal searchInfo As SearchInfoBase) Implements ISearchControlClient.ApplyFindFilter
            If searchInfo Is Nothing Then
                For Each group As TileGroup In Me.Groups
                    For Each item As TileItem In group.Items
                        item.Visible = True
                    Next item
                Next group
            Else
                Dim info As TileSearchInfo = TryCast(searchInfo, TileSearchInfo)
                Select Case info.FilterCondition
                    Case FilterCondition.StartsWith
                        For Each group As TileGroup In Me.Groups
                            For Each item As TileItem In group.Items
                                item.Visible = item.Text.ToUpper().StartsWith(info.SearchText.ToUpper())
                            Next item
                        Next group
                    Case FilterCondition.Contains, FilterCondition.Like, FilterCondition.Default
                        For Each group As TileGroup In Me.Groups
                            For Each item As TileItem In group.Items
                                item.Visible = item.Text.ToUpper().Contains(info.SearchText.ToUpper())
                            Next item
                        Next group
                    Case FilterCondition.Equals
                        For Each group As TileGroup In Me.Groups
                            For Each item As TileItem In group.Items
                                item.Visible = item.Text.ToUpper().Equals(info.SearchText.ToUpper())
                            Next item
                        Next group
                End Select
            End If
        End Sub

        Public Function CreateSearchProvider() As SearchControlProviderBase Implements ISearchControlClient.CreateSearchProvider
            Return New TileSearchProvider()
        End Function

        Public ReadOnly Property IsAttachedToSearchControl() As Boolean Implements ISearchControlClient.IsAttachedToSearchControl
            Get
                Return srchControl IsNot Nothing
            End Get
        End Property

        Public Sub SetSearchControl(ByVal searchControl As ISearchControl) Implements ISearchControlClient.SetSearchControl
            If srchControl Is searchControl Then
                Return
            End If
            srchControl = searchControl
            ApplyFindFilter(Nothing)
        End Sub
	End Class
End Namespace
