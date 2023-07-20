Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        LabelTitulo = New Label()
        PictureBoxLogo = New PictureBox()
        BtnP1 = New Button()
        BtnP2 = New Button()
        BtnP3 = New Button()
        PanelBarra = New Panel()
        BtnMin = New PictureBox()
        BtnCerrar = New PictureBox()
        LabelPractico = New Label()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        PanelBarra.SuspendLayout()
        CType(BtnMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.AutoSize = True
        LabelTitulo.Font = New Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTitulo.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        LabelTitulo.Location = New Point(378, 89)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(228, 51)
        LabelTitulo.TabIndex = 0
        LabelTitulo.Text = "EJERCICIO"
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), Image)
        PictureBoxLogo.Location = New Point(169, 73)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(206, 117)
        PictureBoxLogo.TabIndex = 1
        PictureBoxLogo.TabStop = False
        ' 
        ' BtnP1
        ' 
        BtnP1.Cursor = Cursors.Hand
        BtnP1.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnP1.FlatAppearance.BorderSize = 0
        BtnP1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnP1.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        BtnP1.Location = New Point(165, 279)
        BtnP1.Name = "BtnP1"
        BtnP1.Size = New Size(223, 84)
        BtnP1.TabIndex = 2
        BtnP1.Text = "Programa #1"
        BtnP1.UseVisualStyleBackColor = False
        ' 
        ' BtnP2
        ' 
        BtnP2.Cursor = Cursors.Hand
        BtnP2.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnP2.FlatAppearance.BorderSize = 0
        BtnP2.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnP2.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        BtnP2.Location = New Point(429, 279)
        BtnP2.Name = "BtnP2"
        BtnP2.Size = New Size(223, 84)
        BtnP2.TabIndex = 3
        BtnP2.Text = "Programa #2"
        BtnP2.UseVisualStyleBackColor = False
        ' 
        ' BtnP3
        ' 
        BtnP3.Cursor = Cursors.Hand
        BtnP3.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnP3.FlatAppearance.BorderSize = 0
        BtnP3.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnP3.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        BtnP3.Location = New Point(290, 427)
        BtnP3.Name = "BtnP3"
        BtnP3.Size = New Size(223, 84)
        BtnP3.TabIndex = 4
        BtnP3.Text = "Programa #3"
        BtnP3.UseVisualStyleBackColor = False
        ' 
        ' PanelBarra
        ' 
        PanelBarra.Controls.Add(BtnMin)
        PanelBarra.Controls.Add(BtnCerrar)
        PanelBarra.Cursor = Cursors.Hand
        PanelBarra.Location = New Point(0, 0)
        PanelBarra.Name = "PanelBarra"
        PanelBarra.Size = New Size(800, 44)
        PanelBarra.TabIndex = 5
        ' 
        ' BtnMin
        ' 
        BtnMin.Image = CType(resources.GetObject("BtnMin.Image"), Image)
        BtnMin.Location = New Point(686, 6)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(33, 33)
        BtnMin.TabIndex = 1
        BtnMin.TabStop = False
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), Image)
        BtnCerrar.Location = New Point(743, 6)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(33, 33)
        BtnCerrar.TabIndex = 0
        BtnCerrar.TabStop = False
        ' 
        ' LabelPractico
        ' 
        LabelPractico.AutoSize = True
        LabelPractico.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPractico.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelPractico.Location = New Point(404, 133)
        LabelPractico.Name = "LabelPractico"
        LabelPractico.Size = New Size(246, 46)
        LabelPractico.TabIndex = 6
        LabelPractico.Text = "PRÁCTICO #1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 579)
        Controls.Add(LabelPractico)
        Controls.Add(PanelBarra)
        Controls.Add(BtnP3)
        Controls.Add(BtnP2)
        Controls.Add(BtnP1)
        Controls.Add(PictureBoxLogo)
        Controls.Add(LabelTitulo)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MENU"
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        PanelBarra.ResumeLayout(False)
        CType(BtnMin, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents BtnP1 As Button
    Friend WithEvents BtnP2 As Button
    Friend WithEvents BtnP3 As Button
    Friend WithEvents PanelBarra As Panel
    Friend WithEvents BtnMin As PictureBox
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents LabelPractico As Label
End Class
