<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.mtp_menu = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PONTODEVENDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTROLEDEESTOQUEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RELATÓRIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasNoMêsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasESaídasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListagemDoEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USUÁRIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarNovoUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_usuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_data = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mtp_menu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtp_menu
        '
        Me.mtp_menu.BackColor = System.Drawing.Color.White
        Me.mtp_menu.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtp_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.PONTODEVENDAToolStripMenuItem, Me.CONTROLEDEESTOQUEToolStripMenuItem, Me.RELATÓRIOSToolStripMenuItem, Me.USUÁRIOToolStripMenuItem})
        Me.mtp_menu.Location = New System.Drawing.Point(0, 0)
        Me.mtp_menu.Name = "mtp_menu"
        Me.mtp_menu.Size = New System.Drawing.Size(800, 27)
        Me.mtp_menu.TabIndex = 0
        Me.mtp_menu.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 23)
        '
        'PONTODEVENDAToolStripMenuItem
        '
        Me.PONTODEVENDAToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.PONTODEVENDAToolStripMenuItem.ForeColor = System.Drawing.Color.Gold
        Me.PONTODEVENDAToolStripMenuItem.Image = CType(resources.GetObject("PONTODEVENDAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PONTODEVENDAToolStripMenuItem.Name = "PONTODEVENDAToolStripMenuItem"
        Me.PONTODEVENDAToolStripMenuItem.Size = New System.Drawing.Size(170, 23)
        Me.PONTODEVENDAToolStripMenuItem.Text = "&PONTO DE VENDA"
        '
        'CONTROLEDEESTOQUEToolStripMenuItem
        '
        Me.CONTROLEDEESTOQUEToolStripMenuItem.ForeColor = System.Drawing.Color.Gold
        Me.CONTROLEDEESTOQUEToolStripMenuItem.Image = CType(resources.GetObject("CONTROLEDEESTOQUEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CONTROLEDEESTOQUEToolStripMenuItem.Name = "CONTROLEDEESTOQUEToolStripMenuItem"
        Me.CONTROLEDEESTOQUEToolStripMenuItem.Size = New System.Drawing.Size(216, 23)
        Me.CONTROLEDEESTOQUEToolStripMenuItem.Text = "&CONTROLE DE ESTOQUE"
        '
        'RELATÓRIOSToolStripMenuItem
        '
        Me.RELATÓRIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendasNoMêsToolStripMenuItem, Me.EntradasESaídasToolStripMenuItem, Me.ListagemDoEstoqueToolStripMenuItem})
        Me.RELATÓRIOSToolStripMenuItem.Enabled = False
        Me.RELATÓRIOSToolStripMenuItem.ForeColor = System.Drawing.Color.Gold
        Me.RELATÓRIOSToolStripMenuItem.Image = CType(resources.GetObject("RELATÓRIOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RELATÓRIOSToolStripMenuItem.Name = "RELATÓRIOSToolStripMenuItem"
        Me.RELATÓRIOSToolStripMenuItem.Size = New System.Drawing.Size(131, 23)
        Me.RELATÓRIOSToolStripMenuItem.Text = "&RELATÓRIOS"
        '
        'VendasNoMêsToolStripMenuItem
        '
        Me.VendasNoMêsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.VendasNoMêsToolStripMenuItem.Enabled = False
        Me.VendasNoMêsToolStripMenuItem.ForeColor = System.Drawing.Color.Gold
        Me.VendasNoMêsToolStripMenuItem.Image = CType(resources.GetObject("VendasNoMêsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VendasNoMêsToolStripMenuItem.Name = "VendasNoMêsToolStripMenuItem"
        Me.VendasNoMêsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.VendasNoMêsToolStripMenuItem.Size = New System.Drawing.Size(278, 24)
        Me.VendasNoMêsToolStripMenuItem.Text = "Vendas no Mês"
        '
        'EntradasESaídasToolStripMenuItem
        '
        Me.EntradasESaídasToolStripMenuItem.Enabled = False
        Me.EntradasESaídasToolStripMenuItem.ForeColor = System.Drawing.Color.Gold
        Me.EntradasESaídasToolStripMenuItem.Image = CType(resources.GetObject("EntradasESaídasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EntradasESaídasToolStripMenuItem.Name = "EntradasESaídasToolStripMenuItem"
        Me.EntradasESaídasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.EntradasESaídasToolStripMenuItem.Size = New System.Drawing.Size(278, 24)
        Me.EntradasESaídasToolStripMenuItem.Text = "Entradas e Saídas"
        '
        'ListagemDoEstoqueToolStripMenuItem
        '
        Me.ListagemDoEstoqueToolStripMenuItem.Enabled = False
        Me.ListagemDoEstoqueToolStripMenuItem.ForeColor = System.Drawing.Color.Gold
        Me.ListagemDoEstoqueToolStripMenuItem.Image = CType(resources.GetObject("ListagemDoEstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListagemDoEstoqueToolStripMenuItem.Name = "ListagemDoEstoqueToolStripMenuItem"
        Me.ListagemDoEstoqueToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ListagemDoEstoqueToolStripMenuItem.Size = New System.Drawing.Size(278, 24)
        Me.ListagemDoEstoqueToolStripMenuItem.Text = "Listagem do Estoque"
        '
        'USUÁRIOToolStripMenuItem
        '
        Me.USUÁRIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarNovoUsuárioToolStripMenuItem, Me.EncerrarSessãoToolStripMenuItem})
        Me.USUÁRIOToolStripMenuItem.ForeColor = System.Drawing.Color.Gold
        Me.USUÁRIOToolStripMenuItem.Image = CType(resources.GetObject("USUÁRIOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.USUÁRIOToolStripMenuItem.Name = "USUÁRIOToolStripMenuItem"
        Me.USUÁRIOToolStripMenuItem.Size = New System.Drawing.Size(105, 23)
        Me.USUÁRIOToolStripMenuItem.Text = "&USUÁRIO"
        '
        'CadastrarNovoUsuárioToolStripMenuItem
        '
        Me.CadastrarNovoUsuárioToolStripMenuItem.Enabled = False
        Me.CadastrarNovoUsuárioToolStripMenuItem.ForeColor = System.Drawing.Color.Gold
        Me.CadastrarNovoUsuárioToolStripMenuItem.Image = CType(resources.GetObject("CadastrarNovoUsuárioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrarNovoUsuárioToolStripMenuItem.Name = "CadastrarNovoUsuárioToolStripMenuItem"
        Me.CadastrarNovoUsuárioToolStripMenuItem.Size = New System.Drawing.Size(243, 24)
        Me.CadastrarNovoUsuárioToolStripMenuItem.Text = "Cadastrar Novo Usuário"
        '
        'EncerrarSessãoToolStripMenuItem
        '
        Me.EncerrarSessãoToolStripMenuItem.ForeColor = System.Drawing.Color.Gold
        Me.EncerrarSessãoToolStripMenuItem.Image = CType(resources.GetObject("EncerrarSessãoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EncerrarSessãoToolStripMenuItem.Name = "EncerrarSessãoToolStripMenuItem"
        Me.EncerrarSessãoToolStripMenuItem.Size = New System.Drawing.Size(243, 24)
        Me.EncerrarSessãoToolStripMenuItem.Text = "Encerrar Sessão"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Goldenrod
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_usuario, Me.lbl_data})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 426)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 24)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(158, 19)
        Me.lbl_usuario.Text = "ToolStripStatusLabel1"
        '
        'lbl_data
        '
        Me.lbl_data.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.ForeColor = System.Drawing.Color.White
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(158, 19)
        Me.lbl_data.Text = "ToolStripStatusLabel2"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mtp_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mtp_menu
        Me.Name = "frm_menu"
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mtp_menu.ResumeLayout(False)
        Me.mtp_menu.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtp_menu As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PONTODEVENDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTROLEDEESTOQUEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RELATÓRIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasNoMêsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasESaídasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListagemDoEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbl_usuario As ToolStripStatusLabel
    Friend WithEvents lbl_data As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents USUÁRIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarNovoUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
End Class
