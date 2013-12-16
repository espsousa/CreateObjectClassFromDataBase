Imports RsStructure
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmAvancado

#Region "Atributos"

    Private vgInfraGrid As clInfragistics
    Public vgArgs As ClassArgs
    Public vgTbReturn As DataTable

#End Region

#Region "Constructor"

    Public Sub New(ByVal iClassArgs As ClassArgs)
        InitializeComponent()

        vgArgs = iClassArgs

    End Sub

#End Region

#Region "Load"

    Private Sub frmAvancado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            CarregarGrelha()
            GerirFormTipoClase()
        Catch ex As Exception
            ShowError("Erro a carregar opções avançadas.", ex)
        End Try
    End Sub

    Private Sub CarregarGrelha()
        Try
            vgInfraGrid = New clInfragistics(vgArgs.ConnectionString, Grid, True)

            Dim dtColumnsInfo As New DataTable
            Using db As New ClassBd(vgArgs.ConnectionString)
                dtColumnsInfo = db.GetDataTable(SQL.GetTableFields(vgArgs.TableName))
            End Using

            If Not dtColumnsInfo Is Nothing Then

                'em qualquer das situações, adicionar coluna de nome da variável
                Dim c As New DataColumn(vggNomesColunas.columnsInfo_Extra.NomeVariavel_Name, GetType(String))
                c.Caption = vggNomesColunas.columnsInfo_Extra.NomeVariavel_Caption
                c.ReadOnly = False
                dtColumnsInfo.Columns.Add(c)

                'adicionar colunas extra à tabela para mostrar na grelha conforme o tipo de classe que seja para construir
                Select Case vgArgs.Classtype

                    Case eClassType.Advanced_ColumnNames
                        'adicionar colunas do valor pretendido em string
                        c = New DataColumn(vggNomesColunas.columnsInfo_Extra.ValorString_Name, GetType(String))
                        c.Caption = vggNomesColunas.columnsInfo_Extra.ValorString_Caption
                        c.ReadOnly = False
                        dtColumnsInfo.Columns.Add(c)

                        'percorrer linhas e meter os valores das novas colunas iguais ao nome original
                        For Each r As DataRow In dtColumnsInfo.Rows
                            r(vggNomesColunas.columnsInfo_Extra.ValorString_Name) = r(vggNomesColunas.columnsInfo.ColumnName)
                        Next

                    Case eClassType.Advanced_ObjectClass
                        'adicionar coluna do tipo de dados pretendido
                        c = New DataColumn(vggNomesColunas.columnsInfo_Extra.TipoDadosPretendido_Name, GetType(String))
                        c.Caption = vggNomesColunas.columnsInfo_Extra.TipoDadosPretendido_Caption
                        c.ReadOnly = False
                        dtColumnsInfo.Columns.Add(c)

                        'percorrer linhas e meter os valores das novas colunas iguais ao nome original
                        For Each r As DataRow In dtColumnsInfo.Rows
                            r(vggNomesColunas.columnsInfo_Extra.TipoDadosPretendido_Name) = SqlTypeToVbNet_ToString(r(vggNomesColunas.columnsInfo.TipoDados))
                        Next

                End Select

                'em qualquer das situações, adicionar coluna de selecção (checkbox)
                c = New DataColumn(vggNomesColunas.columnsInfo_Extra.Sel, GetType(Boolean))
                c.Caption = vggNomesColunas.columnsInfo_Extra.Sel
                c.ReadOnly = False
                dtColumnsInfo.Columns.Add(c)

                'percorrer linhas e meter os valores das novas colunas iguais ao nome original
                For Each r As DataRow In dtColumnsInfo.Rows
                    r(vggNomesColunas.columnsInfo_Extra.NomeVariavel_Name) = r(vggNomesColunas.columnsInfo.ColumnName)
                    r(vggNomesColunas.columnsInfo_Extra.Sel) = False
                Next


                'atribuir tabela à grid
                vgInfraGrid.DataBindGrid(dtColumnsInfo)
                vgInfraGrid.AllowEditSemInsertNemEliminar = True
                vgInfraGrid.AllowExtendLastColumn = True
                vgInfraGrid.AllowGroup = False
                vgInfraGrid.AllowFiltro = clInfragistics.TFiltro.tAllow

                'preencher drops conforme tipo de class
                Select Case vgArgs.Classtype
                    Case eClassType.Advanced_ObjectClass
                        'drop do tipo de dados
                        Dim list As New ValueList
                        'percorrer os items que estão na combo para os dados ficarem coerentes
                        For Each s As String In cbTipoDadosAplicar.Items
                            list.ValueListItems.Add(s)
                        Next

                        vgInfraGrid.Coluna(vggNomesColunas.columnsInfo_Extra.TipoDadosPretendido_Name).Style = ColumnStyle.DropDown
                        vgInfraGrid.Coluna(vggNomesColunas.columnsInfo_Extra.TipoDadosPretendido_Name).ValueList = list


                    Case eClassType.Advanced_ColumnNames

                End Select


            End If

        Catch ex As Exception
            Throw New Exception("Erro ao carregar grelha.", ex)
        End Try
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Não deixar editar algumas colunas 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Grid_BeforeEnterEditMode(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles Grid.BeforeEnterEditMode
        If Grid.ActiveCell Is Nothing Then Return

        Select Case Grid.ActiveCell.Column.Header.Caption

            Case vggNomesColunas.columnsInfo.ColumnName, _
                vggNomesColunas.columnsInfo.DefaultValue, _
                vggNomesColunas.columnsInfo.IsNullable, _
                vggNomesColunas.columnsInfo.TipoDados
                e.Cancel = True

        End Select

    End Sub

    ''' <summary>
    ''' Aplicar o mesmo tipo de dados para a classe objecto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btAplicarTipoDados_Click(sender As System.Object, e As System.EventArgs) Handles btAplicarTipoDados.Click
        For Each r As UltraGridRow In Grid.Rows
            r.Cells(vggNomesColunas.columnsInfo_Extra.TipoDadosPretendido_Name).Value = cbTipoDadosAplicar.Text
        Next
    End Sub

    ''' <summary>
    ''' Repor o tipo de dados criado originalmente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btReporTipoDados_Click(sender As System.Object, e As System.EventArgs) Handles btReporTipoDados.Click
        For Each r As UltraGridRow In Grid.Rows
            r.Cells(vggNomesColunas.columnsInfo_Extra.TipoDadosPretendido_Name).Value = SqlTypeToVbNet_ToString(r.Cells(vggNomesColunas.columnsInfo.TipoDados).Value)
        Next
    End Sub

    Private Sub Grid_ClickCellButton(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles Grid.ClickCellButton
        Try
            Select Case e.Cell.Column.Key

                Case vggNomesColunas.columnsInfo_Extra.NomeVariavel_Name, vggNomesColunas.columnsInfo_Extra.ValorString_Name
                    'seleccionar prefixos
                    Dim dt As New DataTable
                    Dim col As New DataColumn("Prefixo", GetType(String))
                    dt.Columns.Add(col)

                    For Each s As String In vggListaPrefixos
                        Dim r As DataRow = dt.NewRow
                        r("Prefixo") = s
                        dt.Rows.Add(r)
                    Next

                    Using f As New frmProcura("", "", dt)
                        f.ShowDialog()

                        If Not f.Cancelou Then
                            e.Cell.Value = f.Data(0)("Prefixo") & "" & e.Cell.Value
                        End If

                    End Using


            End Select
        Catch ex As Exception
            ShowError("Erro ao processar click cell button.", ex)
        End Try

    End Sub

    Private Sub btCriar_Click(sender As System.Object, e As System.EventArgs) Handles btCriar.Click
        If ValidarCriacao() Then
            vgTbReturn = CType(Grid.DataSource, DataTable)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btRetirarTextoColunaNomeVariavel_Click(sender As System.Object, e As System.EventArgs) Handles btRetirarTextoColunaNomeVariavel.Click
        For Each r As DataRow In CType(Grid.DataSource, DataTable).Rows
            r(vggNomesColunas.columnsInfo_Extra.NomeVariavel_Name) = r(vggNomesColunas.columnsInfo_Extra.NomeVariavel_Name).ToString.Replace(txtRetirarTextoColunaNomeVariavel.Text, "")
        Next
    End Sub

    Private Sub btRetirarTextoColunaValorString_Click(sender As System.Object, e As System.EventArgs) Handles btRetirarTextoColunaValorString.Click
        For Each r As DataRow In CType(Grid.DataSource, DataTable).Rows
            r(vggNomesColunas.columnsInfo_Extra.ValorString_Name) = r(vggNomesColunas.columnsInfo_Extra.ValorString_Name).ToString.Replace(txtRetirarTextoColunaValorString.Text, "")
        Next
    End Sub


#End Region

#Region "Métodos e funções"

    Private Sub GerirFormTipoClase()
        Select Case vgArgs.Classtype

            Case eClassType.Advanced_ColumnNames
                grTipoDadosPretendidos.Visible = False
                pnlRetirarTextoColunaValorString.Visible = True

            Case eClassType.Advanced_ObjectClass
                grTipoDadosPretendidos.Visible = True
                pnlRetirarTextoColunaValorString.Visible = False

        End Select

        lblColunaNomeVariavel.Text = vggNomesColunas.columnsInfo_Extra.NomeVariavel_Caption
        lblColunaValorString.Text = vggNomesColunas.columnsInfo_Extra.ValorString_Caption


    End Sub

    Private Function ValidarCriacao() As Boolean
        For Each r As DataRow In CType(Grid.DataSource, DataTable).Rows
            If r(vggNomesColunas.columnsInfo_Extra.Sel) = True Then
                Return True
            End If
        Next

        ShowMensagem("Não foi seleccionada nenhuma linha")
        Return False
    End Function

#End Region



   

 
   
   
End Class