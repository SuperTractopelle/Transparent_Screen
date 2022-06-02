Public Class Form1

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
     
        If e.KeyCode = Keys.F8 Then
            End
        Else
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)

        Dim primaryScreen = Windows.Forms.Screen.PrimaryScreen
        Dim allScreens = Windows.Forms.Screen.AllScreens
        Dim Total_Width As Integer
        Dim Total_Height As Integer

        For Each fe_screen In allScreens
            Total_Width += fe_screen.Bounds.Width
            Total_Height += fe_screen.Bounds.Height
        Next

        Me.Size = New Point(Total_Width, Total_Height)

    End Sub

    Private Sub Form1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Activate()
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.TopMost = True
        Me.Activate()
    End Sub

End Class
