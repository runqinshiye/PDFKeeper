﻿'------------------------------------------------------------------------------
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
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PDFKeeper.WindowsApplication.Resources", GetType(Resources).Assembly)
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
        '''  Looks up a localized string similar to Cache.
        '''</summary>
        Friend ReadOnly Property Cache() As String
            Get
                Return ResourceManager.GetString("Cache", resourceCulture)
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
        '''  Looks up a localized string similar to Database contains {0} document records..
        '''</summary>
        Friend ReadOnly Property DBDocumentRecordsCountMessage() As String
            Get
                Return ResourceManager.GetString("DBDocumentRecordsCountMessage", resourceCulture)
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
        '''  Looks up a localized string similar to Are you sure you want to delete the selected Upload folder and configuration?.
        '''</summary>
        Friend ReadOnly Property DeleteUploadConfigurationPrompt() As String
            Get
                Return ResourceManager.GetString("DeleteUploadConfigurationPrompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to PDFKeeper is an Open Source PDF Document Storage Solution that integrates with a compatible, relational database management system to provide an upload, index, and search solution for PDF documents.
        '''
        '''This program comes with ABSOLUTELY NO WARRANTY; this is free software, and you are welcome to redistribute it under certain conditions; for details, select License..
        '''</summary>
        Friend ReadOnly Property DescriptionDetail() As String
            Get
                Return ResourceManager.GetString("DescriptionDetail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Document ID: {0} - {1}.
        '''</summary>
        Friend ReadOnly Property DocumentIdException() As String
            Get
                Return ResourceManager.GetString("DocumentIdException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Document Notes have been modified.
        '''Do you want to save changes before closing?.
        '''</summary>
        Friend ReadOnly Property DocumentNotesModified() As String
            Get
                Return ResourceManager.GetString("DocumentNotesModified", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Document record may have been deleted..
        '''</summary>
        Friend ReadOnly Property DocumentRecordMayHaveBeenDeleted() As String
            Get
                Return ResourceManager.GetString("DocumentRecordMayHaveBeenDeleted", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Enter Owner Password:.
        '''</summary>
        Friend ReadOnly Property EnterOwnerPassword() As String
            Get
                Return ResourceManager.GetString("EnterOwnerPassword", resourceCulture)
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
        '''  Looks up a localized string similar to This feature is disabled by policy..
        '''</summary>
        Friend ReadOnly Property FeatureDisabledByPolicy() As String
            Get
                Return ResourceManager.GetString("FeatureDisabledByPolicy", resourceCulture)
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
        '''  Looks up a localized string similar to File not found exception has occurred in the application..
        '''</summary>
        Friend ReadOnly Property FileNotFoundException() As String
            Get
                Return ResourceManager.GetString("FileNotFoundException", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to {0} was saved..
        '''</summary>
        Friend ReadOnly Property FileSaved() As String
            Get
                Return ResourceManager.GetString("FileSaved", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to {0} files (*.{1})|*.{1}.
        '''</summary>
        Friend ReadOnly Property FilterExtension() As String
            Get
                Return ResourceManager.GetString("FilterExtension", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Folder name contains invalid characters..
        '''</summary>
        Friend ReadOnly Property FolderNameContainsInvalidChars() As String
            Get
                Return ResourceManager.GetString("FolderNameContainsInvalidChars", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to cancel and discard all changes?.
        '''</summary>
        Friend ReadOnly Property GenericFormCancellingPrompt() As String
            Get
                Return ResourceManager.GetString("GenericFormCancellingPrompt", resourceCulture)
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
        '''  Looks up a localized string similar to PDF Owner Password.
        '''</summary>
        Friend ReadOnly Property PdfOwnerPassword() As String
            Get
                Return ResourceManager.GetString("PdfOwnerPassword", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Improper usage of query operators and/or characters..
        '''</summary>
        Friend ReadOnly Property SearchStringImproperUsageOfQueryOperators() As String
            Get
                Return ResourceManager.GetString("SearchStringImproperUsageOfQueryOperators", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Selected files have been exported to: {0}.
        '''</summary>
        Friend ReadOnly Property SelectedFilesHaveBeenExported() As String
            Get
                Return ResourceManager.GetString("SelectedFilesHaveBeenExported", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select the location where the export folder will be created:.
        '''</summary>
        Friend ReadOnly Property SelectExportFolder() As String
            Get
                Return ResourceManager.GetString("SelectExportFolder", resourceCulture)
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
        '''  Looks up a localized string similar to Title.
        '''</summary>
        Friend ReadOnly Property Title() As String
            Get
                Return ResourceManager.GetString("Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unhandled exception has occurred in the application..
        '''</summary>
        Friend ReadOnly Property UnhandledException() As String
            Get
                Return ResourceManager.GetString("UnhandledException", resourceCulture)
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
        '''  Looks up a localized string similar to UploadConfig.
        '''</summary>
        Friend ReadOnly Property UploadConfig() As String
            Get
                Return ResourceManager.GetString("UploadConfig", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Upload folder cannot be deleted because it contains one or more files..
        '''</summary>
        Friend ReadOnly Property UploadFolderCannotBeDeleted() As String
            Get
                Return ResourceManager.GetString("UploadFolderCannotBeDeleted", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to UploadStaging.
        '''</summary>
        Friend ReadOnly Property UploadStaging() As String
            Get
                Return ResourceManager.GetString("UploadStaging", resourceCulture)
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
