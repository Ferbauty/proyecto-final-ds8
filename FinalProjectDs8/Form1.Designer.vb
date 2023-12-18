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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        rbCiencias = New RadioButton()
        rbIndustrial = New RadioButton()
        rbMecanica = New RadioButton()
        rbElectrica = New RadioButton()
        rbSistemas = New RadioButton()
        rbCivil = New RadioButton()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        dgvReporte = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgvReporte, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(-2, 1)
        TabControl1.Margin = New Padding(4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1336, 798)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(PictureBox1)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(PictureBox2)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(rbCiencias)
        TabPage1.Controls.Add(rbIndustrial)
        TabPage1.Controls.Add(rbMecanica)
        TabPage1.Controls.Add(rbElectrica)
        TabPage1.Controls.Add(rbSistemas)
        TabPage1.Controls.Add(rbCivil)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Margin = New Padding(4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4)
        TabPage1.Size = New Size(1328, 760)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Inicio"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.ImageLocation = ""
        PictureBox1.Location = New Point(836, 206)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(315, 276)
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Purple
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(1092, 537)
        Label7.Name = "Label7"
        Label7.Size = New Size(18, 225)
        Label7.TabIndex = 23
        Label7.Text = "I" & vbCrLf & "I" & vbCrLf & "I" & vbCrLf & "I" & vbCrLf & "I" & vbCrLf & "I" & vbCrLf & "I" & vbCrLf & "I" & vbCrLf & "I"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Purple
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(1132, 552)
        Label6.Name = "Label6"
        Label6.Size = New Size(150, 175)
        Label6.TabIndex = 22
        Label6.Text = "Mapa de" & vbCrLf & "Ubicación" & vbCrLf & "Mapa del Sitio" & vbCrLf & "Directorio" & vbCrLf & "Telefónico" & vbCrLf & "Contáctenos" & vbCrLf & "Identidad Visual"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Purple
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(916, 552)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 200)
        Label5.TabIndex = 21
        Label5.Text = "Matricula UTP" & vbCrLf & "Correo UTP" & vbCrLf & "Biblioteca UTP" & vbCrLf & "Publicaciones" & vbCrLf & "Sala de Prensa" & vbCrLf & "Bolsa de Trabajo" & vbCrLf & "Acreditación" & vbCrLf & "Centro de Lenguas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Purple
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(28, 569)
        Label4.Name = "Label4"
        Label4.Size = New Size(688, 175)
        Label4.TabIndex = 20
        Label4.Text = resources.GetString("Label4.Text")
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Purple
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(0, 537)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1328, 223)
        PictureBox2.TabIndex = 19
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(175, 19)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(956, 68)
        Label3.TabIndex = 18
        Label3.Text = "Camino a la excelencia a través del mejoramiento continuo" & vbCrLf & "Universidad Tecnológica de Panamá"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' rbCiencias
        ' 
        rbCiencias.AutoSize = True
        rbCiencias.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbCiencias.Location = New Point(76, 479)
        rbCiencias.Margin = New Padding(4)
        rbCiencias.Name = "rbCiencias"
        rbCiencias.Size = New Size(420, 36)
        rbCiencias.TabIndex = 16
        rbCiencias.TabStop = True
        rbCiencias.Text = "Facultad de Ciencias y Tecnología"
        rbCiencias.UseVisualStyleBackColor = True
        ' 
        ' rbIndustrial
        ' 
        rbIndustrial.AutoSize = True
        rbIndustrial.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbIndustrial.Location = New Point(76, 424)
        rbIndustrial.Margin = New Padding(4)
        rbIndustrial.Name = "rbIndustrial"
        rbIndustrial.Size = New Size(409, 36)
        rbIndustrial.TabIndex = 15
        rbIndustrial.TabStop = True
        rbIndustrial.Text = "Facultad de Ingeniería Industrial"
        rbIndustrial.UseVisualStyleBackColor = True
        ' 
        ' rbMecanica
        ' 
        rbMecanica.AutoSize = True
        rbMecanica.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbMecanica.Location = New Point(76, 370)
        rbMecanica.Margin = New Padding(4)
        rbMecanica.Name = "rbMecanica"
        rbMecanica.Size = New Size(407, 36)
        rbMecanica.TabIndex = 14
        rbMecanica.TabStop = True
        rbMecanica.Text = "Facultad de Ingeniería Mecánica"
        rbMecanica.UseVisualStyleBackColor = True
        ' 
        ' rbElectrica
        ' 
        rbElectrica.AutoSize = True
        rbElectrica.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbElectrica.Location = New Point(76, 316)
        rbElectrica.Margin = New Padding(4)
        rbElectrica.Name = "rbElectrica"
        rbElectrica.Size = New Size(395, 36)
        rbElectrica.TabIndex = 13
        rbElectrica.TabStop = True
        rbElectrica.Text = "Facultad de Ingeniería Eléctrica"
        rbElectrica.UseVisualStyleBackColor = True
        ' 
        ' rbSistemas
        ' 
        rbSistemas.AutoSize = True
        rbSistemas.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbSistemas.Location = New Point(76, 260)
        rbSistemas.Margin = New Padding(4)
        rbSistemas.Name = "rbSistemas"
        rbSistemas.Size = New Size(637, 36)
        rbSistemas.TabIndex = 12
        rbSistemas.TabStop = True
        rbSistemas.Text = "Facultad de Ingenieria en Sistemas Computacionales"
        rbSistemas.UseVisualStyleBackColor = True
        ' 
        ' rbCivil
        ' 
        rbCivil.AutoSize = True
        rbCivil.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbCivil.Location = New Point(76, 208)
        rbCivil.Margin = New Padding(4)
        rbCivil.Name = "rbCivil"
        rbCivil.Size = New Size(348, 36)
        rbCivil.TabIndex = 11
        rbCivil.TabStop = True
        rbCivil.Text = "Facultad de Ingeniería Civil"
        rbCivil.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(25, 155)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(226, 30)
        Label2.TabIndex = 10
        Label2.Text = "Seleccione su facultad:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(25, 106)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(939, 38)
        Label1.TabIndex = 9
        Label1.Text = "Bienvenido al Registro Estudiantil para realización de Labor Social"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgvReporte)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Margin = New Padding(4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4)
        TabPage2.Size = New Size(1328, 760)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Reporte"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgvReporte
        ' 
        dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReporte.BackgroundColor = SystemColors.ControlLightLight
        dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReporte.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgvReporte.Location = New Point(68, 92)
        dgvReporte.Margin = New Padding(4)
        dgvReporte.Name = "dgvReporte"
        dgvReporte.RowHeadersWidth = 51
        dgvReporte.RowTemplate.Height = 29
        dgvReporte.Size = New Size(1110, 491)
        dgvReporte.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nombre"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Apellido"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Cédula"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Facultad"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Labor Social"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Purple
        ClientSize = New Size(1332, 796)
        Controls.Add(TabControl1)
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Universidad Tecnológica de Panamá"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(dgvReporte, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvReporte As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
