<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InformacionNomina
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformacionNomina))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxTotalEmpleados = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalNomina = New System.Windows.Forms.TextBox()
        Me.TextBoxSalarioPromedio = New System.Windows.Forms.TextBox()
        Me.TextBoxSalarioMayor = New System.Windows.Forms.TextBox()
        Me.TextBoxSalarioMenor = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(68, 220)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(931, 185)
        Me.DataGridView1.TabIndex = 0
        '
        'EmpleadosBindingSource
        '
        'EmpleadosTableAdapter
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(475, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Resumen Nómina"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(287, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Nómina"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(469, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Salario Promedio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Empleados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(688, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Salario Mayor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(851, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Salario Menor"
        '
        'TextBoxTotalEmpleados
        '
        Me.TextBoxTotalEmpleados.Location = New System.Drawing.Point(103, 164)
        Me.TextBoxTotalEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxTotalEmpleados.Name = "TextBoxTotalEmpleados"
        Me.TextBoxTotalEmpleados.ReadOnly = True
        Me.TextBoxTotalEmpleados.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTotalEmpleados.TabIndex = 7
        '
        'TextBoxTotalNomina
        '
        Me.TextBoxTotalNomina.Location = New System.Drawing.Point(281, 164)
        Me.TextBoxTotalNomina.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxTotalNomina.Name = "TextBoxTotalNomina"
        Me.TextBoxTotalNomina.ReadOnly = True
        Me.TextBoxTotalNomina.Size = New System.Drawing.Size(137, 22)
        Me.TextBoxTotalNomina.TabIndex = 8
        '
        'TextBoxSalarioPromedio
        '
        Me.TextBoxSalarioPromedio.Location = New System.Drawing.Point(477, 164)
        Me.TextBoxSalarioPromedio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxSalarioPromedio.Name = "TextBoxSalarioPromedio"
        Me.TextBoxSalarioPromedio.ReadOnly = True
        Me.TextBoxSalarioPromedio.Size = New System.Drawing.Size(145, 22)
        Me.TextBoxSalarioPromedio.TabIndex = 9
        '
        'TextBoxSalarioMayor
        '
        Me.TextBoxSalarioMayor.Location = New System.Drawing.Point(685, 164)
        Me.TextBoxSalarioMayor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxSalarioMayor.Name = "TextBoxSalarioMayor"
        Me.TextBoxSalarioMayor.ReadOnly = True
        Me.TextBoxSalarioMayor.Size = New System.Drawing.Size(136, 22)
        Me.TextBoxSalarioMayor.TabIndex = 10
        '
        'TextBoxSalarioMenor
        '
        Me.TextBoxSalarioMenor.Location = New System.Drawing.Point(847, 164)
        Me.TextBoxSalarioMenor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxSalarioMenor.Name = "TextBoxSalarioMenor"
        Me.TextBoxSalarioMenor.ReadOnly = True
        Me.TextBoxSalarioMenor.Size = New System.Drawing.Size(139, 22)
        Me.TextBoxSalarioMenor.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(181, 12)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 55)
        Me.Button4.TabIndex = 13
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
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Atrás"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(964, 15)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 92)
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'InformacionNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1080, 450)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBoxSalarioMenor)
        Me.Controls.Add(Me.TextBoxSalarioMayor)
        Me.Controls.Add(Me.TextBoxSalarioPromedio)
        Me.Controls.Add(Me.TextBoxTotalNomina)
        Me.Controls.Add(Me.TextBoxTotalEmpleados)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "InformacionNomina"
        Me.Text = "InformacionNomina"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxTotalEmpleados As TextBox
    Friend WithEvents TextBoxTotalNomina As TextBox
    Friend WithEvents TextBoxSalarioPromedio As TextBox
    Friend WithEvents TextBoxSalarioMayor As TextBox
    Friend WithEvents TextBoxSalarioMenor As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class
