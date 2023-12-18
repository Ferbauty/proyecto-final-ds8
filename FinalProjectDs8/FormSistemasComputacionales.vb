Public Class FormSistemasComputacionales
    Private MainForm As Form1

    ' Constructor que toma una referencia al formulario principal
    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.MainForm = mainForm
    End Sub

    Private Sub btnRegistrarSistemas_Click(sender As Object, e As EventArgs) Handles btnRegistrarSistemas.Click
        Dim nombre, apellido, cedula, laborSocial, facultad As String
        Dim edad, horas As Integer

        'Capturando los datos de los textBox
        nombre = txtNombreSistemas.Text
        apellido = txtApellidoSistemas.Text
        cedula = txtCedulaSistemas.Text

        'Tomando el dato de la edad
        If Integer.TryParse(txtEdadSistemas.Text, edad) = False Then
            MessageBox.Show("Ingrese un edad valida.")
            Return
        End If

        'Obteniendo datos de los radioButton
        If rbLSSistemas1.Checked Then
            laborSocial = "Pintar escuelas"
        ElseIf rbLSSistemas2.Checked Then
            laborSocial = "Jornada de reciclaje"
        ElseIf rbLSSistemas3.Checked Then
            laborSocial = "Jornada de limpieza"
        ElseIf rbLSSistemas4.Checked Then
            laborSocial = "Donacion de alimentos secos"
        ElseIf rbLSSistemas5.Checked Then
            laborSocial = "Plantación de árboles"
        Else
            MessageBox.Show("Selecciona una labor social para registrar")
            Return
        End If

        'Horas de labor social
        If lbHorasSistemas.SelectedIndex <> -1 Then
            horas = lbHorasSistemas.SelectedItem
            txtHorasSistemas.Text = horas.ToString

        Else
            MessageBox.Show("Debes saleccionar una cantidad de horas de la lista.")
        End If

        facultad = "Ingeniería Sistemas Computacionales"

        'codigo para enviar los datos al registro de la facultad correspendiente
        dgvRegistroSistemas.Rows.Add(nombre, apellido, cedula, edad, laborSocial, horas)

        'codigo para enviar el registro de la facultad al reporte general
        Form1.AgregarReporte(nombre, apellido, cedula, facultad, laborSocial)

        LimpiezaControles()

        TabControl1.SelectedIndex = 2

    End Sub

    Private Sub LimpiezaControles()
        'Limpia textBox
        txtNombreSistemas.Clear()
        txtApellidoSistemas.Clear()
        txtCedulaSistemas.Clear()
        txtEdadSistemas.Clear()

        'Desmarca radioButton
        rbLSSistemas1.Checked = False
        rbLSSistemas2.Checked = False
        rbLSSistemas3.Checked = False
        rbLSSistemas4.Checked = False
        rbLSSistemas5.Checked = False

        'Desmarca listBox
        lbHorasSistemas.ClearSelected()

    End Sub



    Private Sub btnSiguienteSistemas_Click(sender As Object, e As EventArgs) Handles btnSiguienteSistemas.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnRegSistemas_Click(sender As Object, e As EventArgs) Handles btnRegSistemas.Click
        TabControl1.SelectedIndex = 0
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Close()
    End Sub
End Class