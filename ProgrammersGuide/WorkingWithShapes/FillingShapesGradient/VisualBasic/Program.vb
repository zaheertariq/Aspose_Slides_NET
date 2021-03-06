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

Namespace FillingShapesGradient
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Instantiate Prseetation class that represents the PPTX//Instantiate Prseetation class that represents the PPTX
			Using pres As New Presentation()

				'Get the first slide
				Dim sld As ISlide = pres.Slides(0)

				'Add autoshape of ellipse type
				Dim shp As IShape = sld.Shapes.AddAutoShape(ShapeType.Ellipse, 50, 150, 75, 150)

				'Apply some gradiant formatting to ellipse shape
				shp.FillFormat.FillType = FillType.Gradient
				shp.FillFormat.GradientFormat.GradientShape = GradientShape.Linear

				'Set the Gradient Direction
				shp.FillFormat.GradientFormat.GradientDirection = GradientDirection.FromCorner2

				'Add two Gradiant Stops
				shp.FillFormat.GradientFormat.GradientStops.Add(CSng(1.0), PresetColor.Purple)
				shp.FillFormat.GradientFormat.GradientStops.Add(CSng(0), PresetColor.Red)

				'Write the PPTX file to disk
				pres.Save(dataDir & "EllipseShpGrad.pptx", SaveFormat.Pptx)
			End Using

		End Sub
	End Class
End Namespace