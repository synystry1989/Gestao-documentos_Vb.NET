<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentos))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItemMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GravarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.TxtMorada = New System.Windows.Forms.TextBox()
        Me.TxtNomeCl = New System.Windows.Forms.TextBox()
        Me.TxtTelefone = New System.Windows.Forms.TextBox()
        Me.TxtNIF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbtnDocAtivo = New System.Windows.Forms.RadioButton()
        Me.DataMod = New System.Windows.Forms.DateTimePicker()
        Me.NrDoc = New System.Windows.Forms.NumericUpDown()
        Me.TxtDescricaoDoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboxCodTipoDoc = New System.Windows.Forms.ComboBox()
        Me.BsTipoDoc = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDocumentos = New VMP_exercicio1.DsDocumentos()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBaixo = New System.Windows.Forms.Button()
        Me.BtnCima = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.DgridLinhasProdutos = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CabProdutoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumLinhaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoUntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BsLinhasProdutos = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NrDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgridLinhasProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsLinhasProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemMenu, Me.GravarToolStripMenuItem, Me.NovoToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(972, 45)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ToolStripMenuItemMenu
        '
        Me.ToolStripMenuItemMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.DocumentosToolStripMenuItem, Me.ProdutosToolStripMenuItem})
        Me.ToolStripMenuItemMenu.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItemMenu.Image = CType(resources.GetObject("ToolStripMenuItemMenu.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemMenu.Name = "ToolStripMenuItemMenu"
        Me.ToolStripMenuItemMenu.Size = New System.Drawing.Size(39, 41)
        Me.ToolStripMenuItemMenu.Text = " "
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.ClientesToolStripMenuItem.Enabled = False
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes                 F4"
        '
        'DocumentosToolStripMenuItem
        '
        Me.DocumentosToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.DocumentosToolStripMenuItem.Enabled = False
        Me.DocumentosToolStripMenuItem.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentosToolStripMenuItem.Image = CType(resources.GetObject("DocumentosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DocumentosToolStripMenuItem.Name = "DocumentosToolStripMenuItem"
        Me.DocumentosToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.DocumentosToolStripMenuItem.Text = "Documentos     Tab+F4"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.ProdutosToolStripMenuItem.Enabled = False
        Me.ProdutosToolStripMenuItem.Image = CType(resources.GetObject("ProdutosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ProdutosToolStripMenuItem.Text = "Produtos             Novo"
        '
        'GravarToolStripMenuItem
        '
        Me.GravarToolStripMenuItem.AutoSize = False
        Me.GravarToolStripMenuItem.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GravarToolStripMenuItem.Image = CType(resources.GetObject("GravarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GravarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GravarToolStripMenuItem.Name = "GravarToolStripMenuItem"
        Me.GravarToolStripMenuItem.Size = New System.Drawing.Size(94, 41)
        Me.GravarToolStripMenuItem.Text = "Gravar"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.AutoSize = False
        Me.NovoToolStripMenuItem.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NovoToolStripMenuItem.Image = CType(resources.GetObject("NovoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(94, 41)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.AutoSize = False
        Me.EliminarToolStripMenuItem.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(114, 41)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.AutoSize = False
        Me.SairToolStripMenuItem.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(74, 41)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 45)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnBaixo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnCima)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnEliminar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnNovo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DgridLinhasProdutos)
        Me.SplitContainer1.Size = New System.Drawing.Size(972, 634)
        Me.SplitContainer1.SplitterDistance = 184
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtCliente)
        Me.Panel2.Controls.Add(Me.TxtMorada)
        Me.Panel2.Controls.Add(Me.TxtNomeCl)
        Me.Panel2.Controls.Add(Me.TxtTelefone)
        Me.Panel2.Controls.Add(Me.TxtNIF)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(23, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(928, 78)
        Me.Panel2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(660, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "NIF:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(660, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Contato:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Morada:"
        '
        'TxtCliente
        '
        Me.TxtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(157, 13)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(82, 23)
        Me.TxtCliente.TabIndex = 7
        '
        'TxtMorada
        '
        Me.TxtMorada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMorada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMorada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMorada.Location = New System.Drawing.Point(242, 39)
        Me.TxtMorada.Name = "TxtMorada"
        Me.TxtMorada.Size = New System.Drawing.Size(412, 22)
        Me.TxtMorada.TabIndex = 3
        '
        'TxtNomeCl
        '
        Me.TxtNomeCl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNomeCl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNomeCl.Enabled = False
        Me.TxtNomeCl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomeCl.Location = New System.Drawing.Point(242, 13)
        Me.TxtNomeCl.Name = "TxtNomeCl"
        Me.TxtNomeCl.Size = New System.Drawing.Size(412, 22)
        Me.TxtNomeCl.TabIndex = 4
        '
        'TxtTelefone
        '
        Me.TxtTelefone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefone.Location = New System.Drawing.Point(728, 12)
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Size = New System.Drawing.Size(190, 22)
        Me.TxtTelefone.TabIndex = 5
        '
        'TxtNIF
        '
        Me.TxtNIF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNIF.Location = New System.Drawing.Point(728, 39)
        Me.TxtNIF.Name = "TxtNIF"
        Me.TxtNIF.Size = New System.Drawing.Size(190, 22)
        Me.TxtNIF.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.RbtnDocAtivo)
        Me.Panel1.Controls.Add(Me.DataMod)
        Me.Panel1.Controls.Add(Me.NrDoc)
        Me.Panel1.Controls.Add(Me.TxtDescricaoDoc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CboxCodTipoDoc)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(23, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 53)
        Me.Panel1.TabIndex = 0
        '
        'RbtnDocAtivo
        '
        Me.RbtnDocAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbtnDocAtivo.Checked = True
        Me.RbtnDocAtivo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnDocAtivo.Location = New System.Drawing.Point(551, 18)
        Me.RbtnDocAtivo.Name = "RbtnDocAtivo"
        Me.RbtnDocAtivo.Size = New System.Drawing.Size(54, 18)
        Me.RbtnDocAtivo.TabIndex = 9
        Me.RbtnDocAtivo.TabStop = True
        Me.RbtnDocAtivo.Text = "Ativo"
        Me.RbtnDocAtivo.UseVisualStyleBackColor = True
        '
        'DataMod
        '
        Me.DataMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataMod.Location = New System.Drawing.Point(728, 18)
        Me.DataMod.Name = "DataMod"
        Me.DataMod.Size = New System.Drawing.Size(190, 22)
        Me.DataMod.TabIndex = 4
        '
        'NrDoc
        '
        Me.NrDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NrDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NrDoc.Location = New System.Drawing.Point(478, 15)
        Me.NrDoc.Name = "NrDoc"
        Me.NrDoc.Size = New System.Drawing.Size(64, 22)
        Me.NrDoc.TabIndex = 2
        '
        'TxtDescricaoDoc
        '
        Me.TxtDescricaoDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescricaoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescricaoDoc.Enabled = False
        Me.TxtDescricaoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescricaoDoc.Location = New System.Drawing.Point(242, 15)
        Me.TxtDescricaoDoc.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.TxtDescricaoDoc.Name = "TxtDescricaoDoc"
        Me.TxtDescricaoDoc.Size = New System.Drawing.Size(233, 22)
        Me.TxtDescricaoDoc.TabIndex = 0
        Me.TxtDescricaoDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(634, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Alterado em:"
        '
        'CboxCodTipoDoc
        '
        Me.CboxCodTipoDoc.DataSource = Me.BsTipoDoc
        Me.CboxCodTipoDoc.DisplayMember = "CodigoDoc"
        Me.CboxCodTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxCodTipoDoc.FormattingEnabled = True
        Me.CboxCodTipoDoc.Location = New System.Drawing.Point(157, 15)
        Me.CboxCodTipoDoc.Name = "CboxCodTipoDoc"
        Me.CboxCodTipoDoc.Size = New System.Drawing.Size(82, 23)
        Me.CboxCodTipoDoc.TabIndex = 1
        Me.CboxCodTipoDoc.ValueMember = "CodigoDoc"
        '
        'BsTipoDoc
        '
        Me.BsTipoDoc.DataMember = "TipoDocumentos"
        Me.BsTipoDoc.DataSource = Me.DsDocumentos
        '
        'DsDocumentos
        '
        Me.DsDocumentos.DataSetName = "DsDocumentos"
        Me.DsDocumentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Documento"
        '
        'BtnBaixo
        '
        Me.BtnBaixo.BackColor = System.Drawing.Color.Silver
        Me.BtnBaixo.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBaixo.Location = New System.Drawing.Point(311, 3)
        Me.BtnBaixo.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.BtnBaixo.Name = "BtnBaixo"
        Me.BtnBaixo.Size = New System.Drawing.Size(93, 40)
        Me.BtnBaixo.TabIndex = 4
        Me.BtnBaixo.Text = "Baixo"
        Me.BtnBaixo.UseVisualStyleBackColor = False
        '
        'BtnCima
        '
        Me.BtnCima.BackColor = System.Drawing.Color.Silver
        Me.BtnCima.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCima.Location = New System.Drawing.Point(215, 3)
        Me.BtnCima.Name = "BtnCima"
        Me.BtnCima.Size = New System.Drawing.Size(93, 40)
        Me.BtnCima.TabIndex = 3
        Me.BtnCima.Text = "Cima"
        Me.BtnCima.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Silver
        Me.BtnEliminar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(119, 3)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(93, 40)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnNovo
        '
        Me.BtnNovo.BackColor = System.Drawing.Color.Silver
        Me.BtnNovo.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.Location = New System.Drawing.Point(23, 3)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(93, 40)
        Me.BtnNovo.TabIndex = 1
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = False
        '
        'DgridLinhasProdutos
        '
        Me.DgridLinhasProdutos.AllowUserToAddRows = False
        Me.DgridLinhasProdutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgridLinhasProdutos.AutoGenerateColumns = False
        Me.DgridLinhasProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgridLinhasProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgridLinhasProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridLinhasProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CabProdutoIDDataGridViewTextBoxColumn, Me.NumLinhaDataGridViewTextBoxColumn, Me.ProdutoDataGridViewTextBoxColumn, Me.DescricaoDataGridViewTextBoxColumn, Me.PrecoUntDataGridViewTextBoxColumn, Me.QuantidadeDataGridViewTextBoxColumn, Me.DataEntregaDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DgridLinhasProdutos.DataSource = Me.BsLinhasProdutos
        Me.DgridLinhasProdutos.Location = New System.Drawing.Point(23, 49)
        Me.DgridLinhasProdutos.Name = "DgridLinhasProdutos"
        Me.DgridLinhasProdutos.Size = New System.Drawing.Size(928, 385)
        Me.DgridLinhasProdutos.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'CabProdutoIDDataGridViewTextBoxColumn
        '
        Me.CabProdutoIDDataGridViewTextBoxColumn.DataPropertyName = "CabProdutoID"
        Me.CabProdutoIDDataGridViewTextBoxColumn.HeaderText = "CabProdutoID"
        Me.CabProdutoIDDataGridViewTextBoxColumn.Name = "CabProdutoIDDataGridViewTextBoxColumn"
        Me.CabProdutoIDDataGridViewTextBoxColumn.Visible = False
        '
        'NumLinhaDataGridViewTextBoxColumn
        '
        Me.NumLinhaDataGridViewTextBoxColumn.DataPropertyName = "NumLinha"
        Me.NumLinhaDataGridViewTextBoxColumn.HeaderText = "#"
        Me.NumLinhaDataGridViewTextBoxColumn.Name = "NumLinhaDataGridViewTextBoxColumn"
        '
        'ProdutoDataGridViewTextBoxColumn
        '
        Me.ProdutoDataGridViewTextBoxColumn.DataPropertyName = "Produto"
        Me.ProdutoDataGridViewTextBoxColumn.HeaderText = "Produto"
        Me.ProdutoDataGridViewTextBoxColumn.Name = "ProdutoDataGridViewTextBoxColumn"
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        '
        'PrecoUntDataGridViewTextBoxColumn
        '
        Me.PrecoUntDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnt"
        Me.PrecoUntDataGridViewTextBoxColumn.HeaderText = "PrecoUnt"
        Me.PrecoUntDataGridViewTextBoxColumn.Name = "PrecoUntDataGridViewTextBoxColumn"
        '
        'QuantidadeDataGridViewTextBoxColumn
        '
        Me.QuantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.Name = "QuantidadeDataGridViewTextBoxColumn"
        '
        'DataEntregaDataGridViewTextBoxColumn
        '
        Me.DataEntregaDataGridViewTextBoxColumn.DataPropertyName = "DataEntrega"
        Me.DataEntregaDataGridViewTextBoxColumn.HeaderText = "DataEntrega"
        Me.DataEntregaDataGridViewTextBoxColumn.Name = "DataEntregaDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'BsLinhasProdutos
        '
        Me.BsLinhasProdutos.DataMember = "LinhasProdutos"
        Me.BsLinhasProdutos.DataSource = Me.DsDocumentos
        '
        'FrmDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(972, 679)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edito de Documentos"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NrDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgridLinhasProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsLinhasProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ToolStripMenuItemMenu As ToolStripMenuItem
    Friend WithEvents GravarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DgridLinhasProdutos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents CboxCodTipoDoc As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents TxtMorada As TextBox
    Friend WithEvents TxtTelefone As TextBox
    Friend WithEvents TxtNIF As TextBox
    Friend WithEvents TxtDescricaoDoc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RbtnDocAtivo As RadioButton
    Friend WithEvents DataMod As DateTimePicker
    Friend WithEvents NrDoc As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNomeCl As TextBox
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnBaixo As Button
    Friend WithEvents BtnCima As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DsDocumentos As DsDocumentos
    Friend WithEvents BsTipoDoc As BindingSource
    Friend WithEvents BsLinhasProdutos As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CabProdutoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumLinhaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdutoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecoUntDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataEntregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
End Class
