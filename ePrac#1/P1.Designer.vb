<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(P1))
        Panel1 = New Panel()
        Btn_Ingresar = New Button()
        TextBoxNumero = New TextBox()
        LabelNumero = New Label()
        PanelBarra = New Panel()
        BtnMin = New PictureBox()
        BtnCerrar = New PictureBox()
        LabelTítulo = New Label()
        Panel1.SuspendLayout()
        PanelBarra.SuspendLayout()
        CType(BtnMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Btn_Ingresar)
        Panel1.Controls.Add(TextBoxNumero)
        Panel1.Controls.Add(LabelNumero)
        Panel1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Panel1.Location = New Point(144, 157)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 128)
        Panel1.TabIndex = 0
        ' 
        ' Btn_Ingresar
        ' 
        Btn_Ingresar.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        Btn_Ingresar.Cursor = Cursors.Hand
        Btn_Ingresar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Btn_Ingresar.FlatAppearance.BorderSize = 0
        Btn_Ingresar.FlatStyle = FlatStyle.Flat
        Btn_Ingresar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Ingresar.Location = New Point(356, 35)
        Btn_Ingresar.Name = "Btn_Ingresar"
        Btn_Ingresar.Size = New Size(140, 51)
        Btn_Ingresar.TabIndex = 2
        Btn_Ingresar.Text = "Ingresar"
        Btn_Ingresar.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNumero
        ' 
        TextBoxNumero.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxNumero.Location = New Point(143, 42)
        TextBoxNumero.Name = "TextBoxNumero"
        TextBoxNumero.Size = New Size(189, 38)
        TextBoxNumero.TabIndex = 1
        ' 
        ' LabelNumero
        ' 
        LabelNumero.AutoSize = True
        LabelNumero.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelNumero.Location = New Point(4, 50)
        LabelNumero.Name = "LabelNumero"
        LabelNumero.Size = New Size(118, 27)
        LabelNumero.TabIndex = 0
        LabelNumero.Text = "Numero #"
        ' 
        ' PanelBarra
        ' 
        PanelBarra.Controls.Add(BtnMin)
        PanelBarra.Controls.Add(BtnCerrar)
        PanelBarra.Cursor = Cursors.Hand
        PanelBarra.Location = New Point(0, 0)
        PanelBarra.Name = "PanelBarra"
        PanelBarra.Size = New Size(782, 44)
        PanelBarra.TabIndex = 6
        ' 
        ' BtnMin
        ' 
        BtnMin.Image = CType(resources.GetObject("BtnMin.Image"), Image)
        BtnMin.Location = New Point(679, 6)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(33, 33)
        BtnMin.TabIndex = 1
        BtnMin.TabStop = False
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), Image)
        BtnCerrar.Location = New Point(732, 6)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(33, 33)
        BtnCerrar.TabIndex = 0
        BtnCerrar.TabStop = False
        ' 
        ' LabelTítulo
        ' 
        LabelTítulo.AutoSize = True
        LabelTítulo.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTítulo.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelTítulo.Location = New Point(253, 73)
        LabelTítulo.Name = "LabelTítulo"
        LabelTítulo.Size = New Size(276, 46)
        LabelTítulo.TabIndex = 10
        LabelTítulo.Text = "OPERACIONES"
        ' 
        ' P1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(782, 320)
        Controls.Add(LabelTítulo)
        Controls.Add(PanelBarra)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "P1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "P1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PanelBarra.ResumeLayout(False)
        CType(BtnMin, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelNumero As Label
    Friend WithEvents Btn_Ingresar As Button
    Friend WithEvents TextBoxNumero As TextBox
    Friend WithEvents PanelBarra As Panel
    Friend WithEvents BtnMin As PictureBox
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents LabelTítulo As Label
End Class
