<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_obs
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_obs))
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.cmb_retirar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_acrescentar = New System.Windows.Forms.ComboBox()
        Me.btn_add_obs = New System.Windows.Forms.Button()
        Me.btn_add_acr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.White
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.Color.Goldenrod
        Me.btn_confirmar.Location = New System.Drawing.Point(109, 182)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(113, 30)
        Me.btn_confirmar.TabIndex = 3
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'cmb_retirar
        '
        Me.cmb_retirar.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_retirar.FormattingEnabled = True
        Me.cmb_retirar.Items.AddRange(New Object() {"Sem Maionese", "Sem Queijo", "Sem Tomate", "Sem Alface", "Sem Gelo"})
        Me.cmb_retirar.Location = New System.Drawing.Point(38, 50)
        Me.cmb_retirar.Name = "cmb_retirar"
        Me.cmb_retirar.Size = New System.Drawing.Size(225, 31)
        Me.cmb_retirar.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(34, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Retirar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label2.Location = New System.Drawing.Point(34, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Acrescentar:"
        '
        'cmb_acrescentar
        '
        Me.cmb_acrescentar.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_acrescentar.FormattingEnabled = True
        Me.cmb_acrescentar.Items.AddRange(New Object() {"Bacon", "Ovo"})
        Me.cmb_acrescentar.Location = New System.Drawing.Point(38, 124)
        Me.cmb_acrescentar.Name = "cmb_acrescentar"
        Me.cmb_acrescentar.Size = New System.Drawing.Size(225, 31)
        Me.cmb_acrescentar.TabIndex = 6
        '
        'btn_add_obs
        '
        Me.btn_add_obs.BackColor = System.Drawing.Color.Green
        Me.btn_add_obs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_obs.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_obs.ForeColor = System.Drawing.Color.White
        Me.btn_add_obs.Location = New System.Drawing.Point(278, 50)
        Me.btn_add_obs.Name = "btn_add_obs"
        Me.btn_add_obs.Size = New System.Drawing.Size(34, 30)
        Me.btn_add_obs.TabIndex = 8
        Me.btn_add_obs.Text = "+"
        Me.btn_add_obs.UseVisualStyleBackColor = False
        '
        'btn_add_acr
        '
        Me.btn_add_acr.BackColor = System.Drawing.Color.Green
        Me.btn_add_acr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_acr.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_acr.ForeColor = System.Drawing.Color.White
        Me.btn_add_acr.Location = New System.Drawing.Point(278, 124)
        Me.btn_add_acr.Name = "btn_add_acr"
        Me.btn_add_acr.Size = New System.Drawing.Size(34, 30)
        Me.btn_add_acr.TabIndex = 9
        Me.btn_add_acr.Text = "+"
        Me.btn_add_acr.UseVisualStyleBackColor = False
        '
        'frm_obs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(337, 224)
        Me.Controls.Add(Me.btn_add_acr)
        Me.Controls.Add(Me.btn_add_obs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_acrescentar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_retirar)
        Me.Controls.Add(Me.btn_confirmar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_obs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Observação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents cmb_retirar As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_acrescentar As ComboBox
    Friend WithEvents btn_add_obs As Button
    Friend WithEvents btn_add_acr As Button
End Class
