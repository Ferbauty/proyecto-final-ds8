Public Class FormCiencias

    Private MainForm As Form1

    ' Constructor que toma una referencia al formulario principal
    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.MainForm = mainForm
    End Sub

    Private Sub btnRegistrarCiencias_Click(sender As Object, e As EventArgs) Handles btnRegistrarCiencias.Click
        Dim nombre, apellido, cedula, laborSocial, facultad As String
        Dim edad, horas As Integer

        'Capturando los datos de los textBox
        nombre = txtNombreCiencias.Text
        apellido = txtApellidoCiencias.Text
        cedula = txtCedulaCiencias.Text

        'Tomando el dato de la edad
        If Integer.TryParse(txtEdadCiencias.Text, edad) = False Then
            MessageBox.Show("Ingrese un edad valida.")
            Return
        End If

        'Obteniendo datos de los radioButton
        If rbLSCiencias1.Checked Then
            laborSocial = "Pintar escuelas"
        ElseIf rbLSCiencias2.Checked Then
            laborSocial = "Jornada de reciclaje"
        ElseIf rbLSCiencias3.Checked Then
            laborSocial = "Jornada de limpieza"
        ElseIf rbLSCiencias4.Checked Then
            laborSocial = "Donacion de alimentos secos"
        ElseIf rbLSCiencias5.Checked Then
            laborSocial = "Plantación de árboles"
        Else
            MessageBox.Show("Selecciona una labor social para registrar")
            Return
        End If

        'Horas de labor social
        If lbHorasCiencias.SelectedIndex <> -1 Then
            horas = lbHorasCiencias.SelectedItem
            txtHorasCiencias.Text = horas.ToString

        Else
            MessageBox.Show("Debes saleccionar una cantidad de horas de la lista.")
        End If

        facultad = "Ingeniería Ciencias y Tecnología"

        'codigo para enviar los datos al registro de la facultad correspendiente
        dgvRegistroCiencias.Rows.Add(nombre, apellido, cedula, edad, laborSocial, horas)

        'codigo para enviar el registro de la facultad al reporte general
        Form1.AgregarReporte(nombre, apellido, cedula, facultad, laborSocial)

        LimpiezaControles()

        TabControl1.SelectedIndex = 2

    End Sub

    Private Sub LimpiezaControles()
        'Limpia textBox
        txtNombreCiencias.Clear()
        txtApellidoCiencias.Clear()
        txtCedulaCiencias.Clear()
        txtEdadCiencias.Clear()

        'Desmarca radioButton
        rbLSCiencias1.Checked = False
        rbLSCiencias2.Checked = False
        rbLSCiencias3.Checked = False
        rbLSCiencias4.Checked = False
        rbLSCiencias5.Checked = False

        'Desmarca listBox
        lbHorasCiencias.ClearSelected()

    End Sub



    Private Sub btnSiguienteCiencias_Click(sender As Object, e As EventArgs) Handles btnSiguienteCiencias.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnRegCiencias_Click(sender As Object, e As EventArgs) Handles btnRegCiencias.Click
        TabControl1.SelectedIndex = 0
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Close()
    End Sub

End Class