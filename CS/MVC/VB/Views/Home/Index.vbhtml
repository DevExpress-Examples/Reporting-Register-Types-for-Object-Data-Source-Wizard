@Html.DevExpress().ReportDesigner(Sub(settings)
                                           settings.Name = "ReportDesigner1"
                                       End Sub).Bind(New DevExpress.XtraReports.UI.XtraReport()).GetHtml()
