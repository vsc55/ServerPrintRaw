﻿Option Strict On
Option Explicit On
'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System.Configuration

Namespace My

    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0"),
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced),
    SettingsProvider(GetType(CerebelumLib.MySettings.SettingsProvider))>
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()), MySettings)

#Region "Funcionalidad para autoguardar My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region

        Public Shared ReadOnly Property [Default]() As MySettings
            Get

#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("False")>
        Public Property AutoStart() As Boolean
            Get
                Return CType(Me("AutoStart"), Boolean)
            End Get
            Set
                Me("AutoStart") = Value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("")>
        Public Property Path() As String
            Get
                Return CType(Me("Path"), String)
            End Get
            Set
                Me("Path") = Value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("0.0.0.0")>
        Public Property Address() As String
            Get
                Return CType(Me("Address"), String)
            End Get
            Set
                Me("Address") = Value
            End Set
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("9100")>
        Public ReadOnly Property DefaultPort() As Integer
            Get
                Return CType(Me("DefaultPort"), Integer)
            End Get
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("0.0.0.0")>
        Public ReadOnly Property DefaultAddress() As String
            Get
                Return CType(Me("DefaultAddress"), String)
            End Get
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("False")>
        Public ReadOnly Property DefaultAutoStart() As Boolean
            Get
                Return CType(Me("DefaultAutoStart"), Boolean)
            End Get
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("yyyyMMddhhmmssfff")>
        Public Property StorePrintTemplateID() As String
            Get
                Return CType(Me("StorePrintTemplateID"), String)
            End Get
            Set
                Me("StorePrintTemplateID") = Value
            End Set
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("yyyyMMddhhmmssfff")>
        Public ReadOnly Property DefaultStorePrintTemplateID() As String
            Get
                Return CType(Me("DefaultStorePrintTemplateID"), String)
            End Get
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("9100")>
        Public Property Port() As Integer
            Get
                Return CType(Me("Port"), Integer)
            End Get
            Set
                Me("Port") = Value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("Tipo de(\s*.*)\: modo usuario")>
        Public Property RegexSearchID() As String
            Get
                Return CType(Me("RegexSearchID"), String)
            End Get
            Set
                Me("RegexSearchID") = Value
            End Set
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("")>
        Public ReadOnly Property DefaultRegexSearchID() As String
            Get
                Return CType(Me("DefaultRegexSearchID"), String)
            End Get
        End Property
    End Class
End Namespace

Namespace My

    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    Friend Module MySettingsProperty

        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>
        Friend ReadOnly Property Settings() As Global.LibCore.My.MySettings
            Get
                Return Global.LibCore.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace