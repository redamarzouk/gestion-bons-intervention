Imports System.Data.SqlClient

Public Class Form4
    Dim connection As New SqlConnection("Server = SONY-PC\SQLEXPRESS1 ; Database = MAINTENANCE; Integrated Security = true")



    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TBid.Text <> "" Then
            MsgBox("le champ ID doit être vide")





        ElseIf MsgBox("CONFIRMER L'AJOUT?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then


            DateTimePicker1.Format = DateTimePickerFormat.Custom
            DateTimePicker1.CustomFormat = "yyyy-MM-dd"

            Dim a As String = h_entree1.Value.ToString()
            Dim b As String = h_entree2.Value.ToString()
            Dim k As String = "0"
            Dim z As String = a & ":" & b
            If h_entree2.Value < 10 Then
                b = k & h_entree2.Value.ToString()
                z = a & ":" & b
            Else
                z = a & ":" & b
            End If



            Dim c As String = h_sortie1.Value.ToString()
            Dim d As String = h_sortie2.Value.ToString()
            Dim w As String = c & ":" & d

            If h_sortie2.Value < 10 Then
                d = k & h_sortie2.Value.ToString()
                w = c & ":" & d
            Else
                w = c & ":" & d
            End If

            Dim strBranch As String = ""
            If ComboBox1.SelectedItem <> "" Then
                strBranch = ComboBox1.SelectedItem.ToString()
            End If

            Dim TBmachine As String = ""
            If CBmachine.SelectedItem <> "" Then
                TBmachine = CBmachine.SelectedItem.ToString()
            End If

            Dim TBarret As String = ""
            If CBarret.SelectedItem <> "" Then
                TBarret = CBarret.SelectedItem.ToString()
            End If

            Dim insertQuery As String =
                "INSERT INTO maintenance1 (MACHINE, CODE, Date, DEFAUT, ACTION, MATIERE, H_ENTREE, H_SORTIE, TYPE_MAINTENANCE, N_OP , EQUIPE, ARRET,NOMBRE_JOUR) VALUES ('" & TBmachine & "', '" & TBcode.Text & "',  '" & DateTimePicker1.Text & "',  '" & TBdefaut.Text & "', '" & TBaction.Text & "','" & TBmatiere.Text & "','" & z & "','" & w & "','" & strBranch & "','" & TBnop.Text & "','" & TBequipe.Text & "','" & TBarret & "', '" & NumericUpDown1.Text & "') "

            ExcuteQuery(insertQuery)
            MessageBox.Show("item ajouté")

        End If

    End Sub


    Public Sub ExcuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub



    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        HELP.Show()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label14.Text = TimeOfDay
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.Show()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim command1 As New SqlCommand("select * from maintenance1 where id =@id ", connection)
        command1.Parameters.Add("@id", SqlDbType.Int).Value = TBid.Text
        Dim adapter As New SqlDataAdapter(command1)
        Dim table As New DataTable()



        Try
            adapter.Fill(table)
            CBmachine.Text = table.Rows(0)(1).ToString()
            TBcode.Text = table.Rows(0)(2).ToString()
            DateTimePicker1.Text = table.Rows(0)(3).ToString()
            TBdefaut.Text = table.Rows(0)(4).ToString()
            TBaction.Text = table.Rows(0)(5).ToString()
            TBmatiere.Text = table.Rows(0)(6).ToString()

            Dim stringlist As String = table.Rows(0)(7).ToString()
            Dim arraylist = stringlist.Split(":")
            Dim stringlist1 As String = table.Rows(0)(8).ToString()
            Dim arraylist1 = stringlist1.Split(":")


            h_entree1.Text = arraylist(0)
            h_entree2.Text = arraylist(1)
            h_sortie1.Text = arraylist1(0)
            h_sortie2.Text = arraylist1(1)

            ComboBox1.Text = table.Rows(0)(9).ToString()
            TBnop.Text = table.Rows(0)(10).ToString()
            TBequipe.Text = table.Rows(0)(11).ToString()
            CBarret.Text = table.Rows(0)(12).ToString()
            NumericUpDown1.Text = table.Rows(0)(13).ToString()
        Catch ex As Exception
            MsgBox("nombre id incorrect")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TBid.Text = "" Then
            MsgBox("remplir le champ ID ")
        ElseIf MsgBox("CONFIRMER LA MODIFICATION?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            DateTimePicker1.Format = DateTimePickerFormat.Custom
            DateTimePicker1.CustomFormat = "yyyy-MM-dd"

            Dim a As String = h_entree1.Value.ToString()
            Dim b As String = h_entree2.Value.ToString()
            Dim k As String = "0"
            Dim z As String = a & ":" & b
            If h_entree2.Value < 10 Then
                b = k & h_entree2.Value.ToString()
                z = a & ":" & b
            Else
                z = a & ":" & b
            End If



            Dim c As String = h_sortie1.Value.ToString()
            Dim d As String = h_sortie2.Value.ToString()
            Dim w As String = c & ":" & d

            If h_sortie2.Value < 10 Then
                d = k & h_sortie2.Value.ToString()
                w = c & ":" & d
            Else
                w = c & ":" & d
            End If

            Dim strBranch As String = ""
            If ComboBox1.SelectedItem <> "" Then
                strBranch = ComboBox1.SelectedItem.ToString()
            End If

            Dim TBmachine As String = ""
            If CBmachine.SelectedItem <> "" Then
                TBmachine = CBmachine.SelectedItem.ToString()
            End If

            Dim TBarret As String = ""
            If CBarret.SelectedItem <> "" Then
                TBarret = CBarret.SelectedItem.ToString()
            End If

            'bloc test

            Dim id As String = String.Empty
            Using cmd As SqlClient.SqlCommand = connection.CreateCommand()

                cmd.CommandText = "SELECT id FROM maintenance1 WHERE id = '" & CInt(TBid.Text) & "'"
                
                connection.Open()


                Dim exists As String = cmd.ExecuteScalar()
                connection.Close()
                If exists = Nothing Then

                    MsgBox("ce ID n'existe dans la base de données")
                Else
                    Dim insertQuery As String =
            "UPDATE  maintenance1 SET MACHINE='" & TBmachine & "', CODE='" & TBcode.Text & "', Date='" & DateTimePicker1.Text & "', DEFAUT='" & TBdefaut.Text & "', ACTION='" & TBaction.Text & "', MATIERE='" & TBmatiere.Text & "', H_ENTREE='" & z & "', H_SORTIE='" & w & "', TYPE_MAINTENANCE='" & strBranch & "', N_OP='" & TBnop.Text & "' , EQUIPE='" & TBequipe.Text & "', ARRET='" & TBarret & "', NOMBRE_JOUR='" & NumericUpDown1.Text & "' WHERE id= '" & CInt(TBid.Text) & "' "

                    ExcuteQuery(insertQuery)
                    MessageBox.Show("modification terminée")
                End If
                connection.Close()
            End Using
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TBid.Text = "" Then
            MsgBox("remplir le champ ID ")

        ElseIf MsgBox("SUPRRIMER L'ELEMENT?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim id As String = String.Empty
            Using cmd As SqlClient.SqlCommand = connection.CreateCommand()

                cmd.CommandText = "SELECT id FROM maintenance1 WHERE id = @id"
                cmd.Parameters.AddWithValue("@id", CInt(TBid.Text))
                connection.Open()
                Dim exists As String = cmd.ExecuteScalar()
                connection.Close()
                If exists = Nothing Then

                    MsgBox("ce ID n'existe pas dans la base de données")
                Else
                    Dim insertQuery As String =
                "DELETE FROM  maintenance1  WHERE id= '" & CInt(TBid.Text) & "' "

                    ExcuteQuery(insertQuery)
                    MessageBox.Show("element supprimé")
                End If
                connection.Close()
            End Using


        End If


    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form6.Show()
    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        CBmachine.Text = ""
        TBcode.Text = ""
        TBid.Text = ""
        TBdefaut.Text = ""
        TBaction.Text = ""
        TBmatiere.Text = ""




        h_entree1.Text = "0"
        h_entree2.Text = "0"
        h_sortie1.Text = "0"
        h_sortie2.Text = "0"

        ComboBox1.Text = ""
        TBnop.Text = ""
        TBequipe.Text = ""
        CBarret.Text = ""
        NumericUpDown1.Text = "0"
    End Sub




End Class