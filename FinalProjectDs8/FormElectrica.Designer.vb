<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormElectrica
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnSiguienteElectrica = New Button()
        txtEdadElectrica = New TextBox()
        txtCedulaElectrica = New TextBox()
        txtApellidoElectrica = New TextBox()
        txtNombreElectrica = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        btnRegElectrica = New Button()
        btnRegistrarElectrica = New Button()
        txtHorasElectrica = New TextBox()
        Label7 = New Label()
        lbHorasElectrica = New ListBox()
        Label6 = New Label()
        rbLSElectrica5 = New RadioButton()
        rbLSElectrica4 = New RadioButton()
        rbLSElectrica3 = New RadioButton()
        rbLSElectrica2 = New RadioButton()
        rbLSElectrica1 = New RadioButton()
        Label5 = New Label()
        TabPage3 = New TabPage()
        dgvRegistroElectrica = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Label8 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(dgvRegistroElectrica, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(13, 96)
        TabControl1.Margin = New Padding(4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1193, 668)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnSiguienteElectrica)
        TabPage1.Controls.Add(txtEdadElectrica)
        TabPage1.Controls.Add(txtCedulaElectrica)
        TabPage1.Controls.Add(txtApellidoElectrica)
        TabPage1.Controls.Add(txtNombreElectrica)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Margin = New Padding(4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4)
        TabPage1.Size = New Size(1185, 630)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Datos del estudiante"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnSiguienteElectrica
        ' 
        btnSiguienteElectrica.Location = New Point(225, 348)
        btnSiguienteElectrica.Margin = New Padding(4)
        btnSiguienteElectrica.Name = "btnSiguienteElectrica"
        btnSiguienteElectrica.Size = New Size(118, 36)
        btnSiguienteElectrica.TabIndex = 8
        btnSiguienteElectrica.Text = "Siguiente"
        btnSiguienteElectrica.UseVisualStyleBackColor = True
        ' 
        ' txtEdadElectrica
        ' 
        txtEdadElectrica.Location = New Point(176, 229)
        txtEdadElectrica.Margin = New Padding(4)
        txtEdadElectrica.Name = "txtEdadElectrica"
        txtEdadElectrica.Size = New Size(279, 31)
        txtEdadElectrica.TabIndex = 7
        ' 
        ' txtCedulaElectrica
        ' 
        txtCedulaElectrica.Location = New Point(176, 166)
        txtCedulaElectrica.Margin = New Padding(4)
        txtCedulaElectrica.Name = "txtCedulaElectrica"
        txtCedulaElectrica.Size = New Size(279, 31)
        txtCedulaElectrica.TabIndex = 6
        ' 
        ' txtApellidoElectrica
        ' 
        txtApellidoElectrica.Location = New Point(176, 104)
        txtApellidoElectrica.Margin = New Padding(4)
        txtApellidoElectrica.Name = "txtApellidoElectrica"
        txtApellidoElectrica.Size = New Size(279, 31)
        txtApellidoElectrica.TabIndex = 5
        ' 
        ' txtNombreElectrica
        ' 
        txtNombreElectrica.Location = New Point(176, 46)
        txtNombreElectrica.Margin = New Padding(4)
        txtNombreElectrica.Name = "txtNombreElectrica"
        txtNombreElectrica.Size = New Size(279, 31)
        txtNombreElectrica.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(66, 240)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 25)
        Label4.TabIndex = 3
        Label4.Text = "Edad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(66, 178)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 25)
        Label3.TabIndex = 2
        Label3.Text = "Cédula"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 116)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 1
        Label2.Text = "Apellido"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(66, 58)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnRegElectrica)
        TabPage2.Controls.Add(btnRegistrarElectrica)
        TabPage2.Controls.Add(txtHorasElectrica)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(lbHorasElectrica)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(rbLSElectrica5)
        TabPage2.Controls.Add(rbLSElectrica4)
        TabPage2.Controls.Add(rbLSElectrica3)
        TabPage2.Controls.Add(rbLSElectrica2)
        TabPage2.Controls.Add(rbLSElectrica1)
        TabPage2.Controls.Add(Label5)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Margin = New Padding(4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4)
        TabPage2.Size = New Size(1185, 630)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Labor Social"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnRegElectrica
        ' 
        btnRegElectrica.Location = New Point(66, 465)
        btnRegElectrica.Margin = New Padding(4)
        btnRegElectrica.Name = "btnRegElectrica"
        btnRegElectrica.Size = New Size(118, 36)
        btnRegElectrica.TabIndex = 11
        btnRegElectrica.Text = "Regresar"
        btnRegElectrica.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarElectrica
        ' 
        btnRegistrarElectrica.Location = New Point(702, 291)
        btnRegistrarElectrica.Margin = New Padding(4)
        btnRegistrarElectrica.Name = "btnRegistrarElectrica"
        btnRegistrarElectrica.Size = New Size(188, 74)
        btnRegistrarElectrica.TabIndex = 10
        btnRegistrarElectrica.Text = "Registrar"
        btnRegistrarElectrica.UseVisualStyleBackColor = True
        ' 
        ' txtHorasElectrica
        ' 
        txtHorasElectrica.Location = New Point(409, 410)
        txtHorasElectrica.Margin = New Padding(4)
        txtHorasElectrica.Name = "txtHorasElectrica"
        txtHorasElectrica.ReadOnly = True
        txtHorasElectrica.Size = New Size(286, 31)
        txtHorasElectrica.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(192, 422)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(189, 25)
        Label7.TabIndex = 8
        Label7.Text = "Horas de Labor Social:"
        ' 
        ' lbHorasElectrica
        ' 
        lbHorasElectrica.FormattingEnabled = True
        lbHorasElectrica.ItemHeight = 25
        lbHorasElectrica.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        lbHorasElectrica.Location = New Point(725, 118)
        lbHorasElectrica.Margin = New Padding(4)
        lbHorasElectrica.Name = "lbHorasElectrica"
        lbHorasElectrica.Size = New Size(166, 104)
        lbHorasElectrica.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(578, 66)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(419, 25)
        Label6.TabIndex = 6
        Label6.Text = "Seleccione la cantidad de horas que desea registrar:"
        ' 
        ' rbLSElectrica5
        ' 
        rbLSElectrica5.AutoSize = True
        rbLSElectrica5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSElectrica5.Location = New Point(106, 296)
        rbLSElectrica5.Margin = New Padding(4)
        rbLSElectrica5.Name = "rbLSElectrica5"
        rbLSElectrica5.Size = New Size(273, 36)
        rbLSElectrica5.TabIndex = 5
        rbLSElectrica5.Text = "Plantación de arboles"
        rbLSElectrica5.UseVisualStyleBackColor = True
        ' 
        ' rbLSElectrica4
        ' 
        rbLSElectrica4.AutoSize = True
        rbLSElectrica4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSElectrica4.Location = New Point(106, 258)
        rbLSElectrica4.Margin = New Padding(4)
        rbLSElectrica4.Name = "rbLSElectrica4"
        rbLSElectrica4.Size = New Size(354, 36)
        rbLSElectrica4.TabIndex = 4
        rbLSElectrica4.Text = "Donacion de alimentos secos"
        rbLSElectrica4.UseVisualStyleBackColor = True
        ' 
        ' rbLSElectrica3
        ' 
        rbLSElectrica3.AutoSize = True
        rbLSElectrica3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSElectrica3.Location = New Point(106, 220)
        rbLSElectrica3.Margin = New Padding(4)
        rbLSElectrica3.Name = "rbLSElectrica3"
        rbLSElectrica3.Size = New Size(257, 36)
        rbLSElectrica3.TabIndex = 3
        rbLSElectrica3.Text = "Jornada de limpieza"
        rbLSElectrica3.UseVisualStyleBackColor = True
        ' 
        ' rbLSElectrica2
        ' 
        rbLSElectrica2.AutoSize = True
        rbLSElectrica2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSElectrica2.Location = New Point(106, 183)
        rbLSElectrica2.Margin = New Padding(4)
        rbLSElectrica2.Name = "rbLSElectrica2"
        rbLSElectrica2.Size = New Size(255, 36)
        rbLSElectrica2.TabIndex = 2
        rbLSElectrica2.Text = "Jornada de reciclaje"
        rbLSElectrica2.UseVisualStyleBackColor = True
        ' 
        ' rbLSElectrica1
        ' 
        rbLSElectrica1.AutoSize = True
        rbLSElectrica1.Checked = True
        rbLSElectrica1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSElectrica1.Location = New Point(106, 146)
        rbLSElectrica1.Margin = New Padding(4)
        rbLSElectrica1.Name = "rbLSElectrica1"
        rbLSElectrica1.Size = New Size(201, 36)
        rbLSElectrica1.TabIndex = 1
        rbLSElectrica1.TabStop = True
        rbLSElectrica1.Text = "Pintar escuelas"
        rbLSElectrica1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(76, 66)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(423, 32)
        Label5.TabIndex = 0
        Label5.Text = "Seleccione qué labor desea realizar:"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(dgvRegistroElectrica)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Margin = New Padding(4)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1185, 630)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Registro"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgvRegistroElectrica
        ' 
        dgvRegistroElectrica.AllowUserToAddRows = False
        dgvRegistroElectrica.AllowUserToDeleteRows = False
        dgvRegistroElectrica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRegistroElectrica.BackgroundColor = SystemColors.ControlLightLight
        dgvRegistroElectrica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRegistroElectrica.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dgvRegistroElectrica.Location = New Point(41, 79)
        dgvRegistroElectrica.Margin = New Padding(4)
        dgvRegistroElectrica.Name = "dgvRegistroElectrica"
        dgvRegistroElectrica.ReadOnly = True
        dgvRegistroElectrica.RowHeadersWidth = 51
        dgvRegistroElectrica.RowTemplate.Height = 29
        dgvRegistroElectrica.Size = New Size(1004, 334)
        dgvRegistroElectrica.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nombre"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Apellido"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Cédula"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Edad"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Labor Social"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Horas"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1054, 75)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 3
        Button1.Text = "Inicio"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(22, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(848, 74)
        Label8.TabIndex = 7
        Label8.Text = "Facultad de Ingeniería Eléctrica"
        ' 
        ' FormElectrica
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(1219, 777)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(TabControl1)
        Name = "FormElectrica"
        Text = "Facultad de Ingeniería Eléctrica"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(dgvRegistroElectrica, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnSiguienteElectrica As Button
    Friend WithEvents txtEdadElectrica As TextBox
    Friend WithEvents txtCedulaElectrica As TextBox
    Friend WithEvents txtApellidoElectrica As TextBox
    Friend WithEvents txtNombreElectrica As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnRegElectrica As Button
    Friend WithEvents btnRegistrarElectrica As Button
    Friend WithEvents txtHorasElectrica As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbHorasElectrica As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbLSElectrica5 As RadioButton
    Friend WithEvents rbLSElectrica4 As RadioButton
    Friend WithEvents rbLSElectrica3 As RadioButton
    Friend WithEvents rbLSElectrica2 As RadioButton
    Friend WithEvents rbLSElectrica1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvRegistroElectrica As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
End Class
