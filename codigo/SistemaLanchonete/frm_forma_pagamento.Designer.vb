<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_forma_pagamento
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_forma_pagamento))
        Me.btn_dinheiro = New System.Windows.Forms.Button()
        Me.btn_debito = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_dinheiro
        '
        Me.btn_dinheiro.BackColor = System.Drawing.Color.Gold
        Me.btn_dinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dinheiro.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dinheiro.ForeColor = System.Drawing.Color.White
        Me.btn_dinheiro.Location = New System.Drawing.Point(37, 41)
        Me.btn_dinheiro.Name = "btn_dinheiro"
        Me.btn_dinheiro.Size = New System.Drawing.Size(259, 38)
        Me.btn_dinheiro.TabIndex = 1
        Me.btn_dinheiro.Text = "Dinheiro"
        Me.btn_dinheiro.UseVisualStyleBackColor = False
        '
        'btn_debito
        '
        Me.btn_debito.BackColor = System.Drawing.Color.Gold
        Me.btn_debito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_debito.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_debito.ForeColor = System.Drawing.Color.White
        Me.btn_debito.Location = New System.Drawing.Point(37, 113)
        Me.btn_debito.Name = "btn_debito"
        Me.btn_debito.Size = New System.Drawing.Size(259, 38)
        Me.btn_debito.TabIndex = 2
        Me.btn_debito.Text = "Débito"
        Me.btn_debito.UseVisualStyleBackColor = False
        '
        'frm_forma_pagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 212)
        Me.Controls.Add(Me.btn_debito)
        Me.Controls.Add(Me.btn_dinheiro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_forma_pagamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Forma de pagamento"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_dinheiro As Button
    Friend WithEvents btn_debito As Button
End Class
