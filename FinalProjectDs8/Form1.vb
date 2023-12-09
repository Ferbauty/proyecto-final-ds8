Public Class Form1
    Private Sub rbCivil_CheckedChanged(sender As Object, e As EventArgs) Handles rbCivil.CheckedChanged
        FormCivil.Show()
        Me.Hide()

    End Sub

    Public Sub AgregarReporte(nombre As String, apellido As String, cedula As String, facultad As String, laborSocial As String)
        'metodo que agrega los datos al reporte general
        dgvReporte.Rows.Add(nombre, apellido, cedula, facultad, laborSocial)
    End Sub

End Class
