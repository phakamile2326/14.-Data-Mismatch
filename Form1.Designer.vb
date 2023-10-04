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
        btnShow = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Visual = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(334, 231)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(75, 23)
        btnShow.TabIndex = 0
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(225, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 15)
        Label1.TabIndex = 1
        Label1.Text = "Text2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(225, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 1
        Label2.Text = "Text1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(225, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 15)
        Label3.TabIndex = 1
        Label3.Text = "Text3"
        ' 
        ' Visual
        ' 
        Visual.Location = New Point(364, 55)
        Visual.Name = "Visual"
        Visual.Size = New Size(100, 23)
        Visual.TabIndex = 2
        Visual.Text = "Visual"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(364, 152)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(364, 102)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 2
        TextBox3.Text = "22"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(Visual)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(btnShow)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnShow As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Visual As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
