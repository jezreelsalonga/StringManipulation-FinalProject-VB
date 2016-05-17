Public Class CaesarCipher
    Private _cipherEngine As New Cypher
    Private Sub C2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2.CheckedChanged

        If C2.Checked = True Then
            C1.CheckState = CheckState.Unchecked
            T1.Clear()
            T2.Clear()
            Label1.Text = "Cipher"
            Label2.Text = "Plain Text"
        End If
    End Sub
    Private Sub C1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1.CheckedChanged

        If C1.Checked = True Then
            T1.Clear()
            T2.clear()
            C2.Checked = False
            Label1.Text = "Plain Text"
            Label2.Text = "Cipher"
        End If
    End Sub

    Private Sub T1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles T1.TextChanged
        If C1.Checked = True Then
            T2.Text = _cipherEngine.Encipher(T1.Text)
        ElseIf C2.Checked = True Then
            T2.Text = _cipherEngine.Decipher(T1.Text)
        End If

    End Sub
End Class
