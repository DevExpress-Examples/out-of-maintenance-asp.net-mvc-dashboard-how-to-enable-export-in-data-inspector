*Files to look at*:
* [\_rootLayout.cshtml](./CS/datainspectorExport/Views/Shared/_rootLayout.cshtml) (VB: [rootLayout.cshtml](./VB/datainspectorExport/Views/Shared/_rootLayout.cshtml) )
* [beforeRender.js](./CS/datainspectorExport/Scripts/beforeRender.js) (VB: [beforeRender.js](./VB/datainspectorExport/Scripts/beforeRender.js) )
* [Index.cshtml](./CS/datainspectorExport/Views/Home/Index.cshtml) (VB: [Index.cshtml](./VB/datainspectorExport/Views/Home/Index.cshtml) )

# ASP.NET MVC Dashboard - How to Enable Export in Data Inspector


This example demonstrates how to enable export to Excel in [Data Inspector](https://docs.devexpress.com/Dashboard/401194/common-features/underlying-and-displayed-data/data-inspector)(ASP.NET MVC). 

![](images/data_inspector_export.png)


Install and reference the [JSZip](https://stuk.github.io/jszip/) third-party library in your application to enable client-side export. Refer to the [DevExtreme Client-Side Exporting](https://js.devexpress.com/Documentation/Guide/Widgets/DataGrid/Client-Side_Exporting/) topic for more information.

Follow the steps below to enable export to Excel: 

1. Subscribe to the [BeforeRender](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_aspxclientdashboard_beforerender) event. 
2. Call the [DashboardControl.option](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl?p=netframework#js_devexpress_dashboard_dashboardcontrol_option_args_) method and get access to the [DataInspectorExtension](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtension) options.
3. Use the [DataInspectorExtensionOptions.onGridInitialized](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions#js_devexpress_dashboard_datainspectorextensionoptions_ongridinitialized) property to enable export in the Grid widget before its content is loaded.
4. Install and reference the [JSZip](https://stuk.github.io/jszip/) library.

## Documentation

* [Access to Underlying Widgets](https://docs.devexpress.com/Dashboard/401089/web-dashboard/aspnet-mvc-dashboard-extension/access-to-underlying-widgets?p=netframework)
* [Client-Side API Overview for ASP.NET MVC Dashboard](https://docs.devexpress.com/Dashboard/16796/web-dashboard/aspnet-mvc-dashboard-extension/client-side-api-overview?p=netframework)

## API

* The [ASPxClientDashboard.BeforeRender](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_aspxclientdashboard_beforerender) event.
* The [DashboardControl.option](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl?p=netframework#js_devexpress_dashboard_dashboardcontrol_option_args_) method.
* The [DashboardControlOptions.extensions](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions) property.
* The [DataInspectorExtension](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtension) class.
* The [DataInspectorExtensionOptions.onGridInitialized](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions#js_devexpress_dashboard_datainspectorextensionoptions_ongridinitialized) property.