'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PDFKeeper.Presentation.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to About {0}.
        '''</summary>
        Friend ReadOnly Property About() As String
            Get
                Return ResourceManager.GetString("About", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Added.
        '''</summary>
        Friend ReadOnly Property Added() As String
            Get
                Return ResourceManager.GetString("Added", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Author.
        '''</summary>
        Friend ReadOnly Property Author() As String
            Get
                Return ResourceManager.GetString("Author", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to cancel?.
        '''</summary>
        Friend ReadOnly Property CancelQuestion() As String
            Get
                Return ResourceManager.GetString("CancelQuestion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Category.
        '''</summary>
        Friend ReadOnly Property Category() As String
            Get
                Return ResourceManager.GetString("Category", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property cut_red() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("cut_red", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property database() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("database", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;Date_Time&gt;.
        '''</summary>
        Friend ReadOnly Property DateTimeToken() As String
            Get
                Return ResourceManager.GetString("DateTimeToken", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;Date&gt;.
        '''</summary>
        Friend ReadOnly Property DateToken() As String
            Get
                Return ResourceManager.GetString("DateToken", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Delete {0} to the Recycle Bin?.
        '''</summary>
        Friend ReadOnly Property DeleteFileToRecycleBin() As String
            Get
                Return ResourceManager.GetString("DeleteFileToRecycleBin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Delete selected documents?.
        '''</summary>
        Friend ReadOnly Property DeleteSelectedDocuments() As String
            Get
                Return ResourceManager.GetString("DeleteSelectedDocuments", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Delete the selected Upload Profile to the Recycle Bin?.
        '''</summary>
        Friend ReadOnly Property DeleteUploadProfile() As String
            Get
                Return ResourceManager.GetString("DeleteUploadProfile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to PDFKeeper is free, open source software that provides a storage and management solution for PDF documents.
        '''
        '''This program comes with ABSOLUTELY NO WARRANTY; this is free software, and you are welcome to redistribute it under certain conditions; for details, select License..
        '''</summary>
        Friend ReadOnly Property DescriptionDetail() As String
            Get
                Return ResourceManager.GetString("DescriptionDetail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Do you wish to discard all changes?.
        '''</summary>
        Friend ReadOnly Property DiscardChanges() As String
            Get
                Return ResourceManager.GetString("DiscardChanges", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0}.  Document may have been deleted.  Please Refresh your Search Results..
        '''</summary>
        Friend ReadOnly Property DocumentMayHaveBeenDeleted() As String
            Get
                Return ResourceManager.GetString("DocumentMayHaveBeenDeleted", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0}.  Document ID {1} may have been deleted..
        '''</summary>
        Friend ReadOnly Property DocumentMayHaveBeenDeletedException() As String
            Get
                Return ResourceManager.GetString("DocumentMayHaveBeenDeletedException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Export.
        '''</summary>
        Friend ReadOnly Property Export() As String
            Get
                Return ResourceManager.GetString("Export", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property file_acrobat() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("file_acrobat", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;FileName&gt;.
        '''</summary>
        Friend ReadOnly Property FileNameToken() As String
            Get
                Return ResourceManager.GetString("FileNameToken", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ID.
        '''</summary>
        Friend ReadOnly Property ID() As String
            Get
                Return ResourceManager.GetString("ID", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Improper usage of query operators and/or characters..
        '''</summary>
        Friend ReadOnly Property ImproperUsageOfQueryOperators() As String
            Get
                Return ResourceManager.GetString("ImproperUsageOfQueryOperators", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Notes for selected document have been modified.
        '''Do you want to save changes before closing?.
        '''</summary>
        Friend ReadOnly Property NotesModified() As String
            Get
                Return ResourceManager.GetString("NotesModified", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to OCR each PDF page containing text and image data?.
        '''</summary>
        Friend ReadOnly Property OcrImageDataPages() As String
            Get
                Return ResourceManager.GetString("OcrImageDataPages", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to More than {0} documents have been selected. Only the first {0} selected documents will be opened..
        '''</summary>
        Friend ReadOnly Property OpenCheckedDocumentsMaximumReached() As String
            Get
                Return ResourceManager.GetString("OpenCheckedDocumentsMaximumReached", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property page_text() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("page_text", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to PDF contains User password and is not supported..
        '''</summary>
        Friend ReadOnly Property PdfContainsUserPassword() As String
            Get
                Return ResourceManager.GetString("PdfContainsUserPassword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to PDF files|*.pdf.
        '''</summary>
        Friend ReadOnly Property PdfFilter() As String
            Get
                Return ResourceManager.GetString("PdfFilter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to PDF is invalid..
        '''</summary>
        Friend ReadOnly Property PdfInvalid() As String
            Get
                Return ResourceManager.GetString("PdfInvalid", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to PDF Owner password is invalid..
        '''</summary>
        Friend ReadOnly Property PdfOwnerPasswordInvalid() As String
            Get
                Return ResourceManager.GetString("PdfOwnerPasswordInvalid", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to PDF Owner password required..
        '''</summary>
        Friend ReadOnly Property PdfOwnerPasswordRequired() As String
            Get
                Return ResourceManager.GetString("PdfOwnerPasswordRequired", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Profile name contains characters not allowed in file names..
        '''</summary>
        Friend ReadOnly Property ProfileNameInvalid() As String
            Get
                Return ResourceManager.GetString("ProfileNameInvalid", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Refresh Documents?.
        '''</summary>
        Friend ReadOnly Property RefreshDocuments() As String
            Get
                Return ResourceManager.GetString("RefreshDocuments", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select the folder location where to burst the PDF for the selected document:
        '''Note: PDF file names will be prefixed with: {0}.
        '''</summary>
        Friend ReadOnly Property SelectBurstFolder() As String
            Get
                Return ResourceManager.GetString("SelectBurstFolder", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select the folder location where the export folder will be created:.
        '''</summary>
        Friend ReadOnly Property SelectExportFolder() As String
            Get
                Return ResourceManager.GetString("SelectExportFolder", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select the new folder location where the database will be stored:.
        '''</summary>
        Friend ReadOnly Property SelectNewDatabaseFolderLocation() As String
            Get
                Return ResourceManager.GetString("SelectNewDatabaseFolderLocation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Subject.
        '''</summary>
        Friend ReadOnly Property Subject() As String
            Get
                Return ResourceManager.GetString("Subject", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property table() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("table", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tax Year.
        '''</summary>
        Friend ReadOnly Property TaxYear() As String
            Get
                Return ResourceManager.GetString("TaxYear", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Text files|*.txt.
        '''</summary>
        Friend ReadOnly Property TextFilter() As String
            Get
                Return ResourceManager.GetString("TextFilter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Title.
        '''</summary>
        Friend ReadOnly Property Title() As String
            Get
                Return ResourceManager.GetString("Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The changes you made to the Notes text box cannot be saved and have been lost because another user has updated the Notes for the same record.
        '''
        '''The contents of the Notes text box prior to the attempted save operation have been copied to the Clipboard..
        '''</summary>
        Friend ReadOnly Property UnableToSaveNotes() As String
            Get
                Return ResourceManager.GetString("UnableToSaveNotes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An Unhandled Exception has occurred in the application..
        '''</summary>
        Friend ReadOnly Property UnhandledException() As String
            Get
                Return ResourceManager.GetString("UnhandledException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Stack Trace has been logged to {0}.
        '''</summary>
        Friend ReadOnly Property UnhandledExceptionLog() As String
            Get
                Return ResourceManager.GetString("UnhandledExceptionLog", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Upload.
        '''</summary>
        Friend ReadOnly Property Upload() As String
            Get
                Return ResourceManager.GetString("Upload", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Upload Profile already exists..
        '''</summary>
        Friend ReadOnly Property UploadProfileExists() As String
            Get
                Return ResourceManager.GetString("UploadProfileExists", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Version {0}.
        '''</summary>
        Friend ReadOnly Property Version() As String
            Get
                Return ResourceManager.GetString("Version", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
