'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides
Imports Aspose.Slides.Export

Namespace ConvertingPresentationToHTML
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")


			'Instantiate a Presentation object that represents a presentation file
			Using pres As New Presentation(dataDir & "Aspose.pptx")

				Dim htmlOpt As New HtmlOptions()
				htmlOpt.HtmlFormatter = HtmlFormatter.CreateDocumentFormatter("", False)

				'Saving the presentation to HTML
				pres.Save(dataDir & "demo.html", Aspose.Slides.Export.SaveFormat.Html, htmlOpt)
			End Using
		End Sub
	End Class
End Namespace