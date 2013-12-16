Imports RsStructure

Public Class ClassGenerator

    Private vgArgs As New ClassArgs

   

    ''' <summary>
    ''' Constructor, recebe argumentos
    ''' </summary>
    ''' <param name="iArgs"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal iArgs As ClassArgs)
        vgArgs = iArgs
    End Sub

    ''' <summary>
    ''' Função pública que conforme o typo de acção e tipo de classe, vai realizar a acção
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CriarClasseSimples() As String
        Dim str As String = ""
        Try
            With vgArgs
                If .IsPrivate Then
                    str &= "Private Class "
                Else
                    str &= "Public Class "
                End If

                If .Classtype = eClassType.Simple_ColumnNames Then str &= "cl"
                str &= .ClassName & vbNewLine


                Using db As New ClassBd(.ConnectionString)

                    Dim tbCampos As New DataTable

                    tbCampos = db.GetDataTable(SQL.GetTableFields(.TableName))

                    If Not tbCampos Is Nothing Then
                        For Each r As DataRow In tbCampos.Rows
                            If .Classtype = eClassType.Simple_ColumnNames Then
                                str &= "Public " & r(vggNomesColunas.columnsInfo.ColumnName) & " As "
                                str &= "String = """ & r(vggNomesColunas.columnsInfo.ColumnName) & """" & vbNewLine
                            Else
                                str &= PropertyLine(r(vggNomesColunas.columnsInfo.ColumnName), SqlTypeToVbNet_ToString(r(vggNomesColunas.columnsInfo.TipoDados))) & vbNewLine
                            End If
                        Next
                    End If

                End Using

                str &= "End Class"
            End With


        Catch ex As Exception
            ShowError(ex.Message, ex)
        End Try
        Return str
    End Function

    Public Function CriarClasseAdvanced(ByVal iTbAdvanced As DataTable) As String
        Dim str As String = ""
        Try
            With vgArgs
                If .IsPrivate Then
                    str &= "Private Class "
                Else
                    str &= "Public Class "
                End If

                If .Classtype = eClassType.Advanced_ColumnNames Then str &= "cl"
                str &= .ClassName & vbNewLine

                If Not iTbAdvanced Is Nothing Then
                    For Each r As DataRow In iTbAdvanced.Rows
                        If r(vggNomesColunas.columnsInfo_Extra.Sel) = True Then
                            If .Classtype = eClassType.Advanced_ColumnNames Then
                                str &= "Public " & r(vggNomesColunas.columnsInfo_Extra.NomeVariavel_Name) & " As "
                                str &= "String = """ & r(vggNomesColunas.columnsInfo_Extra.ValorString_Name) & """" & vbNewLine
                            Else
                                str &= PropertyLine(r(vggNomesColunas.columnsInfo_Extra.NomeVariavel_Name), r(vggNomesColunas.columnsInfo_Extra.TipoDadosPretendido_Name)) & vbNewLine
                            End If
                        End If
                    Next
                End If

                str &= "End Class"
            End With


        Catch ex As Exception
            ShowError(ex.Message, ex)
        End Try
        Return str
    End Function

    Private Function PropertyLine(ByVal iPropertyName As String, ByVal iDataType As String) As String
        Dim str As String = ""
        str &= "Private _" & iPropertyName & " As " & iDataType & vbNewLine
        str &= "Public Property " & iPropertyName & " As " & iDataType & vbNewLine
        str &= "    Get " & vbNewLine
        str &= "        Return _" & iPropertyName & vbNewLine
        str &= "    End Get" & vbNewLine
        str &= "    Set(value as " & iDataType & ")" & vbNewLine
        str &= "        value = _" & iPropertyName & vbNewLine
        str &= "    End Set" & vbNewLine
        str &= "End Property" & vbNewLine
        Return str
    End Function

  


End Class
