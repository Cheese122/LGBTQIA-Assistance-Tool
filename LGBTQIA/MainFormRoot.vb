Public Class MainFormRoot
    Private Sub cbxSexualOrientation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSexualOrientation.SelectedIndexChanged
        If cbxSexualOrientation.SelectedIndex = 5 Then
            Dim strOtherOrientation = InputBox("What is your preferred sexual orientation?")
            cbxSexualOrientation.Items.Add(strOtherOrientation)
            cbxSexualOrientation.SelectedItem = strOtherOrientation
        End If
    End Sub

    Private Sub cbxRomanticOrientation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRomanticOrientation.SelectedIndexChanged
        If cbxRomanticOrientation.SelectedIndex = 6 Then
            Dim strOtherOrientation = InputBox("What is your preferred romantic orientation?")
            cbxRomanticOrientation.Items.Add(strOtherOrientation)
            cbxRomanticOrientation.SelectedItem = strOtherOrientation
        End If
    End Sub

End Class
