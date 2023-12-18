<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIndustrial
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
        btnSiguienteIndustrial = New Button()
        txtEdadIndustrial = New TextBox()
        txtCedulaIndustrial = New TextBox()
        txtApellidoIndustrial = New TextBox()
        txtNombreIndustrial = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        btnRegIndustrial = New Button()
        btnRegistrarIndustrial = New Button()
        txtHorasIndustrial = New TextBox()
        Label7 = New Label()
        lbHorasIndustrial = New ListBox()
        Label6 = New Label()
        rbLSIndustrial5 = New RadioButton()
        rbLSIndustrial4 = New RadioButton()
        rbLSIndustrial3 = New RadioButton()
        rbLSIndustrial2 = New RadioButton()
        rbLSIndustrial1 = New RadioButton()
        Label5 = New Label()
        TabPage3 = New TabPage()
        dgvRegistroIndustrial = New DataGridView()
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
        CType(dgvRegistroIndustrial, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(13, 93)
        TabControl1.Margin = New Padding(4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1193, 665)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnSiguienteIndustrial)
        TabPage1.Controls.Add(txtEdadIndustrial)
        TabPage1.Controls.Add(txtCedulaIndustrial)
        TabPage1.Controls.Add(txtApellidoIndustrial)
        TabPage1.Controls.Add(txtNombreIndustrial)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Margin = New Padding(4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4)
        TabPage1.Size = New Size(1185, 627)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Datos del estudiante"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnSiguienteIndustrial
        ' 
        btnSiguienteIndustrial.Location = New Point(225, 348)
        btnSiguienteIndustrial.Margin = New Padding(4)
        btnSiguienteIndustrial.Name = "btnSiguienteIndustrial"
        btnSiguienteIndustrial.Size = New Size(118, 36)
        btnSiguienteIndustrial.TabIndex = 8
        btnSiguienteIndustrial.Text = "Siguiente"
        btnSiguienteIndustrial.UseVisualStyleBackColor = True
        ' 
        ' txtEdadIndustrial
        ' 
        txtEdadIndustrial.Location = New Point(176, 229)
        txtEdadIndustrial.Margin = New Padding(4)
        txtEdadIndustrial.Name = "txtEdadIndustrial"
        txtEdadIndustrial.Size = New Size(279, 31)
        txtEdadIndustrial.TabIndex = 7
        ' 
        ' txtCedulaIndustrial
        ' 
        txtCedulaIndustrial.Location = New Point(176, 166)
        txtCedulaIndustrial.Margin = New Padding(4)
        txtCedulaIndustrial.Name = "txtCedulaIndustrial"
        txtCedulaIndustrial.Size = New Size(279, 31)
        txtCedulaIndustrial.TabIndex = 6
        ' 
        ' txtApellidoIndustrial
        ' 
        txtApellidoIndustrial.Location = New Point(176, 104)
        txtApellidoIndustrial.Margin = New Padding(4)
        txtApellidoIndustrial.Name = "txtApellidoIndustrial"
        txtApellidoIndustrial.Size = New Size(279, 31)
        txtApellidoIndustrial.TabIndex = 5
        ' 
        ' txtNombreIndustrial
        ' 
        txtNombreIndustrial.Location = New Point(176, 46)
        txtNombreIndustrial.Margin = New Padding(4)
        txtNombreIndustrial.Name = "txtNombreIndustrial"
        txtNombreIndustrial.Size = New Size(279, 31)
        txtNombreIndustrial.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(70, 244)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 25)
        Label4.TabIndex = 3
        Label4.Text = "Edad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(70, 182)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 25)
        Label3.TabIndex = 2
        Label3.Text = "Cédula"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(70, 120)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 1
        Label2.Text = "Apellido"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(70, 62)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnRegIndustrial)
        TabPage2.Controls.Add(btnRegistrarIndustrial)
        TabPage2.Controls.Add(txtHorasIndustrial)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(lbHorasIndustrial)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(rbLSIndustrial5)
        TabPage2.Controls.Add(rbLSIndustrial4)
        TabPage2.Controls.Add(rbLSIndustrial3)
        TabPage2.Controls.Add(rbLSIndustrial2)
        TabPage2.Controls.Add(rbLSIndustrial1)
        TabPage2.Controls.Add(Label5)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Margin = New Padding(4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4)
        TabPage2.Size = New Size(1185, 627)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Labor Social"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnRegIndustrial
        ' 
        btnRegIndustrial.Location = New Point(66, 465)
        btnRegIndustrial.Margin = New Padding(4)
        btnRegIndustrial.Name = "btnRegIndustrial"
        btnRegIndustrial.Size = New Size(118, 36)
        btnRegIndustrial.TabIndex = 11
        btnRegIndustrial.Text = "Regresar"
        btnRegIndustrial.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarIndustrial
        ' 
        btnRegistrarIndustrial.Location = New Point(702, 291)
        btnRegistrarIndustrial.Margin = New Padding(4)
        btnRegistrarIndustrial.Name = "btnRegistrarIndustrial"
        btnRegistrarIndustrial.Size = New Size(188, 74)
        btnRegistrarIndustrial.TabIndex = 10
        btnRegistrarIndustrial.Text = "Registrar"
        btnRegistrarIndustrial.UseVisualStyleBackColor = True
        ' 
        ' txtHorasIndustrial
        ' 
        txtHorasIndustrial.Location = New Point(409, 410)
        txtHorasIndustrial.Margin = New Padding(4)
        txtHorasIndustrial.Name = "txtHorasIndustrial"
        txtHorasIndustrial.ReadOnly = True
        txtHorasIndustrial.Size = New Size(286, 31)
        txtHorasIndustrial.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(196, 426)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(189, 25)
        Label7.TabIndex = 8
        Label7.Text = "Horas de Labor Social:"
        ' 
        ' lbHorasIndustrial
        ' 
        lbHorasIndustrial.FormattingEnabled = True
        lbHorasIndustrial.ItemHeight = 25
        lbHorasIndustrial.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        lbHorasIndustrial.Location = New Point(725, 118)
        lbHorasIndustrial.Margin = New Padding(4)
        lbHorasIndustrial.Name = "lbHorasIndustrial"
        lbHorasIndustrial.Size = New Size(166, 104)
        lbHorasIndustrial.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(582, 70)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(419, 25)
        Label6.TabIndex = 6
        Label6.Text = "Seleccione la cantidad de horas que desea registrar:"
        ' 
        ' rbLSIndustrial5
        ' 
        rbLSIndustrial5.AutoSize = True
        rbLSIndustrial5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSIndustrial5.Location = New Point(110, 300)
        rbLSIndustrial5.Margin = New Padding(4)
        rbLSIndustrial5.Name = "rbLSIndustrial5"
        rbLSIndustrial5.Size = New Size(273, 36)
        rbLSIndustrial5.TabIndex = 5
        rbLSIndustrial5.Text = "Plantación de arboles"
        rbLSIndustrial5.UseVisualStyleBackColor = True
        ' 
        ' rbLSIndustrial4
        ' 
        rbLSIndustrial4.AutoSize = True
        rbLSIndustrial4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSIndustrial4.Location = New Point(110, 262)
        rbLSIndustrial4.Margin = New Padding(4)
        rbLSIndustrial4.Name = "rbLSIndustrial4"
        rbLSIndustrial4.Size = New Size(354, 36)
        rbLSIndustrial4.TabIndex = 4
        rbLSIndustrial4.Text = "Donacion de alimentos secos"
        rbLSIndustrial4.UseVisualStyleBackColor = True
        ' 
        ' rbLSIndustrial3
        ' 
        rbLSIndustrial3.AutoSize = True
        rbLSIndustrial3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSIndustrial3.Location = New Point(110, 224)
        rbLSIndustrial3.Margin = New Padding(4)
        rbLSIndustrial3.Name = "rbLSIndustrial3"
        rbLSIndustrial3.Size = New Size(257, 36)
        rbLSIndustrial3.TabIndex = 3
        rbLSIndustrial3.Text = "Jornada de limpieza"
        rbLSIndustrial3.UseVisualStyleBackColor = True
        ' 
        ' rbLSIndustrial2
        ' 
        rbLSIndustrial2.AutoSize = True
        rbLSIndustrial2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSIndustrial2.Location = New Point(110, 187)
        rbLSIndustrial2.Margin = New Padding(4)
        rbLSIndustrial2.Name = "rbLSIndustrial2"
        rbLSIndustrial2.Size = New Size(255, 36)
        rbLSIndustrial2.TabIndex = 2
        rbLSIndustrial2.Text = "Jornada de reciclaje"
        rbLSIndustrial2.UseVisualStyleBackColor = True
        ' 
        ' rbLSIndustrial1
        ' 
        rbLSIndustrial1.AutoSize = True
        rbLSIndustrial1.Checked = True
        rbLSIndustrial1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSIndustrial1.Location = New Point(110, 150)
        rbLSIndustrial1.Margin = New Padding(4)
        rbLSIndustrial1.Name = "rbLSIndustrial1"
        rbLSIndustrial1.Size = New Size(201, 36)
        rbLSIndustrial1.TabIndex = 1
        rbLSIndustrial1.TabStop = True
        rbLSIndustrial1.Text = "Pintar escuelas"
        rbLSIndustrial1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(80, 70)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(423, 32)
        Label5.TabIndex = 0
        Label5.Text = "Seleccione qué labor desea realizar:"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(dgvRegistroIndustrial)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Margin = New Padding(4)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1185, 627)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Registro"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgvRegistroIndustrial
        ' 
        dgvRegistroIndustrial.AllowUserToAddRows = False
        dgvRegistroIndustrial.AllowUserToDeleteRows = False
        dgvRegistroIndustrial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRegistroIndustrial.BackgroundColor = SystemColors.ControlLightLight
        dgvRegistroIndustrial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRegistroIndustrial.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dgvRegistroIndustrial.Location = New Point(41, 79)
        dgvRegistroIndustrial.Margin = New Padding(4)
        dgvRegistroIndustrial.Name = "dgvRegistroIndustrial"
        dgvRegistroIndustrial.ReadOnly = True
        dgvRegistroIndustrial.RowHeadersWidth = 51
        dgvRegistroIndustrial.RowTemplate.Height = 29
        dgvRegistroIndustrial.Size = New Size(1004, 334)
        dgvRegistroIndustrial.TabIndex = 0
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
        Button1.Location = New Point(1058, 69)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 4
        Button1.Text = "Inicio"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(12, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(880, 74)
        Label8.TabIndex = 9
        Label8.Text = "Facultad de Ingeniería Industrial"
        ' 
        ' FormIndustrial
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(1219, 771)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(TabControl1)
        Name = "FormIndustrial"
        Text = "Facultad de Ingeniería Industrial"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(dgvRegistroIndustrial, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnSiguienteIndustrial As Button
    Friend WithEvents txtEdadIndustrial As TextBox
    Friend WithEvents txtCedulaIndustrial As TextBox
    Friend WithEvents txtApellidoIndustrial As TextBox
    Friend WithEvents txtNombreIndustrial As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnRegIndustrial As Button
    Friend WithEvents btnRegistrarIndustrial As Button
    Friend WithEvents txtHorasIndustrial As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbHorasIndustrial As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbLSIndustrial5 As RadioButton
    Friend WithEvents rbLSIndustrial4 As RadioButton
    Friend WithEvents rbLSIndustrial3 As RadioButton
    Friend WithEvents rbLSIndustrial2 As RadioButton
    Friend WithEvents rbLSIndustrial1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvRegistroIndustrial As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
End Class
