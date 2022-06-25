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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.searchTxtBox = New System.Windows.Forms.TextBox()
        Me.viewSpecTxtBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.titleLable = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.MediumTurquoise
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searchBtn.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.Location = New System.Drawing.Point(338, 298)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(75, 23)
        Me.searchBtn.TabIndex = 0
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearBtn.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(419, 297)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 1
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'searchTxtBox
        '
        Me.searchTxtBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.searchTxtBox.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTxtBox.Location = New System.Drawing.Point(38, 297)
        Me.searchTxtBox.Name = "searchTxtBox"
        Me.searchTxtBox.Size = New System.Drawing.Size(294, 24)
        Me.searchTxtBox.TabIndex = 3
        '
        'viewSpecTxtBox
        '
        Me.viewSpecTxtBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.viewSpecTxtBox.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewSpecTxtBox.Location = New System.Drawing.Point(38, 338)
        Me.viewSpecTxtBox.Multiline = True
        Me.viewSpecTxtBox.Name = "viewSpecTxtBox"
        Me.viewSpecTxtBox.Size = New System.Drawing.Size(456, 149)
        Me.viewSpecTxtBox.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox1.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(38, 68)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(456, 214)
        Me.ListBox1.TabIndex = 5
        '
        'titleLable
        '
        Me.titleLable.AutoSize = True
        Me.titleLable.Font = New System.Drawing.Font("Corbel", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLable.ForeColor = System.Drawing.Color.White
        Me.titleLable.Location = New System.Drawing.Point(159, 23)
        Me.titleLable.Name = "titleLable"
        Me.titleLable.Size = New System.Drawing.Size(307, 28)
        Me.titleLable.TabIndex = 6
        Me.titleLable.Text = "Visitor's Contact Tracing Viewer"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.searchBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(528, 506)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.titleLable)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.viewSpecTxtBox)
        Me.Controls.Add(Me.searchTxtBox)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.searchBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Tracing Viewer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents searchTxtBox As TextBox
    Friend WithEvents viewSpecTxtBox As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents titleLable As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
