Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Xpo

Namespace XpoWebApplication
	Partial Public Class _Default
		Inherits System.Web.UI.Page

		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			Dim session As Session = XpoHelper.GetNewSession()
			XpoDataSource1.Session = session
		End Sub
	End Class
End Namespace
