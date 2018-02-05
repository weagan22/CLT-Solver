Imports System.Windows.Forms

Public Class User_Interface
    Private Sub User_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Module1.Main()
        'Close()
    End Sub

    Private Sub LayerTable_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles LayerTable.RowsAdded
        For i = 1 To LayerTable.RowCount
            LayerTable.Item(0, i - 1).Value = i
        Next

        LayerTable.Item(0, LayerTable.RowCount - 1).Value = "Add"
    End Sub

    Private Sub LayerTable_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles LayerTable.RowsRemoved
        For i = 1 To LayerTable.RowCount
            LayerTable.Item(0, i - 1).Value = i
        Next
    End Sub

    Private Sub BtnSym_Click(sender As Object, e As EventArgs) Handles BtnSym.Click

        Dim symCnt As Integer = LayerTable.RowCount - 1

        If symCnt Mod 2 = 1 Then symCnt = symCnt - 1

        For i = 1 To symCnt
            LayerTable.Rows.Add(New String() {"0", "0", "0"})
        Next

        LayerTable.Update()

        For i = 1 To symCnt
            LayerTable.Item(1, LayerTable.RowCount - i - 1).Value = LayerTable.Item(1, i - 1).Value
            LayerTable.Update()
            LayerTable.Item(2, LayerTable.RowCount - i - 1).Value = LayerTable.Item(2, i - 1).Value
            LayerTable.Update()
        Next

        LayerTable.Update()
    End Sub

    Private Sub LayerTable_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles LayerTable.CellValueChanged

        If symCheck() = True Then
            LabelSym.Text = "SYMMETRIC"
            LabelSym.BackColor = Drawing.Color.Green
        Else
            LabelSym.Text = "NOT SYMMETRIC"
            LabelSym.BackColor = Drawing.Color.Red
        End If

        'Call stackingNotation()

    End Sub

    Function symCheck() As Boolean
        symCheck = True

        Dim symCnt As Integer = LayerTable.RowCount - 1
        If symCnt Mod 2 = 1 Then symCnt = symCnt - 1
        symCnt = symCnt / 2

        For i = 1 To LayerTable.RowCount - 1
            If LayerTable.Item(1, LayerTable.RowCount - i - 1).Value <> LayerTable.Item(1, i - 1).Value Then
                symCheck = False
            End If

            If LayerTable.Item(2, LayerTable.RowCount - i - 1).Value <> LayerTable.Item(2, i - 1).Value Then
                symCheck = False
            End If
        Next

        Return symCheck
    End Function

    Private Sub MatTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MatTable.CellContentClick

    End Sub

    'Sub stackingNotation()

    '    Dim symCnt As Integer = LayerTable.RowCount - 1

    '    Dim midPly As Boolean = False
    '    If symCnt Mod 2 = 1 Then midPly = True

    '    If symCheck() = True Then
    '        If symCnt Mod 2 = 1 Then
    '            symCnt = symCnt - 1
    '            symCnt = symCnt / 2
    '            symCnt = symCnt + 1
    '        Else
    '            symCnt = symCnt / 2
    '        End If
    '    End If

    '    PlyNotation.Clear()
    '    PlyNotation.Text = "["

    '    For i = 0 To symCnt - 1
    '        Dim groupCnt As Integer = 1
    '        Dim plusMinus As Boolean = False

    '        If i <> symCnt Then
    '            Dim loopVar As Integer = symCnt
    '            If midPly = True Then loopVar = symCnt - 1

    '            For z = i To loopVar - 2
    '                If CStr(LayerTable.Item(2, z).Value) = CStr(LayerTable.Item(2, z + 1).Value) Then
    '                    groupCnt = groupCnt + 1
    '                ElseIf CStr(LayerTable.Item(2, z + 1).Value) = "-" & CStr(LayerTable.Item(2, z).Value) And plusMinus = False Then
    '                    plusMinus = True
    '                    z = z + 1
    '                ElseIf plusMinus = True Then
    '                    If CStr(LayerTable.Item(2, z).Value) = CStr(LayerTable.Item(2, z - 2).Value) And CStr(LayerTable.Item(2, z + 1).Value) = CStr(LayerTable.Item(2, z - 1).Value) Then
    '                        groupCnt = groupCnt + 1
    '                        z = z + 2
    '                    Else
    '                        Exit For
    '                    End If
    '                Else
    '                    Exit For
    '                End If
    '            Next
    '        End If

    '        If plusMinus = True Then
    '            PlyNotation.AppendText("±")
    '        End If

    '        If groupCnt > 1 Then

    '            If LayerTable.Item(2, i).Value = Nothing Then
    '                PlyNotation.AppendText("0")
    '            Else
    '                PlyNotation.AppendText(CStr(LayerTable.Item(2, i).Value))
    '            End If


    '            PlyNotation.Update()
    '            PlyNotation.SelectionCharOffset = -10
    '            PlyNotation.SelectedText = groupCnt
    '            PlyNotation.SelectionCharOffset = 0
    '            PlyNotation.Update()

    '            PlyNotation.AppendText(", ")
    '            PlyNotation.Update()


    '        Else
    '            If LayerTable.Item(2, i).Value = Nothing Then
    '                PlyNotation.AppendText("0")
    '                PlyNotation.Update()

    '            Else
    '                PlyNotation.AppendText(LayerTable.Item(2, i).Value)
    '                PlyNotation.Update()
    '            End If
    '            PlyNotation.AppendText(", ")
    '            PlyNotation.Update()
    '        End If

    '        If plusMinus = True Then
    '            i = i + groupCnt * 2 - 1
    '        Else
    '            i = i + groupCnt - 1
    '        End If
    '    Next

    '    If Len(PlyNotation.Text) > 3 Then
    '        PlyNotation.Select(PlyNotation.TextLength - 2, PlyNotation.TextLength)
    '        PlyNotation.SelectedText = ""
    '        PlyNotation.Update()
    '    End If

    '    If midPly = True And symCheck() = True Then
    '        PlyNotation.AppendText("(bar)")
    '        PlyNotation.Update()
    '    End If

    '    PlyNotation.AppendText("]")
    '    PlyNotation.Update()

    '    If symCheck() = True Then
    '        PlyNotation.SelectionCharOffset = -10
    '        PlyNotation.SelectedText = "S"
    '        PlyNotation.SelectionCharOffset = 0
    '    End If


    'End Sub

End Class