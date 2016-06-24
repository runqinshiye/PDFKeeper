﻿'******************************************************************************
'*
'* PDFKeeper -- Free, Open Source PDF Capture, Upload, and Search.
'* Copyright (C) 2009-2016 Robert F. Frasca
'*
'* This file is part of PDFKeeper.
'*
'* PDFKeeper is free software: you can redistribute it and/or modify it under
'* the terms of the GNU General Public License as published by the Free
'* Software Foundation, either version 3 of the License, or (at your option)
'* any later version.
'*
'* PDFKeeper is distributed in the hope that it will be useful, but WITHOUT
'* ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
'* FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for
'* more details.
'*
'* You should have received a copy of the GNU General Public License along
'* with PDFKeeper.  If not, see <http://www.gnu.org/licenses/>.
'*
'******************************************************************************
'*
'* Created by SharpDevelop.
'* User: Robert
'* Date: 6/23/2016
'* Time: 6:22 PM
'*
'******************************************************************************

''' <summary>
''' AboutView Helper.
''' </summary>
Public NotInheritable Class AboutHelper
	Private Sub New()
		' Because type 'About' contains only 'Shared' members, add a default
		' private constructor to prevent the compiler from adding a default
		' public constructor. (CA1053)
	End Sub
	
	''' <summary>
	''' Opens the Homepage using the default application.
	''' </summary>
	Public Shared Sub OpenHomepage
		Process.Start(About.HomepageUrl)
	End Sub
End Class
