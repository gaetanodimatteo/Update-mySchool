Public Class Form1

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub Sostituisci()
        Dim ListaNon As New List(Of String)
        Dim ListaSi As New List(Of String)
        Dim PercorsoOrigine As String = LeggiValoreXML("percorsoorigine")
        Dim Scuola As String = LeggiValoreXML("scuola")

        If Scuola = "Assofram" Then
            For Each Dir As String In System.IO.Directory.GetDirectories("c:\client")
                If Dir.StartsWith("c:\client\cas") Then
                    Try
                        My.Computer.FileSystem.CopyFile(PercorsoOrigine & "\mySchool.exe", Dir & "\mySchool\mySchool.exe", True)
                        My.Computer.FileSystem.CopyFile(PercorsoOrigine & "\ctrl.dll", Dir & "\mySchool\ctrl.dll", True)
                        ListaSi.Add(Dir)
                    Catch ex As Exception
                        ListaNon.Add(Dir)
                    End Try
                ElseIf Dir.StartsWith("c:\client\Nap") Then
                    Try
                        My.Computer.FileSystem.CopyFile(PercorsoOrigine & "\mySchool.exe", Dir & "\mySchool.exe", True)
                        My.Computer.FileSystem.CopyFile(PercorsoOrigine & "\ctrl.dll", Dir & "\ctrl.dll", True)
                        ListaSi.Add(Dir)
                    Catch ex As Exception
                        ListaNon.Add(Dir)
                    End Try
                End If
            Next
        Else
            For Each Dir As String In System.IO.Directory.GetDirectories("c:\")
                If Dir.StartsWith("c:\mySchool") Then
                    Try
                        My.Computer.FileSystem.CopyFile(PercorsoOrigine & "\mySchool.exe", Dir & "\mySchool.exe", True)
                        My.Computer.FileSystem.CopyFile(PercorsoOrigine & "\ctrl.dll", Dir & "\ctrl.dll", True)
                        ListaSi.Add(Dir)
                    Catch ex As Exception
                        ListaNon.Add(Dir)
                    End Try
                End If
            Next
        End If

        LV1.Items.Clear()
        For Each s As String In ListaSi
            LV1.Items.Add(s)
            LV1.Items(LV1.Items.Count - 1).SubItems.Add("Completato")
        Next
        For Each s As String In ListaNon
            LV1.Items.Add(s)
            LV1.Items(LV1.Items.Count - 1).SubItems.Add("Sospeso")
        Next
    End Sub

    Public Function LeggiValoreXML(ByVal Campo As String) As String
        Try
            Using ds As New DataSet
                ds.ReadXml(Application.StartupPath & "\SettingUpdate.xml")
                Return ds.Tables(0).Rows(0).Item(Campo).ToString
            End Using
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub btnSostituisci_Click(sender As Object, e As EventArgs) Handles btnSostituisci.Click
        Sostituisci()
    End Sub

End Class
