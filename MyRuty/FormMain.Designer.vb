<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits MyFormsLibrary.FormMaster

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.UcMenuLeftStack1 = New MyControlsLibrary.UcMenuLeftStack()
        Me.UcMenuLeftTreeView1 = New MyControlsLibrary.UcMenuLeftTreeView()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.UcMenuLeftTreeView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.UcMenuLeftStack1)
        Me.SplitContainer2.Size = New System.Drawing.Size(230, 498)
        Me.SplitContainer2.SplitterDistance = 285
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Size = New System.Drawing.Size(956, 498)
        '
        'tabControlMain
        '
        Me.tabControlMain.Size = New System.Drawing.Size(722, 498)
        '
        'UcMenuLeftStack1
        '
        Me.UcMenuLeftStack1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMenuLeftStack1.Location = New System.Drawing.Point(0, 0)
        Me.UcMenuLeftStack1.Name = "UcMenuLeftStack1"
        Me.UcMenuLeftStack1.Size = New System.Drawing.Size(230, 209)
        Me.UcMenuLeftStack1.TabIndex = 0
        '
        'UcMenuLeftTreeView1
        '
        Me.UcMenuLeftTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMenuLeftTreeView1.Location = New System.Drawing.Point(0, 0)
        Me.UcMenuLeftTreeView1.Name = "UcMenuLeftTreeView1"
        Me.UcMenuLeftTreeView1.Size = New System.Drawing.Size(230, 285)
        Me.UcMenuLeftTreeView1.TabIndex = 0
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 544)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcMenuLeftStack1 As MyControlsLibrary.UcMenuLeftStack
    Friend WithEvents UcMenuLeftTreeView1 As MyControlsLibrary.UcMenuLeftTreeView

End Class
