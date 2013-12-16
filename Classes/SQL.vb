Public Class SQL

    Public Shared Function GetTableFields(ByVal iTableName As String) As String
        Dim str As String = ""

        With vggNomesColunas.columnsInfo
            str &= "SELECT " & vbNewLine
            str &= "    COLUMN_NAME AS [" & .ColumnName & "]" & vbNewLine
            str &= "    ,COLUMN_DEFAULT AS [" & .DefaultValue & "]" & vbNewLine
            str &= "    ,IS_NULLABLE AS [" & .IsNullable & "]" & vbNewLine
            str &= "    ,ORDINAL_POSITION AS [" & .OrdinalPosition & "]" & vbNewLine
            str &= "    ,TABLE_NAME AS [" & .TableName & "]" & vbNewLine
            str &= "    ,DATA_TYPE AS [" & .TipoDados & "]" & vbNewLine
            str &= "from information_schema.columns where table_name = '" & iTableName & "' order by ordinal_position"
        End With

        Return str
    End Function


End Class
