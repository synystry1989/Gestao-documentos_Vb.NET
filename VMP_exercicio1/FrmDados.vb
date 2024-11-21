Imports VMP_exercicio1.DsDocumentos

Public Class FrmDados

    Public RowSelecionada As DataRow

    Dim dsDados As New DsDocumentos

    'passamos o parametro byref pois o valor de referencia sera carregado/alterado consoante a selecao 
    Public Sub ShowDialog(ByRef dados As DataTable)

        Try
            RowSelecionada = Nothing
            DgridViewDados.DataSource = dados

            If dados.TableName = dsDados.LinhasProdutos.TableName Then
                'retira os campos id e cabecalho quando a tabela carregada e a lista produtos
                FrmDocumentos.FormatarTabelaLinhas()
            End If
            'outra forma
            'Dim linhasTipo = dsDados.LinhasProdutos.GetType()
            'Dim dgvTipo = dgViewDados.GetType()
            'If linhasTipo = dgvTipo Then
            '    dsDados.FormatarGrelha(dgViewDados)
            'End If
            DgridViewDados.Refresh()
            MyBase.ShowDialog()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub OkToolStripButton_Click(sender As Object, e As EventArgs) Handles OkToolStripButton.Click

        Try
            RowSelecionada = TryCast(DgridViewDados.CurrentRow.DataBoundItem.row, DataRow)
            DialogResult = DialogResult.OK

        Catch ex As Exception

        End Try


    End Sub

    Private Sub VoltarToolStripButton_Click(sender As Object, e As EventArgs) Handles VoltarToolStripButton.Click
        Try
            DialogResult = DialogResult.Cancel
            RowSelecionada = Nothing
            Me.Dispose()
        Catch ex As Exception

        End Try

    End Sub
End Class