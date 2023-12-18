<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMecanica
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
        btnSiguienteMecanica = New Button()
        txtEdadMecanica = New TextBox()
        txtCedulaMecanica = New TextBox()
        txtApellidoMecanica = New TextBox()
        txtNombreMecanica = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        btnRegMecanica = New Button()
        btnRegistrarMecanica = New Button()
        txtHorasMecanica = New TextBox()
        Label7 = New Label()
        lbHorasMecanica = New ListBox()
        Label6 = New Label()
        rbLSMecanica5 = New RadioButton()
        rbLSMecanica4 = New RadioButton()
        rbLSMecanica3 = New RadioButton()
        rbLSMecanica2 = New RadioButton()
        rbLSMecanica1 = New RadioButton()
        Label5 = New Label()
        TabPage3 = New TabPage()
        dgvRegistroMecanica = New DataGridView()
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
        CType(dgvRegistroMecanica, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(13, 89)
        TabControl1.Margin = New Padding(4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1192, 660)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnSiguienteMecanica)
        TabPage1.Controls.Add(txtEdadMecanica)
        TabPage1.Controls.Add(txtCedulaMecanica)
        TabPage1.Controls.Add(txtApellidoMecanica)
        TabPage1.Controls.Add(txtNombreMecanica)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Margin = New Padding(4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4)
        TabPage1.Size = New Size(1184, 622)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Datos del estudiante"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnSiguienteMecanica
        ' 
        btnSiguienteMecanica.Location = New Point(225, 348)
        btnSiguienteMecanica.Margin = New Padding(4)
        btnSiguienteMecanica.Name = "btnSiguienteMecanica"
        btnSiguienteMecanica.Size = New Size(118, 36)
        btnSiguienteMecanica.TabIndex = 8
        btnSiguienteMecanica.Text = "Siguiente"
        btnSiguienteMecanica.UseVisualStyleBackColor = True
        ' 
        ' txtEdadMecanica
        ' 
        txtEdadMecanica.Location = New Point(176, 229)
        txtEdadMecanica.Margin = New Padding(4)
        txtEdadMecanica.Name = "txtEdadMecanica"
        txtEdadMecanica.Size = New Size(279, 31)
        txtEdadMecanica.TabIndex = 7
        ' 
        ' txtCedulaMecanica
        ' 
        txtCedulaMecanica.Location = New Point(176, 166)
        txtCedulaMecanica.Margin = New Padding(4)
        txtCedulaMecanica.Name = "txtCedulaMecanica"
        txtCedulaMecanica.Size = New Size(279, 31)
        txtCedulaMecanica.TabIndex = 6
        ' 
        ' txtApellidoMecanica
        ' 
        txtApellidoMecanica.Location = New Point(176, 104)
        txtApellidoMecanica.Margin = New Padding(4)
        txtApellidoMecanica.Name = "txtApellidoMecanica"
        txtApellidoMecanica.Size = New Size(279, 31)
        txtApellidoMecanica.TabIndex = 5
        ' 
        ' txtNombreMecanica
        ' 
        txtNombreMecanica.Location = New Point(176, 46)
        txtNombreMecanica.Margin = New Padding(4)
        txtNombreMecanica.Name = "txtNombreMecanica"
        txtNombreMecanica.Size = New Size(279, 31)
        txtNombreMecanica.TabIndex = 4
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
        TabPage2.Controls.Add(btnRegMecanica)
        TabPage2.Controls.Add(btnRegistrarMecanica)
        TabPage2.Controls.Add(txtHorasMecanica)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(lbHorasMecanica)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(rbLSMecanica5)
        TabPage2.Controls.Add(rbLSMecanica4)
        TabPage2.Controls.Add(rbLSMecanica3)
        TabPage2.Controls.Add(rbLSMecanica2)
        TabPage2.Controls.Add(rbLSMecanica1)
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
        ' btnRegMecanica
        ' 
        btnRegMecanica.Location = New Point(66, 465)
        btnRegMecanica.Margin = New Padding(4)
        btnRegMecanica.Name = "btnRegMecanica"
        btnRegMecanica.Size = New Size(118, 36)
        btnRegMecanica.TabIndex = 11
        btnRegMecanica.Text = "Regresar"
        btnRegMecanica.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarMecanica
        ' 
        btnRegistrarMecanica.Location = New Point(702, 291)
        btnRegistrarMecanica.Margin = New Padding(4)
        btnRegistrarMecanica.Name = "btnRegistrarMecanica"
        btnRegistrarMecanica.Size = New Size(188, 74)
        btnRegistrarMecanica.TabIndex = 10
        btnRegistrarMecanica.Text = "Registrar"
        btnRegistrarMecanica.UseVisualStyleBackColor = True
        ' 
        ' txtHorasMecanica
        ' 
        txtHorasMecanica.Location = New Point(409, 410)
        txtHorasMecanica.Margin = New Padding(4)
        txtHorasMecanica.Name = "txtHorasMecanica"
        txtHorasMecanica.ReadOnly = True
        txtHorasMecanica.Size = New Size(286, 31)
        txtHorasMecanica.TabIndex = 9
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
        ' lbHorasMecanica
        ' 
        lbHorasMecanica.FormattingEnabled = True
        lbHorasMecanica.ItemHeight = 25
        lbHorasMecanica.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        lbHorasMecanica.Location = New Point(725, 118)
        lbHorasMecanica.Margin = New Padding(4)
        lbHorasMecanica.Name = "lbHorasMecanica"
        lbHorasMecanica.Size = New Size(166, 104)
        lbHorasMecanica.TabIndex = 7
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
        ' rbLSMecanica5
        ' 
        rbLSMecanica5.AutoSize = True
        rbLSMecanica5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSMecanica5.Location = New Point(102, 292)
        rbLSMecanica5.Margin = New Padding(4)
        rbLSMecanica5.Name = "rbLSMecanica5"
        rbLSMecanica5.Size = New Size(273, 36)
        rbLSMecanica5.TabIndex = 5
        rbLSMecanica5.Text = "Plantación de arboles"
        rbLSMecanica5.UseVisualStyleBackColor = True
        ' 
        ' rbLSMecanica4
        ' 
        rbLSMecanica4.AutoSize = True
        rbLSMecanica4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSMecanica4.Location = New Point(102, 254)
        rbLSMecanica4.Margin = New Padding(4)
        rbLSMecanica4.Name = "rbLSMecanica4"
        rbLSMecanica4.Size = New Size(354, 36)
        rbLSMecanica4.TabIndex = 4
        rbLSMecanica4.Text = "Donacion de alimentos secos"
        rbLSMecanica4.UseVisualStyleBackColor = True
        ' 
        ' rbLSMecanica3
        ' 
        rbLSMecanica3.AutoSize = True
        rbLSMecanica3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSMecanica3.Location = New Point(102, 216)
        rbLSMecanica3.Margin = New Padding(4)
        rbLSMecanica3.Name = "rbLSMecanica3"
        rbLSMecanica3.Size = New Size(257, 36)
        rbLSMecanica3.TabIndex = 3
        rbLSMecanica3.Text = "Jornada de limpieza"
        rbLSMecanica3.UseVisualStyleBackColor = True
        ' 
        ' rbLSMecanica2
        ' 
        rbLSMecanica2.AutoSize = True
        rbLSMecanica2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSMecanica2.Location = New Point(102, 179)
        rbLSMecanica2.Margin = New Padding(4)
        rbLSMecanica2.Name = "rbLSMecanica2"
        rbLSMecanica2.Size = New Size(255, 36)
        rbLSMecanica2.TabIndex = 2
        rbLSMecanica2.Text = "Jornada de reciclaje"
        rbLSMecanica2.UseVisualStyleBackColor = True
        ' 
        ' rbLSMecanica1
        ' 
        rbLSMecanica1.AutoSize = True
        rbLSMecanica1.Checked = True
        rbLSMecanica1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSMecanica1.Location = New Point(102, 142)
        rbLSMecanica1.Margin = New Padding(4)
        rbLSMecanica1.Name = "rbLSMecanica1"
        rbLSMecanica1.Size = New Size(201, 36)
        rbLSMecanica1.TabIndex = 1
        rbLSMecanica1.TabStop = True
        rbLSMecanica1.Text = "Pintar escuelas"
        rbLSMecanica1.UseVisualStyleBackColor = True
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
        TabPage3.Controls.Add(dgvRegistroMecanica)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Margin = New Padding(4)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1114, 546)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Registro"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgvRegistroMecanica
        ' 
        dgvRegistroMecanica.AllowUserToAddRows = False
        dgvRegistroMecanica.AllowUserToDeleteRows = False
        dgvRegistroMecanica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRegistroMecanica.BackgroundColor = SystemColors.ControlLightLight
        dgvRegistroMecanica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRegistroMecanica.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dgvRegistroMecanica.Location = New Point(41, 79)
        dgvRegistroMecanica.Margin = New Padding(4)
        dgvRegistroMecanica.Name = "dgvRegistroMecanica"
        dgvRegistroMecanica.ReadOnly = True
        dgvRegistroMecanica.RowHeadersWidth = 51
        dgvRegistroMecanica.RowTemplate.Height = 29
        dgvRegistroMecanica.Size = New Size(1004, 334)
        dgvRegistroMecanica.TabIndex = 0
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
        Button1.Location = New Point(1053, 72)
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
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(17, 11)
        Label8.Name = "Label8"
        Label8.Size = New Size(876, 74)
        Label8.TabIndex = 9
        Label8.Text = "Facultad de Ingeniería Mecánica" & vbCrLf
        ' 
        ' FormMecanica
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Brown
        ClientSize = New Size(1218, 762)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(TabControl1)
        Name = "FormMecanica"
        Text = "Facultad de Ingeniería Mecánica"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(dgvRegistroMecanica, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnSiguienteMecanica As Button
    Friend WithEvents txtEdadMecanica As TextBox
    Friend WithEvents txtCedulaMecanica As TextBox
    Friend WithEvents txtApellidoMecanica As TextBox
    Friend WithEvents txtNombreMecanica As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnRegMecanica As Button
    Friend WithEvents btnRegistrarMecanica As Button
    Friend WithEvents txtHorasMecanica As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbHorasMecanica As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbLSMecanica5 As RadioButton
    Friend WithEvents rbLSMecanica4 As RadioButton
    Friend WithEvents rbLSMecanica3 As RadioButton
    Friend WithEvents rbLSMecanica2 As RadioButton
    Friend WithEvents rbLSMecanica1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvRegistroMecanica As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
End Class
