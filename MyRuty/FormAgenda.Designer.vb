<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgenda))
        Me.UcDataInizioDataFine1 = New MyControlsLibrary.UcDataInizioDataFine
        Me.MyButton1 = New MyControlsLibrary.MyButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLunediM = New System.Windows.Forms.TextBox
        Me.txtMartediM = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMercolediM = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtGiovediM = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtVenerdiM = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSabatoM = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDomenicaM = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDomenicaP = New System.Windows.Forms.TextBox
        Me.txtLunediP = New System.Windows.Forms.TextBox
        Me.txtSabatoP = New System.Windows.Forms.TextBox
        Me.txtMartediP = New System.Windows.Forms.TextBox
        Me.txtVenerdiP = New System.Windows.Forms.TextBox
        Me.txtMercolediP = New System.Windows.Forms.TextBox
        Me.txtGiovediP = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkEcografia = New System.Windows.Forms.RadioButton
        Me.chkAmbulatorio = New System.Windows.Forms.RadioButton
        Me.TabControlDetail.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me._ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageMain.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlDetail
        '
        Me.TabControlDetail.Size = New System.Drawing.Size(682, 258)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Size = New System.Drawing.Size(674, 232)
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 258)
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.GroupBox1)
        Me.panel1.Controls.Add(Me.MyButton1)
        Me.panel1.Controls.Add(Me.UcDataInizioDataFine1)
        Me.panel1.Size = New System.Drawing.Size(706, 69)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.SplitterDistance = 94
        '
        'UcDataInizioDataFine1
        '
        Me.UcDataInizioDataFine1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcDataInizioDataFine1.Location = New System.Drawing.Point(0, 0)
        Me.UcDataInizioDataFine1.Name = "UcDataInizioDataFine1"
        Me.UcDataInizioDataFine1.Size = New System.Drawing.Size(301, 69)
        Me.UcDataInizioDataFine1.TabIndex = 0
        '
        'MyButton1
        '
        Me.MyButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyButton1.FlatAppearance.BorderSize = 0
        Me.MyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton1.Image = CType(resources.GetObject("MyButton1.Image"), System.Drawing.Image)
        Me.MyButton1.Location = New System.Drawing.Point(526, 31)
        Me.MyButton1.MyType = MyControlsLibrary.MyButton.ButtonType.btnSave
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(156, 30)
        Me.MyButton1.TabIndex = 1
        Me.MyButton1.Text = "Genera Excel"
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lunedì"
        '
        'txtLunediM
        '
        Me.txtLunediM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLunediM.Location = New System.Drawing.Point(75, 24)
        Me.txtLunediM.Name = "txtLunediM"
        Me.txtLunediM.Size = New System.Drawing.Size(241, 20)
        Me.txtLunediM.TabIndex = 1
        '
        'txtMartediM
        '
        Me.txtMartediM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMartediM.Location = New System.Drawing.Point(75, 50)
        Me.txtMartediM.Name = "txtMartediM"
        Me.txtMartediM.Size = New System.Drawing.Size(241, 20)
        Me.txtMartediM.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Martedì"
        '
        'txtMercolediM
        '
        Me.txtMercolediM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMercolediM.Location = New System.Drawing.Point(75, 76)
        Me.txtMercolediM.Name = "txtMercolediM"
        Me.txtMercolediM.Size = New System.Drawing.Size(241, 20)
        Me.txtMercolediM.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mercoledì"
        '
        'txtGiovediM
        '
        Me.txtGiovediM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGiovediM.Location = New System.Drawing.Point(75, 102)
        Me.txtGiovediM.Name = "txtGiovediM"
        Me.txtGiovediM.Size = New System.Drawing.Size(241, 20)
        Me.txtGiovediM.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Giovedì"
        '
        'txtVenerdiM
        '
        Me.txtVenerdiM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVenerdiM.Location = New System.Drawing.Point(75, 128)
        Me.txtVenerdiM.Name = "txtVenerdiM"
        Me.txtVenerdiM.Size = New System.Drawing.Size(241, 20)
        Me.txtVenerdiM.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Venerdì"
        '
        'txtSabatoM
        '
        Me.txtSabatoM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSabatoM.Location = New System.Drawing.Point(75, 154)
        Me.txtSabatoM.Name = "txtSabatoM"
        Me.txtSabatoM.Size = New System.Drawing.Size(241, 20)
        Me.txtSabatoM.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sabato"
        '
        'txtDomenicaM
        '
        Me.txtDomenicaM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDomenicaM.Location = New System.Drawing.Point(75, 180)
        Me.txtDomenicaM.Name = "txtDomenicaM"
        Me.txtDomenicaM.Size = New System.Drawing.Size(241, 20)
        Me.txtDomenicaM.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Domenica"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtDomenicaM)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtLunediM)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtSabatoM)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtMartediM)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtVenerdiM)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtMercolediM)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtGiovediM)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtDomenicaP)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtLunediP)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtSabatoP)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtMartediP)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtVenerdiP)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtMercolediP)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtGiovediP)
        Me.SplitContainer2.Size = New System.Drawing.Size(668, 226)
        Me.SplitContainer2.SplitterDistance = 330
        Me.SplitContainer2.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(147, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Mattina"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(119, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Pomeriggio"
        '
        'txtDomenicaP
        '
        Me.txtDomenicaP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDomenicaP.Location = New System.Drawing.Point(18, 180)
        Me.txtDomenicaP.Name = "txtDomenicaP"
        Me.txtDomenicaP.Size = New System.Drawing.Size(297, 20)
        Me.txtDomenicaP.TabIndex = 20
        '
        'txtLunediP
        '
        Me.txtLunediP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLunediP.Location = New System.Drawing.Point(18, 24)
        Me.txtLunediP.Name = "txtLunediP"
        Me.txtLunediP.Size = New System.Drawing.Size(297, 20)
        Me.txtLunediP.TabIndex = 14
        '
        'txtSabatoP
        '
        Me.txtSabatoP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSabatoP.Location = New System.Drawing.Point(18, 154)
        Me.txtSabatoP.Name = "txtSabatoP"
        Me.txtSabatoP.Size = New System.Drawing.Size(297, 20)
        Me.txtSabatoP.TabIndex = 19
        '
        'txtMartediP
        '
        Me.txtMartediP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMartediP.Location = New System.Drawing.Point(18, 50)
        Me.txtMartediP.Name = "txtMartediP"
        Me.txtMartediP.Size = New System.Drawing.Size(297, 20)
        Me.txtMartediP.TabIndex = 15
        '
        'txtVenerdiP
        '
        Me.txtVenerdiP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVenerdiP.Location = New System.Drawing.Point(18, 128)
        Me.txtVenerdiP.Name = "txtVenerdiP"
        Me.txtVenerdiP.Size = New System.Drawing.Size(297, 20)
        Me.txtVenerdiP.TabIndex = 18
        '
        'txtMercolediP
        '
        Me.txtMercolediP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMercolediP.Location = New System.Drawing.Point(18, 76)
        Me.txtMercolediP.Name = "txtMercolediP"
        Me.txtMercolediP.Size = New System.Drawing.Size(297, 20)
        Me.txtMercolediP.TabIndex = 16
        '
        'txtGiovediP
        '
        Me.txtGiovediP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGiovediP.Location = New System.Drawing.Point(18, 102)
        Me.txtGiovediP.Name = "txtGiovediP"
        Me.txtGiovediP.Size = New System.Drawing.Size(297, 20)
        Me.txtGiovediP.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkEcografia)
        Me.GroupBox1.Controls.Add(Me.chkAmbulatorio)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(301, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 69)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agenda"
        '
        'chkEcografia
        '
        Me.chkEcografia.AutoSize = True
        Me.chkEcografia.Location = New System.Drawing.Point(21, 44)
        Me.chkEcografia.Name = "chkEcografia"
        Me.chkEcografia.Size = New System.Drawing.Size(70, 17)
        Me.chkEcografia.TabIndex = 1
        Me.chkEcografia.TabStop = True
        Me.chkEcografia.Text = "Ecografia"
        Me.chkEcografia.UseVisualStyleBackColor = True
        '
        'chkAmbulatorio
        '
        Me.chkAmbulatorio.AutoSize = True
        Me.chkAmbulatorio.Location = New System.Drawing.Point(21, 20)
        Me.chkAmbulatorio.Name = "chkAmbulatorio"
        Me.chkAmbulatorio.Size = New System.Drawing.Size(80, 17)
        Me.chkAmbulatorio.TabIndex = 0
        Me.chkAmbulatorio.TabStop = True
        Me.chkAmbulatorio.Text = "Ambulatorio"
        Me.chkAmbulatorio.UseVisualStyleBackColor = True
        '
        'FormAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 452)
        Me.Name = "FormAgenda"
        Me.Text = "FormAgenda"
        Me.TabControlDetail.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me._ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageMain.ResumeLayout(False)
        Me.tabPageMain.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcDataInizioDataFine1 As MyControlsLibrary.UcDataInizioDataFine
    Friend WithEvents MyButton1 As MyControlsLibrary.MyButton
    Friend WithEvents txtDomenicaM As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSabatoM As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtVenerdiM As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGiovediM As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMercolediM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMartediM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLunediM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEcografia As System.Windows.Forms.RadioButton
    Friend WithEvents chkAmbulatorio As System.Windows.Forms.RadioButton
    Friend WithEvents txtDomenicaP As System.Windows.Forms.TextBox
    Friend WithEvents txtLunediP As System.Windows.Forms.TextBox
    Friend WithEvents txtSabatoP As System.Windows.Forms.TextBox
    Friend WithEvents txtMartediP As System.Windows.Forms.TextBox
    Friend WithEvents txtVenerdiP As System.Windows.Forms.TextBox
    Friend WithEvents txtMercolediP As System.Windows.Forms.TextBox
    Friend WithEvents txtGiovediP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
