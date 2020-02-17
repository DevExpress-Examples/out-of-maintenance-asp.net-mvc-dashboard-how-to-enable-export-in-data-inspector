Imports Microsoft.VisualBasic
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports System.Web.Routing

Namespace datainspectorExport
	Public NotInheritable Class DashboardConfig
		Private Sub New()
		End Sub
		Public Shared Sub RegisterService(ByVal routes As RouteCollection)
			routes.MapDashboardRoute("dashboardControl")

			Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
			DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage)

			DashboardConfigurator.Default.SetConnectionStringsProvider(New DevExpress.DataAccess.Web.ConfigFileConnectionStringsProvider())

			Dim dataSourceStorage As New DataSourceInMemoryStorage()
			DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage)
		End Sub

	End Class
End Namespace