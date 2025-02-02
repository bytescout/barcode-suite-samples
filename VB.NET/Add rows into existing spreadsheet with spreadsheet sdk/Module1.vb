'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.IO
Imports System.Diagnostics

Module Module1

    Sub Main()
        ' Open Spreadsheet
        Dim document As New Spreadsheet()
	document.LoadFromFile("AdvancedReport.xls")

        ' Get Worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

        ' Add new row
        worksheet.Rows.Insert(6, 1)

        ' Set values
        worksheet.Rows(6)(0).Value = "New Name"
        worksheet.Rows(6)(1).Value = "New Full Name"

        ' remove output file if already exists
        If File.Exists("Output.xls") Then
            File.Delete("Output.xls")
        End If

        ' Save document
        document.SaveAs("Output.xls")

        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.xls")

    End Sub

End Module
