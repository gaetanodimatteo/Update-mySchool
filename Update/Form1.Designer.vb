<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LV1 = New System.Windows.Forms.ListView()
        Me.btnSostituisci = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'LV1
        '
        Me.LV1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LV1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LV1.HideSelection = False
        Me.LV1.Location = New System.Drawing.Point(12, 60)
        Me.LV1.Name = "LV1"
        Me.LV1.Size = New System.Drawing.Size(578, 399)
        Me.LV1.TabIndex = 0
        Me.LV1.UseCompatibleStateImageBehavior = False
        Me.LV1.View = System.Windows.Forms.View.Details
        '
        'btnSostituisci
        '
        Me.btnSostituisci.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSostituisci.Location = New System.Drawing.Point(341, 482)
        Me.btnSostituisci.Name = "btnSostituisci"
        Me.btnSostituisci.Size = New System.Drawing.Size(249, 46)
        Me.btnSostituisci.TabIndex = 1
        Me.btnSostituisci.Text = "Sostituisci"
        Me.btnSostituisci.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Posizionare i file da copiare nella cartella ""C:\mySchool"""
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cartella"
        Me.ColumnHeader1.Width = 241
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Esito"
        Me.ColumnHeader2.Width = 109
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 540)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSostituisci)
        Me.Controls.Add(Me.LV1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LV1 As ListView
    Friend WithEvents btnSostituisci As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
