Public Class FormMecanica

    Private MainForm As Form1

    ' Constructor que toma una referencia al formulario principal
    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.MainForm = mainForm
    End Sub


    Private Sub btnRegistrarMecanica_Click(sender As Object, e As EventArgs) Handles btnRegistrarMecanica.Click
        Dim nombre, apellido, cedula, laborSocial, facultad As String
        Dim edad, horas As Integer

        'Capturando los datos de los textBox
        nombre = txtNombreMecanica.Text
        apellido = txtApellidoMecanica.Text
        cedula = txtCedulaMecanica.Text

        'Tomando el dato de la edad
        If Integer.TryParse(txtEdadMecanica.Text, edad) = False Then
            MessageBox.Show("Ingrese un edad valida.")
            Return
        End If

        'Obteniendo datos de los radioButton
        If rbLSMecanica1.Checked Then
            laborSocial = "Pintar escuelas"
        ElseIf rbLSMecanica2.Checked Then
            laborSocial = "Jornada de reciclaje"
        ElseIf rbLSMecanica3.Checked Then
            laborSocial = "Jornada de limpieza"
        ElseIf rbLSMecanica4.Checked Then
            laborSocial = "Donacion de alimentos secos"
        ElseIf rbLSMecanica5.Checked Then
            laborSocial = "Plantación de árboles"
        Else
            MessageBox.Show("Selecciona una labor social para registrar")
            Return
        End If

        'Horas de labor social
        If lbHorasMecanica.SelectedIndex <> -1 Then
            horas = lbHorasMecanica.SelectedItem
            txtHorasMecanica.Text = horas.ToString

        Else
            MessageBox.Show("Debes saleccionar una cantidad de horas de la lista.")
        End If

        facultad = "Ingeniería Mecanica"

        'codigo para enviar los datos al registro de la facultad correspendiente
        dgvRegistroMecanica.Rows.Add(nombre, apellido, cedula, edad, laborSocial, horas)

        'codigo para enviar el registro de la facultad al reporte general
        Form1.AgregarReporte(nombre, apellido, cedula, facultad, laborSocial)

        LimpiezaControles()

        TabControl1.SelectedIndex = 2

    End Sub

    Private Sub LimpiezaControles()
        'Limpia textBox
        txtNombreMecanica.Clear()
        txtApellidoMecanica.Clear()
        txtCedulaMecanica.Clear()
        txtEdadMecanica.Clear()

        'Desmarca radioButton
        rbLSMecanica1.Checked = False
        rbLSMecanica2.Checked = False
        rbLSMecanica3.Checked = False
        rbLSMecanica4.Checked = False
        rbLSMecanica5.Checked = False

        'Desmarca listBox
        lbHorasMecanica.ClearSelected()

    End Sub



    Private Sub btnSiguienteMecanica_Click(sender As Object, e As EventArgs) Handles btnSiguienteMecanica.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnRegMecanica_Click(sender As Object, e As EventArgs) Handles btnRegMecanica.Click
        TabControl1.SelectedIndex = 0
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Close()
    End Sub
End Class