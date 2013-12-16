<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbSQLInstances = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cbServers = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbBDs = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtUser = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtPass = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbTables = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.btCriarClasseObjectoSimples = New Infragistics.Win.Misc.UltraButton()
        Me.txtResult = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtClassName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkPrivada = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btClipBoard = New Infragistics.Win.Misc.UltraButton()
        Me.btCriarClasseNomesColunasSimples = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btCriarClasseObjectoAvancada = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btCriarClassNomesColunasAvancada = New Infragistics.Win.Misc.UltraButton()
        CType(Me.cbSQLInstances, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbServers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClassName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPrivada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbSQLInstances
        '
        Me.cbSQLInstances.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cbSQLInstances.Location = New System.Drawing.Point(158, 35)
        Me.cbSQLInstances.Name = "cbSQLInstances"
        Me.cbSQLInstances.Size = New System.Drawing.Size(144, 21)
        Me.cbSQLInstances.TabIndex = 1
        Me.cbSQLInstances.Text = "sql2008r2"
        '
        'cbServers
        '
        Me.cbServers.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cbServers.Location = New System.Drawing.Point(12, 35)
        Me.cbServers.Name = "cbServers"
        Me.cbServers.Size = New System.Drawing.Size(140, 21)
        Me.cbServers.TabIndex = 0
        Me.cbServers.Text = "srvprog"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 18)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Servidor"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(158, 18)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "Instância"
        '
        'cbBDs
        '
        Me.cbBDs.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cbBDs.Location = New System.Drawing.Point(12, 79)
        Me.cbBDs.Name = "cbBDs"
        Me.cbBDs.Size = New System.Drawing.Size(234, 21)
        Me.cbBDs.TabIndex = 4
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(12, 62)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UltraLabel3.TabIndex = 5
        Me.UltraLabel3.Text = "BD"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(308, 35)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 21)
        Me.txtUser.TabIndex = 2
        Me.txtUser.Text = "sa"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(414, 35)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 21)
        Me.txtPass.TabIndex = 3
        Me.txtPass.Text = "ink"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(308, 18)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(100, 20)
        Me.UltraLabel4.TabIndex = 8
        Me.UltraLabel4.Text = "User"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(414, 18)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UltraLabel5.TabIndex = 9
        Me.UltraLabel5.Text = "Password"
        '
        'cbTables
        '
        Me.cbTables.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cbTables.Location = New System.Drawing.Point(252, 79)
        Me.cbTables.Name = "cbTables"
        Me.cbTables.Size = New System.Drawing.Size(262, 21)
        Me.cbTables.TabIndex = 5
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(252, 62)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UltraLabel6.TabIndex = 11
        Me.UltraLabel6.Text = "Tabela"
        '
        'btCriarClasseObjectoSimples
        '
        Me.btCriarClasseObjectoSimples.Location = New System.Drawing.Point(19, 19)
        Me.btCriarClasseObjectoSimples.Name = "btCriarClasseObjectoSimples"
        Me.btCriarClasseObjectoSimples.Size = New System.Drawing.Size(63, 23)
        Me.btCriarClasseObjectoSimples.TabIndex = 7
        Me.btCriarClasseObjectoSimples.Text = "Simples"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(12, 152)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(678, 330)
        Me.txtResult.TabIndex = 8
        '
        'txtClassName
        '
        Me.txtClassName.Location = New System.Drawing.Point(12, 125)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.Size = New System.Drawing.Size(234, 21)
        Me.txtClassName.TabIndex = 6
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Location = New System.Drawing.Point(12, 106)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(100, 23)
        Me.UltraLabel7.TabIndex = 15
        Me.UltraLabel7.Text = "Nome da classe"
        '
        'chkPrivada
        '
        Me.chkPrivada.Location = New System.Drawing.Point(252, 126)
        Me.chkPrivada.Name = "chkPrivada"
        Me.chkPrivada.Size = New System.Drawing.Size(76, 20)
        Me.chkPrivada.TabIndex = 16
        Me.chkPrivada.Text = "Privada"
        '
        'btClipBoard
        '
        Me.btClipBoard.Location = New System.Drawing.Point(625, 124)
        Me.btClipBoard.Name = "btClipBoard"
        Me.btClipBoard.Size = New System.Drawing.Size(65, 23)
        Me.btClipBoard.TabIndex = 17
        Me.btClipBoard.Text = "ClipBoard"
        '
        'btCriarClasseNomesColunasSimples
        '
        Me.btCriarClasseNomesColunasSimples.Location = New System.Drawing.Point(19, 19)
        Me.btCriarClasseNomesColunasSimples.Name = "btCriarClasseNomesColunasSimples"
        Me.btCriarClasseNomesColunasSimples.Size = New System.Drawing.Size(63, 23)
        Me.btCriarClasseNomesColunasSimples.TabIndex = 18
        Me.btCriarClasseNomesColunasSimples.Text = "Simples"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.btCriarClasseObjectoAvancada)
        Me.UltraGroupBox1.Controls.Add(Me.btCriarClasseObjectoSimples)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(532, 18)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(166, 50)
        Me.UltraGroupBox1.TabIndex = 19
        Me.UltraGroupBox1.Text = "Criar Classe Objecto"
        '
        'btCriarClasseObjectoAvancada
        '
        Me.btCriarClasseObjectoAvancada.Location = New System.Drawing.Point(88, 19)
        Me.btCriarClasseObjectoAvancada.Name = "btCriarClasseObjectoAvancada"
        Me.btCriarClasseObjectoAvancada.Size = New System.Drawing.Size(70, 23)
        Me.btCriarClasseObjectoAvancada.TabIndex = 8
        Me.btCriarClasseObjectoAvancada.Text = "Avançada"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.btCriarClassNomesColunasAvancada)
        Me.UltraGroupBox2.Controls.Add(Me.btCriarClasseNomesColunasSimples)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(532, 74)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(166, 50)
        Me.UltraGroupBox2.TabIndex = 20
        Me.UltraGroupBox2.Text = "Criar Classe Nomes Colunas"
        '
        'btCriarClassNomesColunasAvancada
        '
        Me.btCriarClassNomesColunasAvancada.Location = New System.Drawing.Point(88, 19)
        Me.btCriarClassNomesColunasAvancada.Name = "btCriarClassNomesColunasAvancada"
        Me.btCriarClassNomesColunasAvancada.Size = New System.Drawing.Size(70, 23)
        Me.btCriarClassNomesColunasAvancada.TabIndex = 8
        Me.btCriarClassNomesColunasAvancada.Text = "Avançada"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 494)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.btClipBoard)
        Me.Controls.Add(Me.txtClassName)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.cbTables)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.cbBDs)
        Me.Controls.Add(Me.cbServers)
        Me.Controls.Add(Me.cbSQLInstances)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.chkPrivada)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Object Class BD"
        CType(Me.cbSQLInstances, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbServers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClassName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPrivada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbSQLInstances As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cbServers As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbBDs As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtUser As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtPass As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbTables As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btCriarClasseObjectoSimples As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtResult As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtClassName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkPrivada As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btClipBoard As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btCriarClasseNomesColunasSimples As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btCriarClasseObjectoAvancada As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btCriarClassNomesColunasAvancada As Infragistics.Win.Misc.UltraButton

End Class
