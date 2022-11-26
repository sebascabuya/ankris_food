<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarProductos))
        Me.Actualizar = New System.Windows.Forms.Button()
        Me.ValorTetx = New System.Windows.Forms.TextBox()
        Me.CantidadTetx = New System.Windows.Forms.TextBox()
        Me.NombreProductoTetx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.DataGridViewInventario = New System.Windows.Forms.DataGridView()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Actualizar
        '
        Me.Actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Actualizar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actualizar.Location = New System.Drawing.Point(500, 102)
        Me.Actualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(144, 50)
        Me.Actualizar.TabIndex = 18
        Me.Actualizar.Text = "Actualizar Producto"
        Me.Actualizar.UseVisualStyleBackColor = False
        '
        'ValorTetx
        '
        Me.ValorTetx.Location = New System.Drawing.Point(335, 182)
        Me.ValorTetx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ValorTetx.Name = "ValorTetx"
        Me.ValorTetx.Size = New System.Drawing.Size(100, 22)
        Me.ValorTetx.TabIndex = 17
        '
        'CantidadTetx
        '
        Me.CantidadTetx.Location = New System.Drawing.Point(335, 145)
        Me.CantidadTetx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CantidadTetx.Name = "CantidadTetx"
        Me.CantidadTetx.Size = New System.Drawing.Size(100, 22)
        Me.CantidadTetx.TabIndex = 16
        '
        'NombreProductoTetx
        '
        Me.NombreProductoTetx.Location = New System.Drawing.Point(335, 105)
        Me.NombreProductoTetx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreProductoTetx.Name = "NombreProductoTetx"
        Me.NombreProductoTetx.Size = New System.Drawing.Size(100, 22)
        Me.NombreProductoTetx.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 26)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Valor Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 26)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre Producto"
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Eliminar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.Location = New System.Drawing.Point(500, 161)
        Me.Eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(144, 50)
        Me.Eliminar.TabIndex = 19
        Me.Eliminar.Text = "Eliminar Producto"
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'DataGridViewInventario
        '
        Me.DataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInventario.Location = New System.Drawing.Point(229, 251)
        Me.DataGridViewInventario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewInventario.Name = "DataGridViewInventario"
        Me.DataGridViewInventario.RowHeadersWidth = 51
        Me.DataGridViewInventario.RowTemplate.Height = 24
        Me.DataGridViewInventario.Size = New System.Drawing.Size(624, 174)
        Me.DataGridViewInventario.TabIndex = 20
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "Inventario"
        '
        'Akris_FoodDataSet
        '
        '
        'InventarioTableAdapter
        '
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(181, 12)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 55)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Cerrar Sesión"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(68, 12)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 55)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Atrás"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(971, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 86)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'EditarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1080, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridViewInventario)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Actualizar)
        Me.Controls.Add(Me.ValorTetx)
        Me.Controls.Add(Me.CantidadTetx)
        Me.Controls.Add(Me.NombreProductoTetx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "EditarProductos"
        Me.Text = "EditarProductos"
        CType(Me.DataGridViewInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Actualizar As Button
    Friend WithEvents ValorTetx As TextBox
    Friend WithEvents CantidadTetx As TextBox
    Friend WithEvents NombreProductoTetx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Eliminar As Button
    Friend WithEvents DataGridViewInventario As DataGridView
    Friend WithEvents InventarioBindingSource As BindingSource
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
