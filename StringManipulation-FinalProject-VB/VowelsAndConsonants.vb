Public Class VowelsAndConsonants

    'Dim vowels() As String = {"a", "e", "i", "o", "u"}
    'Dim consonant() As String = {"b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z"}
    Dim vlop As Integer



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub

        'convert to lowercase
        TextBox1.Text = TextBox1.Text.ToLower()
        'trim spaces
        TextBox1.Text = TextBox1.Text.Trim()
        'replace space to blank
        If InStr(TextBox1.Text, " ") Then TextBox1.Text = Replace(TextBox1.Text, " ", "")

        For Me.vlop = 0 To Len(Trim(TextBox1.Text)) - 1

            If TextBox1.Text.Substring(Me.vlop, 1) = "a" Then
                Label2.Text = Label2.Text & TextBox1.Text.Substring(Me.vlop, 1)

            ElseIf TextBox1.Text.Substring(Me.vlop, 1) = "e" Then
                Label2.Text = Label2.Text & TextBox1.Text.Substring(Me.vlop, 1)

            ElseIf TextBox1.Text.Substring(Me.vlop, 1) = "i" Then
                Label2.Text = Label2.Text & TextBox1.Text.Substring(Me.vlop, 1)

            ElseIf TextBox1.Text.Substring(Me.vlop, 1) = "o" Then
                Label2.Text = Label2.Text & TextBox1.Text.Substring(Me.vlop, 1)

            ElseIf TextBox1.Text.Substring(Me.vlop, 1) = "u" Then
                Label2.Text = Label2.Text & TextBox1.Text.Substring(Me.vlop, 1)

                'consonants
            Else
                Label3.Text = Label3.Text & TextBox1.Text.Substring(Me.vlop, 1)
            End If

        Next Me.vlop

        Label4.Text = Label4.Text & Len(Label2.Text) - 8
        Label5.Text = Label5.Text & Len(Label3.Text) - 12

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Label2.Text = ""
        'Label3.Text = ""
        Button1.Text = "OKAY"
        Button2.Text = "CLEAR"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label2.Text = "Vowels: "
        Label3.Text = "Consonants: "
        Label4.Text = "Length: "
        Label5.Text = "Length: "
    End Sub
End Class
