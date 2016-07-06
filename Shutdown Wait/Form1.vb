Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'NOTE: You will need to change the - to / if you want to use this on Windows 7

        Shell("shutdown -a")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'NOTE: You will need to change the - to / if you want to use this on Windows 7

        If ComboBox1.SelectedItem = "Restart" Then
            Shell("shutdown -r -f -t " & TextBox1.Text)
        End If
        If ComboBox1.SelectedItem = "Shutdown" Then
            Shell("shutdown -s -f -t " & TextBox1.Text)
        End If
        If ComboBox1.SelectedItem = "Logoff" Then
            Shell("shutdown -l -f -t " & TextBox1.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim webAddress As String = "http://techreviewsandhelp.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim webAddress As String = "http://techreviewsandhelp.com/youtube"
        Process.Start(webAddress)
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim webAddress As String = "http://techreviewsandhelp.com/github"
        Process.Start(webAddress)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim webAddress As String = "http://techreviewsandhelp.com/patreon"
        Process.Start(webAddress)
    End Sub
End Class
