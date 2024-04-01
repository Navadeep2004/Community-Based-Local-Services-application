﻿Imports System.IO

Public Class Display_Services
    ' Define the service provider class
    Public Class ServiceProvider
        Public Property Name As String
        Public Property Description As String
        Public Property Cost As String
        Public Property ServiceName As String
        Public Property Ratings As Integer
    End Class

    ' List to store service providers
    Private serviceProviders As New List(Of ServiceProvider)()

    Private Sub Display_Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure the form
        Me.CenterToParent()
        Me.WindowState = FormWindowState.Normal
        Me.Size = New Size(841, 635)

        ' Populate the serviceProviders list with query from DB
        serviceProviders.Add(New ServiceProvider() With {.Name = "Electrician", .Description = "Expert in electrical repairs", .Cost = "5000", .ServiceName = "Electrical Services", .Ratings = 4})
        serviceProviders.Add(New ServiceProvider() With {.Name = "Plumber", .Description = "Experienced in plumbing works", .Cost = "6000", .ServiceName = "Plumbing Services", .Ratings = 4})
        serviceProviders.Add(New ServiceProvider() With {.Name = "Gardener", .Description = "Provides garden maintenance services", .Cost = "5500", .ServiceName = "Gardening Services", .Ratings = 3})
        serviceProviders.Add(New ServiceProvider() With {.Name = "Cleaner", .Description = "Offers professional cleaning services", .Cost = "8000", .ServiceName = "Cleaning Services", .Ratings = 5})
        serviceProviders.Add(New ServiceProvider() With {.Name = "Painter", .Description = "Specializes in interior and exterior painting", .Cost = "9000", .ServiceName = "Painting Services", .Ratings = 4})
        serviceProviders.Add(New ServiceProvider() With {.Name = "Carpenter", .Description = "Skilled in carpentry and woodworking", .Cost = "8500", .ServiceName = "Carpentry Services", .Ratings = 3})
        serviceProviders.Add(New ServiceProvider() With {.Name = "Mover", .Description = "Offers moving and relocation services", .Cost = "7500", .ServiceName = "Moving Services", .Ratings = 4})
        serviceProviders.Add(New ServiceProvider() With {.Name = "Tutor", .Description = "Provides tutoring services for various subjects", .Cost = "6500", .ServiceName = "Tutoring Services", .Ratings = 4})
        serviceProviders.Add(New ServiceProvider() With {.Name = "Electrician", .Description = "Expert in electrical repairs and installation", .Cost = "7000", .ServiceName = "Electrical Services", .Ratings = 4})
        serviceProviders.Add(New ServiceProvider() With {.Name = "Plumber", .Description = "Offers plumbing solutions for households and businesses", .Cost = "6500", .ServiceName = "Plumbing Services", .Ratings = 3})

        ' Display the default data
        DisplayDefault()
    End Sub

    ' Method to display default view
    Private Sub DisplayDefault()
        Dim lblMostTrustedHeading As New Label()
        lblMostTrustedHeading.Text = "Most Trusted Service Providers"
        lblMostTrustedHeading.Font = New Font(SessionManager.font_family, 14, FontStyle.Bold)
        lblMostTrustedHeading.Size = New Size(280, 28)
        lblMostTrustedHeading.Location = New Point(51, 118)
        Me.Controls.Add(lblMostTrustedHeading)

        Dim lblPopularHeading As New Label()
        lblPopularHeading.Text = "Trending Services"
        lblPopularHeading.Font = New Font(SessionManager.font_family, 14, FontStyle.Bold)
        lblPopularHeading.Size = New Size(280, 28)
        lblPopularHeading.Location = New Point(51, 371)
        Me.Controls.Add(lblPopularHeading)

        ' Display most trusted service providers
        For i As Integer = 0 To 3
            Dim pb As New PictureBox()
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Size = New Size(169, 157)
            pb.Location = New Point(48 + (i * (32 + 169)), 155)
            ' Load sample image for service provider
            Dim imagePath As String = Path.Combine(Application.StartupPath, "..\..\..\Resources\sample_SP.jpg")
            pb.Image = Image.FromFile(imagePath)
            Me.Controls.Add(pb)

            Dim lblProvider As New Label()
            lblProvider.Text = serviceProviders(i).Name
            lblProvider.Size = New Size(92, 14)
            lblProvider.Font = New Font(SessionManager.font_family, 10, FontStyle.Regular)
            lblProvider.Location = New Point(86 + (i * (110 + 92)) + 20, 320)
            Me.Controls.Add(lblProvider)
        Next

        ' Display popular services
        For i As Integer = 0 To 3
            Dim pb As New PictureBox()
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Size = New Size(169, 157)
            pb.Location = New Point(48 + (i * (32 + 169)), 408)
            ' Load sample image for service provider
            Dim imagePath As String = Path.Combine(Application.StartupPath, "..\..\..\Resources\sample_SP.jpg")
            pb.Image = Image.FromFile(imagePath)
            Me.Controls.Add(pb)

            Dim lblProvider As New Label()
            lblProvider.Text = serviceProviders(i).ServiceName
            lblProvider.Size = New Size(92, 14)
            lblProvider.Font = New Font(SessionManager.font_family, 10, FontStyle.Regular)
            lblProvider.Location = New Point(86 + (i * (110 + 92)) + 20, 574)
            Me.Controls.Add(lblProvider)
        Next
    End Sub

    ' Method to update services based on search criteria
    Public Sub UpdateServices(searchCriteria As String, minCostCriteria As String, maxCostCriteria As String)
        ' Clear existing controls from the form
        Me.Controls.Clear()

        ' Convert min and max cost criteria to integers
        Dim minCost As Integer
        Dim maxCost As Integer
        Integer.TryParse(minCostCriteria, minCost)
        Integer.TryParse(maxCostCriteria, maxCost)

        ' Check if the search criteria is empty
        If String.IsNullOrWhiteSpace(searchCriteria) Then
            ' Load the default view
            DisplayDefault()
            ' Show a "No results" popup
            MessageBox.Show("Please enter a search criteria.", "No results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Filter service providers based on search criteria and cost criteria
            Dim filteredProviders = serviceProviders.Where(Function(provider) _
            (provider.Name.ToLower().Contains(searchCriteria.ToLower()) Or
            provider.Description.ToLower().Contains(searchCriteria.ToLower()) Or
            provider.ServiceName.ToLower().Contains(searchCriteria.ToLower())) And
            (Integer.TryParse(provider.Cost, Nothing) AndAlso
            (String.IsNullOrWhiteSpace(minCostCriteria) OrElse Integer.Parse(provider.Cost) >= minCost) AndAlso
            (String.IsNullOrWhiteSpace(maxCostCriteria) OrElse Integer.Parse(provider.Cost) <= maxCost))
        ).ToList()

            ' Check if there are any results
            If filteredProviders.Count = 0 Then
                ' Load the default view
                DisplayDefault()
                ' Show a "No results" popup
                MessageBox.Show("No results found for the search criteria.", "No results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Display the filtered service providers
                DisplaySearchResults(filteredProviders)
            End If
        End If
    End Sub

    ' Method to display search results
    Private Sub DisplaySearchResults(providers As List(Of ServiceProvider))
        Me.AutoScroll = True
        Dim verticalGap As Integer = 26 ' Vertical gap between result panels

        Dim yPos As Integer = 101 ' Initial Y position of the result panels
        For Each provider In providers
            Dim resultPanel As New Panel()
            resultPanel.Size = New Size(734, 198)
            ' Set the position of the result panel
            resultPanel.Location = New Point(38, yPos)
            yPos += resultPanel.Height + verticalGap ' Update yPos for next result panel
            resultPanel.BorderStyle = BorderStyle.FixedSingle

            Dim pb As New PictureBox()
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Size = New Size(169, 157)
            ' Load sample image for service provider
            Dim imagePath As String = Path.Combine(Application.StartupPath, "..\..\..\Resources\sample_SP.jpg")
            pb.Image = Image.FromFile(imagePath)
            pb.Location = New Point(21, 21)
            resultPanel.Controls.Add(pb)

            Dim nameLabel As New Label()
            nameLabel.Text = provider.Name
            nameLabel.Size = New Size(280, 28)
            nameLabel.Location = New Point(208, 22)
            nameLabel.Font = New Font(SessionManager.font_family, 13, FontStyle.Regular)
            resultPanel.Controls.Add(nameLabel)

            Dim serviceNameLabel As New Label()
            serviceNameLabel.Text = provider.ServiceName
            serviceNameLabel.Size = New Size(280, 28)
            serviceNameLabel.Location = New Point(208, 50)
            serviceNameLabel.Font = New Font(SessionManager.font_family, 11, FontStyle.Regular)
            resultPanel.Controls.Add(serviceNameLabel)

            Dim costLabel As New Label()
            costLabel.Text = "Rate : Rs. " & provider.Cost
            costLabel.Size = New Size(280, 14)
            costLabel.Location = New Point(208, 76)
            costLabel.Font = New Font(SessionManager.font_family, 9, FontStyle.Regular)
            resultPanel.Controls.Add(costLabel)

            Dim descriptionLabel As New Label()
            descriptionLabel.Text = provider.Description
            descriptionLabel.Size = New Size(490, 47)
            descriptionLabel.Location = New Point(208, 99)
            descriptionLabel.Font = New Font(SessionManager.font_family, 7, FontStyle.Regular)
            resultPanel.Controls.Add(descriptionLabel)

            Dim viewBtn As New Button()
            viewBtn.Text = "View Details"
            viewBtn.Size = New Size(107, 29)
            viewBtn.Location = New Point(451, 156)
            viewBtn.BackColor = Color.FromArgb(249, 117, 75)
            viewBtn.ForeColor = Color.White
            viewBtn.FlatStyle = FlatStyle.Flat
            viewBtn.FlatAppearance.BorderSize = 0
            ' Set the Tag property of the button to store the provider details
            viewBtn.Tag = provider
            ' Attach event handler for the button click
            AddHandler viewBtn.Click, AddressOf Navbar_Customer.ViewDetails_Click
            resultPanel.Controls.Add(viewBtn)

            Dim bookNowBtn As New Button()
            bookNowBtn.Text = "Book Now"
            bookNowBtn.Size = New Size(107, 29)
            bookNowBtn.Location = New Point(591, 156)
            bookNowBtn.BackColor = Color.FromArgb(249, 117, 75)
            bookNowBtn.ForeColor = Color.White
            bookNowBtn.FlatStyle = FlatStyle.Flat
            bookNowBtn.FlatAppearance.BorderSize = 0
            resultPanel.Controls.Add(bookNowBtn)

            Me.Controls.Add(resultPanel)
        Next
    End Sub

    ' Event handler for "View Details" button click
    Private Sub ViewDetails_Click(sender As Object, e As EventArgs)
        ' Retrieve the provider details from the Tag property of the button
        Dim provider As ServiceProvider = DirectCast(DirectCast(sender, Button).Tag, ServiceProvider)

        ' Open the SP_profile form and pass the provider details
        Dim spProfileForm As New SP_profile(provider.Name, provider.Description, provider.Cost, provider.ServiceName)
        spProfileForm.ShowDialog() ' Show the form as a dialog
    End Sub

End Class
