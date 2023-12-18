<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSistemasComputacionales
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
        btnSiguienteSistemas = New Button()
        txtEdadSistemas = New TextBox()
        txtCedulaSistemas = New TextBox()
        txtApellidoSistemas = New TextBox()
        txtNombreSistemas = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        btnRegSistemas = New Button()
        btnRegistrarSistemas = New Button()
        txtHorasSistemas = New TextBox()
        Label7 = New Label()
        lbHorasSistemas = New ListBox()
        Label6 = New Label()
        rbLSSistemas5 = New RadioButton()
        rbLSSistemas4 = New RadioButton()
        rbLSSistemas3 = New RadioButton()
        rbLSSistemas2 = New RadioButton()
        rbLSSistemas1 = New RadioButton()
        Label5 = New Label()
        TabPage3 = New TabPage()
        dgvRegistroSistemas = New DataGridView()
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
        CType(dgvRegistroSistemas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(13, 98)
        TabControl1.Margin = New Padding(4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1189, 669)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnSiguienteSistemas)
        TabPage1.Controls.Add(txtEdadSistemas)
        TabPage1.Controls.Add(txtCedulaSistemas)
        TabPage1.Controls.Add(txtApellidoSistemas)
        TabPage1.Controls.Add(txtNombreSistemas)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Margin = New Padding(4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4)
        TabPage1.Size = New Size(1181, 631)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Datos del estudiante"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnSiguienteSistemas
        ' 
        btnSiguienteSistemas.Location = New Point(225, 348)
        btnSiguienteSistemas.Margin = New Padding(4)
        btnSiguienteSistemas.Name = "btnSiguienteSistemas"
        btnSiguienteSistemas.Size = New Size(118, 36)
        btnSiguienteSistemas.TabIndex = 8
        btnSiguienteSistemas.Text = "Siguiente"
        btnSiguienteSistemas.UseVisualStyleBackColor = True
        ' 
        ' txtEdadSistemas
        ' 
        txtEdadSistemas.Location = New Point(176, 229)
        txtEdadSistemas.Margin = New Padding(4)
        txtEdadSistemas.Name = "txtEdadSistemas"
        txtEdadSistemas.Size = New Size(279, 31)
        txtEdadSistemas.TabIndex = 7
        ' 
        ' txtCedulaSistemas
        ' 
        txtCedulaSistemas.Location = New Point(176, 166)
        txtCedulaSistemas.Margin = New Padding(4)
        txtCedulaSistemas.Name = "txtCedulaSistemas"
        txtCedulaSistemas.Size = New Size(279, 31)
        txtCedulaSistemas.TabIndex = 6
        ' 
        ' txtApellidoSistemas
        ' 
        txtApellidoSistemas.Location = New Point(176, 104)
        txtApellidoSistemas.Margin = New Padding(4)
        txtApellidoSistemas.Name = "txtApellidoSistemas"
        txtApellidoSistemas.Size = New Size(279, 31)
        txtApellidoSistemas.TabIndex = 5
        ' 
        ' txtNombreSistemas
        ' 
        txtNombreSistemas.Location = New Point(176, 46)
        txtNombreSistemas.Margin = New Padding(4)
        txtNombreSistemas.Name = "txtNombreSistemas"
        txtNombreSistemas.Size = New Size(279, 31)
        txtNombreSistemas.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(62, 236)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 25)
        Label4.TabIndex = 3
        Label4.Text = "Edad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 174)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 25)
        Label3.TabIndex = 2
        Label3.Text = "Cédula"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 112)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 1
        Label2.Text = "Apellido"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 54)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnRegSistemas)
        TabPage2.Controls.Add(btnRegistrarSistemas)
        TabPage2.Controls.Add(txtHorasSistemas)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(lbHorasSistemas)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(rbLSSistemas5)
        TabPage2.Controls.Add(rbLSSistemas4)
        TabPage2.Controls.Add(rbLSSistemas3)
        TabPage2.Controls.Add(rbLSSistemas2)
        TabPage2.Controls.Add(rbLSSistemas1)
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
        ' btnRegSistemas
        ' 
        btnRegSistemas.Location = New Point(66, 465)
        btnRegSistemas.Margin = New Padding(4)
        btnRegSistemas.Name = "btnRegSistemas"
        btnRegSistemas.Size = New Size(118, 36)
        btnRegSistemas.TabIndex = 11
        btnRegSistemas.Text = "Regresar"
        btnRegSistemas.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarSistemas
        ' 
        btnRegistrarSistemas.Location = New Point(702, 291)
        btnRegistrarSistemas.Margin = New Padding(4)
        btnRegistrarSistemas.Name = "btnRegistrarSistemas"
        btnRegistrarSistemas.Size = New Size(188, 74)
        btnRegistrarSistemas.TabIndex = 10
        btnRegistrarSistemas.Text = "Registrar"
        btnRegistrarSistemas.UseVisualStyleBackColor = True
        ' 
        ' txtHorasSistemas
        ' 
        txtHorasSistemas.Location = New Point(409, 410)
        txtHorasSistemas.Margin = New Padding(4)
        txtHorasSistemas.Name = "txtHorasSistemas"
        txtHorasSistemas.ReadOnly = True
        txtHorasSistemas.Size = New Size(286, 31)
        txtHorasSistemas.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(188, 418)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(189, 25)
        Label7.TabIndex = 8
        Label7.Text = "Horas de Labor Social:"
        ' 
        ' lbHorasSistemas
        ' 
        lbHorasSistemas.FormattingEnabled = True
        lbHorasSistemas.ItemHeight = 25
        lbHorasSistemas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        lbHorasSistemas.Location = New Point(725, 118)
        lbHorasSistemas.Margin = New Padding(4)
        lbHorasSistemas.Name = "lbHorasSistemas"
        lbHorasSistemas.Size = New Size(166, 104)
        lbHorasSistemas.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(574, 62)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(419, 25)
        Label6.TabIndex = 6
        Label6.Text = "Seleccione la cantidad de horas que desea registrar:"
        ' 
        ' rbLSSistemas5
        ' 
        rbLSSistemas5.AutoSize = True
        rbLSSistemas5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSSistemas5.Location = New Point(102, 292)
        rbLSSistemas5.Margin = New Padding(4)
        rbLSSistemas5.Name = "rbLSSistemas5"
        rbLSSistemas5.Size = New Size(273, 36)
        rbLSSistemas5.TabIndex = 5
        rbLSSistemas5.Text = "Plantación de arboles"
        rbLSSistemas5.UseVisualStyleBackColor = True
        ' 
        ' rbLSSistemas4
        ' 
        rbLSSistemas4.AutoSize = True
        rbLSSistemas4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSSistemas4.Location = New Point(102, 254)
        rbLSSistemas4.Margin = New Padding(4)
        rbLSSistemas4.Name = "rbLSSistemas4"
        rbLSSistemas4.Size = New Size(354, 36)
        rbLSSistemas4.TabIndex = 4
        rbLSSistemas4.Text = "Donacion de alimentos secos"
        rbLSSistemas4.UseVisualStyleBackColor = True
        ' 
        ' rbLSSistemas3
        ' 
        rbLSSistemas3.AutoSize = True
        rbLSSistemas3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSSistemas3.Location = New Point(102, 216)
        rbLSSistemas3.Margin = New Padding(4)
        rbLSSistemas3.Name = "rbLSSistemas3"
        rbLSSistemas3.Size = New Size(257, 36)
        rbLSSistemas3.TabIndex = 3
        rbLSSistemas3.Text = "Jornada de limpieza"
        rbLSSistemas3.UseVisualStyleBackColor = True
        ' 
        ' rbLSSistemas2
        ' 
        rbLSSistemas2.AutoSize = True
        rbLSSistemas2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSSistemas2.Location = New Point(102, 179)
        rbLSSistemas2.Margin = New Padding(4)
        rbLSSistemas2.Name = "rbLSSistemas2"
        rbLSSistemas2.Size = New Size(255, 36)
        rbLSSistemas2.TabIndex = 2
        rbLSSistemas2.Text = "Jornada de reciclaje"
        rbLSSistemas2.UseVisualStyleBackColor = True
        ' 
        ' rbLSSistemas1
        ' 
        rbLSSistemas1.AutoSize = True
        rbLSSistemas1.Checked = True
        rbLSSistemas1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSSistemas1.Location = New Point(102, 142)
        rbLSSistemas1.Margin = New Padding(4)
        rbLSSistemas1.Name = "rbLSSistemas1"
        rbLSSistemas1.Size = New Size(201, 36)
        rbLSSistemas1.TabIndex = 1
        rbLSSistemas1.TabStop = True
        rbLSSistemas1.Text = "Pintar escuelas"
        rbLSSistemas1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(72, 62)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(423, 32)
        Label5.TabIndex = 0
        Label5.Text = "Seleccione qué labor desea realizar:"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(dgvRegistroSistemas)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Margin = New Padding(4)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1114, 546)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Registro"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgvRegistroSistemas
        ' 
        dgvRegistroSistemas.AllowUserToAddRows = False
        dgvRegistroSistemas.AllowUserToDeleteRows = False
        dgvRegistroSistemas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRegistroSistemas.BackgroundColor = SystemColors.ControlLightLight
        dgvRegistroSistemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRegistroSistemas.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dgvRegistroSistemas.Location = New Point(41, 79)
        dgvRegistroSistemas.Margin = New Padding(4)
        dgvRegistroSistemas.Name = "dgvRegistroSistemas"
        dgvRegistroSistemas.ReadOnly = True
        dgvRegistroSistemas.RowHeadersWidth = 51
        dgvRegistroSistemas.RowTemplate.Height = 29
        dgvRegistroSistemas.Size = New Size(1004, 334)
        dgvRegistroSistemas.TabIndex = 0
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
        Button1.Location = New Point(1056, 91)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 6
        Button1.Text = "Inicio"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(12, 14)
        Label8.Name = "Label8"
        Label8.Size = New Size(1111, 60)
        Label8.TabIndex = 9
        Label8.Text = "Facultad de Ingeniería de Sistemas Computacionales" & vbCrLf
        ' 
        ' FormSistemasComputacionales
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(1215, 780)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(TabControl1)
        Name = "FormSistemasComputacionales"
        Text = "Facultad de Ingeniería de Sistemas Computacionales"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(dgvRegistroSistemas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnSiguienteSistemas As Button
    Friend WithEvents txtEdadSistemas As TextBox
    Friend WithEvents txtCedulaSistemas As TextBox
    Friend WithEvents txtApellidoSistemas As TextBox
    Friend WithEvents txtNombreSistemas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnRegSistemas As Button
    Friend WithEvents btnRegistrarSistemas As Button
    Friend WithEvents txtHorasSistemas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbHorasSistemas As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbLSSistemas5 As RadioButton
    Friend WithEvents rbLSSistemas4 As RadioButton
    Friend WithEvents rbLSSistemas3 As RadioButton
    Friend WithEvents rbLSSistemas2 As RadioButton
    Friend WithEvents rbLSSistemas1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvRegistroSistemas As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
End Class
