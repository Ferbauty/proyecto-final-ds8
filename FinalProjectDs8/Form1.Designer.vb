<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        rbCiencias = New RadioButton()
        rbIndustrial = New RadioButton()
        rbMecanica = New RadioButton()
        rbElectrica = New RadioButton()
        rbSistemas = New RadioButton()
        rbCivil = New RadioButton()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        dgv = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(-2, 1)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1069, 638)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(rbCiencias)
        TabPage1.Controls.Add(rbIndustrial)
        TabPage1.Controls.Add(rbMecanica)
        TabPage1.Controls.Add(rbElectrica)
        TabPage1.Controls.Add(rbSistemas)
        TabPage1.Controls.Add(rbCivil)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1061, 605)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Inicio"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' rbCiencias
        ' 
        rbCiencias.AutoSize = True
        rbCiencias.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbCiencias.Location = New Point(61, 383)
        rbCiencias.Name = "rbCiencias"
        rbCiencias.Size = New Size(349, 32)
        rbCiencias.TabIndex = 16
        rbCiencias.TabStop = True
        rbCiencias.Text = "Facultad de Ciencias y Tecnología"
        rbCiencias.UseVisualStyleBackColor = True
        ' 
        ' rbIndustrial
        ' 
        rbIndustrial.AutoSize = True
        rbIndustrial.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbIndustrial.Location = New Point(61, 339)
        rbIndustrial.Name = "rbIndustrial"
        rbIndustrial.Size = New Size(338, 32)
        rbIndustrial.TabIndex = 15
        rbIndustrial.TabStop = True
        rbIndustrial.Text = "Facultad de Ingeniería Industrial"
        rbIndustrial.UseVisualStyleBackColor = True
        ' 
        ' rbMecanica
        ' 
        rbMecanica.AutoSize = True
        rbMecanica.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbMecanica.Location = New Point(61, 296)
        rbMecanica.Name = "rbMecanica"
        rbMecanica.Size = New Size(338, 32)
        rbMecanica.TabIndex = 14
        rbMecanica.TabStop = True
        rbMecanica.Text = "Facultad de Ingeniería Mecánica"
        rbMecanica.UseVisualStyleBackColor = True
        ' 
        ' rbElectrica
        ' 
        rbElectrica.AutoSize = True
        rbElectrica.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbElectrica.Location = New Point(61, 253)
        rbElectrica.Name = "rbElectrica"
        rbElectrica.Size = New Size(329, 32)
        rbElectrica.TabIndex = 13
        rbElectrica.TabStop = True
        rbElectrica.Text = "Facultad de Ingeniería Eléctrica"
        rbElectrica.UseVisualStyleBackColor = True
        ' 
        ' rbSistemas
        ' 
        rbSistemas.AutoSize = True
        rbSistemas.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbSistemas.Location = New Point(61, 208)
        rbSistemas.Name = "rbSistemas"
        rbSistemas.Size = New Size(528, 32)
        rbSistemas.TabIndex = 12
        rbSistemas.TabStop = True
        rbSistemas.Text = "Facultad de Ingenieria en Sistemas Computacionales"
        rbSistemas.UseVisualStyleBackColor = True
        ' 
        ' rbCivil
        ' 
        rbCivil.AutoSize = True
        rbCivil.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbCivil.Location = New Point(61, 166)
        rbCivil.Name = "rbCivil"
        rbCivil.Size = New Size(289, 32)
        rbCivil.TabIndex = 11
        rbCivil.TabStop = True
        rbCivil.Text = "Facultad de Ingeniería Civil"
        rbCivil.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(38, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 23)
        Label2.TabIndex = 10
        Label2.Text = "Saleccione su facultad:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(20, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(760, 31)
        Label1.TabIndex = 9
        Label1.Text = "Bienvenido al Registro Estudiantil para realización de Labor Social"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgv)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1061, 605)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Reporte"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgv.Location = New Point(184, 74)
        dgv.Name = "dgv"
        dgv.RowHeadersWidth = 51
        dgv.RowTemplate.Height = 29
        dgv.Size = New Size(677, 393)
        dgv.TabIndex = 0
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
        Column4.HeaderText = "Facultad"
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1066, 637)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Inicio"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents rbCiencias As RadioButton
    Friend WithEvents rbIndustrial As RadioButton
    Friend WithEvents rbMecanica As RadioButton
    Friend WithEvents rbElectrica As RadioButton
    Friend WithEvents rbSistemas As RadioButton
    Friend WithEvents rbCivil As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
