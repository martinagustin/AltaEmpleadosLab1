<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DtGrid = New System.Windows.Forms.DataGridView()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNleg = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtLocalidad = New System.Windows.Forms.TextBox()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.TxtUltSueldo = New System.Windows.Forms.TextBox()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.BtnConexion = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtGrid
        '
        Me.DtGrid.AllowUserToAddRows = False
        Me.DtGrid.AllowUserToDeleteRows = False
        Me.DtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGrid.Location = New System.Drawing.Point(306, 45)
        Me.DtGrid.Name = "DtGrid"
        Me.DtGrid.ReadOnly = True
        Me.DtGrid.RowTemplate.Height = 25
        Me.DtGrid.Size = New System.Drawing.Size(333, 222)
        Me.DtGrid.TabIndex = 16
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(141, 359)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(90, 33)
        Me.BtnMostrar.TabIndex = 17
        Me.BtnMostrar.Text = "Mostrar Datos"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Legajo"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nombre"
        '
        'T
        '
        Me.T.Location = New System.Drawing.Point(12, 78)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(100, 23)
        Me.T.TabIndex = 21
        Me.T.Text = "DNI"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Direccion"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Localidad"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Celular"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Sexo"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(12, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Edad"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(12, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Categoria"
        '
        'TxtNleg
        '
        Me.TxtNleg.Location = New System.Drawing.Point(99, 6)
        Me.TxtNleg.Name = "TxtNleg"
        Me.TxtNleg.Size = New System.Drawing.Size(100, 23)
        Me.TxtNleg.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(12, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Ultimo Sueldo"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(99, 29)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(100, 23)
        Me.TxtApellido.TabIndex = 30
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(99, 52)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 23)
        Me.TxtNombre.TabIndex = 31
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(99, 75)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(100, 23)
        Me.TxtDni.TabIndex = 32
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(99, 98)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(100, 23)
        Me.TxtDireccion.TabIndex = 33
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(99, 121)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(100, 23)
        Me.TxtLocalidad.TabIndex = 34
        '
        'TxtCelular
        '
        Me.TxtCelular.Location = New System.Drawing.Point(99, 144)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(100, 23)
        Me.TxtCelular.TabIndex = 35
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(99, 190)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(100, 23)
        Me.TxtEdad.TabIndex = 36
        '
        'TxtUltSueldo
        '
        Me.TxtUltSueldo.Location = New System.Drawing.Point(99, 236)
        Me.TxtUltSueldo.Name = "TxtUltSueldo"
        Me.TxtUltSueldo.Size = New System.Drawing.Size(100, 23)
        Me.TxtUltSueldo.TabIndex = 37
        '
        'CmbSexo
        '
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Items.AddRange(New Object() {"Masculino" & Global.Microsoft.VisualBasic.ChrW(9), "Femenino"})
        Me.CmbSexo.Location = New System.Drawing.Point(99, 167)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(121, 23)
        Me.CmbSexo.TabIndex = 38
        '
        'CmbCategoria
        '
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Items.AddRange(New Object() {"----ADMINISTRATIVO----", "Cadete", "Administrativo", "Jefes de seccion", "Gerentes", "----PRODUCCION----", "Ayudante", "Oficiales", "Capataces"})
        Me.CmbCategoria.Location = New System.Drawing.Point(99, 213)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(121, 23)
        Me.CmbCategoria.TabIndex = 39
        '
        'BtnConexion
        '
        Me.BtnConexion.Location = New System.Drawing.Point(327, 287)
        Me.BtnConexion.Name = "BtnConexion"
        Me.BtnConexion.Size = New System.Drawing.Size(75, 23)
        Me.BtnConexion.TabIndex = 40
        Me.BtnConexion.Text = "Conexion"
        Me.BtnConexion.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(473, 330)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 41
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(680, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 25)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Resultados"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnConexion)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Controls.Add(Me.CmbSexo)
        Me.Controls.Add(Me.TxtUltSueldo)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.TxtCelular)
        Me.Controls.Add(Me.TxtLocalidad)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtNleg)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.T)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.DtGrid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtGrid As DataGridView
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents T As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtNleg As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtLocalidad As TextBox
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents TxtUltSueldo As TextBox
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents CmbCategoria As ComboBox
    Friend WithEvents BtnConexion As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Button1 As Button
End Class
