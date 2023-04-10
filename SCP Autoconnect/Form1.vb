Public Class Form1
    Dim running As Boolean = False
    Dim IP As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If running = False Then
            Autopaste.RunWorkerAsync()
            running = True
        End If
    End Sub
    Private Sub Autopaste_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Autopaste.DoWork
        Do
            For Each letter In ("connect " & IP & "
")
                SendKeys.SendWait(letter)
            Next
            Threading.Thread.Sleep(2000)
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Environment.Exit(0)
    End Sub
End Class
