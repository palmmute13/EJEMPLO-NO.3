<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sumar = New System.Windows.Forms.RadioButton()
        Me.Dividir = New System.Windows.Forms.RadioButton()
        Me.Multiplicar = New System.Windows.Forms.RadioButton()
        Me.Restar = New System.Windows.Forms.RadioButton()
        Me.TbNum1 = New System.Windows.Forms.TextBox()
        Me.TbNum2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num 1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ejecutar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Num 2"
        '
        'Sumar
        '
        Me.Sumar.AutoSize = True
        Me.Sumar.Location = New System.Drawing.Point(78, 117)
        Me.Sumar.Name = "Sumar"
        Me.Sumar.Size = New System.Drawing.Size(55, 17)
        Me.Sumar.TabIndex = 3
        Me.Sumar.TabStop = True
        Me.Sumar.Text = "Sumar"
        Me.Sumar.UseVisualStyleBackColor = True
        '
        'Dividir
        '
        Me.Dividir.AutoSize = True
        Me.Dividir.Location = New System.Drawing.Point(78, 186)
        Me.Dividir.Name = "Dividir"
        Me.Dividir.Size = New System.Drawing.Size(54, 17)
        Me.Dividir.TabIndex = 5
        Me.Dividir.TabStop = True
        Me.Dividir.Text = "Dividir"
        Me.Dividir.UseVisualStyleBackColor = True
        '
        'Multiplicar
        '
        Me.Multiplicar.AutoSize = True
        Me.Multiplicar.Location = New System.Drawing.Point(78, 163)
        Me.Multiplicar.Name = "Multiplicar"
        Me.Multiplicar.Size = New System.Drawing.Size(72, 17)
        Me.Multiplicar.TabIndex = 6
        Me.Multiplicar.TabStop = True
        Me.Multiplicar.Text = "Multiplicar"
        Me.Multiplicar.UseVisualStyleBackColor = True
        '
        'Restar
        '
        Me.Restar.AutoSize = True
        Me.Restar.Location = New System.Drawing.Point(78, 140)
        Me.Restar.Name = "Restar"
        Me.Restar.Size = New System.Drawing.Size(56, 17)
        Me.Restar.TabIndex = 7
        Me.Restar.TabStop = True
        Me.Restar.Text = "Restar"
        Me.Restar.UseVisualStyleBackColor = True
        '
        'TbNum1
        '
        Me.TbNum1.Location = New System.Drawing.Point(78, 70)
        Me.TbNum1.Name = "TbNum1"
        Me.TbNum1.Size = New System.Drawing.Size(51, 20)
        Me.TbNum1.TabIndex = 8
        '
        'TbNum2
        '
        Me.TbNum2.Location = New System.Drawing.Point(163, 70)
        Me.TbNum2.Name = "TbNum2"
        Me.TbNum2.Size = New System.Drawing.Size(51, 20)
        Me.TbNum2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 460)
        Me.Controls.Add(Me.TbNum2)
        Me.Controls.Add(Me.TbNum1)
        Me.Controls.Add(Me.Restar)
        Me.Controls.Add(Me.Multiplicar)
        Me.Controls.Add(Me.Dividir)
        Me.Controls.Add(Me.Sumar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Sumar As RadioButton
    Friend WithEvents Dividir As RadioButton
    Friend WithEvents Multiplicar As RadioButton
    Friend WithEvents Restar As RadioButton
    Friend WithEvents TbNum1 As TextBox
    Friend WithEvents TbNum2 As TextBox
End Class
