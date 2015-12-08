Imports System.Net.Mail
Public Class Form1
    Dim smtpserver As New SmtpClient
    Dim mail As New MailMessage
    Public Shared pass_flag As Boolean = True
    Public Sub host_port_set(ByVal index As Integer)
        If index = 1 Then
            smtpserver.Host = "smtp.mail.yahoo.com"
            smtpserver.Host = 465
            smtpserver.EnableSsl = False
        ElseIf index = 2 Then
            smtpserver.Host = "smtp.gmail.com"
            smtpserver.Port = 587
        ElseIf index = 3 Then
            smtpserver.Host = "smtp.live.com"
            smtpserver.Port = 587
        End If
    End Sub
    Public Function empty_message() As Boolean
        Dim result As Boolean
        If TextBox1.Text.Contains("@") = False Or Len(TextBox1.Text) = 0 Then
            MsgBox("Please Enter Your Complete Mail With @")
        ElseIf Len(TextBox2.Text) = 0 Then
            MsgBox("Please Enter Your Password")
        ElseIf ListBox1.Items.Count = 0 Then
            MsgBox("Please Enter Reciever Address Complete With @")
        ElseIf Len(TextBox5.Text) = 0 Then
            MsgBox("Please Enter Subject Of Your Mail")
        Else
            result = True
        End If
        Return result
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        smtpserver.EnableSsl = True

        host_port_set(1)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error GoTo error_label
        Dim flag As Boolean
        flag = empty_message()
        If flag = True Then
            smtpserver.Credentials = New System.Net.NetworkCredential(TextBox1.Text, TextBox2.Text)
            TextBox1.Text = (ListBox1.Items.Count)
            'mail.To.Add(ListBox1.Items.ToString)
            'mail.From = New MailAddress(TextBox1.Text, TextBox1.Text, System.Text.Encoding.UTF8)
            'mail.IsBodyHtml = True
            'mail.Subject = TextBox4.Text
            'mail.Body = TextBox3.Text
            'smtpserver.Send(mail)
            'MsgBox("Message Sent")
        End If

        Exit Sub
error_label:
        MsgBox("Error In Send")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        host_port_set(2)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        host_port_set(1)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        host_port_set(3)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If pass_flag = True Then
            TextBox2.UseSystemPasswordChar = False
            pass_flag = False
            Button2.Text = "Hide"
        Else
            TextBox2.UseSystemPasswordChar = True
            pass_flag = True
            Button2.Text = "Show"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBox1.Items.Contains(TextBox5.Text) Then
            MsgBox("This Email Is Present In Mail List")
        ElseIf TextBox5.Text.Contains("@") And TextBox5.Text.Contains(".") = True Then
            ListBox1.Items.Add(TextBox5.Text)
            TextBox5.Text = ""
        Else
            MsgBox("Please Enter Correct Email Address")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
End Class
