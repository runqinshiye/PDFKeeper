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
Public NotInheritable Class DocumentRepositoryFactory
    ''' <summary>
    ''' Gets the document repository for the database platform.
    ''' </summary>
    ''' <returns>IDocumentRepository object</returns>
    Public Shared ReadOnly Property Repository As IDocumentRepository
        Get
            If DbSession.Platform = DbSession.DbPlatform.Sqlite Then
                Return GetSqliteObject()
            ElseIf DbSession.Platform = DbSession.DbPlatform.Oracle Then
                Return GetOracleObject()
            Else
                Throw New NotSupportedException
            End If
        End Get
    End Property

    ' repository object creation has to occur outside of the Repository property to avoid:
    '
    ' System.InvalidOperationException: An error occurred creating the form. See Exception.InnerException for details.
    ' The error is: Could not load file or assembly 'Oracle.ManagedDataAccess, Version=4.122.19.1, Culture=neutral,
    ' PublicKeyToken=89b483f429c47342' or one of its dependencies. The system cannot find the file specified.
    ' ---> System.IO.FileNotFoundException: Could not load file or assembly 'Oracle.ManagedDataAccess,
    ' Version=4.122.19.1, Culture=neutral, PublicKeyToken=89b483f429c47342' or one of its dependencies.
    ' The system cannot find the file specified.

    Private Shared Function GetSqliteObject() As IDocumentRepository
        Return New DocumentRepositorySqlite
    End Function

    Private Shared Function GetOracleObject() As IDocumentRepository
        Return New DocumentRepositoryOracle
    End Function
End Class
