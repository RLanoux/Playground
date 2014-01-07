Imports System.IO

Public Class Form1

    Private Const APP_VERSION = "v1.0"
    Private Const FILEPATH As String = "C:/Playground"
    Private Const DATAFILE As String = "Cities.txt"
    Private sFullPath As String = FILEPATH & "/" & DATAFILE
    Dim moSR As StreamReader = Nothing
    Dim moSW As StreamWriter = Nothing

    Private Sub DoWork()
        ' Here is where you'll put the "meat and potatoes" of your program.

        ' Validate the user's information and selections
        If ValidateInfo() Then
            'Put the name into the output label
            lblOutput.Text = "Name: " & txtFName.Text & vbCrLf & vbCrLf

            'Put the departure date into the output label
            lblOutput.Text &= "Departure Date: " & dtpDeparture.Value.ToShortDateString() & vbCrLf

            'Put the return date into the output label
            lblOutput.Text &= "Return Date: " & dtpReturn.Value.ToShortDateString() & vbCrLf

            'State the city of origin in the output label
            lblOutput.Text &= "Origination: " & cboDepartCity.Text & vbCrLf

            'State the city of destination in the output label
            lblOutput.Text &= "Destination: " & cboDestination.Text & vbCrLf

            'Message the user to confirm travel details
            SetStatus("Please verify your information and click the Commit button.")

        Else
        End If

        ' Output details to the user for confirmation

    End Sub

    Private Sub LoadCities()


        'Check to make sure the data file exists
        If File.Exists(sFullPath) Then
            moSR = New StreamReader(sFullPath)
            Dim sTemp As String = moSR.ReadLine()
            While Not (sTemp = String.Empty)
                cboDepartCity.Items.Add(sTemp)
                cboDestination.Items.Add(sTemp)
                sTemp = moSR.ReadLine()
            End While
            moSR.Close()
        End If

    End Sub

    Private Sub Reset()

    End Sub
    Private Sub SaveCities()
        moSW = New StreamWriter(sFullPath, False)
        For Each Item As String In cboDepartCity.Items
            moSW.WriteLine(Item)

            'Check to make sure the data folder exists
            If Not Directory.Exists(FILEPATH) Then
                Directory.CreateDirectory(FILEPATH)
            End If
        Next
        moSW.Close()
    End Sub

    Private Sub SetStatus(ByVal s As String)
        tslStatus.Text = s
    End Sub

    Private Function ValidateInfo() As Boolean

        Dim bIsValid As Boolean = True

        ' Validate a First name has been entered
        If txtFName.Text = String.Empty Then
            txtFName.BackColor = Color.LightSalmon
            MsgBox("You must enter a name.")
            txtFName.BackColor = Color.White
            bIsValid = False
        End If

        ' Validate a Last name has been entered
        If txtLName.Text = String.Empty Then
            txtLName.BackColor = Color.LightSalmon
            MsgBox("You must enter a name.")
            txtFName.BackColor = Color.White
            bIsValid = False
        End If

        ' Validate the Departure Date is >= today
        If dtpDeparture.Value < Today Then
            lblDepDate.ForeColor = Color.Red
            MsgBox("Departure date must" & vbCrLf & "be today or later.")
            lblDepDate.ForeColor = Color.Black
            bIsValid = False
        End If

        ' Validate the Destination Date is >= today and the Destination Date is >= Departure Date
        If ((dtpReturn.Value < Today) Or _
            (dtpReturn.Value < dtpDeparture.Value)) Then
            lblRetDate.ForeColor = Color.Red
            MsgBox("Return date must be today or later" & vbCrLf _
                   & "and later than departure date.")
            lblRetDate.ForeColor = Color.Black
            bIsValid = False
        End If

        ' Validate that Departure City was selected
        If (cboDepartCity.SelectedIndex < 0) Then
            MsgBox("Please select city of origin (departure).")
            bIsValid = False
        End If

        ' Validate that Destination City was selected
        If (cboDestination.SelectedIndex < 0) Then
            MsgBox("Please select a city of destination.")
            bIsValid = False
        End If

        Return bIsValid

    End Function

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveCities()
        cboDepartCity.Items.Clear()
        cboDestination.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Playground " + APP_VERSION
        LoadCities()
    End Sub

    Private Sub btnProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnProcess.Click
        DoWork()
        txtFName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub dtpDeparture_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDeparture.ValueChanged

    End Sub

    Private Sub dtpReturn_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpReturn.ValueChanged

    End Sub

    Private Sub cboDepartCity_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDepartCity.SelectedIndexChanged
        Select Case (cboDepartCity.Text)
            Case "Atlanta"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\Atlanta.jpg")
            Case "Boston"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\Boston.jpg")
            Case "Dallas"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\Dallas.jpg")
            Case "Houston"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\Houston.jpg")
            Case "Linden, Tennessee"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\Linden.jpg")
            Case "Los Angeles"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\LosAngeles.jpg")
            Case "New Orleans"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\NewOrleans.jpg")
            Case "New York City"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\NewYorkCity.jpg")
            Case "Chicago"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\Chicago.jpg")
            Case "Miami"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\Miami.jpg")
            Case "San Francisco"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\SanFrancisco.jpg")
            Case "Washington, D.C."
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\WashingtonDC.jpg")
            Case "Seattle"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\Seattle.jpg")
            Case "Las Vegas"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\LasVegas.jpg")
            Case "St. Louis"
                picDep.Load("H:\Programming\VB Programs\Playground\Playground\StLouis.jpg")
        End Select

    End Sub

    Private Sub cboDestination_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDestination.SelectedIndexChanged
        Select Case (cboDestination.Text)
            Case "Atlanta"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\Atlanta.jpg")
            Case "Boston"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\Boston.jpg")
            Case "Dallas"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\Dallas.jpg")
            Case "Houston"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\Houston.jpg")
            Case "Linden, Tennessee"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\Linden.jpg")
            Case "Los Angeles"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\LosAngeles.jpg")
            Case "New Orleans"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\NewOrleans.jpg")
            Case "New York City"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\NewYorkCity.jpg")
            Case "Chicago"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\Chicago.jpg")
            Case "Miami"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\Miami.jpg")
            Case "San Francisco"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\SanFrancisco.jpg")
            Case "Washington, D.C."
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\WashingtonDC.jpg")
            Case "Seattle"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\Seattle.jpg")
            Case "Las Vegas"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\LasVegas.jpg")
            Case "St. Louis"
                picDest.Load("H:\Programming\VB Programs\Playground\Playground\StLouis.jpg")
        End Select

    End Sub

    Private Sub btnCities_Click(sender As System.Object, e As System.EventArgs) Handles btnCities.Click
        Cities.Show()

    End Sub
End Class

