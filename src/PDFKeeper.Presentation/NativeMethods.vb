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
Public NotInheritable Class NativeMethods
    ''' <summary>
    ''' Adds the specified window into the system-maintained clipboard format listener list.
    ''' </summary>
    ''' <param name="hwnd">Window handle</param>
    ''' <returns>True or False</returns>
    <DllImport("user32.dll", SetLastError:=True)>
    <DefaultDllImportSearchPaths(DllImportSearchPath.System32)>
    Friend Shared Function AddClipboardFormatListener(hwnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    ''' <summary>
    ''' Removes the specified window from the system-maintained clipboard format listener list.
    ''' </summary>
    ''' <param name="hwnd">Window handle</param>
    ''' <returns>True or False</returns>
    <DllImport("user32.dll", SetLastError:=True)>
    <DefaultDllImportSearchPaths(DllImportSearchPath.System32)>
    Friend Shared Function RemoveClipboardFormatListener(hwnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
End Class
