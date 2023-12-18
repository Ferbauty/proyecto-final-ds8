Public Class FormIndustrial

    Private MainForm As Form1

    ' Constructor que toma una referencia al formulario principal
    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.MainForm = mainForm
    End Sub


    Private Sub btnRegistrarIndustrial_Click(sender As Object, e As EventArgs) Handles btnRegistrarIndustrial.Click
        Dim nombre, apellido, cedula, laborSocial, facultad As String
        Dim edad, horas As Integer

        'Capturando los datos de los textBox
        nombre = txtNombreIndustrial.Text
        apellido = txtApellidoIndustrial.Text
        cedula = txtCedulaIndustrial.Text

        'Tomando el dato de la edad
        If Integer.TryParse(txtEdadIndustrial.Text, edad) = False Then
            MessageBox.Show("Ingrese un edad valida.")
            Return
        End If

        'Obteniendo datos de los radioButton
        If rbLSIndustrial1.Checked Then
            laborSocial = "Pintar escuelas"
        ElseIf rbLSIndustrial2.Checked Then
            laborSocial = "Jornada de reciclaje"
        ElseIf rbLSIndustrial3.Checked Then
            laborSocial = "Jornada de limpieza"
        ElseIf rbLSIndustrial4.Checked Then
            laborSocial = "Donacion de alimentos secos"
        ElseIf rbLSIndustrial5.Checked Then
            laborSocial = "Plantación de árboles"
        Else
            MessageBox.Show("Selecciona una labor social para registrar")
            Return
        End If

        'Horas de labor social
        If lbHorasIndustrial.SelectedIndex <> -1 Then
            horas = lbHorasIndustrial.SelectedItem
            txtHorasIndustrial.Text = horas.ToString

        Else
            MessageBox.Show("Debes saleccionar una cantidad de horas de la lista.")
        End If

        facultad = "Ingeniería Industrial"

        'codigo para enviar los datos al registro de la facultad correspendiente
        dgvRegistroIndustrial.Rows.Add(nombre, apellido, cedula, edad, laborSocial, horas)

        'codigo para enviar el registro de la facultad al reporte general
        Form1.AgregarReporte(nombre, apellido, cedula, facultad, laborSocial)

        LimpiezaControles()

        TabControl1.SelectedIndex = 2

    End Sub

    Private Sub LimpiezaControles()
        'Limpia textBox
        txtNombreIndustrial.Clear()
        txtApellidoIndustrial.Clear()
        txtCedulaIndustrial.Clear()
        txtEdadIndustrial.Clear()

        'Desmarca radioButton
        rbLSIndustrial1.Checked = False
        rbLSIndustrial2.Checked = False
        rbLSIndustrial3.Checked = False
        rbLSIndustrial4.Checked = False
        rbLSIndustrial5.Checked = False

        'Desmarca listBox
        lbHorasIndustrial.ClearSelected()

    End Sub



    Private Sub btnSiguienteIndustrial_Click(sender As Object, e As EventArgs) Handles btnSiguienteIndustrial.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnRegIndustrial_Click(sender As Object, e As EventArgs) Handles btnRegIndustrial.Click
        TabControl1.SelectedIndex = 0
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Close()
    End Sub

   
End Class