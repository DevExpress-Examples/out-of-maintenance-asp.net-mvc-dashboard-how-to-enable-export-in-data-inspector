<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/241095143/21.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T862804)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for MVC - How to Enable Export in Data Inspector

This example demonstrates how to enable export to Excel in [Data Inspector](https://docs.devexpress.com/Dashboard/401194/common-features/underlying-and-displayed-data/data-inspector). 

![Web Dashboard - Data Inspector Window](images/data_inspector_export.png)


Follow the steps below to enable export to Excel:

1. Install and reference the additional third-party library required for client-side export. Refer to the following topic for more information: [DevExtreme Client-Side Export](https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/Configuration/export/).
2. Subscribe to the [`BeforeRender`](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_aspxclientdashboard_beforerender) event. 
3. Call the [`DashboardControl.option`](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl?p=netframework#js_devexpress_dashboard_dashboardcontrol_option_args_) method and get access to the [`DataInspectorExtension`](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtension) options.
4. Use the [`DataInspectorExtensionOptions.onGridInitialized`](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions#js_devexpress_dashboard_datainspectorextensionoptions_ongridinitialized) property to enable export in the Grid widget before its content is loaded.

## Files to Look At
* [\_rootLayout.cshtml](./CS/datainspectorExport/Views/Shared/_rootLayout.cshtml) (VB: [rootLayout.cshtml](./VB/datainspectorExport/Views/Shared/_rootLayout.cshtml) )
* [beforeRender.js](./CS/datainspectorExport/Scripts/beforeRender.js) (VB: [beforeRender.js](./VB/datainspectorExport/Scripts/beforeRender.js) )
* [Index.cshtml](./CS/datainspectorExport/Views/Home/Index.cshtml) (VB: [Index.cshtml](./VB/datainspectorExport/Views/Home/Index.cshtml) )

## Documentation

* [Manage Data Inspector in the ASP.NET MVC Dashboard Extension](https://docs.devexpress.com/Dashboard/403978/web-dashboard/aspnet-mvc-dashboard-extension/manage-data-inspector-in-asp-net-mvc-dashboard-extension)
* [Client-Side API Overview for ASP.NET MVC Dashboard](https://docs.devexpress.com/Dashboard/16796/web-dashboard/aspnet-mvc-dashboard-extension/client-side-api-overview?p=netframework)

## API

* The [ASPxClientDashboard.BeforeRender](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_aspxclientdashboard_beforerender) event.
* The [DashboardControl.option](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl?p=netframework#js_devexpress_dashboard_dashboardcontrol_option_args_) method.
* The [DashboardControlOptions.extensions](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions) property.
* The [DataInspectorExtension](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtension) class.
* The [DataInspectorExtensionOptions.onGridInitialized](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions#js_devexpress_dashboard_datainspectorextensionoptions_ongridinitialized) property.

## More Examples

- [Dashboard for Web Forms - How to Enable Export in Data Inspector](https://github.com/DevExpress-Examples/aspxdashboard-how-to-enable-export-in-datainspector)
- [Dashboard for MVC - How to implement server-side export](https://github.com/DevExpress-Examples/aspnet-mvc-dashboard-how-to-implement-server-side-export-t590027)
