﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.searchTxtBox = New System.Windows.Forms.TextBox()
        Me.viewSpecTxtBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'searchBtn
        '
        Me.searchBtn.Location = New System.Drawing.Point(338, 239)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(75, 23)
        Me.searchBtn.TabIndex = 0
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(419, 238)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 1
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'searchTxtBox
        '
        Me.searchTxtBox.Location = New System.Drawing.Point(38, 241)
        Me.searchTxtBox.Name = "searchTxtBox"
        Me.searchTxtBox.Size = New System.Drawing.Size(294, 20)
        Me.searchTxtBox.TabIndex = 3
        '
        'viewSpecTxtBox
        '
        Me.viewSpecTxtBox.Location = New System.Drawing.Point(38, 282)
        Me.viewSpecTxtBox.Multiline = True
        Me.viewSpecTxtBox.Name = "viewSpecTxtBox"
        Me.viewSpecTxtBox.Size = New System.Drawing.Size(456, 149)
        Me.viewSpecTxtBox.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(38, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(456, 212)
        Me.ListBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 460)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.viewSpecTxtBox)
        Me.Controls.Add(Me.searchTxtBox)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.searchBtn)
        Me.Name = "Form1"
        Me.Text = "Contact Tracing Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents searchTxtBox As TextBox
    Friend WithEvents viewSpecTxtBox As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
