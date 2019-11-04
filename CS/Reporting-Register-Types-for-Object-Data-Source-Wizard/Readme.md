# Register Types for Object Data Source Wizard

This example performs the following steps to register object types for the [Object Data Source Wizard](https://docs.devexpress.com/XtraReports/401220), which allows users to create an [Object Data Source](https://docs.devexpress.com/XtraReports/119313):

 - Declares the _DataSource_ and _DataSource2_ classes that should provide data to reports. The **DisplayName** attribute is applied to the _DataSource_ class to specify a custom display name for the **Report Wizard** and **Data Source Wizard**. The class's name and namespace are used for the _DataSource2_ class.

 - Implements the [IObjectDataSourceWizardTypeProvider](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Web.IObjectDataSourceWizardTypeProvider) to list data types.

 - Implements the [IObjectDataSourceConstructorFilterService](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Web.IObjectDataSourceConstructorFilterService) interface to list only specific data type constructors in the **Report Wizard** and **Data Source Wizard**.

 - Implements the [IObjectDataSourceMemberFilterService](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Web.IObjectDataSourceMemberFilterService) interface to list only specific data members in the **Report Wizard** and **Data Source Wizard**.

 - The [RegisterObjectDataSourceWizardTypeProvider&lt;T>()](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.ReportDesigner.DefaultReportDesignerContainer.RegisterObjectDataSourceWizardTypeProvider--1), [RegisterObjectDataSourceConstructorFilterService&lt;T>()](https://docs.devexpress.com/DevExpress.XtraReports.Web.ReportDesigner.DefaultReportDesignerContainer.RegisterObjectDataSourceConstructorFilterService--1) and [RegisterObjectDataSourceMemberFilterService&lt;T>()](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.ReportDesigner.DefaultReportDesignerContainer.RegisterObjectDataSourceMemberFilterService--1) methods are called at the application's startup to register the interface implementations.

## Files to look at

ASP.NET WebForms:

- [ObjectDataSource/SampleObjectTypes.cs](./WebForms/WebForms/ObjectDataSource/SampleObjectTypes.cs)
- [Services/CustomObjectDataSourceWizardTypeProvider.cs](./WebForms/WebForms/Services/CustomObjectDataSourceWizardTypeProvider.cs)
- [Global.asax.cs](./WebForms/WebForms/Global.asax.cs)

ASP.NET MVC:

- [ObjectDataSource/SampleObjectTypes.cs](./MVC/MVC/ObjectDataSource/SampleObjectTypes.cs)
- [Services/CustomObjectDataSourceWizardTypeProvider.cs](./MVC/MVC/Services/CustomObjectDataSourceWizardTypeProvider.cs)
- [Global.asax.cs](./MVC/MVC/Global.asax.cs)

ASP.NET Core:

- [ObjectDataSource/SampleObjectTypes.cs](./ASPNetCore/ASPNetCore/ObjectDataSource/SampleObjectTypes.cs)
- [Services/CustomObjectDataSourceWizardTypeProvider.cs](./ASPNetCore/ASPNetCore/Services/CustomObjectDataSourceWizardTypeProvider.cs)
- [Startup.cs](./ASPNetCore/ASPNetCore/Startup.cs)

## Documentation

* [Register Types for Object Data Source Wizard (ASP.NET WebForms)](https://docs.devexpress.com/XtraReports/401228)
* [Register Types for Object Data Source Wizard (ASP.NET MVC)](https://docs.devexpress.com/XtraReports/401229)
* [Register Types for Object Data Source Wizard (ASP.NET Core)](https://docs.devexpress.com/XtraReports/401230)
