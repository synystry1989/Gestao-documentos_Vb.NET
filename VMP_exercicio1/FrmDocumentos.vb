Imports VMP_exercicio1.DsDocumentos

Public Class FrmDocumentos

    Private Sub FrmDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CarregarTabelas()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub NrDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles NrDoc.KeyDown
        If e.KeyCode = Keys.F4 Then
            '^sabemos com o clear e o fill que temos os dados atualizados 
            DsDocumentos.CarregaCabecDoc()
            FrmDados.ShowDialog(DsDocumentos.CabecDocumento)
            If FrmDados.DialogResult = DialogResult.OK Then
                Dim rowEscolhida As CabecDocumentoRow = FrmDados.RowSelecionada
                CboxCodTipoDoc.Text = rowEscolhida.TipoDocumento
                TxtDescricaoDoc.Text = DsDocumentos.DaTipoDocumento(CboxCodTipoDoc.Text)
                NrDoc.Value = DsDocumentos.DaNrDocSeguinte(CboxCodTipoDoc.Text)
                TxtCliente.Text = rowEscolhida.Cliente
                TxtNomeCl.Text = DsDocumentos.DaNomeCliente(TxtCliente.Text)
                TxtTelefone.Text = rowEscolhida.Telefone
                TxtMorada.Text = rowEscolhida.Morada
                TxtNIF.Text = rowEscolhida.NIF
                RbtnDocAtivo.Checked = rowEscolhida.Estado
                DsDocumentos.CarregaLinhasProd(rowEscolhida.ID)
                DataMod.Text = rowEscolhida.DataModificacao
            End If
        End If
    End Sub
    Private Sub RbtnDocAtivo_MouseClick(sender As Object, e As EventArgs) Handles RbtnDocAtivo.MouseClick
        Try
            If RbtnDocAtivo.Checked = True Then
                HabilitarCampos()
                HabilitarButoes()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub NrDoc_Leave(sender As Object, e As EventArgs) Handles NrDoc.Leave
        Try
            If NrDoc.Value > 0 Then
                Dim rowCabec As CabecDocumentoRow = DsDocumentos.PesquisarCabecDoc(CboxCodTipoDoc.Text, NrDoc.Value)
                If rowCabec.Cliente <> "" Then
                    PreencheCabecDoc()
                Else
                    NrDoc.Value = DsDocumentos.DaNrDocSeguinte(CboxCodTipoDoc.Text)
                    Limpar()
                    RbtnDocAtivo.Checked = True
                    HabilitarButoes()
                    HabilitarCampos()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TxtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCliente.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                '^sabemos com o clear e o fill que temos os dados atualizados 
                DsDocumentos.CarregaClientes()
                FrmDados.ShowDialog(DsDocumentos.Clientes)
                If FrmDados.DialogResult = DialogResult.OK Then
                    Dim rowEscolhida As ClientesRow = FrmDados.RowSelecionada
                    If rowEscolhida.Estado = True Then
                        TxtCliente.Text = rowEscolhida.CodigoCl
                        TxtNomeCl.Text = rowEscolhida.Nome
                        TxtTelefone.Text = rowEscolhida.Telefone
                        TxtMorada.Text = rowEscolhida.Morada
                        TxtNIF.Text = rowEscolhida.NIF
                    End If
                End If
            End If
            FrmDados.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Try
            LimparFormulario()
            HabilitarCampos()
            HabilitarButoes()
            DsDocumentos.CabecDocumento.Clear()
            DsDocumentos.LinhasProdutos.Clear()
            DsDocumentos.Novo()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub GravarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GravarToolStripMenuItem.Click
        Try
            Dim rowAtual = DsDocumentos.CabecDocumento(0)
            If IsValidInput() Then

                rowAtual.TipoDocumento = CboxCodTipoDoc.Text
                rowAtual.NrDocumento = NrDoc.Value
                rowAtual.Cliente = TxtCliente.Text
                rowAtual.Telefone = TxtTelefone.Text
                rowAtual.NIF = TxtNIF.Text
                rowAtual.Morada = TxtMorada.Text
                rowAtual.DataModificacao = DateTime.Now()
                rowAtual.Estado = RbtnDocAtivo.Checked
                DsDocumentos.AtualizarDoc()
                LimparFormulario()
            End If
        Catch ex As Exception

            MessageBox.Show("Erro ao gravar: " & ex.Message)
        End Try
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            Dim yesNo As DialogResult = MessageBox.Show("Deseja Eliminar o Documento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If DsDocumentos.CabecDocumento(0) IsNot Nothing AndAlso yesNo = DialogResult.Yes Then
                DsDocumentos.CabecDocumento(0).Estado = False
                DesabilitarButoes()
                DesabilitarCampos()
                DsDocumentos.UpdateCabecDoc()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub PreencheCabecDoc()
        Try
            Dim cabRow As CabecDocumentoRow = DsDocumentos.PesquisarCabecDoc(CboxCodTipoDoc.Text, NrDoc.Value)
            TxtCliente.Text = cabRow.Cliente
            TxtNomeCl.Text = DsDocumentos.DaNomeCliente(TxtCliente.Text)
            DataMod.Text = cabRow.DataModificacao
            TxtMorada.Text = cabRow.Morada
            TxtTelefone.Text = cabRow.Telefone
            TxtNIF.Text = cabRow.NIF
            RbtnDocAtivo.Checked = cabRow.Estado
            DsDocumentos.CarregaLinhasProd(cabRow.ID)
            HabilitarCampos()
            If cabRow.Estado = False Then
                DesabilitarCampos()
                DesabilitarButoes()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Try
            DsDocumentos.CarregaProdutos()
            FrmDados.ShowDialog(DsDocumentos.Produtos)
            If FrmDados.DialogResult = DialogResult.OK Then
                Dim rowEscolhida As ProdutosRow = FrmDados.RowSelecionada
                DsDocumentos.NovaLinhaProd(rowEscolhida)

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If DgridLinhasProdutos.CurrentRow.Cells.Count > 0 Then
                Dim id As Guid = DgridLinhasProdutos.CurrentRow().Cells("IDDataGridViewTextBoxColumn").Value
                DsDocumentos.EliminarLinha(id)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao eliminar: " & ex.Message)
        End Try
    End Sub
    Private Sub BtnCima_Click(sender As Object, e As EventArgs) Handles BtnCima.Click
        Try
            If DgridLinhasProdutos.CurrentRow.Cells.Count > 0 Then
                Dim id As Guid = DgridLinhasProdutos.CurrentRow().Cells("IDDataGridViewTextBoxColumn").Value
                DsDocumentos.SubirLinha(id)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub BtnBaixo_Click(sender As Object, e As EventArgs) Handles BtnBaixo.Click
        Try
            If DgridLinhasProdutos.CurrentRow.Cells.Count > 0 Then
                Dim id As Guid = DgridLinhasProdutos.CurrentRow().Cells("IDDataGridViewTextBoxColumn").Value
                DsDocumentos.DescerLinha(id)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Function IsValidInput() As Boolean
        Try
            Return Not String.IsNullOrWhiteSpace(TxtCliente.Text) AndAlso
           Not String.IsNullOrWhiteSpace(TxtNomeCl.Text) AndAlso
           Not String.IsNullOrWhiteSpace(TxtTelefone.Text) AndAlso
           Not String.IsNullOrWhiteSpace(TxtMorada.Text) AndAlso
           Not String.IsNullOrWhiteSpace(TxtNIF.Text) AndAlso
           Not String.IsNullOrWhiteSpace(DataMod.Text) AndAlso
           Not String.IsNullOrEmpty(CboxCodTipoDoc.Text) AndAlso
           Not String.IsNullOrWhiteSpace(TxtDescricaoDoc.Text) AndAlso
           Not String.IsNullOrEmpty(NrDoc.Value)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub DesabilitarCampos()
        DataMod.Enabled = False
        TxtCliente.Enabled = False
        TxtTelefone.Enabled = False
        TxtMorada.Enabled = False
        TxtNIF.Enabled = False
        RbtnDocAtivo.Checked = False
    End Sub
    Public Sub HabilitarCampos()
        DataMod.Enabled = True
        TxtCliente.Enabled = True
        TxtTelefone.Enabled = True
        TxtMorada.Enabled = True
        TxtNIF.Enabled = True
    End Sub

    Public Sub Limpar()
        DataMod.Text = ""
        TxtNomeCl.Text = ""
        TxtCliente.Text = ""
        TxtTelefone.Text = ""
        TxtMorada.Text = ""
        TxtNIF.Text = String.Empty
        DsDocumentos.LinhasProdutos.Clear()
    End Sub
    Public Sub LimparFormulario()
        NrDoc.Value = 0
        CboxCodTipoDoc.Text = ""
        TxtDescricaoDoc.Text = ""
        DataMod.Text = ""
        TxtNomeCl.Text = ""
        TxtCliente.Text = ""
        TxtTelefone.Text = ""
        TxtMorada.Text = ""
        TxtNIF.Text = String.Empty
        DsDocumentos.LinhasProdutos.Clear()
    End Sub
    Public Sub DesabilitarButoes()
        BtnNovo.Enabled = False
        BtnEliminar.Enabled = False
        BtnCima.Enabled = False
        BtnBaixo.Enabled = False
        GravarToolStripMenuItem.Enabled = False
        EliminarToolStripMenuItem.Enabled = False
    End Sub
    Public Sub HabilitarButoes()
        BtnNovo.Enabled = True
        BtnEliminar.Enabled = True
        BtnCima.Enabled = True
        BtnBaixo.Enabled = True
        GravarToolStripMenuItem.Enabled = True
        EliminarToolStripMenuItem.Enabled = True
    End Sub
    Public Sub FormatarTabelaLinhas()
        DgridLinhasProdutos.Columns("IDDataGridViewTextBoxColumn").Visible = False
        DgridLinhasProdutos.Columns("CabProdutoIDDataGridViewTextBoxColumn").Visible = False
        DgridLinhasProdutos.Sort(DgridLinhasProdutos.Columns("NumLinhaDataGridViewTextBoxColumn"), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Public Sub CarregarTabelas()
        Try
            CboxCodTipoDoc.Focus()
            DsDocumentos.CarregaTipodoc()
            CboxCodTipoDoc.Text = ""
            'arredondamos os valores que recebemos do binding source para a nivel visual apenas estar formatado na nossa datagrid em duas casas decimais
            DgridLinhasProdutos.Columns("QuantidadeDataGridViewTextBoxColumn").DefaultCellStyle.Format = "F2"
            DgridLinhasProdutos.Columns("PrecoUntDataGridViewTextBoxColumn").DefaultCellStyle.Format = "F2"
            FormatarTabelaLinhas()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub CboxCodTipoDoc_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboxCodTipoDoc.SelectedValueChanged
        Try
            TxtDescricaoDoc.Text = DsDocumentos.DaTipoDocumento(CboxCodTipoDoc.Text)
            NrDoc.Value = DsDocumentos.DaNrDocSeguinte(CboxCodTipoDoc.Text)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    'com tabela de dados a carregar clientes nao necessito
    'Public Function DaCodCliente(dgView As DataGridView) As String

    '    Try
    '        'obter o id do produto por meio de selecao no datagrid
    '        If dgView.SelectedRows.Count > 0 Then
    '            Dim selectedRow As DataGridViewRow = dgView.SelectedRows(0)
    '            Dim CodCl As String = selectedRow.Cells("CodigoClDataGridViewTextBoxColumn").Value
    '            Return CodCl
    '        End If
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try

    'End Function
    'Public Function DaCliente(codCliente As String) As ClientesRow

    '    Try
    '        CarregaTabelaClientes()
    '        'linq onde obtemos uma row, instanciar a row no formulario para receber parametros
    '        If Clientes.Where(Function(x) x.CodigoCl.Equals(codCliente)).Count() > 0 Then
    '            Return Clientes.Where(Function(x) x.CodigoCl.Equals(codCliente)).FirstOrDefault()
    '        End If
    '        Return Nothing
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Function

    ' APRENDIZAGEM
    '  
    'aprendizagem
    ' Dim CodCl As String = selectedRow.Cells("CodigoClDataGridViewTextBoxColumn").Value
    'rowIndex = ListaProdutos.Rows.IndexOf(row)
    'row.Item(rowIndex).SetOrdinal(rowIndex - 1)

    'se nececitassemos de adicionar uma linha nova nao existente
    'ListaProdutos.Rows.Add(rowProd)

    'LINQ
    ' Dim row As ListaProdutosRow = DsDocumentos.ListaProdutos.Where(Function(x) x.ID = id).FirstOrDefault()

    'linq "scalar" retorna apenas um resultado sem nececidade instanciar 
    'Return Clientes.Where(Function(x) x.CodigoCl.Equals(codCliente)).FirstOrDefault().Nome
    'Return Clientes.Where(Function(x) x.CodigoCl.Equals(codCliente)).Select(Function(x) x.Nome).FirstOrDefault()

    'TROCA VARIAVEIS

    '    Dim tempValue As Object = row1.Cells("NumLinhaDataGridViewTextBoxColumn").Value
    '    row1.Cells("NumLinhaDataGridViewTextBoxColumn").Value = row2.Cells("NumLinhaDataGridViewTextBoxColumn").Value
    '    row2.Cells("NumLinhaDataGridViewTextBoxColumn").Value = tempValue

    'ACESSAR INDEX DATATABLE
    'Dim rowIndex = DsDocumentos.ListaProdutos.Rows.IndexOf(row)
    'Dim minhaRow As DataRow = DsDocumentos.ListaProdutos.Rows(rowIndex)

    'adicionar a linha na ordem desejada
    'LinhasProdutos.Rows.InsertAt(linhaNova, linhaIndex)

    'adicionar manualmente a binding source a datagrid(apenas Exemplar)
    ' DgridListaProdutos.DataSource = BsLinhasProd
End Class
