<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSteganografiaV2
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSteganografiaV2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New MyControlsLibrary.MyButton()
        Me.btnDecode = New MyControlsLibrary.MyButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtMessaggio = New System.Windows.Forms.TextBox()
        Me.TabPage1.SuspendLayout()
        Me.TabControlDetail.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me._ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageMain.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Size = New System.Drawing.Size(778, 196)
        '
        'TabControlDetail
        '
        Me.TabControlDetail.Controls.Add(Me.TabPage2)
        Me.TabControlDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControlDetail.Size = New System.Drawing.Size(786, 222)
        Me.TabControlDetail.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControlDetail.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.txtPassword)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.btnDecode)
        Me.panel1.Size = New System.Drawing.Size(786, 142)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Size = New System.Drawing.Size(786, 393)
        Me.SplitContainer1.SplitterDistance = 167
        '
        'tabPageMain
        '
        Me.tabPageMain.Size = New System.Drawing.Size(792, 424)
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(772, 190)
        Me.DataGridView1.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(78, 23)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(274, 20)
        Me.txtPassword.TabIndex = 22
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Password:"
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
        Me.btnSave.Location = New System.Drawing.Point(610, 67)
        Me.btnSave.MyType = MyControlsLibrary.MyButton.ButtonType.btnSave
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(156, 30)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Codifica e salva"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDecode
        '
        Me.btnDecode.BackColor = System.Drawing.Color.Transparent
        Me.btnDecode.FlatAppearance.BorderSize = 0
        Me.btnDecode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDecode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecode.Image = CType(resources.GetObject("btnDecode.Image"), System.Drawing.Image)
        Me.btnDecode.Location = New System.Drawing.Point(19, 67)
        Me.btnDecode.MyType = MyControlsLibrary.MyButton.ButtonType.btnExecute
        Me.btnDecode.Name = "btnDecode"
        Me.btnDecode.Size = New System.Drawing.Size(156, 30)
        Me.btnDecode.TabIndex = 19
        Me.btnDecode.Text = "Decodifica"
        Me.btnDecode.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtMessaggio)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(778, 196)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtMessaggio
        '
        Me.txtMessaggio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMessaggio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessaggio.Location = New System.Drawing.Point(0, 0)
        Me.txtMessaggio.Multiline = True
        Me.txtMessaggio.Name = "txtMessaggio"
        Me.txtMessaggio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessaggio.Size = New System.Drawing.Size(778, 196)
        Me.txtMessaggio.TabIndex = 6
        '
        'FormSteganografiaV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "FormSteganografiaV2"
        Me.Text = "FormSteganografiaV2"
        Me.TabPage1.ResumeLayout(False)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As MyControlsLibrary.MyButton
    Friend WithEvents btnDecode As MyControlsLibrary.MyButton
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents txtMessaggio As TextBox
End Class
