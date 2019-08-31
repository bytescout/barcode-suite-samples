'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'



Imports Bytescout.Spreadsheet

Public Partial Class _Default
	Inherits System.Web.UI.Page

    ' IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

    ' Temporary folder access is required for web application when you use ByteScout SDK in it.
    ' If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

    ' SOLUTION:

    ' If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

    ' If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

    ' In this case
    ' - check the User or User Group your web application is running under
    ' - then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
    ' - restart your web application and try again


	Private _document As Spreadsheet = Nothing

	Protected Sub Page_Load(sender As Object, e As EventArgs)

		Dim inputXlsFile As String = Server.MapPath("example.xls")

		' Open spreadsheet
		_document = New Spreadsheet()
		_document.LoadFromFile(inputXlsFile)

		Label1.Text = """Example.xls"" loaded"

		For i As Integer = 0 To _document.Worksheets.Count - 1
			DropDownList1.Items.Add(_document.Worksheets(i).Name)
		Next

	End Sub

	Protected Sub ButtonGo_Click(ByVal sender As Object, ByVal e As EventArgs)

		Dim sheet As String = DropDownList1.SelectedItem.Text

		If Not String.IsNullOrEmpty(sheet) Then

			' Clear HTTP output
			Response.Clear()
			' Set the content type to HTML
			Response.ContentType = "text/HTML"
			' Save selected worksheet to output stream as HTML
			_document.Worksheets(sheet).SaveAsHTML(Response.OutputStream)

			Response.End()

		End If

	End Sub
End Class
