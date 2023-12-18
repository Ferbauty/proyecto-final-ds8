Imports System.Net

Public Class Form1
    Private formCivil As FormCivil
    Private formMecanica As FormMecanica
    Private formSistemas As FormSistemasComputacionales
    Private formElectrica As FormElectrica
    Private formIndustrial As FormIndustrial
    Private formCiencias As FormCiencias

    Private Sub rbCivil_CheckedChanged(sender As Object, e As EventArgs) Handles rbCivil.CheckedChanged
        If formCivil Is Nothing OrElse formCivil.IsDisposed Then
            formCivil = New FormCivil(Me)
        End If
        formCivil.Show()
        Me.Hide()
    End Sub
    Private Sub rbMecanica_CheckedChanged(sender As Object, e As EventArgs) Handles rbMecanica.CheckedChanged
        If formMecanica Is Nothing OrElse formMecanica.IsDisposed Then
            formMecanica = New FormMecanica(Me)
        End If
        formMecanica.Show()
        Me.Hide()
    End Sub

    Private Sub rbSistemas_CheckedChanged(sender As Object, e As EventArgs) Handles rbSistemas.CheckedChanged
        If formSistemas Is Nothing OrElse formSistemas.IsDisposed Then
            formSistemas = New FormSistemasComputacionales(Me)
        End If
        formSistemas.Show()
        Me.Hide()
    End Sub

    Private Sub rbElectrica_CheckedChanged(sender As Object, e As EventArgs) Handles rbElectrica.CheckedChanged
        If formElectrica Is Nothing OrElse formElectrica.IsDisposed Then
            formElectrica = New FormElectrica(Me)
        End If
        formElectrica.Show()
        Me.Hide()
    End Sub

    Private Sub rbIndustrial_CheckedChanged(sender As Object, e As EventArgs) Handles rbIndustrial.CheckedChanged
        If formIndustrial Is Nothing OrElse formIndustrial.IsDisposed Then
            formIndustrial = New FormIndustrial(Me)
        End If
        formIndustrial.Show()
        Me.Hide()
    End Sub

    Private Sub rbCiencias_CheckedChanged(sender As Object, e As EventArgs) Handles rbCiencias.CheckedChanged
        If formCiencias Is Nothing OrElse formCiencias.IsDisposed Then
            formCiencias = New FormCiencias(Me)
        End If
        formCiencias.Show()
        Me.Hide()
    End Sub
    Public Sub AgregarReporte(nombre As String, apellido As String, cedula As String, facultad As String, laborSocial As String)
        'metodo que agrega los datos al reporte general
        dgvReporte.Rows.Add(nombre, apellido, cedula, facultad, laborSocial)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' URL de la imagen en la web
        Dim urlImagen As String = "https://www.google.com/url?sa=i&url=https%3A%2F%2Futp.ac.pa%2Flogos-para-impresion&psig=AOvVaw3K_SBfnjSgSY7jyIEEJPE9&ust=1702787760569000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCKDPlu-Qk4MDFQAAAAAdAAAAABAD"

        ' Descargar la imagen desde la web
        Dim clienteWeb As New WebClient()

        Try
            ' Convierte la imagen descargada en un objeto Image
            Dim imagenDesdeWeb As Image = Image.FromStream(clienteWeb.OpenRead(urlImagen))

            ' Asigna la imagen al PictureBox
            PictureBox1.Image = imagenDesdeWeb
        Catch ex As Exception
            MessageBox.Show("Error al descargar la imagen desde la web: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
