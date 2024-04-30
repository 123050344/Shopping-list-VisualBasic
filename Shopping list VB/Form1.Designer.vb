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
        listcompras = New ListView()
        btnsave = New Button()
        btnshow = New Button()
        txtcompras = New TextBox()
        label1 = New Label()
        SuspendLayout()
        ' 
        ' listcompras
        ' 
        listcompras.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        listcompras.Location = New Point(44, 129)
        listcompras.Name = "listcompras"
        listcompras.Size = New Size(408, 283)
        listcompras.TabIndex = 5
        listcompras.UseCompatibleStateImageBehavior = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.IndianRed
        btnsave.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave.Location = New Point(528, 65)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(179, 57)
        btnsave.TabIndex = 6
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btnshow
        ' 
        btnshow.BackColor = Color.IndianRed
        btnshow.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnshow.Location = New Point(528, 346)
        btnshow.Name = "btnshow"
        btnshow.Size = New Size(179, 66)
        btnshow.TabIndex = 7
        btnshow.Text = "Show"
        btnshow.UseVisualStyleBackColor = False
        ' 
        ' txtcompras
        ' 
        txtcompras.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        txtcompras.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtcompras.Location = New Point(78, 65)
        txtcompras.Name = "txtcompras"
        txtcompras.Size = New Size(338, 33)
        txtcompras.TabIndex = 8
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label1.Location = New Point(296, 9)
        label1.Name = "label1"
        label1.Size = New Size(183, 30)
        label1.TabIndex = 9
        label1.Text = "Shopping list  VB"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ClientSize = New Size(800, 450)
        Controls.Add(label1)
        Controls.Add(txtcompras)
        Controls.Add(btnshow)
        Controls.Add(btnsave)
        Controls.Add(listcompras)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents listcompras As ListView
    Private WithEvents btnsave As Button
    Private WithEvents btnshow As Button
    Private WithEvents txtcompras As TextBox
    Private WithEvents label1 As Label
End Class
