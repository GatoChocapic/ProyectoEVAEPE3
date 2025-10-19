<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        txtUsuario = New TextBox()
        txtPassword = New TextBox()
        btIniciar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 0
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(85, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(229, 148)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(144, 23)
        txtUsuario.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(229, 208)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(144, 23)
        txtPassword.TabIndex = 3
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btIniciar
        ' 
        btIniciar.Location = New Point(162, 328)
        btIniciar.Name = "btIniciar"
        btIniciar.Size = New Size(109, 23)
        btIniciar.TabIndex = 4
        btIniciar.Text = "Iniciar sesión"
        btIniciar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(440, 624)
        Controls.Add(btIniciar)
        Controls.Add(txtPassword)
        Controls.Add(txtUsuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btIniciar As Button

End Class
