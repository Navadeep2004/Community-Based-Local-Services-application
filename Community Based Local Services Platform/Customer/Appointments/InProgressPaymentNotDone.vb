﻿Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class InProgressPaymentNotDone

    Public Sub CheckOrGenerateOTP(appointmentID As Integer)
        Dim checkQuery As String = "SELECT otpCode 
            FROM OTPs 
            WHERE appointmentID = @appointmentID"

        Dim insertQuery As String = "INSERT INTO OTPs (appointmentID, otpCode, otpExpiration) 
            VALUES (@appointmentID, @otp, ADDTIME(NOW(), '00:15:00'))"

        Using connection As New MySqlConnection(SessionManager.connectionString)
            connection.Open()

            Using checkCommand As New MySqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@appointmentID", SessionManager.appointmentID)

                Dim existingOTP As String = checkCommand.ExecuteScalar()?.ToString()

                If Not String.IsNullOrEmpty(existingOTP) Then
                    OTP_box.Text = existingOTP
                Else
                    Dim random As New Random()
                    Dim newOTP As Integer = random.Next(100000, 999999)

                    Using insertCommand As New MySqlCommand(insertQuery, connection)
                        insertCommand.Parameters.AddWithValue("@appointmentID", appointmentID)
                        insertCommand.Parameters.AddWithValue("@otp", newOTP)
                        insertCommand.ExecuteNonQuery()
                        OTP_box.Text = newOTP.ToString()
                    End Using
                End If
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub Appointmentdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1200, 700)
        Me.BackColor = Color.White
        Me.FormBorderStyle = BorderStyle.None

        OTP_box.ReadOnly = True
        OTP_box.BackColor = Me.BackColor

        BackButton.Font = New Font(SessionManager.font_family, 11, FontStyle.Regular)
        BackButton.BackColor = ColorTranslator.FromHtml("#F9754B")
        BackButton.Size = New Size(67, 25)
        BackButton.Location = New Point(1067, 75)
        BackButton.FlatAppearance.BorderSize = 0
        BackButton.ForeColor = ColorTranslator.FromHtml("#FFFFFF")
        CheckOrGenerateOTP(SessionManager.appointmentID)
        LoadChatPanel()

    End Sub

    Private Sub LoadChatPanel()

        Dim chatPanel As New Panel()
        chatPanel.Location = New Point(687, 125)
        chatPanel.Size = New Size(437, 490)
        chatPanel.BorderStyle = BorderStyle.FixedSingle
        chatPanel.BackColor = Color.White

        Me.Controls.Add(chatPanel)

        With ChatBox
            .TopLevel = False
            .Dock = DockStyle.Fill
            chatPanel.Controls.Add(ChatBox)
            .BringToFront()
            .Show()
        End With

    End Sub


    Private Sub RemovePreviousForm()
        ' Check if any form is already in Panel5
        If Panel3.Controls.Count > 0 Then
            ' Remove the first control (form) from Panel5
            Panel3.Controls.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RemovePreviousForm()

        Dim str As String = "Reschedule"
        Dim appointmentBookingForm As New Appointment_booking(str)

        With appointmentBookingForm
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel3.Controls.Add(appointmentBookingForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim currentDateTime As DateTime = DateTime.Now
        Dim restrictedTimeString As String = Booked_slot_tb.Text
        Dim restrictedDateTime As DateTime

        If DateTime.TryParse(restrictedTimeString, restrictedDateTime) Then
            ' Check if the current date is past the restricted date
            If currentDateTime.Date > restrictedDateTime.Date OrElse (currentDateTime.Date = restrictedDateTime.Date AndAlso currentDateTime.TimeOfDay >= restrictedDateTime.TimeOfDay) Then
                ' If past the restricted date and time, proceed to show the Payment_Gateway form
                ' Remove any previous form
                RemovePreviousForm()
                With Payment_Gateway
                    .TopLevel = False
                    .Dock = DockStyle.Fill
                    Panel3.Controls.Add(Payment_Gateway)
                    .BringToFront()
                    .Show()
                End With
            Else
                MessageBox.Show("Button click is not allowed yet.")
            End If
        Else

            MessageBox.Show("Error parsing TextBox value to DateTime.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RemovePreviousForm()
        Me.Close()
        With AppointmentList_Customer
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel3.Controls.Add(AppointmentList_Customer)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        RemovePreviousForm()
        Me.Close()
        With AppointmentList_Customer
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel3.Controls.Add(AppointmentList_Customer)
            .BringToFront()
            .Show()
        End With
    End Sub

End Class