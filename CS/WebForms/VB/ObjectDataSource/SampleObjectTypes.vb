Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace WebForms.SampleObjectTypes
	<DisplayName("My Data Source")>
	Public Class DataSource
		Private data As New List(Of DataItem)()
		Public Sub New()
			Me.New(100)
		End Sub
		Public Sub New(ByVal count As Integer)
			Me.New(count, 1000)
		End Sub
		Public Sub New(ByVal count As Integer, ByVal maxValue As Integer)
			Dim random = New Random()
			For i = 0 To count - 1
				data.Add(New DataItem() With {.Random = random.Next(0, maxValue)})
			Next i
		End Sub
		Public Function GetData() As List(Of DataItem)
			Return data
		End Function

		Public Function GetData(ByVal count As Integer) As List(Of DataItem)
			Return data.GetRange(0, count)
		End Function
	End Class

	Public Class DataSource2
		Inherits DataSource

		Public Sub New()
			MyBase.New(1000, 1000)
		End Sub
	End Class
	Public Class DataItem
		Public Property Random() As Integer
	End Class
End Namespace
