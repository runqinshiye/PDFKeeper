'******************************************************************************
'* PDFKeeper -- Open Source PDF Document Management
'* Copyright (C) 2009-2023 Robert F. Frasca
'*
'* This file is part of PDFKeeper.
'*
'* PDFKeeper is free software: you can redistribute it and/or modify
'* it under the terms of the GNU General Public License as published by
'* the Free Software Foundation, either version 3 of the License, or
'* (at your option) any later version.
'*
'* PDFKeeper is distributed in the hope that it will be useful,
'* but WITHOUT ANY WARRANTY; without even the implied warranty of
'* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'* GNU General Public License for more details.
'*
'* You should have received a copy of the GNU General Public License
'* along with PDFKeeper.  If not, see <http://www.gnu.org/licenses/>.
'******************************************************************************
Imports System.Drawing.Imaging
Imports System.IO

Public Class PdfOcrTextExtractionStrategy
    Implements IPdfTextExtractionStrategy

    Public Function GetText(pdfFile As FileInfo) As String Implements IPdfTextExtractionStrategy.GetText
        If pdfFile Is Nothing Then
            Throw New ArgumentNullException(NameOf(pdfFile))
        End If
        Dim ocr = New ImageTextExtractor(New PdfFile(pdfFile.FullName).GetAllPagesAsTiffImages, ImageFormat.Tiff)
        Dim result = ocr.GetText
        Return result.Result
    End Function
End Class
