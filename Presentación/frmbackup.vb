Public Class frmbackup
    Private Sub btnBackup_Click_Click(sender As Object, e As EventArgs) Handles btnBackup_Click.Click
        Try
            Dim func As New fbackup
            If func.backupbase Then
                MsgBox("El Backup se generado con exito...", 0 + 64, "Proceso con exito...")
                Me.Close()
            Else
                MsgBox("El Backup no puedo ser generado...", 0 + 16, "Error en proceso...")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class