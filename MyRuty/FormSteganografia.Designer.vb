<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSteganografia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSteganografia))
        Me.txtMessaggio = New System.Windows.Forms.TextBox()
        Me.btnDecode = New MyControlsLibrary.MyButton()
        Me.btnSave = New MyControlsLibrary.MyButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.TabPage1.SuspendLayout()
        Me.TabControlDetail.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me._ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtMessaggio)
        Me.TabPage1.Size = New System.Drawing.Size(636, 264)
        Me.TabPage1.Text = "Messaggio"
        '
        'TabControlDetail
        '
        Me.TabControlDetail.Size = New System.Drawing.Size(644, 290)
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.txtPassword)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.btnDecode)
        Me.panel1.Size = New System.Drawing.Size(644, 118)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Size = New System.Drawing.Size(644, 437)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'tabPageMain
        '
        Me.tabPageMain.Size = New System.Drawing.Size(650, 468)
        '
        'txtMessaggio
        '
        Me.txtMessaggio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMessaggio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessaggio.Location = New System.Drawing.Point(3, 3)
        Me.txtMessaggio.Multiline = True
        Me.txtMessaggio.Name = "txtMessaggio"
        Me.txtMessaggio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessaggio.Size = New System.Drawing.Size(630, 258)
        Me.txtMessaggio.TabIndex = 5
        '
        'btnDecode
        '
        Me.btnDecode.BackColor = System.Drawing.Color.Transparent
        Me.btnDecode.FlatAppearance.BorderSize = 0
        Me.btnDecode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDecode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecode.Image = CType(resources.GetObject("btnDecode.Image"), System.Drawing.Image)
        Me.btnDecode.Location = New System.Drawing.Point(7, 74)
        Me.btnDecode.MyType = MyControlsLibrary.MyButton.ButtonType.btnExecute
        Me.btnDecode.Name = "btnDecode"
        Me.btnDecode.Size = New System.Drawing.Size(156, 30)
        Me.btnDecode.TabIndex = 15
        Me.btnDecode.Text = "Decodifica"
        Me.btnDecode.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(481, 74)
        Me.btnSave.MyType = MyControlsLibrary.MyButton.ButtonType.btnSave
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(156, 30)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Codifica e salva"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(69, 13)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(274, 20)
        Me.txtPassword.TabIndex = 18
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'FormSteganografia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 494)
        Me.Name = "FormSteganografia"
        Me.Text = "FormSteganografia"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControlDetail.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me._ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageMain.ResumeLayout(False)
        Me.tabPageMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtMessaggio As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As MyControlsLibrary.MyButton
    Friend WithEvents btnDecode As MyControlsLibrary.MyButton
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
