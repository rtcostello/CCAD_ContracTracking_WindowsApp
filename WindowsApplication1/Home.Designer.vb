<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.btnSubmitContract = New System.Windows.Forms.Button()
        Me.lblUserLogged = New System.Windows.Forms.Label()
        Me.btnTracker = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSubmitContract
        '
        Me.btnSubmitContract.Location = New System.Drawing.Point(12, 39)
        Me.btnSubmitContract.Name = "btnSubmitContract"
        Me.btnSubmitContract.Size = New System.Drawing.Size(102, 38)
        Me.btnSubmitContract.TabIndex = 0
        Me.btnSubmitContract.Text = "Submit Contract"
        Me.btnSubmitContract.UseVisualStyleBackColor = True
        '
        'lblUserLogged
        '
        Me.lblUserLogged.AutoSize = True
        Me.lblUserLogged.Location = New System.Drawing.Point(12, 9)
        Me.lblUserLogged.Name = "lblUserLogged"
        Me.lblUserLogged.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUserLogged.Size = New System.Drawing.Size(75, 13)
        Me.lblUserLogged.TabIndex = 2
        Me.lblUserLogged.Text = "lblUserLogged"
        Me.lblUserLogged.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnTracker
        '
        Me.btnTracker.Location = New System.Drawing.Point(12, 83)
        Me.btnTracker.Name = "btnTracker"
        Me.btnTracker.Size = New System.Drawing.Size(102, 38)
        Me.btnTracker.TabIndex = 3
        Me.btnTracker.Text = "Contract Tracking"
        Me.btnTracker.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 700)
        Me.Controls.Add(Me.btnTracker)
        Me.Controls.Add(Me.lblUserLogged)
        Me.Controls.Add(Me.btnSubmitContract)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Home"
        Me.Text = "Corporate Contracting Application Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmitContract As Button
    Friend WithEvents lblUserLogged As Label
    Friend WithEvents btnTracker As Button
End Class
