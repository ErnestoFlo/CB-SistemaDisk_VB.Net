<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbackup
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBackup_Click = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBackup_Click
        '
        Me.btnBackup_Click.Location = New System.Drawing.Point(112, 47)
        Me.btnBackup_Click.Name = "btnBackup_Click"
        Me.btnBackup_Click.Size = New System.Drawing.Size(159, 57)
        Me.btnBackup_Click.TabIndex = 0
        Me.btnBackup_Click.Text = "Realizar Copia de Respaldo"
        Me.btnBackup_Click.UseVisualStyleBackColor = True
        '
        'frmbackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 151)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBackup_Click)
        Me.Name = "frmbackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar respaldo de la base de datos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBackup_Click As Button
End Class
