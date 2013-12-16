<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvancado
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.Grid = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.btCriar = New Infragistics.Win.Misc.UltraButton()
        Me.grTipoDadosPretendidos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btReporTipoDados = New Infragistics.Win.Misc.UltraButton()
        Me.cbTipoDadosAplicar = New System.Windows.Forms.ComboBox()
        Me.btAplicarTipoDados = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel2.ClientArea.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        CType(Me.grTipoDadosPretendidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grTipoDadosPretendidos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.Grid)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 98)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(619, 314)
        Me.UltraPanel1.TabIndex = 0
        '
        'Grid
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.Grid.DisplayLayout.Appearance = Appearance1
        Me.Grid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.Grid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.Grid.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grid.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.Grid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance3.BackColor2 = System.Drawing.SystemColors.Control
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grid.DisplayLayout.GroupByBox.PromptAppearance = Appearance3
        Me.Grid.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid.DisplayLayout.MaxRowScrollRegions = 1
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Appearance7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid.DisplayLayout.Override.ActiveCellAppearance = Appearance7
        Appearance10.BackColor = System.Drawing.SystemColors.Highlight
        Appearance10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Grid.DisplayLayout.Override.ActiveRowAppearance = Appearance10
        Me.Grid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.Grid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Me.Grid.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.Grid.DisplayLayout.Override.CellAppearance = Appearance8
        Me.Grid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.Grid.DisplayLayout.Override.CellPadding = 0
        Appearance6.BackColor = System.Drawing.SystemColors.Control
        Appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance6.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.BorderColor = System.Drawing.SystemColors.Window
        Me.Grid.DisplayLayout.Override.GroupByRowAppearance = Appearance6
        Appearance5.TextHAlignAsString = "Left"
        Me.Grid.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.Grid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.Grid.DisplayLayout.Override.RowAppearance = Appearance11
        Me.Grid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Grid.DisplayLayout.Override.TemplateAddRowAppearance = Appearance9
        Me.Grid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(619, 314)
        Me.Grid.TabIndex = 0
        Me.Grid.Text = "UltraGrid1"
        '
        'UltraPanel2
        '
        '
        'UltraPanel2.ClientArea
        '
        Me.UltraPanel2.ClientArea.Controls.Add(Me.btCriar)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.grTipoDadosPretendidos)
        Me.UltraPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel2.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(619, 98)
        Me.UltraPanel2.TabIndex = 1
        '
        'btCriar
        '
        Me.btCriar.Location = New System.Drawing.Point(550, 56)
        Me.btCriar.Name = "btCriar"
        Me.btCriar.Size = New System.Drawing.Size(57, 23)
        Me.btCriar.TabIndex = 5
        Me.btCriar.Text = "Criar"
        '
        'grTipoDadosPretendidos
        '
        Me.grTipoDadosPretendidos.Controls.Add(Me.btReporTipoDados)
        Me.grTipoDadosPretendidos.Controls.Add(Me.cbTipoDadosAplicar)
        Me.grTipoDadosPretendidos.Controls.Add(Me.btAplicarTipoDados)
        Me.grTipoDadosPretendidos.Controls.Add(Me.UltraLabel1)
        Me.grTipoDadosPretendidos.Location = New System.Drawing.Point(12, 12)
        Me.grTipoDadosPretendidos.Name = "grTipoDadosPretendidos"
        Me.grTipoDadosPretendidos.Size = New System.Drawing.Size(160, 67)
        Me.grTipoDadosPretendidos.TabIndex = 1
        Me.grTipoDadosPretendidos.Text = "Definir tipo de dados igual"
        '
        'btReporTipoDados
        '
        Me.btReporTipoDados.Location = New System.Drawing.Point(9, 38)
        Me.btReporTipoDados.Name = "btReporTipoDados"
        Me.btReporTipoDados.Size = New System.Drawing.Size(57, 23)
        Me.btReporTipoDados.TabIndex = 4
        Me.btReporTipoDados.Text = "Repor"
        '
        'cbTipoDadosAplicar
        '
        Me.cbTipoDadosAplicar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTipoDadosAplicar.FormattingEnabled = True
        Me.cbTipoDadosAplicar.Items.AddRange(New Object() {"String", "Object", "Double", "Decimal", "Datetime", "Date", "Integer", "Long", "Boolean", "Char", "Int16", "Int32", "Int64"})
        Me.cbTipoDadosAplicar.Location = New System.Drawing.Point(72, 15)
        Me.cbTipoDadosAplicar.Name = "cbTipoDadosAplicar"
        Me.cbTipoDadosAplicar.Size = New System.Drawing.Size(75, 21)
        Me.cbTipoDadosAplicar.TabIndex = 3
        Me.cbTipoDadosAplicar.Text = "Object"
        '
        'btAplicarTipoDados
        '
        Me.btAplicarTipoDados.Location = New System.Drawing.Point(90, 38)
        Me.btAplicarTipoDados.Name = "btAplicarTipoDados"
        Me.btAplicarTipoDados.Size = New System.Drawing.Size(57, 23)
        Me.btAplicarTipoDados.TabIndex = 2
        Me.btAplicarTipoDados.Text = "Aplicar"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 18)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Tipo Dados"
        '
        'frmAvancado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 412)
        Me.Controls.Add(Me.UltraPanel2)
        Me.Controls.Add(Me.UltraPanel1)
        Me.Name = "frmAvancado"
        Me.Text = "Opções avançadas"
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel2.ClientArea.ResumeLayout(False)
        Me.UltraPanel2.ResumeLayout(False)
        CType(Me.grTipoDadosPretendidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grTipoDadosPretendidos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents Grid As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents grTipoDadosPretendidos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btAplicarTipoDados As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbTipoDadosAplicar As System.Windows.Forms.ComboBox
    Friend WithEvents btReporTipoDados As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btCriar As Infragistics.Win.Misc.UltraButton
End Class
