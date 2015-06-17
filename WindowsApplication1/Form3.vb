Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ProgressBar1.Value = 100 Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://dl.dropbox.com/u/46370133/Noter/Version.txt.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                Button1.Text = ("You are up todate!")
                Label2.Text = ("You may now close this dialog")
            Else
                Button1.Text = ("Downloading update!")
                WebBrowser1.Navigate("http://dl.dropbox.com/u/46370133/Noter/Noter.exe")
                Label2.Text = ("You may now close this dialog")
            End If
        End If
    End Sub
End Class