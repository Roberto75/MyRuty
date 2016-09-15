'
' Created by SharpDevelop.
' User: Roberto
' Date: 22/10/2009
' Time: 17.52
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FormAccessSQL
    Inherits MyFormsLibrary.FormBaseDetail_3

    ''' <summary>
    ''' Designer variable used to keep track of non-visual components.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

    ''' <summary>
    ''' Disposes resources used by the form.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ''' <summary>
    ''' This method is required for Windows Forms designer support.
    ''' Do not change the method contents inside the source code editor. The Forms designer might
    ''' not be able to load this method if it was changed manually.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccessSQL))
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtSQL = New System.Windows.Forms.TextBox
        Me.MyButton2 = New MyControlsLibrary.MyButton
        Me.btnReset = New MyControlsLibrary.MyButton
        Me.MyButton1 = New MyControlsLibrary.MyButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtFileAccess = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnOpenAccess = New MyControlsLibrary.MyButton
        Me.SelezionaTuttoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage1.SuspendLayout()
        Me.TabControlDetail.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me._ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtSQL)
        Me.TabPage1.Size = New System.Drawing.Size(753, 246)
        Me.TabPage1.Text = "SQL"
        '
        'TabControlDetail
        '
        Me.TabControlDetail.Controls.Add(Me.TabPage2)
        Me.TabControlDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControlDetail.Size = New System.Drawing.Size(761, 272)
        Me.TabControlDetail.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControlDetail.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.Panel2)
        Me.panel1.Size = New System.Drawing.Size(761, 94)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Size = New System.Drawing.Size(761, 395)
        Me.SplitContainer1.SplitterDistance = 119
        '
        'tabPageMain
        '
        Me.tabPageMain.Size = New System.Drawing.Size(767, 426)
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(698, 246)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Result"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtSQL
        '
        Me.txtSQL.AcceptsReturn = True
        Me.txtSQL.AcceptsTab = True
        Me.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSQL.Location = New System.Drawing.Point(3, 3)
        Me.txtSQL.MaxLength = 0
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSQL.Size = New System.Drawing.Size(747, 240)
        Me.txtSQL.TabIndex = 0
        '
        'MyButton2
        '
        Me.MyButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyButton2.FlatAppearance.BorderSize = 0
        Me.MyButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton2.Image = CType(resources.GetObject("MyButton2.Image"), System.Drawing.Image)
        Me.MyButton2.Location = New System.Drawing.Point(560, 60)
        Me.MyButton2.MyType = MyControlsLibrary.MyButton.ButtonType.btnExecute
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(156, 30)
        Me.MyButton2.TabIndex = 1
        Me.MyButton2.Text = "Esegui"
        Me.MyButton2.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.Location = New System.Drawing.Point(21, 60)
        Me.btnReset.MyType = MyControlsLibrary.MyButton.ButtonType.btnReset
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(156, 30)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Clear"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'MyButton1
        '
        Me.MyButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MyButton1.FlatAppearance.BorderSize = 0
        Me.MyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton1.Image = CType(resources.GetObject("MyButton1.Image"), System.Drawing.Image)
        Me.MyButton1.Location = New System.Drawing.Point(212, 60)
        Me.MyButton1.MyType = MyControlsLibrary.MyButton.ButtonType.btnOpen
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(156, 30)
        Me.MyButton1.TabIndex = 4
        Me.MyButton1.Text = "Apri file sql"
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MyButton1)
        Me.Panel2.Controls.Add(Me.txtFileAccess)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnOpenAccess)
        Me.Panel2.Controls.Add(Me.MyButton2)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(761, 94)
        Me.Panel2.TabIndex = 7
        '
        'txtFileAccess
        '
        Me.txtFileAccess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileAccess.Location = New System.Drawing.Point(91, 13)
        Me.txtFileAccess.Name = "txtFileAccess"
        Me.txtFileAccess.Size = New System.Drawing.Size(463, 20)
        Me.txtFileAccess.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "File Access:"
        '
        'btnOpenAccess
        '
        Me.btnOpenAccess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenAccess.FlatAppearance.BorderSize = 0
        Me.btnOpenAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenAccess.Image = CType(resources.GetObject("btnOpenAccess.Image"), System.Drawing.Image)
        Me.btnOpenAccess.Location = New System.Drawing.Point(560, 7)
        Me.btnOpenAccess.MyType = MyControlsLibrary.MyButton.ButtonType.btnOpen
        Me.btnOpenAccess.Name = "btnOpenAccess"
        Me.btnOpenAccess.Size = New System.Drawing.Size(156, 30)
        Me.btnOpenAccess.TabIndex = 8
        Me.btnOpenAccess.Text = "Apri file Access"
        Me.btnOpenAccess.UseVisualStyleBackColor = True
        '
        'SelezionaTuttoToolStripMenuItem
        '
        Me.SelezionaTuttoToolStripMenuItem.Name = "SelezionaTuttoToolStripMenuItem"
        Me.SelezionaTuttoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelezionaTuttoToolStripMenuItem.Text = "Seleziona tutto"
        '
        'FormAccessSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 452)
        Me.Name = "FormAccessSQL"
        Me.Text = "FormSQL"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControlDetail.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me._ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageMain.ResumeLayout(False)
        Me.tabPageMain.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MyButton2 As MyControlsLibrary.MyButton
    Friend WithEvents btnReset As MyControlsLibrary.MyButton
    Friend WithEvents MyButton1 As MyControlsLibrary.MyButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelezionaTuttoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOpenAccess As MyControlsLibrary.MyButton
    Friend WithEvents txtFileAccess As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
