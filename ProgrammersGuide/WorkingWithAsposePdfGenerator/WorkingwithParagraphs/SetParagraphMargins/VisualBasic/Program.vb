'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf

Namespace SetParagraphMargins
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If


			'Instantiate Pdf object by calling its empty constructor
			Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

			'Add a new section to the Pdf object
			Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

			'Instantiate a graph object, associate it with a section and pass the height
			' & width of the graph
			Dim g1 As New Aspose.Pdf.Generator.Graph(sec1, 100, 100)

			'Add a graph object to the paragraphs collection of the section
			sec1.Paragraphs.Add(g1)

			'Add a circle object to the shapes collection of graph object
			g1.Shapes.Add(New Aspose.Pdf.Generator.Circle(g1, 50, 50, 30))

			'Instantiate another Graph object, associate it with a section and pass the height
			' & width of the graph
			Dim g2 As New Aspose.Pdf.Generator.Graph(sec1, 100, 100)

			'Set the value of left margin
			g2.Margin.Left = 150

			'Set the value of top margin and assign a negative value to it
			g2.Margin.Top = -100

			'Add the paragraph object "g2" to paragraphs collection of the section
			sec1.Paragraphs.Add(g2)

			'Add a rectangle to the graph object (g2) in its shapes collection
			g2.Shapes.Add(New Aspose.Pdf.Generator.Rectangle(g2, 20, 20, 60, 60))

			' save the resultant PDF
			pdf1.Save(dataDir & "MergedOutput.pdf")


		End Sub
	End Class
End Namespace