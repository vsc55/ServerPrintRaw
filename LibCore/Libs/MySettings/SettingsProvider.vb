Imports System.Configuration
Imports System.Reflection
Imports Newtonsoft.Json


'No implementado
'Basado en: https://www.vbforums.com/showthread.php?754687-RESOLVED-Saving-My-Settings-in-user-defined-path

Namespace CerebelumLib.MySettings

    Public Class SettingsProvider
        Inherits System.Configuration.SettingsProvider

        Private ReadOnly _sFileCfgName As String = "SettingsAll.json"
        Private _appName As String

        Public ReadOnly Property GetConfigPathFull As String
            Get
                Return String.Format("{0}\{1}", My.Application.Info.DirectoryPath, Me._sFileCfgName)
            End Get
        End Property


        Public Overrides Property ApplicationName As String
            Get
                Return System.Reflection.Assembly.GetExecutingAssembly().GetName().Name
            End Get
            Set(ByVal value As String)

            End Set
        End Property

        Public Overrides Sub Initialize(ByVal name As String, ByVal config As System.Collections.Specialized.NameValueCollection)
            'MyBase.Initialize(name, config)
            MyBase.Initialize("CustomProviderSettings", Nothing)
        End Sub

        Public Overrides Function GetPropertyValues(ByVal context As System.Configuration.SettingsContext, ByVal collection As System.Configuration.SettingsPropertyCollection) As System.Configuration.SettingsPropertyValueCollection
            Dim settingsCollection As New SettingsPropertyValueCollection
            Dim settings As New Dictionary(Of String, StoreSetting)
            Dim json As String

            If IO.File.Exists(Me.GetConfigPathFull()) Then
                json = IO.File.ReadAllText(Me.GetConfigPathFull())
                settings = JsonConvert.DeserializeObject(Of Dictionary(Of String, StoreSetting))(json)
            End If

            For Each prop As SettingsProperty In collection
                Dim propNameKey As String = prop.Name.ToLower
                Dim pval As New SettingsPropertyValue(prop)
                settingsCollection.Add(pval)

                If settings.ContainsKey(propNameKey) Then
                    Dim setting As StoreSetting = settings.Item(propNameKey)
                    If IsNothing(setting.TypeValueStr) OrElse Not setting.TypeValueStr.GetType.Equals(GetType(String)) OrElse setting.TypeValueStr = String.Empty Then
                        logger.WarnFormat("Config ({0}) Skip!! - Tipo de propiedad no definida o no valida!", propNameKey)
                    Else
                        'pval.PropertyValue = Convert.ChangeType(setting.Value, setting.TypeValue)
                        pval.PropertyValue = Convert.ChangeType(setting.Value, Type.GetType(setting.TypeValueStr))
                        Continue For
                    End If
                End If
                pval.PropertyValue = prop.DefaultValue
            Next
            Return settingsCollection
        End Function

        Public Overrides Sub SetPropertyValues(ByVal context As System.Configuration.SettingsContext, ByVal collection As System.Configuration.SettingsPropertyValueCollection)

            Dim settings As New Dictionary(Of String, StoreSetting)
            For Each pval As SettingsPropertyValue In collection
                Dim PropInfo As PropertyInfo = My.Settings.GetType().GetProperty(pval.Name)

                'Solo guardamos las propiedades que se pueden modificar (UserScopedSettingAttribute).
                If Not PropInfo.CanWrite Then Continue For

                Dim setting As New StoreSetting With {
                    .Name = pval.Name,
                    .Value = pval.PropertyValue,
                    .TypeValue = pval.Property.PropertyType,
                    .TypeValueStr = pval.Property.PropertyType.ToString
                }
                settings.Add(pval.Name.ToLower, setting)
            Next
            Dim json As String = JsonConvert.SerializeObject(settings)
            IO.File.WriteAllText(Me.GetConfigPathFull(), json)
        End Sub

    End Class

End Namespace