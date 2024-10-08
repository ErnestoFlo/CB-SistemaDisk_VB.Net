Imports System.Data.SqlTypes

Public Class frmmenuprincipal
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs)
        frmcliente.ShowDialog()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs)
        frmproducto.ShowDialog()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs)
        frmproveedor.ShowDialog()
    End Sub

    Private Sub btnTipo_Click(sender As Object, e As EventArgs)
        frmtipo.ShowDialog()
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs)
        frmusuario.ShowDialog()
    End Sub

    Private Sub btnRespaldo_Click(sender As Object, e As EventArgs)
        frmbackup.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmcliente.ShowDialog()
    End Sub

    Private Sub CategoríasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoríasToolStripMenuItem.Click
        frmtipo.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmproducto.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmproveedor.ShowDialog()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmusuario.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim R As Integer
        R = MsgBox("¿Esta seguro que desea salir?", 4 + 32 + 256, "Confirme...")
        If R = 6 Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub UtilitariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtilitariosToolStripMenuItem.Click

    End Sub

    Private Sub RespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldoToolStripMenuItem.Click
        frmbackup.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frmacercade.ShowDialog()
    End Sub
End Class