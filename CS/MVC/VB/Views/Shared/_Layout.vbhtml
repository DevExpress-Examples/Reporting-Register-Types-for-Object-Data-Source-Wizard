<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>DevExpress ASP.NET project</title>

    @Html.DevExpress().GetStyleSheets(
                    New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
                    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors},
                    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Report},
                    New StyleSheet With {.ExtensionSuite = ExtensionSuite.ClientRichEdit}
                            )
    @Html.DevExpress().GetScripts(
                New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
                New Script With {.ExtensionSuite = ExtensionSuite.Editors},
                New Script With {.ExtensionSuite = ExtensionSuite.Report},
                New Script With {.ExtensionSuite = ExtensionSuite.ClientRichEdit}
                )
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
</head>

<body>
    <div class="content">
        @RenderBody()
    </div>
</body>
</html>
