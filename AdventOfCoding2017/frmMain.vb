Public Class frmMain
    Private Sub GO_Click(sender As Object, e As EventArgs) Handles GOButton.Click
        Me.lblResults.Text = "Running"
        Application.DoEvents()

        Me.lblResults.Text = countValid(Me.TextBox1.Text.Trim.ToLower)
    End Sub


    Private Function countValid(input As String) As Integer
        Dim lst As New List(Of String)(input.Split(ControlChars.CrLf))
        Dim cnt As Integer = 0
        For Each row In lst
            If isValidPart2(row.Trim) Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function


    Private Function isValidPart2(input As String)
        Dim lst As New List(Of String)(input.Split(" "))
        Dim unique As New List(Of String)
        For Each itm As String In lst
            If Not String.IsNullOrEmpty(itm) Then
                If unique.Contains(itm) Then
                    Return False
                Else
                    For Each s As String In unique
                        If s.Length = itm.Length Then
                            If StringMethods.IsAnagram(itm, s) Then
                                Return False
                            End If
                        End If
                    Next
                    unique.Add(itm)
                End If
            End If
        Next
        Return True
    End Function


    Private Function isValidPart1(input As String)
        Dim lst As New List(Of String)(input.Split(" "))
        Dim unique As New List(Of String)
        For Each itm As String In lst
            If Not String.IsNullOrEmpty(itm) Then
                If unique.Contains(itm) Then
                    Return False
                Else
                    unique.Add(itm)
                End If
            End If
        Next
        Return True
    End Function


    Private Function calcItDay3Grid(max As Integer) As Integer

        Dim tableSize As Integer = 1
        For i As Integer = 0 To max - 1


        Next
        Return tableSize
    End Function



    Private Function calcItDay2(input As String)
        Dim dt As DataTable = ConvertToDataTable(input, Me.chkTabDelimited.Checked)
        Dim checkDigit As Integer = 0

        For Each row As DataRow In dt.Rows
            checkDigit += getCheckDigitDay2b(row)
        Next
        Return checkDigit
    End Function

    Private Function getCheckDigitDay2b(row As DataRow) As Integer
        Dim checkDigit As Integer = 0
        For i As Integer = 0 To row.ItemArray.Count - 1
            Dim cell As Integer = CInt(row.ItemArray(i))
            Dim rowValue As Integer = 0

            For Each itm As Integer In row.ItemArray
                If itm <> cell Then
                    If cell Mod itm = 0 Then
                        rowValue += CInt(cell / itm)
                    End If
                End If
            Next
            checkDigit += rowValue
        Next
        Return checkDigit
    End Function

    Private Function getCheckDigitDay2a(row As DataRow) As Integer
        Dim min As Integer = -1, max As Integer = -1
        For i As Integer = 0 To row.ItemArray.Count - 1
            If IsDBNull(row.ItemArray(i)) = False Then
                Dim cell As Integer = CInt(row.ItemArray(i))
                If min = -1 Then
                    min = cell
                    max = cell
                End If
                If cell > max Then
                    max = cell
                ElseIf cell < min Then
                    min = cell
                End If
            End If
        Next
        Return max - min
    End Function



    Private Function countItDay1B(input As String) As Long
        Dim total As Long = 0
        Dim compareDigit As Integer = -1, current As Integer = -1
        Dim offset As Integer = input.Length / 2
        Dim compareIndex As Integer = -1

        For i As Integer = 0 To input.Length - 1
            current = input.Substring(i, 1)
            If i + offset < input.Length Then
                compareIndex = i + offset
            Else
                compareIndex = i + offset - input.Length
            End If

            compareDigit = input.Substring(compareIndex, 1)
            If current = compareDigit Then
                total += current
            End If

        Next
        Return total
    End Function


    Private Function countItDay1A(input As String) As Long
        Dim total As Long = 0
        Dim compareDigit As Integer = -1, current As Integer = -2
        For i As Integer = 0 To input.Length - 1
            current = input.Substring(i, 1)
            If current = compareDigit Then
                total += current
            End If
            compareDigit = current
        Next
        If CInt(input.Substring(0, 1)) = current Then
            total += current
        End If

        Return total
    End Function

    Private Sub cmdCopyToClipboard_Click(sender As Object, e As EventArgs) Handles cmdCopyToClipboard.Click
        My.Computer.Clipboard.SetText(Me.lblResultsLabel.Text)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
