<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCivil
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
        txtEdadCivil = New TextBox()
        txtCedulaCivil = New TextBox()
        txtApellidoCivil = New TextBox()
        txtNombreCivil = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        btnRegistrarCivil = New Button()
        TextBox5 = New TextBox()
        Label7 = New Label()
        lbHorasCivil = New ListBox()
        Label6 = New Label()
        rbLSCivil5 = New RadioButton()
        rbLSCivil4 = New RadioButton()
        rbLSCivil3 = New RadioButton()
        rbLSCivil2 = New RadioButton()
        rbLSCivil1 = New RadioButton()
        Label5 = New Label()
        TabPage3 = New TabPage()
        dgvRegistroCivil = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(dgvRegistroCivil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(31, 78)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(898, 467)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(txtEdadCivil)
        TabPage1.Controls.Add(txtCedulaCivil)
        TabPage1.Controls.Add(txtApellidoCivil)
        TabPage1.Controls.Add(txtNombreCivil)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(890, 434)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Datos del estudiante"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' txtEdadCivil
        ' 
        txtEdadCivil.Location = New Point(141, 183)
        txtEdadCivil.Name = "txtEdadCivil"
        txtEdadCivil.Size = New Size(224, 27)
        txtEdadCivil.TabIndex = 7
        ' 
        ' txtCedulaCivil
        ' 
        txtCedulaCivil.Location = New Point(141, 133)
        txtCedulaCivil.Name = "txtCedulaCivil"
        txtCedulaCivil.Size = New Size(224, 27)
        txtCedulaCivil.TabIndex = 6
        ' 
        ' txtApellidoCivil
        ' 
        txtApellidoCivil.Location = New Point(141, 83)
        txtApellidoCivil.Name = "txtApellidoCivil"
        txtApellidoCivil.Size = New Size(224, 27)
        txtApellidoCivil.TabIndex = 5
        ' 
        ' txtNombreCivil
        ' 
        txtNombreCivil.Location = New Point(141, 37)
        txtNombreCivil.Name = "txtNombreCivil"
        txtNombreCivil.Size = New Size(224, 27)
        txtNombreCivil.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(46, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 3
        Label4.Text = "Edad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 2
        Label3.Text = "Cédula"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 1
        Label2.Text = "Apellido"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnRegistrarCivil)
        TabPage2.Controls.Add(TextBox5)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(lbHorasCivil)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(rbLSCivil5)
        TabPage2.Controls.Add(rbLSCivil4)
        TabPage2.Controls.Add(rbLSCivil3)
        TabPage2.Controls.Add(rbLSCivil2)
        TabPage2.Controls.Add(rbLSCivil1)
        TabPage2.Controls.Add(Label5)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(890, 434)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Labor Social"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarCivil
        ' 
        btnRegistrarCivil.Location = New Point(562, 233)
        btnRegistrarCivil.Name = "btnRegistrarCivil"
        btnRegistrarCivil.Size = New Size(150, 59)
        btnRegistrarCivil.TabIndex = 10
        btnRegistrarCivil.Text = "Registrar"
        btnRegistrarCivil.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(327, 328)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(230, 27)
        TextBox5.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(147, 331)
        Label7.Name = "Label7"
        Label7.Size = New Size(158, 20)
        Label7.TabIndex = 8
        Label7.Text = "Horas de Labor Social:"
        ' 
        ' lbHorasCivil
        ' 
        lbHorasCivil.FormattingEnabled = True
        lbHorasCivil.ItemHeight = 20
        lbHorasCivil.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        lbHorasCivil.Location = New Point(580, 94)
        lbHorasCivil.Name = "lbHorasCivil"
        lbHorasCivil.Size = New Size(134, 84)
        lbHorasCivil.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(456, 46)
        Label6.Name = "Label6"
        Label6.Size = New Size(353, 20)
        Label6.TabIndex = 6
        Label6.Text = "Seleccione la cantidad de horas que desea registrar:"
        ' 
        ' rbLSCivil5
        ' 
        rbLSCivil5.AutoSize = True
        rbLSCivil5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSCivil5.Location = New Point(78, 230)
        rbLSCivil5.Name = "rbLSCivil5"
        rbLSCivil5.Size = New Size(228, 32)
        rbLSCivil5.TabIndex = 5
        rbLSCivil5.Text = "Plantación de arboles"
        rbLSCivil5.UseVisualStyleBackColor = True
        ' 
        ' rbLSCivil4
        ' 
        rbLSCivil4.AutoSize = True
        rbLSCivil4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSCivil4.Location = New Point(78, 200)
        rbLSCivil4.Name = "rbLSCivil4"
        rbLSCivil4.Size = New Size(299, 32)
        rbLSCivil4.TabIndex = 4
        rbLSCivil4.Text = "Donacion de alimentos secos"
        rbLSCivil4.UseVisualStyleBackColor = True
        ' 
        ' rbLSCivil3
        ' 
        rbLSCivil3.AutoSize = True
        rbLSCivil3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSCivil3.Location = New Point(78, 170)
        rbLSCivil3.Name = "rbLSCivil3"
        rbLSCivil3.Size = New Size(214, 32)
        rbLSCivil3.TabIndex = 3
        rbLSCivil3.Text = "Jornada de limpieza"
        rbLSCivil3.UseVisualStyleBackColor = True
        ' 
        ' rbLSCivil2
        ' 
        rbLSCivil2.AutoSize = True
        rbLSCivil2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSCivil2.Location = New Point(78, 140)
        rbLSCivil2.Name = "rbLSCivil2"
        rbLSCivil2.Size = New Size(211, 32)
        rbLSCivil2.TabIndex = 2
        rbLSCivil2.Text = "Jornada de reciclaje"
        rbLSCivil2.UseVisualStyleBackColor = True
        ' 
        ' rbLSCivil1
        ' 
        rbLSCivil1.AutoSize = True
        rbLSCivil1.Checked = True
        rbLSCivil1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbLSCivil1.Location = New Point(78, 110)
        rbLSCivil1.Name = "rbLSCivil1"
        rbLSCivil1.Size = New Size(168, 32)
        rbLSCivil1.TabIndex = 1
        rbLSCivil1.TabStop = True
        rbLSCivil1.Text = "Pintar escuelas"
        rbLSCivil1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(54, 46)
        Label5.Name = "Label5"
        Label5.Size = New Size(351, 28)
        Label5.TabIndex = 0
        Label5.Text = "Seleccione qué labor desea realizar:"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(dgvRegistroCivil)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(890, 434)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Registro"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgvRegistroCivil
        ' 
        dgvRegistroCivil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRegistroCivil.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dgvRegistroCivil.Location = New Point(33, 63)
        dgvRegistroCivil.Name = "dgvRegistroCivil"
        dgvRegistroCivil.RowHeadersWidth = 51
        dgvRegistroCivil.RowTemplate.Height = 29
        dgvRegistroCivil.Size = New Size(803, 267)
        dgvRegistroCivil.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nombre"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Apellido"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Cédula"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Edad"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Labor Social"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Horas"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' FormCivil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(966, 557)
        Controls.Add(TabControl1)
        Name = "FormCivil"
        Text = "Facultad de Ing. Civil"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(dgvRegistroCivil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtEdadCivil As TextBox
    Friend WithEvents txtCedulaCivil As TextBox
    Friend WithEvents txtApellidoCivil As TextBox
    Friend WithEvents txtNombreCivil As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbLSCivil5 As RadioButton
    Friend WithEvents rbLSCivil4 As RadioButton
    Friend WithEvents rbLSCivil3 As RadioButton
    Friend WithEvents rbLSCivil2 As RadioButton
    Friend WithEvents rbLSCivil1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbHorasCivil As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRegistrarCivil As Button
    Friend WithEvents dgvRegistroCivil As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
