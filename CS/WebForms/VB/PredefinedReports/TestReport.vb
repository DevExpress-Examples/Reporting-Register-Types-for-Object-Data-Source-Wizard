Imports System
Imports System.Drawing
Imports DevExpress.XtraReports.UI

Namespace WebForms.PredefinedReports
	Partial Public Class TestReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub tableCell4_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
			TryCast(sender, XRTableCell).Text &= " Customized"
		End Sub
	End Class
End Namespace
