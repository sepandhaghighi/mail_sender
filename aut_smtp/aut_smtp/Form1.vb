Imports System.Net.Mail
Public Class Form1
    Dim smtpserver As New SmtpClient
    Dim mail As New MailMessage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        smtpserver.Host = "smtp.gmail.com"
        smtpserver.Port = 587
        smtpserver.EnableSsl = True


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mail.To.Add(TextBox5.Text)
        mail.From = New MailAddress("questionnaire1394@gmail.com", "Questionnare", System.Text.Encoding.UTF8)
        mail.IsBodyHtml = True
        mail.Subject = TextBox4.Text
        mail.Body = TextBox3.Text
        smtpserver.Send(mail)
        MsgBox("Message Sent")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        smtpserver.Credentials = New System.Net.NetworkCredential("questionnaire1394@gmail.com", "Manchesterderbyqwe1")

    End Sub
End Class
