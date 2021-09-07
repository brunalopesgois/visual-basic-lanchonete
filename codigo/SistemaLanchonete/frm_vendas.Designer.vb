<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_vendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vendas))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btn_saida = New System.Windows.Forms.Button()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_carrinho = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_obs = New System.Windows.Forms.Button()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_suco = New System.Windows.Forms.Button()
        Me.btn_fanta = New System.Windows.Forms.Button()
        Me.btn_coca = New System.Windows.Forms.Button()
        Me.btn_bacon = New System.Windows.Forms.Button()
        Me.btn_salada = New System.Windows.Forms.Button()
        Me.btn_burguer = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv_carrinho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_saida)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_finalizar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_total)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv_carrinho)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_add)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_obs)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_nome)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_preco)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_suco)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_fanta)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_coca)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_bacon)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_salada)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_burguer)
        Me.SplitContainer1.Size = New System.Drawing.Size(916, 522)
        Me.SplitContainer1.SplitterDistance = 558
        Me.SplitContainer1.TabIndex = 0
        '
        'btn_saida
        '
        Me.btn_saida.BackColor = System.Drawing.Color.White
        Me.btn_saida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_saida.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saida.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_saida.Location = New System.Drawing.Point(262, 446)
        Me.btn_saida.Name = "btn_saida"
        Me.btn_saida.Size = New System.Drawing.Size(134, 29)
        Me.btn_saida.TabIndex = 16
        Me.btn_saida.Text = "Lançar Saída"
        Me.btn_saida.UseVisualStyleBackColor = False
        '
        'btn_finalizar
        '
        Me.btn_finalizar.BackColor = System.Drawing.Color.White
        Me.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_finalizar.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_finalizar.Location = New System.Drawing.Point(83, 446)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(134, 29)
        Me.btn_finalizar.TabIndex = 14
        Me.btn_finalizar.Text = "Finalizar Venda"
        Me.btn_finalizar.UseVisualStyleBackColor = False
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(351, 397)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(80, 27)
        Me.txt_total.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(285, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "TOTAL"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(89, 397)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 27)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(36, 400)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Data:"
        '
        'dgv_carrinho
        '
        Me.dgv_carrinho.AllowUserToAddRows = False
        Me.dgv_carrinho.AllowUserToDeleteRows = False
        Me.dgv_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_carrinho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column4, Me.Column3, Me.Column5, Me.Column1})
        Me.dgv_carrinho.Location = New System.Drawing.Point(23, 177)
        Me.dgv_carrinho.Name = "dgv_carrinho"
        Me.dgv_carrinho.ReadOnly = True
        Me.dgv_carrinho.Size = New System.Drawing.Size(513, 206)
        Me.dgv_carrinho.TabIndex = 9
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Obs"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Preço Unitário"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = "Categoria"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 90
        '
        'Column1
        '
        Me.Column1.HeaderText = "Remover"
        Me.Column1.Image = CType(resources.GetObject("Column1.Image"), System.Drawing.Image)
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Green
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_add.Location = New System.Drawing.Point(321, 132)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(169, 29)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Adicionar ao Carrinho"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_obs
        '
        Me.btn_obs.BackColor = System.Drawing.Color.Turquoise
        Me.btn_obs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_obs.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_obs.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_obs.Location = New System.Drawing.Point(198, 132)
        Me.btn_obs.Name = "btn_obs"
        Me.btn_obs.Size = New System.Drawing.Size(101, 29)
        Me.btn_obs.TabIndex = 7
        Me.btn_obs.Text = "Observação"
        Me.btn_obs.UseVisualStyleBackColor = False
        '
        'txt_nome
        '
        Me.txt_nome.Enabled = False
        Me.txt_nome.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(123, 93)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(239, 27)
        Me.txt_nome.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(57, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome: "
        '
        'txt_preco
        '
        Me.txt_preco.Enabled = False
        Me.txt_preco.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco.Location = New System.Drawing.Point(123, 134)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(52, 27)
        Me.txt_preco.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(145, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(57, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Preço:"
        '
        'btn_suco
        '
        Me.btn_suco.BackColor = System.Drawing.Color.Transparent
        Me.btn_suco.BackgroundImage = CType(resources.GetObject("btn_suco.BackgroundImage"), System.Drawing.Image)
        Me.btn_suco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_suco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suco.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suco.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_suco.Location = New System.Drawing.Point(190, 362)
        Me.btn_suco.Name = "btn_suco"
        Me.btn_suco.Size = New System.Drawing.Size(122, 95)
        Me.btn_suco.TabIndex = 22
        Me.btn_suco.Text = "Suco Natural"
        Me.btn_suco.UseVisualStyleBackColor = False
        '
        'btn_fanta
        '
        Me.btn_fanta.BackColor = System.Drawing.Color.Transparent
        Me.btn_fanta.BackgroundImage = CType(resources.GetObject("btn_fanta.BackgroundImage"), System.Drawing.Image)
        Me.btn_fanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_fanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fanta.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fanta.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_fanta.Location = New System.Drawing.Point(39, 362)
        Me.btn_fanta.Name = "btn_fanta"
        Me.btn_fanta.Size = New System.Drawing.Size(122, 95)
        Me.btn_fanta.TabIndex = 21
        Me.btn_fanta.Text = "Fanta"
        Me.btn_fanta.UseVisualStyleBackColor = False
        '
        'btn_coca
        '
        Me.btn_coca.BackColor = System.Drawing.Color.Transparent
        Me.btn_coca.BackgroundImage = CType(resources.GetObject("btn_coca.BackgroundImage"), System.Drawing.Image)
        Me.btn_coca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_coca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_coca.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_coca.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_coca.Location = New System.Drawing.Point(190, 209)
        Me.btn_coca.Name = "btn_coca"
        Me.btn_coca.Size = New System.Drawing.Size(122, 95)
        Me.btn_coca.TabIndex = 20
        Me.btn_coca.Text = "Coca-Cola"
        Me.btn_coca.UseVisualStyleBackColor = False
        '
        'btn_bacon
        '
        Me.btn_bacon.BackColor = System.Drawing.Color.Transparent
        Me.btn_bacon.BackgroundImage = CType(resources.GetObject("btn_bacon.BackgroundImage"), System.Drawing.Image)
        Me.btn_bacon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_bacon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bacon.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bacon.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_bacon.Location = New System.Drawing.Point(39, 209)
        Me.btn_bacon.Name = "btn_bacon"
        Me.btn_bacon.Size = New System.Drawing.Size(122, 95)
        Me.btn_bacon.TabIndex = 19
        Me.btn_bacon.Text = "X Bacon"
        Me.btn_bacon.UseVisualStyleBackColor = False
        '
        'btn_salada
        '
        Me.btn_salada.BackColor = System.Drawing.Color.Transparent
        Me.btn_salada.BackgroundImage = CType(resources.GetObject("btn_salada.BackgroundImage"), System.Drawing.Image)
        Me.btn_salada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_salada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salada.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salada.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_salada.Location = New System.Drawing.Point(190, 58)
        Me.btn_salada.Name = "btn_salada"
        Me.btn_salada.Size = New System.Drawing.Size(122, 95)
        Me.btn_salada.TabIndex = 18
        Me.btn_salada.Text = "X Salada"
        Me.btn_salada.UseVisualStyleBackColor = False
        '
        'btn_burguer
        '
        Me.btn_burguer.BackColor = System.Drawing.Color.Transparent
        Me.btn_burguer.BackgroundImage = CType(resources.GetObject("btn_burguer.BackgroundImage"), System.Drawing.Image)
        Me.btn_burguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_burguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_burguer.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_burguer.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_burguer.Location = New System.Drawing.Point(39, 58)
        Me.btn_burguer.Name = "btn_burguer"
        Me.btn_burguer.Size = New System.Drawing.Size(122, 95)
        Me.btn_burguer.TabIndex = 17
        Me.btn_burguer.Text = "X Burguer"
        Me.btn_burguer.UseVisualStyleBackColor = False
        '
        'frm_vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(916, 522)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_vendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ponto de Venda"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv_carrinho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_obs As Button
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_carrinho As DataGridView
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_saida As Button
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents btn_suco As Button
    Friend WithEvents btn_fanta As Button
    Friend WithEvents btn_coca As Button
    Friend WithEvents btn_bacon As Button
    Friend WithEvents btn_salada As Button
    Friend WithEvents btn_burguer As Button
End Class
