Public Class Home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmitContract.Click
        Submit_Contract.Show()
    End Sub
    Private Sub Home_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblUserLogged.Text = "Logged in as: " & CCADFullName()
    End Sub
    Private Sub btnTracker_Click(sender As Object, e As EventArgs) Handles btnTracker.Click
        Tracker_Contracts.Show()
    End Sub
End Class