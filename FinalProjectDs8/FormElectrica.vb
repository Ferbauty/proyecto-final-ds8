Public Class FormElectrica

    Private MainForm As Form1

    ' Constructor que toma una referencia al formulario principal
    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.MainForm = mainForm
    End Sub

    Private Sub btnRegistrarElectrica_Click(sender As Object, e As EventArgs) Handles btnRegistrarElectrica.Click
        Dim nombre, apellido, cedula, laborSocial, facultad As String
        Dim edad, horas As Integer

        'Capturando los datos de los textBox
        nombre = txtNombreElectrica.Text
        apellido = txtApellidoElectrica.Text
        cedula = txtCedulaElectrica.Text

        'Tomando el dato de la edad
        If Integer.TryParse(txtEdadElectrica.Text, edad) = False Then
            MessageBox.Show("Ingrese un edad valida.")
            Return
        End If

        'Obteniendo datos de los radioButton
        If rbLSElectrica1.Checked Then
            laborSocial = "Pintar escuelas"
        ElseIf rbLSElectrica2.Checked Then
            laborSocial = "Jornada de reciclaje"
        ElseIf rbLSElectrica3.Checked Then
            laborSocial = "Jornada de limpieza"
        ElseIf rbLSElectrica4.Checked Then
            laborSocial = "Donacion de alimentos secos"
        ElseIf rbLSElectrica5.Checked Then
            laborSocial = "Plantación de árboles"
        Else
            MessageBox.Show("Selecciona una labor social para registrar")
            Return
        End If

        'Horas de labor social
        If lbHorasElectrica.SelectedIndex <> -1 Then
            horas = lbHorasElectrica.SelectedItem
            txtHorasElectrica.Text = horas.ToString

        Else
            MessageBox.Show("Debes saleccionar una cantidad de horas de la lista.")
        End If

        facultad = "Ingeniería Electrica"

        'codigo para enviar los datos al registro de la facultad correspendiente
        dgvRegistroElectrica.Rows.Add(nombre, apellido, cedula, edad, laborSocial, horas)

        'codigo para enviar el registro de la facultad al reporte general
        Form1.AgregarReporte(nombre, apellido, cedula, facultad, laborSocial)

        LimpiezaControles()

        TabControl1.SelectedIndex = 2

    End Sub

    Private Sub LimpiezaControles()
        'Limpia textBox
        txtNombreElectrica.Clear()
        txtApellidoElectrica.Clear()
        txtCedulaElectrica.Clear()
        txtEdadElectrica.Clear()

        'Desmarca radioButton
        rbLSElectrica1.Checked = False
        rbLSElectrica2.Checked = False
        rbLSElectrica3.Checked = False
        rbLSElectrica4.Checked = False
        rbLSElectrica5.Checked = False

        'Desmarca listBox
        lbHorasElectrica.ClearSelected()

    End Sub



    Private Sub btnSiguienteElectrica_Click(sender As Object, e As EventArgs) Handles btnSiguienteElectrica.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnRegElectrica_Click(sender As Object, e As EventArgs) Handles btnRegElectrica.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Close()
    End Sub
End Class