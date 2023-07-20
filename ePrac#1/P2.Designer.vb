<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(P2))
        BtnMin = New PictureBox()
        BtnCerrar = New PictureBox()
        PanelBarra = New Panel()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        LabelResultado = New Label()
        TextBoxValor = New TextBox()
        Lista2 = New ComboBox()
        Lista1 = New ComboBox()
        LabelTítulo = New Label()
        CType(BtnMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        PanelBarra.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnMin
        ' 
        BtnMin.Image = CType(resources.GetObject("BtnMin.Image"), Image)
        BtnMin.Location = New Point(694, 6)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(33, 33)
        BtnMin.TabIndex = 1
        BtnMin.TabStop = False
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), Image)
        BtnCerrar.Location = New Point(747, 6)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(33, 33)
        BtnCerrar.TabIndex = 0
        BtnCerrar.TabStop = False
        ' 
        ' PanelBarra
        ' 
        PanelBarra.Controls.Add(BtnMin)
        PanelBarra.Controls.Add(BtnCerrar)
        PanelBarra.Cursor = Cursors.Hand
        PanelBarra.Location = New Point(0, 0)
        PanelBarra.Name = "PanelBarra"
        PanelBarra.Size = New Size(800, 44)
        PanelBarra.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(LabelResultado)
        Panel1.Controls.Add(TextBoxValor)
        Panel1.Controls.Add(Lista2)
        Panel1.Controls.Add(Lista1)
        Panel1.Location = New Point(0, 171)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 210)
        Panel1.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Label2.Location = New Point(209, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 27)
        Label2.TabIndex = 10
        Label2.Text = "Valor"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Label1.Location = New Point(368, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 46)
        Label1.TabIndex = 4
        Label1.Text = "➡️"
        ' 
        ' LabelResultado
        ' 
        LabelResultado.AutoSize = True
        LabelResultado.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        LabelResultado.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        LabelResultado.Location = New Point(440, 150)
        LabelResultado.Name = "LabelResultado"
        LabelResultado.Size = New Size(150, 46)
        LabelResultado.TabIndex = 3
        LabelResultado.Text = "0.00 💵"
        ' 
        ' TextBoxValor
        ' 
        TextBoxValor.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxValor.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxValor.Location = New Point(209, 152)
        TextBoxValor.Name = "TextBoxValor"
        TextBoxValor.Size = New Size(151, 48)
        TextBoxValor.TabIndex = 2
        ' 
        ' Lista2
        ' 
        Lista2.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lista2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Lista2.FormattingEnabled = True
        Lista2.Location = New Point(440, 20)
        Lista2.Name = "Lista2"
        Lista2.Size = New Size(151, 35)
        Lista2.TabIndex = 1
        ' 
        ' Lista1
        ' 
        Lista1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lista1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Lista1.FormattingEnabled = True
        Lista1.Location = New Point(209, 20)
        Lista1.Name = "Lista1"
        Lista1.Size = New Size(151, 35)
        Lista1.TabIndex = 0
        ' 
        ' LabelTítulo
        ' 
        LabelTítulo.AutoSize = True
        LabelTítulo.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTítulo.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelTítulo.Location = New Point(174, 62)
        LabelTítulo.Name = "LabelTítulo"
        LabelTítulo.Size = New Size(451, 46)
        LabelTítulo.TabIndex = 9
        LabelTítulo.Text = "CONVERSOR DE DIVISAS"
        ' 
        ' P2
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(LabelTítulo)
        Controls.Add(Panel1)
        Controls.Add(PanelBarra)
        FormBorderStyle = FormBorderStyle.None
        Name = "P2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "P2"
        CType(BtnMin, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).EndInit()
        PanelBarra.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnMin As PictureBox
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents PanelBarra As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelResultado As Label
    Friend WithEvents TextBoxValor As TextBox
    Friend WithEvents Lista2 As ComboBox
    Friend WithEvents Lista1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelTítulo As Label
    Friend WithEvents Label2 As Label
End Class
