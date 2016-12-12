Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Public Class Home
    'datagrid pull
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim ds As DataSet = New DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmitContract.Click
        Submit_Contract.Show()
    End Sub
    Private Sub Home_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'datagrid information pull
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "P:\NewSystem\tracking_db.accdb" ' change to access database location on your computer
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        da = New OleDbDataAdapter("Select [CCG], [STATUS], [VENDOR], [CATEGORY], [EXPDATE], [MEDITRACT], [CONTRACT_TYPE], [PHYS_CHAMPION], [NOTES], [VAT] from tbl_contracts", myConnection)
        da.Fill(ds, "Items")
        ' replace "items" with the name of the table
        ' replace [Item Code], [Description], [Price] with the columns headers
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        DataGridView1.DataSource = view1
        DataGridView1.Refresh()

        'user identification (full name)
        Me.lblUserLogged.Text = "Logged in as: " & CCADFullName()

        'filter by user (username)
        source1.Filter = "[CCG] = '" & CCADLogin() & "' AND [STATUS] = 'ACTIVE'"
        DataGridView1.Refresh()

    End Sub
    Private Sub btnTracker_Click(sender As Object, e As EventArgs) Handles btnTracker.Click
        Tracker_Contracts.Show()
    End Sub
End Class