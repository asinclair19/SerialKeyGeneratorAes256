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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtSerialDisk = New System.Windows.Forms.TextBox()
        Me.cmbLetterDisk = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerialKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSecretKey = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnShowSecretKey = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(182, 192)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(166, 40)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "GENERAR"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtSerialDisk
        '
        Me.txtSerialDisk.Location = New System.Drawing.Point(182, 97)
        Me.txtSerialDisk.Name = "txtSerialDisk"
        Me.txtSerialDisk.Size = New System.Drawing.Size(166, 20)
        Me.txtSerialDisk.TabIndex = 1
        '
        'cmbLetterDisk
        '
        Me.cmbLetterDisk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLetterDisk.FormattingEnabled = True
        Me.cmbLetterDisk.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cmbLetterDisk.Location = New System.Drawing.Point(182, 70)
        Me.cmbLetterDisk.Name = "cmbLetterDisk"
        Me.cmbLetterDisk.Size = New System.Drawing.Size(166, 21)
        Me.cmbLetterDisk.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LETTER DISK:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "HDD/SSD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SERIAL KEY GENERATED:"
        '
        'txtSerialKey
        '
        Me.txtSerialKey.Location = New System.Drawing.Point(182, 149)
        Me.txtSerialKey.Name = "txtSerialKey"
        Me.txtSerialKey.Size = New System.Drawing.Size(330, 20)
        Me.txtSerialKey.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "SECRET KEY:"
        '
        'txtSecretKey
        '
        Me.txtSecretKey.Location = New System.Drawing.Point(182, 123)
        Me.txtSecretKey.Name = "txtSecretKey"
        Me.txtSecretKey.Size = New System.Drawing.Size(278, 20)
        Me.txtSecretKey.TabIndex = 7
        Me.txtSecretKey.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(176, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 33)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Serial Key Generator"
        '
        'btnShowSecretKey
        '
        Me.btnShowSecretKey.Location = New System.Drawing.Point(466, 121)
        Me.btnShowSecretKey.Name = "btnShowSecretKey"
        Me.btnShowSecretKey.Size = New System.Drawing.Size(46, 23)
        Me.btnShowSecretKey.TabIndex = 10
        Me.btnShowSecretKey.Text = "VER"
        Me.btnShowSecretKey.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(253, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 14)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "AES-256 codificación Base-64"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 251)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnShowSecretKey)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSecretKey)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSerialKey)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbLetterDisk)
        Me.Controls.Add(Me.txtSerialDisk)
        Me.Controls.Add(Me.btnGenerar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents txtSerialDisk As System.Windows.Forms.TextBox
    Friend WithEvents cmbLetterDisk As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSerialKey As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSecretKey As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnShowSecretKey As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
