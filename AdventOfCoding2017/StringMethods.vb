Module StringMethods

    Public Function ConvertToDataTable(ByVal s As String, tabDelim As Boolean) As DataTable
        Dim RecordDelim As String = vbCrLf
        Dim fieldDelim As String = IIf(tabDelim, ControlChars.Tab, " ")

        s = s.Trim()
        Dim createColumns As Boolean = True
        Dim dt As New DataTable
        Dim rows() As String = Split(s, RecordDelim)
        For i As Integer = 0 To rows.Length - 1
            Dim colData() As Object = Split(rows(i), fieldDelim)
            If createColumns = True Then
                For j As Integer = 0 To colData.Length - 1
                    dt.Columns.Add("Field " & j)
                Next
                createColumns = False
            End If
            dt.Rows.Add(colData)
        Next
        Return dt
    End Function


    Public Function IsAnagram(s1 As String, s2 As String) As Boolean
        For Each c As Char In s2
            Dim ix As Integer = s1.IndexOf(c)
            If (ix >= 0) Then
                s1 = s1.Remove(ix, 1)
            Else
                Return False
            End If
        Next

        Return String.IsNullOrEmpty(s1)
    End Function

End Module
