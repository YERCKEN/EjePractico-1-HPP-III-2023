<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(P3))
        PanelBarra = New Panel()
        BtnMin = New PictureBox()
        BtnCerrar = New PictureBox()
        LabelTítulo = New Label()
        Lista1 = New ComboBox()
        LabelPrecioU = New Label()
        TextBoxPrecioU = New TextBox()
        TextBoxCantidad = New TextBox()
        LabelCantidad = New Label()
        LabelProducto = New Label()
        PictureBox1 = New PictureBox()
        PanelEntrada = New Panel()
        BtnCalcular = New Button()
        BtnIngresar = New Button()
        PanelResultado = New Panel()
        LabelTotal = New Label()
        Label3 = New Label()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        BtnBack = New Button()
        LabelVentasC = New Label()
        LabelTotalN = New Label()
        LabelTotalL = New Label()
        LabelTotalC = New Label()
        LabelPrecioN = New Label()
        LabelPrecioL = New Label()
        LabelPrecioC = New Label()
        LabelVentasN = New Label()
        LabelVentasL = New Label()
        Label2 = New Label()
        Label1 = New Label()
        LabelNaranja = New Label()
        LabelLimon = New Label()
        LabelCoca = New Label()
        PanelBarra.SuspendLayout()
        CType(BtnMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelEntrada.SuspendLayout()
        PanelResultado.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelBarra
        ' 
        PanelBarra.Controls.Add(BtnMin)
        PanelBarra.Controls.Add(BtnCerrar)
        PanelBarra.Cursor = Cursors.Hand
        PanelBarra.Location = New Point(0, 0)
        PanelBarra.Name = "PanelBarra"
        PanelBarra.Size = New Size(782, 44)
        PanelBarra.TabIndex = 7
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
        LabelTítulo.Location = New Point(320, 66)
        LabelTítulo.Name = "LabelTítulo"
        LabelTítulo.Size = New Size(159, 46)
        LabelTítulo.TabIndex = 10
        LabelTítulo.Text = "VENTAS"
        ' 
        ' Lista1
        ' 
        Lista1.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        Lista1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Lista1.FormattingEnabled = True
        Lista1.Items.AddRange(New Object() {"R. Cola", "R. Limón", "R. Naranja"})
        Lista1.Location = New Point(46, 59)
        Lista1.Name = "Lista1"
        Lista1.Size = New Size(204, 43)
        Lista1.TabIndex = 11
        ' 
        ' LabelPrecioU
        ' 
        LabelPrecioU.AutoSize = True
        LabelPrecioU.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPrecioU.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelPrecioU.Location = New Point(46, 242)
        LabelPrecioU.Name = "LabelPrecioU"
        LabelPrecioU.Size = New Size(213, 27)
        LabelPrecioU.TabIndex = 13
        LabelPrecioU.Text = "Precio Unitario  (€)"
        ' 
        ' TextBoxPrecioU
        ' 
        TextBoxPrecioU.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxPrecioU.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxPrecioU.Location = New Point(46, 275)
        TextBoxPrecioU.Name = "TextBoxPrecioU"
        TextBoxPrecioU.Size = New Size(204, 48)
        TextBoxPrecioU.TabIndex = 12
        ' 
        ' TextBoxCantidad
        ' 
        TextBoxCantidad.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxCantidad.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxCantidad.Location = New Point(46, 167)
        TextBoxCantidad.Name = "TextBoxCantidad"
        TextBoxCantidad.Size = New Size(204, 48)
        TextBoxCantidad.TabIndex = 14
        ' 
        ' LabelCantidad
        ' 
        LabelCantidad.AutoSize = True
        LabelCantidad.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelCantidad.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelCantidad.Location = New Point(46, 128)
        LabelCantidad.Name = "LabelCantidad"
        LabelCantidad.Size = New Size(108, 27)
        LabelCantidad.TabIndex = 15
        LabelCantidad.Text = "Cantidad"
        ' 
        ' LabelProducto
        ' 
        LabelProducto.AutoSize = True
        LabelProducto.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelProducto.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelProducto.Location = New Point(46, 22)
        LabelProducto.Name = "LabelProducto"
        LabelProducto.Size = New Size(111, 27)
        LabelProducto.TabIndex = 16
        LabelProducto.Text = "Producto"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(406, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 300)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' PanelEntrada
        ' 
        PanelEntrada.Controls.Add(BtnCalcular)
        PanelEntrada.Controls.Add(BtnIngresar)
        PanelEntrada.Controls.Add(PictureBox1)
        PanelEntrada.Controls.Add(Lista1)
        PanelEntrada.Controls.Add(LabelProducto)
        PanelEntrada.Controls.Add(TextBoxPrecioU)
        PanelEntrada.Controls.Add(LabelCantidad)
        PanelEntrada.Controls.Add(LabelPrecioU)
        PanelEntrada.Controls.Add(TextBoxCantidad)
        PanelEntrada.Location = New Point(28, 145)
        PanelEntrada.Name = "PanelEntrada"
        PanelEntrada.Size = New Size(737, 413)
        PanelEntrada.TabIndex = 18
        ' 
        ' BtnCalcular
        ' 
        BtnCalcular.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnCalcular.Cursor = Cursors.Hand
        BtnCalcular.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnCalcular.FlatAppearance.BorderSize = 0
        BtnCalcular.FlatStyle = FlatStyle.Flat
        BtnCalcular.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCalcular.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnCalcular.Location = New Point(421, 359)
        BtnCalcular.Name = "BtnCalcular"
        BtnCalcular.Size = New Size(140, 51)
        BtnCalcular.TabIndex = 19
        BtnCalcular.Text = "Calcular"
        BtnCalcular.UseVisualStyleBackColor = False
        ' 
        ' BtnIngresar
        ' 
        BtnIngresar.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnIngresar.Cursor = Cursors.Hand
        BtnIngresar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnIngresar.FlatAppearance.BorderSize = 0
        BtnIngresar.FlatStyle = FlatStyle.Flat
        BtnIngresar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnIngresar.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnIngresar.Location = New Point(46, 359)
        BtnIngresar.Name = "BtnIngresar"
        BtnIngresar.Size = New Size(140, 51)
        BtnIngresar.TabIndex = 18
        BtnIngresar.Text = "Ingresar"
        BtnIngresar.UseVisualStyleBackColor = False
        ' 
        ' PanelResultado
        ' 
        PanelResultado.Controls.Add(LabelTotal)
        PanelResultado.Controls.Add(Label3)
        PanelResultado.Controls.Add(Panel4)
        PanelResultado.Controls.Add(Panel3)
        PanelResultado.Controls.Add(Panel2)
        PanelResultado.Controls.Add(Panel1)
        PanelResultado.Controls.Add(BtnBack)
        PanelResultado.Controls.Add(LabelVentasC)
        PanelResultado.Controls.Add(LabelTotalN)
        PanelResultado.Controls.Add(LabelTotalL)
        PanelResultado.Controls.Add(LabelTotalC)
        PanelResultado.Controls.Add(LabelPrecioN)
        PanelResultado.Controls.Add(LabelPrecioL)
        PanelResultado.Controls.Add(LabelPrecioC)
        PanelResultado.Controls.Add(LabelVentasN)
        PanelResultado.Controls.Add(LabelVentasL)
        PanelResultado.Controls.Add(Label2)
        PanelResultado.Controls.Add(Label1)
        PanelResultado.Controls.Add(LabelNaranja)
        PanelResultado.Controls.Add(LabelLimon)
        PanelResultado.Controls.Add(LabelCoca)
        PanelResultado.Location = New Point(28, 167)
        PanelResultado.Name = "PanelResultado"
        PanelResultado.Size = New Size(735, 388)
        PanelResultado.TabIndex = 21
        ' 
        ' LabelTotal
        ' 
        LabelTotal.AutoSize = True
        LabelTotal.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTotal.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelTotal.Location = New Point(538, 253)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(28, 27)
        LabelTotal.TabIndex = 19
        LabelTotal.Text = "--"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Label3.Location = New Point(427, 253)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 27)
        Label3.TabIndex = 18
        Label3.Text = "TOTAL = "
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Panel4.BackgroundImageLayout = ImageLayout.None
        Panel4.ForeColor = SystemColors.ControlLightLight
        Panel4.Location = New Point(427, 241)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(300, 2)
        Panel4.TabIndex = 16
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Panel3.BackgroundImageLayout = ImageLayout.None
        Panel3.ForeColor = SystemColors.ControlLightLight
        Panel3.Location = New Point(129, 35)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(2, 200)
        Panel3.TabIndex = 17
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.ForeColor = SystemColors.ControlLightLight
        Panel2.Location = New Point(352, 35)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(2, 200)
        Panel2.TabIndex = 16
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.ForeColor = SystemColors.ControlLightLight
        Panel1.Location = New Point(522, 35)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2, 200)
        Panel1.TabIndex = 15
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        BtnBack.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnBack.Location = New Point(307, 331)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(107, 55)
        BtnBack.TabIndex = 14
        BtnBack.Text = "🔙"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' LabelVentasC
        ' 
        LabelVentasC.AutoSize = True
        LabelVentasC.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelVentasC.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelVentasC.Location = New Point(179, 88)
        LabelVentasC.Name = "LabelVentasC"
        LabelVentasC.Size = New Size(28, 27)
        LabelVentasC.TabIndex = 13
        LabelVentasC.Text = "--"
        ' 
        ' LabelTotalN
        ' 
        LabelTotalN.AutoSize = True
        LabelTotalN.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTotalN.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelTotalN.Location = New Point(538, 194)
        LabelTotalN.Name = "LabelTotalN"
        LabelTotalN.Size = New Size(28, 27)
        LabelTotalN.TabIndex = 12
        LabelTotalN.Text = "--"
        ' 
        ' LabelTotalL
        ' 
        LabelTotalL.AutoSize = True
        LabelTotalL.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTotalL.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelTotalL.Location = New Point(538, 140)
        LabelTotalL.Name = "LabelTotalL"
        LabelTotalL.Size = New Size(28, 27)
        LabelTotalL.TabIndex = 11
        LabelTotalL.Text = "--"
        ' 
        ' LabelTotalC
        ' 
        LabelTotalC.AutoSize = True
        LabelTotalC.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTotalC.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelTotalC.Location = New Point(538, 88)
        LabelTotalC.Name = "LabelTotalC"
        LabelTotalC.Size = New Size(28, 27)
        LabelTotalC.TabIndex = 10
        LabelTotalC.Text = "--"
        ' 
        ' LabelPrecioN
        ' 
        LabelPrecioN.AutoSize = True
        LabelPrecioN.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPrecioN.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelPrecioN.Location = New Point(363, 194)
        LabelPrecioN.Name = "LabelPrecioN"
        LabelPrecioN.Size = New Size(28, 27)
        LabelPrecioN.TabIndex = 9
        LabelPrecioN.Text = "--"
        ' 
        ' LabelPrecioL
        ' 
        LabelPrecioL.AutoSize = True
        LabelPrecioL.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPrecioL.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelPrecioL.Location = New Point(363, 140)
        LabelPrecioL.Name = "LabelPrecioL"
        LabelPrecioL.Size = New Size(28, 27)
        LabelPrecioL.TabIndex = 8
        LabelPrecioL.Text = "--"
        ' 
        ' LabelPrecioC
        ' 
        LabelPrecioC.AutoSize = True
        LabelPrecioC.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPrecioC.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelPrecioC.Location = New Point(364, 88)
        LabelPrecioC.Name = "LabelPrecioC"
        LabelPrecioC.Size = New Size(28, 27)
        LabelPrecioC.TabIndex = 7
        LabelPrecioC.Text = "--"
        ' 
        ' LabelVentasN
        ' 
        LabelVentasN.AutoSize = True
        LabelVentasN.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelVentasN.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelVentasN.Location = New Point(179, 194)
        LabelVentasN.Name = "LabelVentasN"
        LabelVentasN.Size = New Size(28, 27)
        LabelVentasN.TabIndex = 6
        LabelVentasN.Text = "--"
        ' 
        ' LabelVentasL
        ' 
        LabelVentasL.AutoSize = True
        LabelVentasL.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelVentasL.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelVentasL.Location = New Point(179, 140)
        LabelVentasL.Name = "LabelVentasL"
        LabelVentasL.Size = New Size(28, 27)
        LabelVentasL.TabIndex = 5
        LabelVentasL.Text = "--"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Label2.Location = New Point(184, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 27)
        Label2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label1.Location = New Point(17, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(693, 27)
        Label1.TabIndex = 3
        Label1.Text = "Producto |            Ventas            |        Precio        |             Total        "
        ' 
        ' LabelNaranja
        ' 
        LabelNaranja.AutoSize = True
        LabelNaranja.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelNaranja.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelNaranja.Location = New Point(12, 194)
        LabelNaranja.Name = "LabelNaranja"
        LabelNaranja.Size = New Size(92, 27)
        LabelNaranja.TabIndex = 2
        LabelNaranja.Text = "Naranja"
        ' 
        ' LabelLimon
        ' 
        LabelLimon.AutoSize = True
        LabelLimon.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelLimon.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelLimon.Location = New Point(12, 140)
        LabelLimon.Name = "LabelLimon"
        LabelLimon.Size = New Size(78, 27)
        LabelLimon.TabIndex = 1
        LabelLimon.Text = "Limón"
        ' 
        ' LabelCoca
        ' 
        LabelCoca.AutoSize = True
        LabelCoca.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelCoca.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelCoca.Location = New Point(12, 88)
        LabelCoca.Name = "LabelCoca"
        LabelCoca.Size = New Size(64, 27)
        LabelCoca.TabIndex = 0
        LabelCoca.Text = "Coca"
        ' 
        ' P3
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(782, 582)
        Controls.Add(PanelResultado)
        Controls.Add(LabelTítulo)
        Controls.Add(PanelBarra)
        Controls.Add(PanelEntrada)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "P3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "P3"
        PanelBarra.ResumeLayout(False)
        CType(BtnMin, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelEntrada.ResumeLayout(False)
        PanelEntrada.PerformLayout()
        PanelResultado.ResumeLayout(False)
        PanelResultado.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelBarra As Panel
    Friend WithEvents BtnMin As PictureBox
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents LabelTítulo As Label
    Friend WithEvents Lista1 As ComboBox
    Friend WithEvents LabelPrecioU As Label
    Friend WithEvents TextBoxPrecioU As TextBox
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents LabelCantidad As Label
    Friend WithEvents LabelProducto As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelEntrada As Panel
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents PanelResultado As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNaranja As Label
    Friend WithEvents LabelLimon As Label
    Friend WithEvents LabelCoca As Label
    Friend WithEvents LabelTotalN As Label
    Friend WithEvents LabelTotalL As Label
    Friend WithEvents LabelTotalC As Label
    Friend WithEvents LabelPrecioN As Label
    Friend WithEvents LabelPrecioL As Label
    Friend WithEvents LabelPrecioC As Label
    Friend WithEvents LabelVentasN As Label
    Friend WithEvents LabelVentasL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelVentasC As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label3 As Label
End Class
