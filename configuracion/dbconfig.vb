Public Class dbconfig
    Dim cs As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=[basededatos];Integrated Security=True;Connect Timeout=30;User Instance=True"
    Private Sub dbconfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        barra.Visible = False
    End Sub

    Private Sub Boton_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_open.Click
        Dim file As String
        Me.OpenFileDialog1.ShowDialog()
        file = Me.OpenFileDialog1.FileName
        Me.basetxt.Text = file
        Me.cstxt.Text = cs.Replace("[basededatos]", file)
        Me.ldftxt.Text = Me.basetxt.Text.Replace(".mdf", "_log.ldf")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.cstxt.Text = cs.Replace("[basededatos]", basetxt.Text)
        Dim fullFilePath As String
        With My.Computer.FileSystem
            fullFilePath = .CombinePath(.SpecialDirectories.MyDocuments, fileini)
        End With
        Dim f As New System.IO.StreamWriter(fullFilePath, False)
        With My.Settings
            f.WriteLine(basetxt.Text)
        End With
        f.Close()
        Me.Close()
    End Sub

End Class