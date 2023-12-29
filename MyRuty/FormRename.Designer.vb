<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRename
    Inherits MyFormsLibrary.FormBaseDetail_4

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRename))
        Me.UcBrowseFileSystem1 = New MyControlsLibrary.UcBrowseFileSystem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkMPG = New System.Windows.Forms.CheckBox()
        Me.chkGPR = New System.Windows.Forms.CheckBox()
        Me.chkMP4 = New System.Windows.Forms.CheckBox()
        Me.chkMTS = New System.Windows.Forms.CheckBox()
        Me.chkAVI = New System.Windows.Forms.CheckBox()
        Me.chkMOV = New System.Windows.Forms.CheckBox()
        Me.chkNEF = New System.Windows.Forms.CheckBox()
        Me.chkJPG = New System.Windows.Forms.CheckBox()
        Me.chkCR2 = New System.Windows.Forms.CheckBox()
        Me.btnPreview = New MyControlsLibrary.MyButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.chkDNG = New System.Windows.Forms.CheckBox()
        Me.TabControlDetail.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me._ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlDetail
        '
        Me.TabControlDetail.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TabControlDetail.Size = New System.Drawing.Size(1168, 272)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TabPage1.Size = New System.Drawing.Size(1160, 239)
        Me.TabPage1.Text = "Info"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 272)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Panel2.Size = New System.Drawing.Size(1198, 60)
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.UcBrowseFileSystem1)
        Me.panel1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.panel1.Size = New System.Drawing.Size(1198, 230)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(14, 43)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.SplitContainer1.Size = New System.Drawing.Size(1198, 601)
        Me.SplitContainer1.SplitterDistance = 255
        Me.SplitContainer1.SplitterWidth = 14
        '
        'tabPageMain
        '
        Me.tabPageMain.Location = New System.Drawing.Point(4, 29)
        Me.tabPageMain.Margin = New System.Windows.Forms.Padding(14, 18, 14, 18)
        Me.tabPageMain.Padding = New System.Windows.Forms.Padding(14, 18, 14, 18)
        Me.tabPageMain.Size = New System.Drawing.Size(1226, 662)
        '
        'UcBrowseFileSystem1
        '
        Me.UcBrowseFileSystem1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBrowseFileSystem1.Location = New System.Drawing.Point(0, 0)
        Me.UcBrowseFileSystem1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcBrowseFileSystem1.Name = "UcBrowseFileSystem1"
        Me.UcBrowseFileSystem1.Size = New System.Drawing.Size(1198, 230)
        Me.UcBrowseFileSystem1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chkDNG)
        Me.Panel3.Controls.Add(Me.chkMPG)
        Me.Panel3.Controls.Add(Me.chkGPR)
        Me.Panel3.Controls.Add(Me.chkMP4)
        Me.Panel3.Controls.Add(Me.chkMTS)
        Me.Panel3.Controls.Add(Me.chkAVI)
        Me.Panel3.Controls.Add(Me.chkMOV)
        Me.Panel3.Controls.Add(Me.chkNEF)
        Me.Panel3.Controls.Add(Me.chkJPG)
        Me.Panel3.Controls.Add(Me.chkCR2)
        Me.Panel3.Controls.Add(Me.btnPreview)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(6, 8)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1148, 55)
        Me.Panel3.TabIndex = 0
        '
        'chkMPG
        '
        Me.chkMPG.AutoSize = True
        Me.chkMPG.Checked = True
        Me.chkMPG.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMPG.Location = New System.Drawing.Point(801, 17)
        Me.chkMPG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkMPG.Name = "chkMPG"
        Me.chkMPG.Size = New System.Drawing.Size(75, 24)
        Me.chkMPG.TabIndex = 9
        Me.chkMPG.Text = ".MPG"
        Me.chkMPG.UseVisualStyleBackColor = True
        '
        'chkGPR
        '
        Me.chkGPR.AutoSize = True
        Me.chkGPR.Checked = True
        Me.chkGPR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGPR.Location = New System.Drawing.Point(242, 17)
        Me.chkGPR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkGPR.Name = "chkGPR"
        Me.chkGPR.Size = New System.Drawing.Size(74, 24)
        Me.chkGPR.TabIndex = 8
        Me.chkGPR.Text = ".GPR"
        Me.chkGPR.UseVisualStyleBackColor = True
        '
        'chkMP4
        '
        Me.chkMP4.AutoSize = True
        Me.chkMP4.Checked = True
        Me.chkMP4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMP4.Location = New System.Drawing.Point(633, 17)
        Me.chkMP4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkMP4.Name = "chkMP4"
        Me.chkMP4.Size = New System.Drawing.Size(71, 24)
        Me.chkMP4.TabIndex = 7
        Me.chkMP4.Text = ".MP4"
        Me.chkMP4.UseVisualStyleBackColor = True
        '
        'chkMTS
        '
        Me.chkMTS.AutoSize = True
        Me.chkMTS.Checked = True
        Me.chkMTS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMTS.Location = New System.Drawing.Point(546, 17)
        Me.chkMTS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkMTS.Name = "chkMTS"
        Me.chkMTS.Size = New System.Drawing.Size(72, 24)
        Me.chkMTS.TabIndex = 6
        Me.chkMTS.Text = ".MTS"
        Me.chkMTS.UseVisualStyleBackColor = True
        '
        'chkAVI
        '
        Me.chkAVI.AutoSize = True
        Me.chkAVI.Checked = True
        Me.chkAVI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAVI.Location = New System.Drawing.Point(468, 17)
        Me.chkAVI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkAVI.Name = "chkAVI"
        Me.chkAVI.Size = New System.Drawing.Size(66, 24)
        Me.chkAVI.TabIndex = 5
        Me.chkAVI.Text = ".AVI"
        Me.chkAVI.UseVisualStyleBackColor = True
        '
        'chkMOV
        '
        Me.chkMOV.AutoSize = True
        Me.chkMOV.Checked = True
        Me.chkMOV.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMOV.Location = New System.Drawing.Point(713, 17)
        Me.chkMOV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkMOV.Name = "chkMOV"
        Me.chkMOV.Size = New System.Drawing.Size(75, 24)
        Me.chkMOV.TabIndex = 4
        Me.chkMOV.Text = ".MOV"
        Me.chkMOV.UseVisualStyleBackColor = True
        '
        'chkNEF
        '
        Me.chkNEF.AutoSize = True
        Me.chkNEF.Checked = True
        Me.chkNEF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNEF.Location = New System.Drawing.Point(172, 17)
        Me.chkNEF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkNEF.Name = "chkNEF"
        Me.chkNEF.Size = New System.Drawing.Size(71, 24)
        Me.chkNEF.TabIndex = 3
        Me.chkNEF.Text = ".NEF"
        Me.chkNEF.UseVisualStyleBackColor = True
        '
        'chkJPG
        '
        Me.chkJPG.AutoSize = True
        Me.chkJPG.Checked = True
        Me.chkJPG.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkJPG.Location = New System.Drawing.Point(4, 17)
        Me.chkJPG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkJPG.Name = "chkJPG"
        Me.chkJPG.Size = New System.Drawing.Size(70, 24)
        Me.chkJPG.TabIndex = 2
        Me.chkJPG.Text = ".JPG"
        Me.chkJPG.UseVisualStyleBackColor = True
        '
        'chkCR2
        '
        Me.chkCR2.AutoSize = True
        Me.chkCR2.Checked = True
        Me.chkCR2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCR2.Location = New System.Drawing.Point(87, 17)
        Me.chkCR2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkCR2.Name = "chkCR2"
        Me.chkCR2.Size = New System.Drawing.Size(71, 24)
        Me.chkCR2.TabIndex = 1
        Me.chkCR2.Text = ".CR2"
        Me.chkCR2.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnPreview.FlatAppearance.BorderSize = 0
        Me.btnPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.Location = New System.Drawing.Point(884, 5)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPreview.MyType = MyControlsLibrary.MyButton.ButtonType.btnPreview
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(234, 46)
        Me.btnPreview.TabIndex = 0
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(6, 63)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1148, 168)
        Me.DataGridView1.TabIndex = 1
        '
        'chkDNG
        '
        Me.chkDNG.AutoSize = True
        Me.chkDNG.Checked = True
        Me.chkDNG.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDNG.Location = New System.Drawing.Point(324, 17)
        Me.chkDNG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkDNG.Name = "chkDNG"
        Me.chkDNG.Size = New System.Drawing.Size(75, 24)
        Me.chkDNG.TabIndex = 10
        Me.chkDNG.Text = ".DNG"
        Me.chkDNG.UseVisualStyleBackColor = True
        '
        'FormRename
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 695)
        Me.Margin = New System.Windows.Forms.Padding(21, 28, 21, 28)
        Me.Name = "FormRename"
        Me.Text = "FormRename"
        Me.TabControlDetail.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me._ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageMain.ResumeLayout(False)
        Me.tabPageMain.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBrowseFileSystem1 As MyControlsLibrary.UcBrowseFileSystem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnPreview As MyControlsLibrary.MyButton
    Friend WithEvents chkJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkCR2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkNEF As System.Windows.Forms.CheckBox
    Friend WithEvents chkMOV As System.Windows.Forms.CheckBox
    Friend WithEvents chkAVI As System.Windows.Forms.CheckBox
    Friend WithEvents chkMTS As System.Windows.Forms.CheckBox
    Friend WithEvents chkMP4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkGPR As CheckBox
    Friend WithEvents chkMPG As CheckBox
    Friend WithEvents chkDNG As CheckBox
End Class
