Public Class Form1
    Dim English() As String = {"hello", "goodbye", "you", "and", "say", "my", "but", "name", "is"}
    Dim French() As String = {"bonjour", "au revoir", "vous", "et", "aire", "ma", "acheter", "nom", "est"}
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'checking which radiobutton is clicked to set one textbox to readonly
        If RadioButton2.Checked = True Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'checking which radiobutton is clicked to set one textbox to readonly
        If RadioButton1.Checked = True Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox2.ReadOnly = True
            TextBox1.ReadOnly = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'copy to clipboard with validation if anything has been entered into the textbox, be that via an output or not
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Nothing to copy")
        ElseIf RadioButton1.Checked = True Then
            Clipboard.Clear()
            Clipboard.SetText(TextBox2.Text)
            MsgBox("Copied to clipboard")
        ElseIf RadioButton2.Checked = True Then
            Clipboard.Clear()
            Clipboard.SetText(TextBox1.Text)
            MsgBox("Copied to clipboard")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eng1 As String = TextBox2.Text.ToLower 'coverting input to lower case to avoid issues
        Dim fre1 As String = TextBox1.Text.ToLower 'coverting input to lower case to avoid issues
        If RadioButton2.Checked = True Then 'checking which direction to convert, e.g. fre -> eng
            Select Case eng1
                Case = English(0)
                    TextBox1.Text = French(0)
                Case = English(1)
                    TextBox1.Text = French(1)
                Case = English(2)
                    TextBox1.Text = French(2)
                Case = English(3)
                    TextBox1.Text = French(3)
                Case = English(4)
                    TextBox1.Text = French(4)
                Case = English(5)
                    TextBox1.Text = French(5)
                Case = English(6)
                    TextBox1.Text = French(6)
                Case = English(7)
                    TextBox1.Text = French(7)
                Case = English(8)
                    TextBox1.Text = French(8)
                Case Else 'validation
                    MsgBox("Please enter a valid input")
            End Select
        ElseIf RadioButton1.Checked = True Then 'checking which direction to convert, e.g. fre -> eng
            Select Case fre1
                Case = French(0)
                    TextBox2.Text = English(0)
                Case = French(1)
                    TextBox2.Text = English(1)
                Case = French(2)
                    TextBox2.Text = English(2)
                Case = French(3)
                    TextBox2.Text = English(3)
                Case = French(4)
                    TextBox2.Text = English(4)
                Case = French(5)
                    TextBox2.Text = English(5)
                Case = French(6)
                    TextBox2.Text = English(6)
                Case = French(7)
                    TextBox2.Text = English(7)
                Case = French(8)
                    TextBox2.Text = English(8)
                Case Else 'validation
                    MsgBox("Please enter a valid input")
            End Select

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
