Imports System.ComponentModel
Imports System.Configuration.Install

Public Class ProjectInstaller

    Public Sub New()
        MyBase.New()

        'El Diseñador de componentes requiere esta llamada.
        InitializeComponent()

        'Agregue el código de inicialización después de llamar a InitializeComponent

    End Sub

    Public Shared Function GetServiceName() As String
        Dim oTemp As New ProjectInstaller
        Return oTemp.ServiceInstaller1.ServiceName
    End Function

End Class
