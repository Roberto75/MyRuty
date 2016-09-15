<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOutlook
    Inherits MyFormsLibrary.FormBaseDetail_3

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOutlook))
        Me.btnOpenFile = New MyControlsLibrary.MyButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPathSource = New System.Windows.Forms.TextBox
        Me.MyButton1 = New MyControlsLibrary.MyButton
        Me.MyButton2 = New MyControlsLibrary.MyButton
        Me.MyButton3 = New MyControlsLibrary.MyButton
        Me.MyButton4 = New MyControlsLibrary.MyButton
        Me.MyButton5 = New MyControlsLibrary.MyButton
        Me.TabControlDetail.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me._ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.MyButton5)
        Me.panel1.Controls.Add(Me.MyButton4)
        Me.panel1.Controls.Add(Me.MyButton3)
        Me.panel1.Controls.Add(Me.MyButton2)
        Me.panel1.Controls.Add(Me.MyButton1)
        Me.panel1.Controls.Add(Me.btnOpenFile)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Controls.Add(Me.txtPathSource)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFile.FlatAppearance.BorderSize = 0
        Me.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenFile.Image = CType(resources.GetObject("btnOpenFile.Image"), System.Drawing.Image)
        Me.btnOpenFile.Location = New System.Drawing.Point(512, 25)
        Me.btnOpenFile.MyType = MyControlsLibrary.MyButton.ButtonType.btnOpen
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(156, 30)
        Me.btnOpenFile.TabIndex = 5
        Me.btnOpenFile.Text = "Apri"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Path file sorgente:"
        '
        'txtPathSource
        '
        Me.txtPathSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPathSource.Location = New System.Drawing.Point(125, 31)
        Me.txtPathSource.Name = "txtPathSource"
        Me.txtPathSource.ReadOnly = True
        Me.txtPathSource.Size = New System.Drawing.Size(360, 20)
        Me.txtPathSource.TabIndex = 3
        '
        'MyButton1
        '
        Me.MyButton1.FlatAppearance.BorderSize = 0
        Me.MyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton1.Image = CType(resources.GetObject("MyButton1.Image"), System.Drawing.Image)
        Me.MyButton1.Location = New System.Drawing.Point(28, 109)
        Me.MyButton1.MyType = MyControlsLibrary.MyButton.ButtonType.btnExecute
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(156, 30)
        Me.MyButton1.TabIndex = 6
        Me.MyButton1.Text = "Import Note"
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'MyButton2
        '
        Me.MyButton2.FlatAppearance.BorderSize = 0
        Me.MyButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton2.Image = CType(resources.GetObject("MyButton2.Image"), System.Drawing.Image)
        Me.MyButton2.Location = New System.Drawing.Point(28, 73)
        Me.MyButton2.MyType = MyControlsLibrary.MyButton.ButtonType.btnExecute
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(156, 30)
        Me.MyButton2.TabIndex = 7
        Me.MyButton2.Text = "Export Note"
        Me.MyButton2.UseVisualStyleBackColor = True
        '
        'MyButton3
        '
        Me.MyButton3.FlatAppearance.BorderSize = 0
        Me.MyButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton3.Image = CType(resources.GetObject("MyButton3.Image"), System.Drawing.Image)
        Me.MyButton3.Location = New System.Drawing.Point(213, 109)
        Me.MyButton3.MyType = MyControlsLibrary.MyButton.ButtonType.btnExecute
        Me.MyButton3.Name = "MyButton3"
        Me.MyButton3.Size = New System.Drawing.Size(156, 30)
        Me.MyButton3.TabIndex = 8
        Me.MyButton3.Text = "Check BODY size"
        Me.MyButton3.UseVisualStyleBackColor = True
        '
        'MyButton4
        '
        Me.MyButton4.FlatAppearance.BorderSize = 0
        Me.MyButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton4.Image = CType(resources.GetObject("MyButton4.Image"), System.Drawing.Image)
        Me.MyButton4.Location = New System.Drawing.Point(407, 109)
        Me.MyButton4.MyType = MyControlsLibrary.MyButton.ButtonType.btnExecute
        Me.MyButton4.Name = "MyButton4"
        Me.MyButton4.Size = New System.Drawing.Size(156, 30)
        Me.MyButton4.TabIndex = 9
        Me.MyButton4.Text = "Import from CSV"
        Me.MyButton4.UseVisualStyleBackColor = True
        '
        'MyButton5
        '
        Me.MyButton5.FlatAppearance.BorderSize = 0
        Me.MyButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton5.Image = CType(resources.GetObject("MyButton5.Image"), System.Drawing.Image)
        Me.MyButton5.Location = New System.Drawing.Point(407, 73)
        Me.MyButton5.MyType = MyControlsLibrary.MyButton.ButtonType.btnExecute
        Me.MyButton5.Name = "MyButton5"
        Me.MyButton5.Size = New System.Drawing.Size(156, 30)
        Me.MyButton5.TabIndex = 10
        Me.MyButton5.Text = "Mobile number"
        Me.MyButton5.UseVisualStyleBackColor = True
        '
        'FormOutlook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 452)
        Me.Name = "FormOutlook"
        Me.Text = "FormOutlook"
        Me.TabControlDetail.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me._ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageMain.ResumeLayout(False)
        Me.tabPageMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents btnOpenFile As MyControlsLibrary.MyButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents txtPathSource As System.Windows.Forms.TextBox
    Friend WithEvents MyButton1 As MyControlsLibrary.MyButton
    Friend WithEvents MyButton2 As MyControlsLibrary.MyButton
    Friend WithEvents MyButton3 As MyControlsLibrary.MyButton
    Friend WithEvents MyButton4 As MyControlsLibrary.MyButton
    Friend WithEvents MyButton5 As MyControlsLibrary.MyButton
End Class
