Module Geral

    Public vggNomesColunas As New NomesColunas
    Public vggListaPrefixos As New List(Of String)

    Public Sub Inicializar()
        Try
            'preencher lista de prefixos
            With vggListaPrefixos
                .Add("HIDDEN_")
                .Add("EDBT_")
                .Add("BT_")
                .Add("DT_")
                .Add("HR_")
                .Add("EUR_")
                .Add("DEC_")
                .Add("PERCENT_")
                .Add("EUR3_")
                .Add("SEL_")
            End With
        Catch ex As Exception
            Throw New Exception("Erro ao inicializar aplicativo.", ex)
        End Try
    End Sub

    Public Function SqlTypeToVbNet_ToString(ByVal iSqlType As String) As String

        Try

            Select Case iSqlType.ToUpper.Trim

                Case "char".ToUpper.Trim, "varchar".ToUpper.Trim, "text".ToUpper.Trim, "nvarchar".ToUpper.Trim, "ntext".ToUpper.Trim
                    Return "String"

                Case "decimal".ToUpper.Trim, "numeric".ToUpper.Trim, "float".ToUpper.Trim, "money".ToUpper.Trim, "smallmoney".ToUpper.Trim
                    Return "Decimal"

                Case "int".ToUpper.Trim, "bigint".ToUpper.Trim
                    Return "Long"

                Case "smallint".ToUpper.Trim, "tinyint".ToUpper.Trim
                    Return "Integer"

                Case "bit".ToUpper.Trim
                    Return "Boolean"

                Case "datetime".ToUpper.Trim, "smalldatetime".ToUpper.Trim
                    Return "Datetime"

                Case Else
                    Return "Object"

            End Select


        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return ""
    End Function

End Module
