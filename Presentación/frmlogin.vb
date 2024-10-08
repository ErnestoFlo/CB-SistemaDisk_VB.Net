Imports System.Resources

Public Class frmlogin
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim R As Integer
        R = MsgBox("¿Esta seguro que desea salir?", 4 + 32 + 256, "Confirme...")
        If R = 6 Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeOfDay
    End Sub

    Private Sub frmusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblhora.Text = TimeOfDay
        Timer1.Start()
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Try

            Dim dts As New vusuario
            Dim func As New fusuario

            dts.glogin = txtlogin.Text
            dts.gpassword = txtpassword.Text

            If func.validar_usuario(dts) = True Then
                frmmenuprincipal.Show()
                MsgBox("Bienvenido al sistema!", 0 + 64, "Acceso permitido")
                Me.Hide()
            Else
                MsgBox("Ingrese nuevamente sus datos!", 0 + 64, "Acceso denegado al sistema")
                txtpassword.Clear()
            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtlogin_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtlogin.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese su nombre de usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtpassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtpassword.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese su contraseña, este dato es obligatorio")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class