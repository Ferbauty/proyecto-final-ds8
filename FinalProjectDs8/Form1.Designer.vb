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
        MenuStrip1 = New MenuStrip()
        tsmInicio = New ToolStripMenuItem()
        tsmReporte = New ToolStripMenuItem()
        tsmSalir = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        rbCivil = New RadioButton()
        rbSistemas = New RadioButton()
        rbElectrica = New RadioButton()
        rbMecanica = New RadioButton()
        rbIndustrial = New RadioButton()
        rbCiencias = New RadioButton()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {tsmInicio, tsmReporte, tsmSalir})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(978, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' tsmInicio
        ' 
        tsmInicio.Name = "tsmInicio"
        tsmInicio.Size = New Size(59, 24)
        tsmInicio.Text = "Inicio"
        ' 
        ' tsmReporte
        ' 
        tsmReporte.Name = "tsmReporte"
        tsmReporte.Size = New Size(76, 24)
        tsmReporte.Text = "Reporte"
        ' 
        ' tsmSalir
        ' 
        tsmSalir.Name = "tsmSalir"
        tsmSalir.Size = New Size(52, 24)
        tsmSalir.Text = "Salir"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(50, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(760, 31)
        Label1.TabIndex = 1
        Label1.Text = "Bienvenido al Registro Estudiantil para realización de Labor Social"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(68, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 23)
        Label2.TabIndex = 2
        Label2.Text = "Saleccione su facultad:"
        ' 
        ' rbCivil
        ' 
        rbCivil.AutoSize = True
        rbCivil.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbCivil.Location = New Point(91, 180)
        rbCivil.Name = "rbCivil"
        rbCivil.Size = New Size(289, 32)
        rbCivil.TabIndex = 3
        rbCivil.TabStop = True
        rbCivil.Text = "Facultad de Ingeniería Civil"
        rbCivil.UseVisualStyleBackColor = True
        ' 
        ' rbSistemas
        ' 
        rbSistemas.AutoSize = True
        rbSistemas.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbSistemas.Location = New Point(91, 222)
        rbSistemas.Name = "rbSistemas"
        rbSistemas.Size = New Size(528, 32)
        rbSistemas.TabIndex = 4
        rbSistemas.TabStop = True
        rbSistemas.Text = "Facultad de Ingenieria en Sistemas Computacionales"
        rbSistemas.UseVisualStyleBackColor = True
        ' 
        ' rbElectrica
        ' 
        rbElectrica.AutoSize = True
        rbElectrica.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbElectrica.Location = New Point(91, 267)
        rbElectrica.Name = "rbElectrica"
        rbElectrica.Size = New Size(329, 32)
        rbElectrica.TabIndex = 5
        rbElectrica.TabStop = True
        rbElectrica.Text = "Facultad de Ingeniería Eléctrica"
        rbElectrica.UseVisualStyleBackColor = True
        ' 
        ' rbMecanica
        ' 
        rbMecanica.AutoSize = True
        rbMecanica.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbMecanica.Location = New Point(91, 310)
        rbMecanica.Name = "rbMecanica"
        rbMecanica.Size = New Size(338, 32)
        rbMecanica.TabIndex = 6
        rbMecanica.TabStop = True
        rbMecanica.Text = "Facultad de Ingeniería Mecánica"
        rbMecanica.UseVisualStyleBackColor = True
        ' 
        ' rbIndustrial
        ' 
        rbIndustrial.AutoSize = True
        rbIndustrial.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbIndustrial.Location = New Point(91, 353)
        rbIndustrial.Name = "rbIndustrial"
        rbIndustrial.Size = New Size(338, 32)
        rbIndustrial.TabIndex = 7
        rbIndustrial.TabStop = True
        rbIndustrial.Text = "Facultad de Ingeniería Industrial"
        rbIndustrial.UseVisualStyleBackColor = True
        ' 
        ' rbCiencias
        ' 
        rbCiencias.AutoSize = True
        rbCiencias.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbCiencias.Location = New Point(91, 397)
        rbCiencias.Name = "rbCiencias"
        rbCiencias.Size = New Size(349, 32)
        rbCiencias.TabIndex = 8
        rbCiencias.TabStop = True
        rbCiencias.Text = "Facultad de Ciencias y Tecnología"
        rbCiencias.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(978, 592)
        Controls.Add(rbCiencias)
        Controls.Add(rbIndustrial)
        Controls.Add(rbMecanica)
        Controls.Add(rbElectrica)
        Controls.Add(rbSistemas)
        Controls.Add(rbCivil)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Inicio"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmInicio As ToolStripMenuItem
    Friend WithEvents tsmReporte As ToolStripMenuItem
    Friend WithEvents tsmSalir As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rbCivil As RadioButton
    Friend WithEvents rbSistemas As RadioButton
    Friend WithEvents rbElectrica As RadioButton
    Friend WithEvents rbMecanica As RadioButton
    Friend WithEvents rbIndustrial As RadioButton
    Friend WithEvents rbCiencias As RadioButton
End Class
