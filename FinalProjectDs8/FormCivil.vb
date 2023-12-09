Public Class FormCivil
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
        Else
            MessageBox.Show("Debes saleccionar una cantidad de horas de la lista.")
        End If

        facultad = "Ingeniería Civil"

        dgvRegistroCivil.Rows.Add(nombre, apellido, cedula, edad, laborSocial, horas)

        LimpiezaControles()

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
End Class