Imports System.Net.NetworkInformation

Public NotInheritable Class frmAboutBox

    Private Sub frmAboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establezca el título del formulario.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
        ' Inicialice todo el texto mostrado en el cuadro Acerca de.
        ' TODO: personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        Me.LabelProductName.Text = String.Format("Aplicacion: {0}", My.Application.Info.ProductName)
        Me.LabelVersion.Text = String.Format("Versión: {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = String.Format("Copyright: {0}", My.Application.Info.Copyright)
        Me.LabelCompanyName.Text = String.Format("Compañia: {0}", My.Application.Info.CompanyName)
        Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox2.DoubleClick

        Dim winDebug As New frmDebug()
        winDebug.Show()

    End Sub

End Class
