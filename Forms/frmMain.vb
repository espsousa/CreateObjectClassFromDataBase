Imports RsStructure
Imports System.Data.Sql
Imports Microsoft.Win32

Public Class frmMain

#Region "Atributos"

    Private vgdb As ClassBd
    Private vgDTServersInstances As New DataTable
    Private vgConnectionStringFinal As String = ""
    Private vgIsLoading As Boolean = True

#End Region

#Region "Load"

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Inicializar()
            LoadDefaultSettings()

            Dim instance As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance

            vgDTServersInstances = instance.GetDataSources
            vgConnectionStringFinal = ""
            'Dim instances As DataTable = dt.DefaultView.ToTable(False, "ServerName", "InstanceName")
            Dim list As IList(Of String) = LocalHostSQLInstancesReader.GetLocalSqlServerInstanceNames()

            For Each s As String In list
                Dim r As DataRow = vgDTServersInstances.NewRow
                r("ServerName") = "localhost"
                r("InstanceName") = s
                vgDTServersInstances.Rows.Add(r)
            Next

            If Not vgDTServersInstances Is Nothing Then
                cbServers.Items.Clear()
                Dim servers As DataTable = vgDTServersInstances.DefaultView.ToTable(True, "ServerName")
                For Each r As DataRow In servers.Rows
                    If Not r.IsNull("Servername") Then
                        cbServers.Items.Add(r("ServerName"))
                    End If
                Next
            End If

            PreencherBDS()

        Catch ex As Exception
            ShowError(ex.Message, ex)
        End Try
        vgIsLoading = False
    End Sub

    ''' <summary>
    ''' Carrega as default settings para os campos respectivos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadDefaultSettings()
        Try
            cbServers.Text = My.Settings.defaultServer
            cbSQLInstances.Text = My.Settings.defaultSQLInstance
            txtUser.Text = My.Settings.defaultUser
            txtPass.Text = My.Settings.defaultPassword

        Catch ex As Exception
            ShowError("Erro ao carregar default settings.", ex)
        End Try
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Após seleccionar novo servidor, actualizar as instâncias do mesmo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbServidores_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cbServers.ValueChanged
        If vgIsLoading Then Return
        Try
            PreencherInstancias()
        Catch ex As Exception
            ShowError(ex.Message, ex)
        End Try
    End Sub

    ''' <summary>
    ''' Preencher as bases de dados existentes na instância do servidor seleccionado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbBDs_BeforeDropDown(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles cbBDs.BeforeDropDown
        Try
            vgConnectionStringFinal = ""
            cbBDs.Items.Clear()

            If txtUser.Text = "" OrElse txtPass.Text = "" OrElse cbServers.Text = "" OrElse cbSQLInstances.Text = "" Then
                ShowMensagem("Os dados não estão preenchidos correctamente.")
                e.Cancel = True
                Return
            End If

            PreencherBDS()

        Catch ex As Exception
            ShowError(ex.Message, ex)
        End Try
    End Sub

    ''' <summary>
    ''' Preencher tabelas da bd seleccionada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbBDs_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cbBDs.ValueChanged
        Try
            vgConnectionStringFinal = ""

            cbTables.Items.Clear()
            cbTables.Text = ""

            If txtUser.Text = "" OrElse txtPass.Text = "" OrElse cbServers.Text = "" OrElse cbSQLInstances.Text = "" OrElse cbBDs.Text = "" Then
                Return
            End If

            PreencherTabelas()

        Catch ex As Exception
            ShowError(ex.Message, ex)
        End Try
    End Sub

    ''' <summary>
    ''' Meter o nome da class igual à tabela seleccionada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbTabelas_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cbTables.ValueChanged
        txtClassName.Text = cbTables.Text
    End Sub

    ''' <summary>
    ''' Criar classe objecto simples
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btCriarClasseObjectoSimples_Click(sender As System.Object, e As System.EventArgs) Handles btCriarClasseObjectoSimples.Click

        If ValidarCriacaoClasse() Then
            Dim cl As New ClassGenerator(FillClassGeneratorArgs(eClassType.Simple_ObjectClass))
            txtResult.Text = cl.CriarClasseSimples()
        End If

    End Sub

    ''' <summary>
    ''' Criar classe objecto avançada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btCriarClasseObjectoAvancada_Click(sender As System.Object, e As System.EventArgs) Handles btCriarClasseObjectoAvancada.Click
        If ValidarCriacaoClasse() Then
            Dim f As New frmAvancado(FillClassGeneratorArgs(eClassType.Advanced_ObjectClass))
            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim cl As New ClassGenerator(f.vgArgs)
                txtResult.Text = cl.CriarClasseAdvanced(f.vgTbReturn)
            End If

            'txtResult.Text = cl.CriarClasse()
        End If
    End Sub

    ''' <summary>
    ''' Seleccionar o conteúdo todo do texto de resultado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtResult_AfterEnterEditMode(sender As System.Object, e As System.EventArgs) Handles txtResult.AfterEnterEditMode
        txtResult.SelectAll()
    End Sub

    ''' <summary>
    ''' Seleccionar o texto para o clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btClipBoard_Click(sender As System.Object, e As System.EventArgs) Handles btClipBoard.Click
        Clipboard.SetText(txtResult.Text)
    End Sub

    ''' <summary>
    ''' Cria classe nomes de colunas simples
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btCriarClasseNomesColunasSimples_Click(sender As System.Object, e As System.EventArgs) Handles btCriarClasseNomesColunasSimples.Click
        If ValidarCriacaoClasse() Then
            Dim cl As New ClassGenerator(FillClassGeneratorArgs(eClassType.Simple_ColumnNames))
            txtResult.Text = cl.CriarClasseSimples()
        End If
    End Sub

    ''' <summary>
    ''' Crair classe nomes de colunas avançado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btCriarClassNomesColunasAvancada_Click(sender As System.Object, e As System.EventArgs) Handles btCriarClassNomesColunasAvancada.Click
        If ValidarCriacaoClasse() Then
            Dim f As New frmAvancado(FillClassGeneratorArgs(eClassType.Advanced_ColumnNames))
            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim cl As New ClassGenerator(f.vgArgs)
                txtResult.Text = cl.CriarClasseAdvanced(f.vgTbReturn)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Depois de mudar de instância, limpar o texto das bds e das tabelas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbSQLInstances_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cbSQLInstances.ValueChanged
        If Not vgIsLoading Then
            cbBDs.Text = ""
            cbTables.Text = ""
        End If
    End Sub

#End Region


#Region "Métodos e funções"

    ''' <summary>
    ''' Preecher combo de instâncias
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PreencherInstancias()
        Try
            vgConnectionStringFinal = ""
            cbSQLInstances.Items.Clear()
            If Not cbServers.Text = "" Then
                If Not vgDTServersInstances Is Nothing Then
                    Dim instances() As DataRow = vgDTServersInstances.Select("ServerName = '" & cbServers.Text & "'")

                    If instances.Length > 0 Then
                        cbSQLInstances.Text = ""
                        cbBDs.Text = ""
                        cbTables.Text = ""
                        For Each r As DataRow In instances
                            If Not r.IsNull("InstanceName") Then
                                cbSQLInstances.Items.Add(r("InstanceName"))
                            End If
                        Next
                    End If

                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    ''' <summary>
    ''' Preencher combo de bds
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PreencherBDS()
        Try
            Dim connString As New SqlClient.SqlConnectionStringBuilder

            With connString
                .DataSource = cbServers.Text & "\" & cbSQLInstances.Text
                .InitialCatalog = "master"
                .PersistSecurityInfo = True
                .UserID = txtUser.Text
                .Password = txtPass.Text
            End With

            Using db As New ClassBd(connString.ConnectionString)
                Dim bds As New DataTable
                bds = db.GetDataTable("SELECT Name FROM sys.databases")
                If Not bds Is Nothing Then
                    For Each r As DataRow In bds.Rows
                        If Not r.IsNull("Name") Then
                            cbBDs.Items.Add(r("Name"))
                        End If
                    Next
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Preencher combo de tabelas e construir connection string final
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PreencherTabelas()
        Try
            Dim connString As New SqlClient.SqlConnectionStringBuilder

            With connString
                .DataSource = cbServers.Text & "\" & cbSQLInstances.Text
                .InitialCatalog = cbBDs.Text
                .PersistSecurityInfo = True
                .UserID = txtUser.Text
                .Password = txtPass.Text
            End With

            Using db As New ClassBd(connString.ConnectionString)
                Dim tbs As New DataTable
                tbs = db.GetDataTable("SELECT Name FROM sys.tables")
                If Not tbs Is Nothing Then
                    For Each r As DataRow In tbs.Rows
                        If Not r.IsNull("Name") Then
                            cbTables.Items.Add(r("Name"))
                        End If
                    Next
                    vgConnectionStringFinal = connString.ConnectionString
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Validar criação de classe (se os dados estão devidamente preenchidos)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidarCriacaoClasse() As Boolean
        txtResult.Text = ""

        If txtUser.Text = "" OrElse _
            txtPass.Text = "" OrElse _
            cbServers.Text = "" _
            OrElse cbSQLInstances.Text = "" _
            OrElse cbBDs.Text = "" _
            OrElse cbTables.Text = "" _
            OrElse txtClassName.Text = "" _
            OrElse vgConnectionStringFinal = "" Then
            ShowMensagem("Os dados não estão preenchidos correctamente.")
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' Preencher os argumentos a enviar para a ClassGenerator
    ''' </summary>
    ''' <param name="iClassType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function FillClassGeneratorArgs(ByVal iClassType As eClassType) As ClassArgs
        Dim args As New ClassArgs
        Try
            With args
                .ClassName = txtClassName.Text
                .Classtype = iClassType
                .ConnectionString = vgConnectionStringFinal
                .DataBase = cbBDs.Text
                .Instance = cbSQLInstances.Text
                .IsPrivate = chkPrivada.Checked
                .Password = txtPass.Text
                .Server = cbServers.Text
                .TableName = cbTables.Text
                .User = txtUser.Text
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return args
    End Function

#End Region


    


 
   
End Class
