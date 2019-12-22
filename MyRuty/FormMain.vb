Public Class FormMain
    Inherits MyFormsLibrary.FormMaster
    Implements MyFormsLibrary.IFormMaster

    Public Overrides Function _buildMenuTop() As Boolean Implements MyFormsLibrary.IFormMaster.BuildMenuTop
        Return True
    End Function

    Public Overrides Function _menuTopSubItemClicked(ByVal clickedItem As System.Windows.Forms.ToolStripItem) As Boolean Implements MyFormsLibrary.IFormMaster.MenuTopSubItemClicked
        Return True
    End Function

    Public Overrides Function _buildMenuLeft() As Boolean Implements MyFormsLibrary.IFormMaster.BuildMenuLeft

        Me.UcMenuLeftStack1._init()
        Me.UcMenuLeftStack1._addGroup("Applicazioni")
        Return True
    End Function

    Private Sub UcMenuLeftStack1_MyGroupOnClickMenuLeftStack(ByVal group As System.String) Handles UcMenuLeftStack1.MyMenuLeftStackGroupOnClick
        UcMenuLeftTreeView1._clear()

        Dim myNode As System.Windows.Forms.TreeNode

        Select group
            Case "Applicazioni"
                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nCalendario", "Calendario")
                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nAgenda", "Agenda")

                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nSteganografia", "Steganografia")
                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nSteganografiaV2", "Steganografia (NEW)")
                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nM3UtoFile", "M3U")
                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nM3UtoNAS", "M3U on NAS")
                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nOutlook", "Outlook")
                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nOutlookGoogle", "Sync Outlook with Google")
                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nAccessSQL", "Access")
                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nRename", "File rename")
                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nRenameByMD5", "File rename by MD5")
                myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nAtac", "Atac 767")

                'Me.UcMenuLeftTreeView1._addNodeLevel_2("nChart1", "Chart1", myNode)
                '  Case "Click Once"
                '     myNode = Me.UcMenuLeftTreeView1._addNodeLevel_1("nDeploySteganografia", "Steganografia")

            Case Else
                Throw New MyManager.ManagerException("MenuStack non gestito:" & group)
        End Select

        Me.UcMenuLeftTreeView1._init()
    End Sub


    Private Sub UcMenuLeftTreeView1_OnClickMenuLeft(ByVal node As System.Windows.Forms.TreeNode) Handles UcMenuLeftTreeView1.MyOnClickMenuLeft
        Dim f As MyFormsLibrary.FormBaseDetail_1 = Nothing

        Select Case node.Name
            Case "nM3UtoFile"
                f = New FormM3U()
            Case "nM3UtoNAS"
                f = New FormM3UtoNAS()
            Case "nOutlook"
                f = New FormOutlook()
            Case "nOutlookGoogle"
                f = New FormSyncOutlookWithGoogle()
            Case "nSteganografia"
                f = New FormSteganografia()
            Case "nSteganografiaV2"
                f = New FormSteganografiaV2()
            Case "nAgenda"
                f = New FormAgenda()
            Case "nAccessSQL"
                f = New FormAccessSQL()
            Case "nRename"
                f = New FormRename()
            Case "nRenameByMD5"
                f = New FormRenameByMD5()
            Case "nAtac"
                f = New FormAutobus()
        End Select

        f.Owner = Me
        f._setTitolo(node.Text)
        f._init(Nothing, Me.MyStatusBar, MyProgressBar)
        Me._addTabPage(f._getTabPage())

    End Sub

    Private Sub FormMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _init()

        _displayMenuTopKillProcessExcel()

        Me.UcMenuLeftStack1_MyGroupOnClickMenuLeftStack("Applicazioni")

    End Sub
End Class
