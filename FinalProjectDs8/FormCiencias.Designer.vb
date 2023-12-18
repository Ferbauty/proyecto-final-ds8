<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCiencias
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
        btnSiguienteCiencias = New Button()
        txtEdadCiencias = New TextBox()
        txtCedulaCiencias = New TextBox()
        txtApellidoCiencias = New TextBox()
        txtNombreCiencias = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        btnRegCiencias = New Button()
        btnRegistrarCiencias = New Button()
        txtHorasCiencias = New TextBox()
        Label7 = New Label()
        lbHorasCiencias = New ListBox()
        Label6 = New Label()
        rbLSCiencias5 = New RadioButton()
        rbLSCiencias4 = New RadioButton()
        rbLSCiencias3 = New RadioButton()
        rbLSCiencias2 = New RadioButton()
        rbLSCiencias1 = New RadioButton()
        Label5 = New Label()
        TabPage3 = New TabPage()
        dgvRegistroCiencias = New DataGridView()
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
        CType(dgvRegistroCiencias, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(13, 97)
        TabControl1.Margin = New Padding(4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1201, 669)
        TabControl1.TabIndex = 4
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnSiguienteCiencias)
        TabPage1.Controls.Add(txtEdadCiencias)
        TabPage1.Controls.Add(txtCedulaCiencias)
        TabPage1.Controls.Add(txtApellidoCiencias)
        TabPage1.Controls.Add(txtNombreCiencias)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Margin = New Padding(4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4)
        TabPage1.Size = New Size(1193, 631)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Datos del estudiante"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnSiguienteCiencias
        ' 
        btnSiguienteCiencias.Location = New Point(225, 348)
        btnSiguienteCiencias.Margin = New Padding(4)
        btnSiguienteCiencias.Name = "btnSiguienteCiencias"
        btnSiguienteCiencias.Size = New Size(118, 36)
        btnSiguienteCiencias.TabIndex = 8
        btnSiguienteCiencias.Text = "Siguiente"
        btnSiguienteCiencias.UseVisualStyleBackColor = True
        ' 
        ' txtEdadCiencias
        ' 
        txtEdadCiencias.Location = New Point(176, 229)
        txtEdadCiencias.Margin = New Padding(4)
        txtEdadCiencias.Name = "txtEdadCiencias"
        txtEdadCiencias.Size = New Size(279, 31)
        txtEdadCiencias.TabIndex = 7
        ' 
        ' txtCedulaCiencias
        ' 
        txtCedulaCiencias.Location = New Point(176, 166)
        txtCedulaCiencias.Margin = New Padding(4)
        txtCedulaCiencias.Name = "txtCedulaCiencias"
        txtCedulaCiencias.Size = New Size(279, 31)
        txtCedulaCiencias.TabIndex = 6
        ' 
        ' txtApellidoCiencias
        ' 
        txtApellidoCiencias.Location = New Point(176, 104)
        txtApellidoCiencias.Margin = New Padding(4)
        txtApellidoCiencias.Name = "txtApellidoCiencias"
        txtApellidoCiencias.Size = New Size(279, 31)
        txtApellidoCiencias.TabIndex = 5
        ' 
        ' txtNombreCiencias
        ' 
        txtNombreCiencias.Location = New Point(176, 46)
        txtNombreCiencias.Margin = New Padding(4)
        txtNombreCiencias.Name = "txtNombreCiencias"
        txtNombreCiencias.Size = New Size(279, 31)
        txtNombreCiencias.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(74, 248)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 25)
        Label4.TabIndex = 3
        Label4.Text = "Edad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 186)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 25)
        Label3.TabIndex = 2
        Label3.Text = "Cédula"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 124)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 1
        Label2.Text = "Apellido"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 66)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnRegCiencias)
        TabPage2.Controls.Add(btnRegistrarCiencias)
        TabPage2.Controls.Add(txtHorasCiencias)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(lbHorasCiencias)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(rbLSCiencias5)
        TabPage2.Controls.Add(rbLSCiencias4)
        TabPage2.Controls.Add(rbLSCiencias3)
        TabPage2.Controls.Add(rbLSCiencias2)
        TabPage2.Controls.Add(rbLSCiencias1)
        TabPage2.Controls.Add(Label5)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Margin = New Padding(4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4)
        TabPage2.Size = New Size(1114, 546)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Labor Social"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnRegCiencias
        ' 
        btnRegCiencias.Location = New Point(66, 465)
        btnRegCiencias.Margin = New Padding(4)
        btnRegCiencias.Name = "btnRegCiencias"
        btnRegCiencias.Size = New Size(118, 36)
        btnRegCiencias.TabIndex = 11
        btnRegCiencias.Text = "Regresar"
        btnRegCiencias.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarCiencias
        ' 
        btnRegistrarCiencias.BackgroundImageLayout = ImageLayout.Center
        btnRegistrarCiencias.Location = New Point(702, 291)
        btnRegistrarCiencias.Margin = New Padding(4)
        btnRegistrarCiencias.Name = "btnRegistrarCiencias"
        btnRegistrarCiencias.Size = New Size(188, 74)
        btnRegistrarCiencias.TabIndex = 10
        btnRegistrarCiencias.Text = "Registrar"
        btnRegistrarCiencias.UseVisualStyleBackColor = True
        ' 
        ' txtHorasCiencias
        ' 
        txtHorasCiencias.Location = New Point(409, 410)
        txtHorasCiencias.Margin = New Padding(4)
        txtHorasCiencias.Name = "txtHorasCiencias"
        txtHorasCiencias.ReadOnly = True
        txtHorasCiencias.Size = New Size(286, 31)
        txtHorasCiencias.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(200, 430)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(189, 25)
        Label7.TabIndex = 8
        Label7.Text = "Horas de Labor Social:"
        ' 
        ' lbHorasCiencias
        ' 
        lbHorasCiencias.FormattingEnabled = True
        lbHorasCiencias.ItemHeight = 25
        lbHorasCiencias.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        lbHorasCiencias.Location = New Point(725, 118)
        lbHorasCiencias.Margin = New Padding(4)
        lbHorasCiencias.Name = "lbHorasCiencias"
        lbHorasCiencias.Size = New Size(166, 104)
        lbHorasCiencias.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(586, 74)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(419, 25)
        Label6.TabIndex = 6
        Label6.Text = "Seleccione la cantidad de horas que desea registrar:"
        ' 
        ' rbLSCiencias5
        ' 
        rbLSCiencias5.AutoSize = True
        rbLSCiencias5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSCiencias5.Location = New Point(114, 304)
        rbLSCiencias5.Margin = New Padding(4)
        rbLSCiencias5.Name = "rbLSCiencias5"
        rbLSCiencias5.Size = New Size(273, 36)
        rbLSCiencias5.TabIndex = 5
        rbLSCiencias5.Text = "Plantación de arboles"
        rbLSCiencias5.UseVisualStyleBackColor = True
        ' 
        ' rbLSCiencias4
        ' 
        rbLSCiencias4.AutoSize = True
        rbLSCiencias4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSCiencias4.Location = New Point(114, 266)
        rbLSCiencias4.Margin = New Padding(4)
        rbLSCiencias4.Name = "rbLSCiencias4"
        rbLSCiencias4.Size = New Size(354, 36)
        rbLSCiencias4.TabIndex = 4
        rbLSCiencias4.Text = "Donacion de alimentos secos"
        rbLSCiencias4.UseVisualStyleBackColor = True
        ' 
        ' rbLSCiencias3
        ' 
        rbLSCiencias3.AutoSize = True
        rbLSCiencias3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSCiencias3.Location = New Point(114, 228)
        rbLSCiencias3.Margin = New Padding(4)
        rbLSCiencias3.Name = "rbLSCiencias3"
        rbLSCiencias3.Size = New Size(257, 36)
        rbLSCiencias3.TabIndex = 3
        rbLSCiencias3.Text = "Jornada de limpieza"
        rbLSCiencias3.UseVisualStyleBackColor = True
        ' 
        ' rbLSCiencias2
        ' 
        rbLSCiencias2.AutoSize = True
        rbLSCiencias2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSCiencias2.Location = New Point(114, 191)
        rbLSCiencias2.Margin = New Padding(4)
        rbLSCiencias2.Name = "rbLSCiencias2"
        rbLSCiencias2.Size = New Size(255, 36)
        rbLSCiencias2.TabIndex = 2
        rbLSCiencias2.Text = "Jornada de reciclaje"
        rbLSCiencias2.UseVisualStyleBackColor = True
        ' 
        ' rbLSCiencias1
        ' 
        rbLSCiencias1.AutoSize = True
        rbLSCiencias1.Checked = True
        rbLSCiencias1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSCiencias1.Location = New Point(114, 154)
        rbLSCiencias1.Margin = New Padding(4)
        rbLSCiencias1.Name = "rbLSCiencias1"
        rbLSCiencias1.Size = New Size(201, 36)
        rbLSCiencias1.TabIndex = 1
        rbLSCiencias1.TabStop = True
        rbLSCiencias1.Text = "Pintar escuelas"
        rbLSCiencias1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(84, 74)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(423, 32)
        Label5.TabIndex = 0
        Label5.Text = "Seleccione qué labor desea realizar:"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(dgvRegistroCiencias)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Margin = New Padding(4)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1114, 546)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Registro"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgvRegistroCiencias
        ' 
        dgvRegistroCiencias.AllowUserToAddRows = False
        dgvRegistroCiencias.AllowUserToDeleteRows = False
        dgvRegistroCiencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRegistroCiencias.BackgroundColor = SystemColors.ControlLightLight
        dgvRegistroCiencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRegistroCiencias.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dgvRegistroCiencias.Location = New Point(41, 79)
        dgvRegistroCiencias.Margin = New Padding(4)
        dgvRegistroCiencias.Name = "dgvRegistroCiencias"
        dgvRegistroCiencias.ReadOnly = True
        dgvRegistroCiencias.RowHeadersWidth = 51
        dgvRegistroCiencias.RowTemplate.Height = 29
        dgvRegistroCiencias.Size = New Size(1004, 334)
        dgvRegistroCiencias.TabIndex = 0
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
        Button1.Location = New Point(1062, 66)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 5
        Button1.Text = "Inicio"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(13, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(905, 74)
        Label8.TabIndex = 6
        Label8.Text = "Facultad de Ciencias y Tecnología"
        ' 
        ' FormCiencias
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGoldenrod
        ClientSize = New Size(1227, 779)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(TabControl1)
        Name = "FormCiencias"
        Text = "Facultad de Ciencias y Tecnología"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(dgvRegistroCiencias, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnSiguienteCiencias As Button
    Friend WithEvents txtEdadCiencias As TextBox
    Friend WithEvents txtCedulaCiencias As TextBox
    Friend WithEvents txtApellidoCiencias As TextBox
    Friend WithEvents txtNombreCiencias As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnRegCiencias As Button
    Friend WithEvents btnRegistrarCiencias As Button
    Friend WithEvents txtHorasCiencias As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbHorasCiencias As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbLSCiencias5 As RadioButton
    Friend WithEvents rbLSCiencias4 As RadioButton
    Friend WithEvents rbLSCiencias3 As RadioButton
    Friend WithEvents rbLSCiencias2 As RadioButton
    Friend WithEvents rbLSCiencias1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvRegistroCiencias As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
End Class
