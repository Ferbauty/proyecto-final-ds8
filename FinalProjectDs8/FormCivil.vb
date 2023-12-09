Public Class FormCivil

    Private Form1 As Form1


    Private Sub btnRegistrarCivil_Click(sender As Object, e As EventArgs) Handles btnRegistrarCivil.Click
        Dim nombre, apellido, cedula, laborSocial, facultad As String
        Dim edad, horas As Integer

        'Capturando los datos de los textBox
        nombre = txtNombreCivil.Text
        apellido = txtApellidoCivil.Text
        cedula = txtCedulaCivil.Text

        'Tomando el dato de la edad
        If Integer.TryParse(txtEdadCivil.Text, edad) = False Then
            MessageBox.Show("Ingrese un edad valida.")
            Return
        End If

        'Obteniendo datos de los radioButton
        If rbLSCivil1.Checked Then
            laborSocial = "Pintar escuelas"
        ElseIf rbLSCivil2.Checked Then
            laborSocial = "Jornada de reciclaje"
        ElseIf rbLSCivil3.Checked Then
            laborSocial = "Jornada de limpieza"
        ElseIf rbLSCivil4.Checked Then
            laborSocial = "Donacion de alimentos secos"
        ElseIf rbLSCivil5.Checked Then
            laborSocial = "Plantación de árboles"
        Else
            MessageBox.Show("Selecciona una labor social para registrar")
            Return
        End If

        'Horas de labor social
        If lbHorasCivil.SelectedIndex <> -1 Then
            horas = lbHorasCivil.SelectedItem
            txtHorasCivil.Text = horas.ToString

        Else
            MessageBox.Show("Debes saleccionar una cantidad de horas de la lista.")
        End If

        facultad = "Ingeniería Civil"

        'codigo para enviar los datos al registro de la facultad correspendiente
        dgvRegistroCivil.Rows.Add(nombre, apellido, cedula, edad, laborSocial, horas)

        'codigo para enviar el registro de la facultad al reporte general
        Form1.AgregarReporte(nombre, apellido, cedula, facultad, laborSocial)

        LimpiezaControles()

        TabControl1.SelectedIndex = 2

    End Sub

    Private Sub LimpiezaControles()
        'Limpia textBox
        txtNombreCivil.Clear()
        txtApellidoCivil.Clear()
        txtCedulaCivil.Clear()
        txtEdadCivil.Clear()

        'Desmarca radioButton
        rbLSCivil1.Checked = False
        rbLSCivil2.Checked = False
        rbLSCivil3.Checked = False
        rbLSCivil4.Checked = False
        rbLSCivil5.Checked = False

        'Desmarca listBox
        lbHorasCivil.ClearSelected()

    End Sub



    Private Sub btnSiguienteCivil_Click(sender As Object, e As EventArgs) Handles btnSiguienteCivil.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnRegCivil_Click(sender As Object, e As EventArgs) Handles btnRegCivil.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub FormCivil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1 = New Form1()
        Form1.Show()

    End Sub
End Class