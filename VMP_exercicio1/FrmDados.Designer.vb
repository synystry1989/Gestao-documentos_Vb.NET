<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDados))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.VoltarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OkToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DgridViewDados = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgridViewDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Silver
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoltarToolStripButton, Me.OkToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 37)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'VoltarToolStripButton
        '
        Me.VoltarToolStripButton.AutoSize = False
        Me.VoltarToolStripButton.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoltarToolStripButton.Image = CType(resources.GetObject("VoltarToolStripButton.Image"), System.Drawing.Image)
        Me.VoltarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.VoltarToolStripButton.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.VoltarToolStripButton.Name = "VoltarToolStripButton"
        Me.VoltarToolStripButton.Size = New System.Drawing.Size(75, 40)
        Me.VoltarToolStripButton.Text = "Voltar"
        Me.VoltarToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OkToolStripButton
        '
        Me.OkToolStripButton.AutoSize = False
        Me.OkToolStripButton.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkToolStripButton.Image = CType(resources.GetObject("OkToolStripButton.Image"), System.Drawing.Image)
        Me.OkToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OkToolStripButton.Name = "OkToolStripButton"
        Me.OkToolStripButton.Size = New System.Drawing.Size(65, 40)
        Me.OkToolStripButton.Text = "Ok"
        Me.OkToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DgridViewDados
        '
        Me.DgridViewDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridViewDados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgridViewDados.Location = New System.Drawing.Point(0, 37)
        Me.DgridViewDados.Name = "DgridViewDados"
        Me.DgridViewDados.Size = New System.Drawing.Size(800, 413)
        Me.DgridViewDados.TabIndex = 1
        '
        'FrmDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DgridViewDados)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DgridViewDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents VoltarToolStripButton As ToolStripButton
    Friend WithEvents DgridViewDados As DataGridView
    Friend WithEvents OkToolStripButton As ToolStripButton
End Class
