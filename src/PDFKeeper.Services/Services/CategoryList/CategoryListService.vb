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
Imports PDFKeeper.Domain
Imports PDFKeeper.Infrastructure

Public Class CategoryListService
    Implements ICategoryListService
    Private ReadOnly repository As IDocumentRepository

    Public Sub New(ByVal repository As IDocumentRepository)
        Me.repository = repository
    End Sub

    Public Function ListCategories() As DataTable Implements ICategoryListService.ListCategories
        Return repository.ListCategories
    End Function

    Public Function GetCategories(filter As CategoryFilterModel) As DataTable Implements ICategoryListService.ListCategories
        Return repository.ListCategories(filter)
    End Function
End Class
