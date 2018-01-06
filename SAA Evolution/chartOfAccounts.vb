Public Class chartOfAccounts
    Dim SubSnumber As String
    Dim insertgroup As New SAAEvoDatasetTableAdapters.groupNamesTableAdapter
    Dim insertsubgroup As New SAAEvoDatasetTableAdapters.subNamesTableAdapter
    Dim getSubCodes As New SAAEvoDatasetTableAdapters.subNamesTableAdapter
    Dim transdate As Date
    Dim groupName, groupCode, subName, subCode, sno, accountName, accountNo As String
    Dim openingbal, creditlimit As Decimal?
    Private Sub tabSubNames_Click(sender As Object, e As EventArgs) Handles tabSubNames.Click

    End Sub

    Private Sub chartOfAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GroupNamesTableAdapter.Fill(Me.SAAEvoDataset.groupNames)
        Me.CenterToScreen()
        Me.Top = 0
        cmbGroupName.SelectedIndex = -1
    End Sub

    Private Sub btnSbSave_Click(sender As Object, e As EventArgs) Handles btnSbSave.Click
        insertsubgroup.InsertQuery(txtSubName.Text, txtSbCode.Text, "", "", txtSvNumber.Text, CmbSubGrp.Text)
        Me.Close()
    End Sub

    Private Sub btnSbAdd_Click(sender As Object, e As EventArgs) Handles btnSbAdd.Click
        insertsubgroup.InsertQuery(txtSubName.Text, txtSbCode.Text, "", "", txtSvNumber.Text, CmbSubGrp.Text)
        CmbSubGrp.SelectedIndex = -1
        txtSubName.Clear()
        txtSbCode.Clear()
        txtSvNumber.Clear()
        CmbSubGrp.Focus()
    End Sub

    Private Sub btnGrpSave_Click(sender As Object, e As EventArgs) Handles btnGrpSave.Click
        insertgroup.InsertQuery(txtGrpName.Text, txtGrpCode.Text, "")
        Me.Close()
    End Sub

    Private Sub btnGrpAdd_Click(sender As Object, e As EventArgs) Handles btnGrpAdd.Click
        insertgroup.InsertQuery(txtGrpName.Text, txtGrpCode.Text, "")
        txtGrpName.Clear()
        txtGrpCode.Clear()
        txtGrpName.Focus()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmbGroupName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroupName.SelectedIndexChanged
        Try
            Dim getGroupCode As New SAAEvoDatasetTableAdapters.groupNamesTableAdapter
            Dim groupData As DataTable
            Dim groupCode As String
            groupData = getGroupCode.GetDataGroupCode(cmbGroupName.Text)
            groupCode = groupData.Rows(0).Item(1).ToString
            txtGroupCode.Text = groupCode
            Me.SubNamesTableAdapter.FillBy(Me.SAAEvoDataset1.subNames, cmbGroupName.Text)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSbClose_Click(sender As Object, e As EventArgs) Handles btnSbClose.Click

    End Sub

    Private Sub cmbGroupName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroupName.SelectedValueChanged

    End Sub

    Private Sub tabChartOfActs_Click(sender As Object, e As EventArgs) Handles tabChartOfActs.Click

    End Sub

    Private Sub cmbSubName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubName.SelectedIndexChanged
        Try

            Dim subgroupData As DataTable
            Dim subgroupCode As String
            Dim sno As String
            subgroupData = getSubCodes.GetDataBySubname(cmbSubName.Text)
            subgroupCode = subgroupData.Rows(0).Item(1).ToString
            txtSubCode.Text = subgroupCode
            txtsno.Text = subgroupData.Rows(0).Item(4).ToString
            SubSnumber = subgroupData.Rows(0).Item(4).ToString
            txtAccountNo.Text = Trim(txtGroupCode.Text) + Trim(txtSubCode.Text) + Trim(txtsno.Text)
            txtAccountName.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intSnumber As Integer
        Dim strSnumber As String
        Dim updateSnumber As New SAAEvoDatasetTableAdapters.subNamesTableAdapter
        Try
            Dim insertChartActs As New SAAEvoDatasetTableAdapters.chartActsTableAdapter
            groupName = cmbGroupName.Text
            groupCode = txtGroupCode.Text
            subName = cmbSubName.Text
            subCode = txtSubCode.Text
            sno = txtsno.Text
            accountName = txtAccountName.Text
            accountNo = txtAccountNo.Text
            transdate = Convert.ToDateTime(txtTransDate.Text)
            insertChartActs.InsertQuery(accountNo, accountName, subName, subCode, groupCode, groupName, "", "", "", 0, "", "", "", "", accountNo, 0, "", "", transdate, transdate, 0, 0)
            intSnumber = Convert.ToInt32(SubSnumber)
            intSnumber = intSnumber + 1
            strSnumber = Convert.ToString(intSnumber)
            updateSnumber.UpdateQuery(strSnumber, subName)
            Me.Close()
            cmbGroupName.SelectedIndex = -1
            txtGroupCode.Clear()
            cmbSubName.SelectedIndex = -1
            txtSubCode.Clear()
            txtsno.Clear()
            txtAccountName.Clear()
            txtAccountNo.Clear()
            cmbGroupName.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SubNamesBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles SubNamesBindingSource.CurrentChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim insertChartActs As New SAAEvoDatasetTableAdapters.chartActsTableAdapter
        groupName = cmbGroupName.Text
        groupCode = txtGroupCode.Text
        subName = cmbSubName.Text
        subCode = txtSubCode.Text
        sno = txtsno.Text
        accountName = txtAccountName.Text
        accountNo = txtAccountNo.Text
        transdate = Convert.ToDateTime(txtTransDate.Text)
        insertChartActs.InsertQuery(accountNo, accountName, subName, subCode, groupCode, groupName, "", "", "", 0, "", "", "", "", accountNo, 0, "", "", transdate, transdate, 0, 0)
        cmbGroupName.SelectedIndex = -1
        txtGroupCode.Clear()
        cmbSubName.SelectedIndex = -1
        txtSubCode.Clear()
        txtsno.Clear()
        txtAccountName.Clear()
        txtAccountNo.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
End Class