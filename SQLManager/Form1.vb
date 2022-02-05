Imports System.Data.SqlClient

Public Class Form1
    Function MasterConnection() As SqlConnection
        Try
            If SqlHostName.Text = "localhost" Then
                If SqlInstance.Text = "" Then
                    Return New SqlConnection("Data Source=localhost;Initial Catalog=master;Integrated Security=True")
                Else
                    Return New SqlConnection("Data Source=localhost\" + SqlInstance.Text + ";Initial Catalog=master;Integrated Security=True")
                End If
            Else
                Return New SqlConnection("Data Source=(localdb)\" + SqlInstance.Text + ";Initial Catalog=master;Integrated Security=True")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Dim a As New SqlConnection
            Return a
        End Try
    End Function
    Function Connection() As SqlConnection
        Try
            If SqlHostName.Text = "localhost" Then
                If SqlInstance.Text = "" Then
                    Return New SqlConnection("Data Source=localhost;Initial Catalog=" + DatabaseList.Text + ";Integrated Security=True")
                Else
                    Return New SqlConnection("Data Source=localhost\" + SqlInstance.Text + ";Initial Catalog=" + DatabaseList.Text + ";Integrated Security=True")
                End If
            Else
                Return New SqlConnection("Data Source=(localdb)\" + SqlInstance.Text + ";Initial Catalog=" + DatabaseList.Text + ";Integrated Security=True")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Dim a As New SqlConnection
            Return a
        End Try
    End Function
    Function GetTable(Connection_ As SqlConnection, cmd As SqlCommand) As DataTable
        Try
            Dim _da = New SqlDataAdapter()
            Dim table = New DataTable("DATA")
            Dim _conn = Connection_
            Try
                _conn.Open()
                cmd.Connection = _conn
                _da.SelectCommand = cmd
                _da.SelectCommand.CommandTimeout = 0
                table.Locale = Globalization.CultureInfo.InvariantCulture
                _da.Fill(table)
                _da.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                _conn.Close()
                _da.Dispose()
                _conn.Dispose()
            End Try
            If table IsNot Nothing Then
                If table.Rows.Count > 0 Then
                    Return table
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return Nothing
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conn = MasterConnection()

            DatabaseList.BeginInvoke(New Action(Sub()

                                                    DatabaseList.DisplayMember = "Text"
                                                    DatabaseList.ValueMember = "Value"
                                                    Dim tb As New DataTable
                                                    tb.Columns.Add("Text", GetType(String))
                                                    tb.Columns.Add("Value", GetType(Long))
                                                    Dim cmd As New SqlCommand("SELECT name, database_id FROM sys.databases")
                                                    Dim tablo As DataTable = GetTable(conn, cmd)
                                                    If tablo IsNot Nothing Then
                                                        For i = 0 To tablo.Rows.Count - 1
                                                            If tablo.Rows(i)("name").ToString <> "master" And tablo.Rows(i)("name").ToString <> "tempdb" And tablo.Rows(i)("name").ToString <> "model" And tablo.Rows(i)("name").ToString <> "msdb" Then
                                                                tb.Rows.Add(tablo.Rows(i)("name").ToString, tablo.Rows(i)("database_id"))
                                                            End If
                                                        Next
                                                        DatabaseList.DataSource = tb
                                                    End If
                                                End Sub))

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub DatabaseList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DatabaseList.SelectedIndexChanged
        Try
            Tablolar.Items.Clear()
            Dim conn = Connection()
            Dim cmd As New SqlCommand("SELECT TABLE_NAME as Tablolar FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='" + DatabaseList.Text + "' order by TABLE_NAME")
            Dim tablo As DataTable = GetTable(conn, cmd)
            If tablo IsNot Nothing Then
                For i = 0 To tablo.Rows.Count - 1
                    If tablo.Rows(i)("Tablolar").ToString <> "sysdiagrams" Then
                        Tablolar.Items.Add(tablo.Rows(i)("Tablolar").ToString)
                    End If
                Next
            Else
                MessageBox.Show("Tablo bilgisi alınamadı !")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim a1 As String = Nothing
            Dim a2 As String = Nothing
            Dim conn = Connection()
            Dim cmd As New SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + Tablolar.Text + "'")
            Dim tablo As DataTable = GetTable(conn, cmd)
            If tablo IsNot Nothing Then
                For i = 0 To tablo.Rows.Count - 1
                    a1 += tablo.Rows(i)("COLUMN_NAME").ToString + ","
                    a2 += "@" + tablo.Rows(i)("COLUMN_NAME").ToString + ","
                Next
                a1 = a1 + ","
                a1 = a1.Replace(",,", "")
                a2 = a2 + ","
                a2 = a2.Replace(",,", "")
                If scope.Checked Then
                    Sonuc.Text = "insert into " + Tablolar.Text + " (" + a1 + ") values(" + a2 + ") SELECT SCOPE_IDENTITY()"
                Else
                    Sonuc.Text = "insert into " + Tablolar.Text + " (" + a1 + ") values(" + a2 + ")"
                End If
            Else
                MessageBox.Show("Tablo kolon bilgisi alınamadı !")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim a1 As String = Nothing
            Dim conn = Connection()
            Dim cmd As New SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + Tablolar.Text + "'")
            Dim tablo As DataTable = GetTable(conn, cmd)
            If tablo IsNot Nothing Then
                For i = 0 To tablo.Rows.Count - 1
                    a1 += tablo.Rows(i)("COLUMN_NAME").ToString + "=@" + tablo.Rows(i)("COLUMN_NAME").ToString + ","
                Next
                a1 = a1 + ","
                a1 = a1.Replace(",,", "")
                Sonuc.Text = "update " + Tablolar.Text + " set " + a1
            Else
                MessageBox.Show("Tablo kolon bilgisi alınamadı !")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clipboard.Clear()
        Clipboard.SetText(Sonuc.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SqlHostName.SelectedIndex = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim a1 As String = Nothing
            Dim conn = Connection()
            Dim cmd As New SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + Tablolar.Text + "'")
            Dim tablo As DataTable = GetTable(conn, cmd)
            If tablo IsNot Nothing Then
                For i = 0 To tablo.Rows.Count - 1
                    a1 += "cmd.Parameters.AddWithValue(""@" + tablo.Rows(i)("COLUMN_NAME").ToString + """," + tablo.Rows(i)("COLUMN_NAME").ToString + ")" + Environment.NewLine
                Next
                Sonuc.Text = a1
            Else
                MessageBox.Show("Tablo kolon bilgisi alınamadı !")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
