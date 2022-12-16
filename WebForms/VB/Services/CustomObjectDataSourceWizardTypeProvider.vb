#Region "usings_1"
Imports System
Imports System.Collections.Generic
#End Region
#Region "usings_2"
Imports System.Linq
Imports System.Reflection
#End Region
#Region "usings"
Imports DevExpress.DataAccess.Web
#End Region

Namespace WebForms.Services
	#Region "CustomObjectDataSourceWizardTypeProvider"
	' ...
	Public Class CustomObjectDataSourceWizardTypeProvider
		Implements IObjectDataSourceWizardTypeProvider

		Public Function GetAvailableTypes(ByVal context As String) As IEnumerable(Of Type) Implements IObjectDataSourceWizardTypeProvider.GetAvailableTypes
			Return { GetType(SampleObjectTypes.DataSource), GetType(SampleObjectTypes.DataSource2) }
		End Function
	End Class
	#End Region

	#Region "CustomObjectDataSourceConstructorFilterService"
	' ...
	Public Class CustomObjectDataSourceConstructorFilterService
		Implements IObjectDataSourceConstructorFilterService

		Public Function Filter(ByVal dataSourceType As Type, ByVal constructors As IEnumerable(Of ConstructorInfo)) As IEnumerable(Of ConstructorInfo) Implements IObjectDataSourceConstructorFilterService.Filter
			If dataSourceType Is GetType(SampleObjectTypes.DataSource2) Then
				Return constructors
			End If
			Return constructors.Where(Function(x) x.GetParameters().Length > 0)
		End Function
	End Class
	#End Region

	#Region "CustomObjectDataSourceMemberFilterService"
	' ...
	Public Class CustomObjectDataSourceMemberFilterService
		Implements IObjectDataSourceMemberFilterService

		Public Function Filter(ByVal dataSourceType As Type, ByVal members As IEnumerable(Of MemberInfo)) As IEnumerable(Of MemberInfo) Implements IObjectDataSourceMemberFilterService.Filter
			If dataSourceType Is GetType(SampleObjectTypes.DataSource2) Then
				Return members
			End If
			Return members.Where(Function(x)
				Dim method = TryCast(x, MethodInfo)
				If method IsNot Nothing Then
					Return method.GetParameters().Length > 0
				End If
				Return False
			End Function)
		End Function
	End Class
	#End Region
End Namespace
