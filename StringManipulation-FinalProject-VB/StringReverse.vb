Public Class StringReverse

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRev.Click
        Dim input As String
        Dim output As String = ""
        Dim x As Integer
        Dim i As Integer
        Dim len As Integer

        input = txtInput.Text
        len = input.Length
        x = len - 1 'since the char positioning in an array starts in 0, we subtract 1 from the text length
        For i = 0 To x
            output = output & input.Chars(x) 'Chars is a method of the String variable type. You can use it on any length of string, 
            x = x - 1                        'not just a Char variable. And that's the difference between the two: Char is a variable type, 
        Next                                 'while Chars is a method you can use on Strings.

        txtOutput.Text = output
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtOutput_TextChanged(sender As Object, e As EventArgs) Handles txtOutput.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtInput.Text = ""
        txtOutput.Text = ""

    End Sub
End Class
