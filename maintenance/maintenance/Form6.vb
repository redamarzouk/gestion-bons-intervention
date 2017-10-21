Imports System.Data.SqlClient

Public Class Form6
    Dim connection As New SqlConnection("Server= SONY-PC\SQLEXPRESS1 ; Database = MAINTENANCE; Integrated Security = true")






    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        TextBox1.Text = "0"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy-MM-dd"



        Dim command1 As New SqlCommand("select * from maintenance1 where date between '" & DateTimePicker1.Text & "' and '" & DateTimePicker2.Text & "'  ", connection)

        Dim adapter As New SqlDataAdapter(command1)
        Dim table As New DataTable()
        adapter.Fill(table)
        Dim matrix = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim matrix1 = New String() {"A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "B1", "B2", "B3", "B4", "B5", "B6", "M1", "M2", "M3", "M4", "M5", "M6", "M7", "M8", "P1", "P2", "P3", "P4", "P5", "P6", "G1", "G2", "G3", "G4", "G5", "G6"}


        For index As Integer = 0 To table.Rows.Count - 1
            Dim arraylist = table.Rows(index)(2).Split("-")
            For Each j In arraylist
                Select Case j.ToString()
                    Case "A1"
                        matrix(0) += 1
                    Case "A2"
                        matrix(1) += 1
                    Case "A3"
                        matrix(2) += 1
                    Case "A4"
                        matrix(3) += 1
                    Case "A5"
                        matrix(4) += 1
                    Case "A6"
                        matrix(5) += 1
                    Case "A7"
                        matrix(6) += 1
                    Case "A8"
                        matrix(7) += 1
                    Case "B1"
                        matrix(8) += 1
                    Case "B2"
                        matrix(9) += 1
                    Case "B3"
                        matrix(10) += 1
                    Case "B4"
                        matrix(11) += 1
                    Case "B5"
                        matrix(12) += 1
                    Case "B6"
                        matrix(13) += 1
                    Case "M1"
                        matrix(14) += 1
                    Case "M2"
                        matrix(15) += 1
                    Case "M3"
                        matrix(16) += 1
                    Case "M4"
                        matrix(17) += 1
                    Case "M5"
                        matrix(18) += 1
                    Case "M6"
                        matrix(19) += 1
                    Case "M7"
                        matrix(20) += 1
                    Case "M8"
                        matrix(21) += 1
                    Case "P1"
                        matrix(22) += 1
                    Case "P2"
                        matrix(23) += 1
                    Case "P3"
                        matrix(24) += 1
                    Case "P4"
                        matrix(25) += 1
                    Case "P5"
                        matrix(26) += 1
                    Case "P6"
                        matrix(27) += 1
                    Case "G1"
                        matrix(28) += 1
                    Case "G2"
                        matrix(29) += 1
                    Case "G3"
                        matrix(30) += 1
                    Case "G4"
                        matrix(31) += 1
                    Case "G5"
                        matrix(32) += 1
                    Case "G6"
                        matrix(33) += 1

                End Select


            Next

        Next



        For index As Integer = 0 To 33

            Me.Chart1.Series("Qté totale").Points.AddXY(matrix1(index), matrix(index))
        Next


        Dim matrix2 = New Double() {0, 0, 0}
        Dim matrix3 = New String() {"PREVENTIF", "PREDICTIF", "CORRECTIF"}
        For index As Integer = 0 To table.Rows.Count - 1


            Select Case table.Rows(index)(9)
                Case "PREVENTIF"
                    matrix2(0) += 1
                Case "PREDICTIF"
                    matrix2(1) += 1
                Case "CORRECTIF"
                    matrix2(2) += 1

            End Select
        Next




        For index As Integer = 0 To 2

            Me.Chart2.Series("Series1").Points.AddXY(matrix3(index), matrix2(index))

        Next

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        'clear chart in order not to create new points in the same serie and getting all fucked up
        Me.Chart1.Series("Qté totale").Points.Clear()
        Me.Chart2.Series("Series1").Points.Clear()




        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy-MM-dd"



        Dim command1 As New SqlCommand("select * from maintenance1 where date between '" & DateTimePicker1.Text & "' and '" & DateTimePicker2.Text & "'  ", connection)

        Dim adapter As New SqlDataAdapter(command1)
        Dim table As New DataTable()
        adapter.Fill(table)
        Dim matrix = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim matrix1 = New String() {"A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "B1", "B2", "B3", "B4", "B5", "B6", "M1", "M2", "M3", "M4", "M5", "M6", "M7", "M8", "P1", "P2", "P3", "P4", "P5", "P6", "G1", "G2", "G3", "G4", "G5", "G6"}


        For index As Integer = 0 To table.Rows.Count - 1
            Dim arraylist = table.Rows(index)(2).Split("-")
            For Each j In arraylist
                Select Case j.ToString()
                    Case "A1"
                        matrix(0) += 1
                    Case "A2"
                        matrix(1) += 1
                    Case "A3"
                        matrix(2) += 1
                    Case "A4"
                        matrix(3) += 1
                    Case "A5"
                        matrix(4) += 1
                    Case "A6"
                        matrix(5) += 1
                    Case "A7"
                        matrix(6) += 1
                    Case "A8"
                        matrix(7) += 1
                    Case "B1"
                        matrix(8) += 1
                    Case "B2"
                        matrix(9) += 1
                    Case "B3"
                        matrix(10) += 1
                    Case "B4"
                        matrix(11) += 1
                    Case "B5"
                        matrix(12) += 1
                    Case "B6"
                        matrix(13) += 1
                    Case "M1"
                        matrix(14) += 1
                    Case "M2"
                        matrix(15) += 1
                    Case "M3"
                        matrix(16) += 1
                    Case "M4"
                        matrix(17) += 1
                    Case "M5"
                        matrix(18) += 1
                    Case "M6"
                        matrix(19) += 1
                    Case "M7"
                        matrix(20) += 1
                    Case "M8"
                        matrix(21) += 1
                    Case "P1"
                        matrix(22) += 1
                    Case "P2"
                        matrix(23) += 1
                    Case "P3"
                        matrix(24) += 1
                    Case "P4"
                        matrix(25) += 1
                    Case "P5"
                        matrix(26) += 1
                    Case "P6"
                        matrix(27) += 1
                    Case "G1"
                        matrix(28) += 1
                    Case "G2"
                        matrix(29) += 1
                    Case "G3"
                        matrix(30) += 1
                    Case "G4"
                        matrix(31) += 1
                    Case "G5"
                        matrix(32) += 1
                    Case "G6"
                        matrix(33) += 1

                End Select


            Next

        Next



        For index As Integer = 0 To 33

            Me.Chart1.Series("Qté totale").Points.AddXY(matrix1(index), matrix(index))
        Next


        Dim matrix2 = New Double() {0, 0, 0}
        Dim matrix3 = New String() {"PREVENTIF", "PREDICTIF", "CORRECTIF"}
        For index As Integer = 0 To table.Rows.Count - 1


            Select Case table.Rows(index)(9)
                Case "PREVENTIF"
                    matrix2(0) += 1
                Case "PREDICTIF"
                    matrix2(1) += 1
                Case "CORRECTIF"
                    matrix2(2) += 1

            End Select
        Next




        For index As Integer = 0 To 2

            Me.Chart2.Series("Series1").Points.AddXY(matrix3(index), matrix2(index))

        Next



        'diffrence between dates

        Dim startTime As Date
        Dim endTime As Date
        Dim actualTime As Integer
        startTime = Convert.ToDateTime(DateTimePicker1.Value)
        endTime = Convert.ToDateTime(DateTimePicker2.Value)
        Dim diff As System.TimeSpan
        diff = endTime - startTime
        actualTime = CInt(diff.Days.ToString()) * 24 * CInt(TextBox1.Text)

        'number of interventions
        Dim lenght As New Integer
        lenght = 0
        For index = 0 To table.Rows.Count - 1
            If table.Rows(index)(12) = "OUI" Then
                lenght += 1

            End If
        Next




        'MTBF
        'diffrence between dates : ALREADY HAVE actualtime
        'downtime calculate

        Dim downtime As New Integer



        Dim minutes As New Integer
        downtime = 0
        Try
            Dim stringlist1 As String = table.Rows(0)(7).ToString()
            Dim arraylist1 = stringlist1.Split(":")
            Dim stringlist2 As String = table.Rows(0)(8).ToString()
            Dim arraylist2 = stringlist2.Split(":")
            For index = 0 To table.Rows.Count - 1
                If table.Rows(index)(12).ToString() = "OUI" Then
                    Try
                        stringlist1 = table.Rows(index)(7).ToString()
                        arraylist1 = stringlist1.Split(":")
                        stringlist2 = table.Rows(index)(8).ToString()
                        arraylist2 = stringlist2.Split(":")
                        If CInt(table.Rows(index)(13)) <> 0 Then
                            downtime += CInt(table.Rows(index)(13)) * 24
                        ElseIf CInt(arraylist2(0)) = CInt(arraylist1(0)) Then
                            minutes += CInt(arraylist2(1)) - CInt(arraylist1(1))

                        Else
                            downtime += CInt(arraylist2(0)) - CInt(arraylist1(0))
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        'ajouter l'acumulation des minutes

        downtime += minutes / 60

        'fin de l'ajout

        Dim MTBF As New Integer
        Try
            MTBF = (actualTime - downtime) / lenght
        Catch ex As Exception

        End Try

        If MTBF = 1 Then
            Label6.Text = MTBF.ToString() + "  heure"
        Else
            Label6.Text = MTBF.ToString() + "  heures"
        End If

        'MTTR
        Dim MTTR As New Integer
        Try
            MTTR = downtime / lenght
        Catch ex As Exception

        End Try
        If MTTR = 1 Then
            Label5.Text = MTTR.ToString() + "  heure"
        Else
            Label5.Text = MTTR.ToString() + "  heures"
        End If


        'disponibilite
        Dim disp As New Double
        Try
            disp = MTBF / (MTBF + MTTR)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        disp = Format(disp * 99.999999, "0.00")

        Label7.Text = disp.ToString() + " %"

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Me.Chart1.Series("Qté totale").Points.Clear()
        Me.Chart2.Series("Series1").Points.Clear()



        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy-MM-dd"



        Dim command1 As New SqlCommand("select * from maintenance1 where date between '" & DateTimePicker1.Text & "' and '" & DateTimePicker2.Text & "'  ", connection)

        Dim adapter As New SqlDataAdapter(command1)
        Dim table As New DataTable()
        adapter.Fill(table)
        Dim matrix = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim matrix1 = New String() {"A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "B1", "B2", "B3", "B4", "B5", "B6", "M1", "M2", "M3", "M4", "M5", "M6", "M7", "M8", "P1", "P2", "P3", "P4", "P5", "P6", "G1", "G2", "G3", "G4", "G5", "G6"}


        For index As Integer = 0 To table.Rows.Count - 1
            Dim arraylist = table.Rows(index)(2).Split("-")
            For Each j In arraylist
                Select Case j.ToString()
                    Case "A1"
                        matrix(0) += 1
                    Case "A2"
                        matrix(1) += 1
                    Case "A3"
                        matrix(2) += 1
                    Case "A4"
                        matrix(3) += 1
                    Case "A5"
                        matrix(4) += 1
                    Case "A6"
                        matrix(5) += 1
                    Case "A7"
                        matrix(6) += 1
                    Case "A8"
                        matrix(7) += 1
                    Case "B1"
                        matrix(8) += 1
                    Case "B2"
                        matrix(9) += 1
                    Case "B3"
                        matrix(10) += 1
                    Case "B4"
                        matrix(11) += 1
                    Case "B5"
                        matrix(12) += 1
                    Case "B6"
                        matrix(13) += 1
                    Case "M1"
                        matrix(14) += 1
                    Case "M2"
                        matrix(15) += 1
                    Case "M3"
                        matrix(16) += 1
                    Case "M4"
                        matrix(17) += 1
                    Case "M5"
                        matrix(18) += 1
                    Case "M6"
                        matrix(19) += 1
                    Case "M7"
                        matrix(20) += 1
                    Case "M8"
                        matrix(21) += 1
                    Case "P1"
                        matrix(22) += 1
                    Case "P2"
                        matrix(23) += 1
                    Case "P3"
                        matrix(24) += 1
                    Case "P4"
                        matrix(25) += 1
                    Case "P5"
                        matrix(26) += 1
                    Case "P6"
                        matrix(27) += 1
                    Case "G1"
                        matrix(28) += 1
                    Case "G2"
                        matrix(29) += 1
                    Case "G3"
                        matrix(30) += 1
                    Case "G4"
                        matrix(31) += 1
                    Case "G5"
                        matrix(32) += 1
                    Case "G6"
                        matrix(33) += 1

                End Select


            Next

        Next



        For index As Integer = 0 To 33

            Me.Chart1.Series("Qté totale").Points.AddXY(matrix1(index), matrix(index))
        Next


        Dim matrix2 = New Double() {0, 0, 0}
        Dim matrix3 = New String() {"PREVENTIF", "PREDICTIF", "CORRECTIF"}
        For index As Integer = 0 To table.Rows.Count - 1


            Select Case table.Rows(index)(9)
                Case "PREVENTIF"
                    matrix2(0) += 1
                Case "PREDICTIF"
                    matrix2(1) += 1
                Case "CORRECTIF"
                    matrix2(2) += 1

            End Select
        Next




        For index As Integer = 0 To 2

            Me.Chart2.Series("Series1").Points.AddXY(matrix3(index), matrix2(index))

        Next



        'diffrence between dates

        Dim startTime As Date
        Dim endTime As Date
        Dim actualTime As Integer
        startTime = Convert.ToDateTime(DateTimePicker1.Value)
        endTime = Convert.ToDateTime(DateTimePicker2.Value)
        Dim diff As System.TimeSpan
        diff = endTime - startTime
        actualTime = CInt(diff.Days.ToString()) * 24 * CInt(TextBox1.Text)

        'number of interventions
        Dim lenght As New Integer
        lenght = 0
        For index = 0 To table.Rows.Count - 1
            If table.Rows(index)(12) = "OUI" Then
                lenght += 1

            End If
        Next




        'MTBF
        'diffrence between dates : ALREADY HAVE actualtime
        'downtime calculate

        Dim downtime As New Integer



        Dim minutes As New Integer
        downtime = 0
        Try
            Dim stringlist1 As String = table.Rows(0)(7).ToString()
            Dim arraylist1 = stringlist1.Split(":")
            Dim stringlist2 As String = table.Rows(0)(8).ToString()
            Dim arraylist2 = stringlist2.Split(":")
            For index = 0 To table.Rows.Count - 1
                If table.Rows(index)(12).ToString() = "OUI" Then
                    Try
                        stringlist1 = table.Rows(index)(7).ToString()
                        arraylist1 = stringlist1.Split(":")
                        stringlist2 = table.Rows(index)(8).ToString()
                        arraylist2 = stringlist2.Split(":")
                        If CInt(table.Rows(index)(13)) <> 0 Then
                            downtime += CInt(table.Rows(index)(13)) * 24
                        ElseIf CInt(arraylist2(0)) = CInt(arraylist1(0)) Then
                            minutes += CInt(arraylist2(1)) - CInt(arraylist1(1))

                        Else
                            downtime += CInt(arraylist2(0)) - CInt(arraylist1(0))
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        'ajouter l'acumulation des minutes

        downtime += minutes / 60

        'fin de l'ajout

        Dim MTBF As New Integer
        Try
            MTBF = (actualTime - downtime) / lenght
        Catch ex As Exception

        End Try

        If MTBF = 1 Then
            Label6.Text = MTBF.ToString() + "  heure"
        Else
            Label6.Text = MTBF.ToString() + "  heures"
        End If

        'MTTR
        Dim MTTR As New Integer
        Try
            MTTR = downtime / lenght
        Catch ex As Exception

        End Try
        If MTTR = 0 Then
            MTTR = 1
        End If
        If MTTR = 1 Then
            Label5.Text = MTTR.ToString() + "  heure"
        Else
            Label5.Text = MTTR.ToString() + "  heures"
        End If


        'disponibilite
        Dim disp As New Double
        Try
            disp = MTBF / (MTBF + MTTR)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        disp = Format(disp * 99.999999, "0.00")

        Label7.Text = disp.ToString() + " %"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.Chart1.Series("Qté totale").Points.Clear()
        Me.Chart2.Series("Series1").Points.Clear()



        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy-MM-dd"



        Dim command1 As New SqlCommand("select * from maintenance1 where date between '" & DateTimePicker1.Text & "' and '" & DateTimePicker2.Text & "'  ", connection)

        Dim adapter As New SqlDataAdapter(command1)
        Dim table As New DataTable()
        adapter.Fill(table)
        Dim matrix = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim matrix1 = New String() {"A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "B1", "B2", "B3", "B4", "B5", "B6", "M1", "M2", "M3", "M4", "M5", "M6", "M7", "M8", "P1", "P2", "P3", "P4", "P5", "P6", "G1", "G2", "G3", "G4", "G5", "G6"}


        For index As Integer = 0 To table.Rows.Count - 1
            Dim arraylist = table.Rows(index)(2).Split("-")
            For Each j In arraylist
                Select Case j.ToString()
                    Case "A1"
                        matrix(0) += 1
                    Case "A2"
                        matrix(1) += 1
                    Case "A3"
                        matrix(2) += 1
                    Case "A4"
                        matrix(3) += 1
                    Case "A5"
                        matrix(4) += 1
                    Case "A6"
                        matrix(5) += 1
                    Case "A7"
                        matrix(6) += 1
                    Case "A8"
                        matrix(7) += 1
                    Case "B1"
                        matrix(8) += 1
                    Case "B2"
                        matrix(9) += 1
                    Case "B3"
                        matrix(10) += 1
                    Case "B4"
                        matrix(11) += 1
                    Case "B5"
                        matrix(12) += 1
                    Case "B6"
                        matrix(13) += 1
                    Case "M1"
                        matrix(14) += 1
                    Case "M2"
                        matrix(15) += 1
                    Case "M3"
                        matrix(16) += 1
                    Case "M4"
                        matrix(17) += 1
                    Case "M5"
                        matrix(18) += 1
                    Case "M6"
                        matrix(19) += 1
                    Case "M7"
                        matrix(20) += 1
                    Case "M8"
                        matrix(21) += 1
                    Case "P1"
                        matrix(22) += 1
                    Case "P2"
                        matrix(23) += 1
                    Case "P3"
                        matrix(24) += 1
                    Case "P4"
                        matrix(25) += 1
                    Case "P5"
                        matrix(26) += 1
                    Case "P6"
                        matrix(27) += 1
                    Case "G1"
                        matrix(28) += 1
                    Case "G2"
                        matrix(29) += 1
                    Case "G3"
                        matrix(30) += 1
                    Case "G4"
                        matrix(31) += 1
                    Case "G5"
                        matrix(32) += 1
                    Case "G6"
                        matrix(33) += 1

                End Select


            Next

        Next



        For index As Integer = 0 To 33

            Me.Chart1.Series("Qté totale").Points.AddXY(matrix1(index), matrix(index))
        Next


        Dim matrix2 = New Double() {0, 0, 0}
        Dim matrix3 = New String() {"PREVENTIF", "PREDICTIF", "CORRECTIF"}
        For index As Integer = 0 To table.Rows.Count - 1


            Select Case table.Rows(index)(9)
                Case "PREVENTIF"
                    matrix2(0) += 1
                Case "PREDICTIF"
                    matrix2(1) += 1
                Case "CORRECTIF"
                    matrix2(2) += 1

            End Select
        Next




        For index As Integer = 0 To 2

            Me.Chart2.Series("Series1").Points.AddXY(matrix3(index), matrix2(index))

        Next



        'diffrence between dates

        Dim startTime As Date
        Dim endTime As Date
        Dim actualTime As Integer
        startTime = Convert.ToDateTime(DateTimePicker1.Value)
        endTime = Convert.ToDateTime(DateTimePicker2.Value)
        Dim diff As System.TimeSpan
        diff = endTime - startTime
        actualTime = CInt(diff.Days.ToString()) * 24 * CInt(TextBox1.Text)

        'number of interventions
        Dim lenght As New Integer
        lenght = 0
        For index = 0 To table.Rows.Count - 1
            If table.Rows(index)(12) = "OUI" Then
                lenght += 1

            End If
        Next




        'MTBF
        'diffrence between dates : ALREADY HAVE actualtime
        'downtime calculate

        Dim downtime As New Integer



        Dim minutes As New Integer
        downtime = 0
        Try
            Dim stringlist1 As String = table.Rows(0)(7).ToString()
            Dim arraylist1 = stringlist1.Split(":")
            Dim stringlist2 As String = table.Rows(0)(8).ToString()
            Dim arraylist2 = stringlist2.Split(":")
            For index = 0 To table.Rows.Count - 1
                If table.Rows(index)(12).ToString() = "OUI" Then
                    Try
                        stringlist1 = table.Rows(index)(7).ToString()
                        arraylist1 = stringlist1.Split(":")
                        stringlist2 = table.Rows(index)(8).ToString()
                        arraylist2 = stringlist2.Split(":")
                        If CInt(table.Rows(index)(13)) <> 0 Then
                            downtime += CInt(table.Rows(index)(13)) * 24
                        ElseIf CInt(arraylist2(0)) = CInt(arraylist1(0)) Then
                            minutes += CInt(arraylist2(1)) - CInt(arraylist1(1))

                        Else
                            downtime += CInt(arraylist2(0)) - CInt(arraylist1(0))
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        'ajouter l'acumulation des minutes

        downtime += minutes / 60

        'fin de l'ajout

        Dim MTBF As New Integer
        Try
            MTBF = (actualTime - downtime) / lenght
        Catch ex As Exception

        End Try

        If MTBF = 1 Then
            Label6.Text = MTBF.ToString() + "  heure"
        Else
            Label6.Text = MTBF.ToString() + "  heures"
        End If

        'MTTR
        Dim MTTR As New Integer
        Try
            MTTR = downtime / lenght
        Catch ex As Exception

        End Try
        If MTTR = 0 Then
            MTTR = 1
        End If
        If MTTR = 1 Then
            Label5.Text = MTTR.ToString() + "  heure"
        Else
            Label5.Text = MTTR.ToString() + "  heures"
        End If


        'disponibilite
        Dim disp As New Double
        Try
            disp = MTBF / (MTBF + MTTR)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        disp = Format(disp * 99.999999, "0.00")

        Label7.Text = disp.ToString() + " %"
    End Sub
End Class