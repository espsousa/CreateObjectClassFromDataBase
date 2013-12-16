Public Class NomesColunas

    Public columnsInfo As New clColumnsInformation
    Public Class clColumnsInformation
        Public TableName As String = "HIDDEN_TableName"
        Public ColumnName As String = "Nome Coluna"
        Public OrdinalPosition As String = "HIDDEN_OrdinalPosition"
        Public DefaultValue As String = "Valor por defeito"
        Public IsNullable As String = "Nulls"
        Public TipoDados As String = "Tipo Dados"
    End Class

    Public columnsInfo_Extra As New clColumsInfo_Extra
    Public Class clColumsInfo_Extra
        Public TipoDadosPretendido_Name As String = "TipoDadosPretendido"
        Public TipoDadosPretendido_Caption As String = "Tipo dados pretendido"
        Public ValorString_Name As String = "EDBT_ValorString"
        Public ValorString_Caption As String = "Valor"
        Public NomeVariavel_Name As String = "EDBT_NomeVariavel"
        Public NomeVariavel_Caption As String = "Nome Variável"
        Public Sel As String = "Sel"
    End Class

End Class
