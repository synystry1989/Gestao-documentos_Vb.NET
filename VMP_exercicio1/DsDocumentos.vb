Imports VMP_exercicio1.DsDocumentosTableAdapters

Partial Class DsDocumentos

    Dim AdpLinhasProdutos As New LinhasProdutosTableAdapter
    Dim AdpClientes As New ClientesTableAdapter
    Dim AdpProdutos As New ProdutosTableAdapter
    Dim AdpCabecDoc As New CabecDocumentoTableAdapter
    Dim AdpTipoDoc As New TipoDocumentosTableAdapter
    Dim AdpQuerryUltNrEmitido As New QueriesTableAdapter

    Public Sub CarregaClientes()
        Try
            Clientes.Clear()
            AdpClientes.Fill(Clientes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub CarregaProdutos()
        Try
            Produtos.Clear()
            AdpProdutos.Fill(Produtos)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub CarregaTipodoc()
        Try
            TipoDocumentos.Clear()
            AdpTipoDoc.Fill(TipoDocumentos)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub CarregaCabecDoc()
        Try
            CabecDocumento.Clear()
            AdpCabecDoc.Fill(CabecDocumento)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub CarregaLinhasProd(ByVal cabecID As Guid)
        Try
            LinhasProdutos.Clear()
            AdpLinhasProdutos.FillByCabecId(LinhasProdutos, cabecID)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub UpdateCabecDoc()
        Try
            AdpCabecDoc.Update(CabecDocumento)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub UpdateLinhas()
        Try
            AdpLinhasProdutos.Update(LinhasProdutos)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Partial Public Class LinhasProdutosDataTable
        Dim TotalUpdate As Boolean = False
        Private Sub ChangeRow(sender As Object, e As LinhasProdutosRowChangeEvent) Handles Me.LinhasProdutosRowChanged
            Try
                'calcular o total a cada row inseridaTry
                If Not TotalUpdate Then
                    TotalUpdate = True

                    Dim total As Decimal = e.Row.Quantidade * e.Row.PrecoUnt
                    'arredondamos o valor recebido do dataTable
                    e.Row.Total = Math.Round(total, 2)
                End If
                TotalUpdate = False
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub
    End Class
    Public Function DaTipoDocumento(ByVal codDoc As String) As String
        Try
            If TipoDocumentos.Where(Function(x) x.CodigoDoc.Equals(codDoc)).Select(Function(x) x.Descricao).FirstOrDefault() IsNot Nothing Then
                Return TipoDocumentos.Where(Function(x) x.CodigoDoc.Equals(codDoc)).Select(Function(x) x.Descricao).FirstOrDefault()
            End If
            Return ""
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function DaNrDocSeguinte(ByVal codDoc As String) As Integer
        Try
            Dim ultimoDoc As Integer = TipoDocumentos.Where(Function(x) x.CodigoDoc.Equals(codDoc)).Select(Function(x) x.UltimoNrEmitido).First()
            If ultimoDoc >= 0 Then
                Return ultimoDoc + 1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function DaNomeCliente(ByVal codCl As String) As String
        Try
            CarregaClientes()
            If Clientes.Where(Function(x) x.CodigoCl.Equals(codCl)).Select(Function(x) x.Nome).FirstOrDefault() IsNot Nothing Then
                'duas formas de dizer o mesmo
                ' Clientes.Where(Function(x) x.CodigoCl.Equals(codCl)).FirstOrDefault().Nome
                Return Clientes.Where(Function(x) x.CodigoCl.Equals(codCl)).Select(Function(x) x.Nome).FirstOrDefault()
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub Novo()
        Try
            If CabecDocumento.Rows.Count = 0 Then
                Dim cabecDocRow As CabecDocumentoRow = CabecDocumento.NewRow()
                cabecDocRow.ID = Guid.NewGuid()
                cabecDocRow.TipoDocumento = ""
                cabecDocRow.NrDocumento = 0
                cabecDocRow.Cliente = ""
                cabecDocRow.Morada = ""
                cabecDocRow.NIF = 0
                cabecDocRow.Telefone = ""
                cabecDocRow.DataModificacao = DateTime.Now()
                cabecDocRow.Estado = 1
                'adicionamos os campos vazios a linha pronta a utilizar
                'varias formas
                ' CabecDocumento.AddCabecDocumentoRow(cabecDocRow)
                CabecDocumento.Rows.Add(cabecDocRow)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Function PesquisarCabecDoc(tipoDoc As String, nrDoc As Integer)
        Try
            CabecDocumento.Clear()
            AdpCabecDoc.FillByTipo_Nr_Doc(CabecDocumento, tipoDoc, nrDoc)

            If CabecDocumento.Rows.Count > 0 Then
                Return CabecDocumento.Rows(0)
            Else
                Novo()
                FrmDocumentos.HabilitarCampos()
                Return CabecDocumento(0)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub NovaLinhaProd(linhaSelecionada As ProdutosRow)
        Try
            Novo()
            Dim linhaNova As LinhasProdutosRow = LinhasProdutos.NewRow()
            'atribuimos os valores a nossa linha nova dos campos do formulario da linha prenchida
            linhaNova.ID = Guid.NewGuid()
            'numlinha novo igual a soma do total de rows do datatable + 1
            ' rowP.NumLinha =ListaProdutos.Rows.Count + 1
            'apenas contabilizando as linhas que nao foram deletadas como total de linhas 
            Dim contadorLinhas As Integer = 0
            For Each linha As LinhasProdutosRow In LinhasProdutos.Rows
                If linha.RowState <> DataRowState.Deleted Then
                    contadorLinhas += 1
                End If
            Next
            linhaNova.NumLinha = contadorLinhas + 1
            linhaNova.CabProdutoID = CabecDocumento(0).ID
            linhaNova.Descricao = linhaSelecionada.NomeProduto
            linhaNova.Produto = linhaSelecionada.CodigoPr
            linhaNova.Quantidade = 0.00
            linhaNova.PrecoUnt = linhaSelecionada.PrecoUnt
            linhaNova.DataEntrega = DateTime.Now()
            linhaNova.Total = 0.00
            LinhasProdutos.Rows.Add(linhaNova)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub EliminarLinha(ByVal id As Guid)
        Try
            Dim rowSelecionada As LinhasProdutosRow = LinhasProdutos.FindByID(id)
            Dim indiceLinha As Integer = rowSelecionada.NumLinha
            For Each linha As LinhasProdutosRow In LinhasProdutos.Rows
                If linha.NumLinha > indiceLinha AndAlso linha.RowState <> DataRowState.Deleted Then
                    linha.NumLinha -= 1
                End If
            Next
            rowSelecionada.Delete()
            'LinhasProdutos.GetChanges(Not DataRowState.Deleted)
            'LinhasProdutos.AcceptChanges()
            'UpdateLinhas()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub SubirLinha(ByVal id As Guid)
        Try
            Dim rowSelecionada As LinhasProdutosRow = LinhasProdutos.FindByID(id)
            Dim indiceLinha As Integer = rowSelecionada.NumLinha
            Dim rowAnterior = LinhasProdutos.Where(Function(x) x.NumLinha = indiceLinha - 1).FirstOrDefault()
            If indiceLinha - 1 <> 0 Then
                rowAnterior.NumLinha = indiceLinha
                rowSelecionada.NumLinha = indiceLinha - 1
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub DescerLinha(ByVal id As Guid)
        Try
            Dim rowSelecionada As LinhasProdutosRow = LinhasProdutos.FindByID(id)
            Dim indiceLinha As Integer = rowSelecionada.NumLinha
            Dim rowSeguinte = LinhasProdutos.Where(Function(x) x.NumLinha = indiceLinha + 1).FirstOrDefault()
            If indiceLinha <> FrmDocumentos.DgridLinhasProdutos.Rows.Count Then
                rowSeguinte.NumLinha = indiceLinha
                rowSelecionada.NumLinha = indiceLinha + 1
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub AtualizarDoc()
        Try
            If CabecDocumento(0).RowState = DataRowState.Added Then
                AdpQuerryUltNrEmitido.UpdateByUltimoEmitido(CabecDocumento(0).NrDocumento, CabecDocumento(0).TipoDocumento)
            End If
            UpdateCabecDoc()
            UpdateLinhas()
            CarregaTipodoc()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


End Class
