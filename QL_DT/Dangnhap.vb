Public Class Dangnhap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "admin") Or (TextBox2.Text = "admin") Then
            Quanly.Show()
            Me.Hide()

        Else
            MessageBox.Show("tài khoản hoặc mật khẩu không đúng ", "lỗi", MessageBoxButtons.OK)
        End If
    End Sub
End Class
