Public Class frmbienvenida
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Opacity = 0.07
            If Me.Opacity = 0.07 Then
                Me.Hide()
                frmlogin.Show()
                Timer1.Stop()
            End If
        Else
            If ProgressBar1.Value Mod 5 = 0 Then
                If Label1.Visible = True Then
                    Label1.Visible = False
                Else
                    Label1.Visible = True
                End If
            End If
        End If

    End Sub

    Private Sub frmbienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class