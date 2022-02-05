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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatabaseList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SqlHostName = New System.Windows.Forms.ComboBox()
        Me.SqlInstance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sonuc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Tablolar = New System.Windows.Forms.ComboBox()
        Me.Tablolar1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.scope = New System.Windows.Forms.CheckBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Veri Tabanları"
        '
        'DatabaseList
        '
        Me.DatabaseList.BackColor = System.Drawing.Color.White
        Me.DatabaseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DatabaseList.FormattingEnabled = True
        Me.DatabaseList.Location = New System.Drawing.Point(29, 93)
        Me.DatabaseList.Name = "DatabaseList"
        Me.DatabaseList.Size = New System.Drawing.Size(216, 21)
        Me.DatabaseList.TabIndex = 101
        Me.DatabaseList.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "HostName"
        '
        'SqlHostName
        '
        Me.SqlHostName.BackColor = System.Drawing.Color.White
        Me.SqlHostName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SqlHostName.FormattingEnabled = True
        Me.SqlHostName.Items.AddRange(New Object() {"(localdb)", "localhost"})
        Me.SqlHostName.Location = New System.Drawing.Point(29, 41)
        Me.SqlHostName.Name = "SqlHostName"
        Me.SqlHostName.Size = New System.Drawing.Size(216, 21)
        Me.SqlHostName.TabIndex = 103
        Me.SqlHostName.Tag = ""
        '
        'SqlInstance
        '
        Me.SqlInstance.Location = New System.Drawing.Point(251, 42)
        Me.SqlInstance.Name = "SqlInstance"
        Me.SqlInstance.Size = New System.Drawing.Size(150, 20)
        Me.SqlInstance.TabIndex = 104
        Me.SqlInstance.Text = "ALTINSOFT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Instance"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(407, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "Bağlan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sonuc
        '
        Me.Sonuc.Location = New System.Drawing.Point(29, 144)
        Me.Sonuc.Multiline = True
        Me.Sonuc.Name = "Sonuc"
        Me.Sonuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Sonuc.Size = New System.Drawing.Size(740, 173)
        Me.Sonuc.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "SQL Cümlesi"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.Location = New System.Drawing.Point(497, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 50)
        Me.Button2.TabIndex = 109
        Me.Button2.Text = "Insert Oluştur"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.Location = New System.Drawing.Point(636, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 50)
        Me.Button3.TabIndex = 110
        Me.Button3.Text = "Update Oluştur"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Tablolar
        '
        Me.Tablolar.BackColor = System.Drawing.Color.White
        Me.Tablolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tablolar.FormattingEnabled = True
        Me.Tablolar.Location = New System.Drawing.Point(251, 93)
        Me.Tablolar.Name = "Tablolar"
        Me.Tablolar.Size = New System.Drawing.Size(216, 21)
        Me.Tablolar.TabIndex = 112
        Me.Tablolar.Tag = ""
        '
        'Tablolar1
        '
        Me.Tablolar1.AutoSize = True
        Me.Tablolar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Tablolar1.Location = New System.Drawing.Point(248, 77)
        Me.Tablolar1.Name = "Tablolar1"
        Me.Tablolar1.Size = New System.Drawing.Size(53, 13)
        Me.Tablolar1.TabIndex = 111
        Me.Tablolar1.Text = "Tablolar"
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button4.Location = New System.Drawing.Point(29, 333)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 50)
        Me.Button4.TabIndex = 113
        Me.Button4.Text = "Hafızaya AL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'scope
        '
        Me.scope.AutoSize = True
        Me.scope.Location = New System.Drawing.Point(358, 351)
        Me.scope.Name = "scope"
        Me.scope.Size = New System.Drawing.Size(124, 17)
        Me.scope.TabIndex = 114
        Me.scope.Text = "SCOPE_IDENTITY()"
        Me.scope.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button5.Location = New System.Drawing.Point(136, 333)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(183, 50)
        Me.Button5.TabIndex = 115
        Me.Button5.Text = "Parametreleri Oluştur"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 414)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.scope)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Tablolar)
        Me.Controls.Add(Me.Tablolar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Sonuc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SqlInstance)
        Me.Controls.Add(Me.SqlHostName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DatabaseList)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltınSoft SQL Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DatabaseList As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SqlHostName As ComboBox
    Friend WithEvents SqlInstance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Sonuc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Tablolar As ComboBox
    Friend WithEvents Tablolar1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents scope As CheckBox
    Friend WithEvents Button5 As Button
End Class
