﻿Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile_Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        customerProfilePicture = New PictureBox()
        customerName_tb = New TextBox()
        email_tb = New TextBox()
        contact_tb = New TextBox()
        address_tb = New TextBox()
        location_tb = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        CType(customerProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' customerProfilePicture
        ' 
        customerProfilePicture.BackgroundImage = My.Resources.Resource1.displayPicture
        customerProfilePicture.BackgroundImageLayout = ImageLayout.Stretch
        customerProfilePicture.Location = New Point(215, 131)
        customerProfilePicture.Name = "customerProfilePicture"
        customerProfilePicture.Size = New Size(370, 443)
        customerProfilePicture.TabIndex = 0
        customerProfilePicture.TabStop = False
        ' 
        ' customerName_tb
        ' 
        customerName_tb.BackColor = Color.WhiteSmoke
        customerName_tb.BorderStyle = BorderStyle.None
        customerName_tb.Enabled = False
        customerName_tb.Font = New Font("Bahnschrift SemiCondensed", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        customerName_tb.ForeColor = Color.Black
        customerName_tb.HideSelection = False
        customerName_tb.Location = New Point(629, 131)
        customerName_tb.Name = "customerName_tb"
        customerName_tb.ReadOnly = True
        customerName_tb.Size = New Size(327, 52)
        customerName_tb.TabIndex = 1
        customerName_tb.Text = "ADITYA MANDAL"
        ' 
        ' email_tb
        ' 
        email_tb.BackColor = Color.White
        email_tb.BorderStyle = BorderStyle.FixedSingle
        email_tb.Font = New Font("Bahnschrift Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        email_tb.Location = New Point(482, 150)
        email_tb.Name = "email_tb"
        email_tb.ReadOnly = True
        email_tb.Size = New Size(332, 33)
        email_tb.TabIndex = 2
        email_tb.Text = "aditya.mandal@iitg.ac.in"
        ' 
        ' contact_tb
        ' 
        contact_tb.BackColor = Color.White
        contact_tb.BorderStyle = BorderStyle.FixedSingle
        contact_tb.Font = New Font("Bahnschrift Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contact_tb.Location = New Point(482, 214)
        contact_tb.Name = "contact_tb"
        contact_tb.ReadOnly = True
        contact_tb.Size = New Size(332, 33)
        contact_tb.TabIndex = 3
        contact_tb.Text = "9939383327"
        ' 
        ' address_tb
        ' 
        address_tb.BackColor = Color.White
        address_tb.BorderStyle = BorderStyle.FixedSingle
        address_tb.Font = New Font("Bahnschrift Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        address_tb.Location = New Point(482, 280)
        address_tb.Multiline = True
        address_tb.Name = "address_tb"
        address_tb.ReadOnly = True
        address_tb.Size = New Size(332, 109)
        address_tb.TabIndex = 4
        address_tb.Text = "Brahmaputra Hostel, IIT Guwahati"
        ' 
        ' location_tb
        ' 
        location_tb.BackColor = Color.White
        location_tb.BorderStyle = BorderStyle.FixedSingle
        location_tb.Font = New Font("Bahnschrift Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        location_tb.Location = New Point(482, 424)
        location_tb.Name = "location_tb"
        location_tb.ReadOnly = True
        location_tb.Size = New Size(332, 33)
        location_tb.TabIndex = 5
        location_tb.Text = "Guwahati"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(629, 220)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 19)
        Label1.TabIndex = 6
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.Font = New Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(629, 287)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 19)
        Label2.TabIndex = 7
        Label2.Text = "Contact"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(482, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 19)
        Label3.TabIndex = 8
        Label3.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(482, 402)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 19)
        Label4.TabIndex = 9
        Label4.Text = "Location"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(email_tb)
        Panel1.Controls.Add(address_tb)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(contact_tb)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(location_tb)
        Panel1.Location = New Point(147, 92)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(865, 580)
        Panel1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(249), CByte(117), CByte(75))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(510, 614)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 33)
        Button1.TabIndex = 10
        Button1.Text = "Update Details"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Profile_Customer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1194, 694)
        ControlBox = False
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(customerName_tb)
        Controls.Add(customerProfilePicture)
        Controls.Add(Panel1)
        DoubleBuffered = True
        ForeColor = SystemColors.Control
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 2, 3, 2)
        Name = "Profile_Customer"
        StartPosition = FormStartPosition.CenterParent
        TopMost = True
        CType(customerProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents customerProfilePicture As PictureBox
    Friend WithEvents customerName_tb As TextBox
    Friend WithEvents email_tb As TextBox
    Friend WithEvents contact_tb As TextBox
    Friend WithEvents address_tb As TextBox
    Friend WithEvents location_tb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
