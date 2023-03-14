Option Strict On
Public Class Form1
    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        'Declaring And Initializing variables
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decAverage As Decimal = 0D
        Dim decSumofSpeeds As Decimal

        Dim strIBoxMsg As String = "Enter the number of Mbps user #"
        Dim strIBoxTitle As String = "Internet Speed"
        Dim strNotNumericErrMsg As String = "Error- Enter the speed of your home Internet connection"
        Dim strNegErrMsg As String = "Error- Enter a valid speed"

        'Declare and initialize loop variables
        Dim intMaxEntries As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)
        'Do Until intNumberofEnties > intMaximmNumberofEntries
        'Or until strSpeed is empty (use Cancel Button property)
        Do Until intEntries > intMaxEntries Or strSpeed = ""

            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)

                If decSpeed > 0 Then
                    lstSpeed.Items.Add(decSpeed)
                    decSumofSpeeds += decSpeed
                    intEntries += 1
                    strIBoxMsg = strIBoxMsg
                Else
                    strIBoxMsg = strNegErrMsg
                End If
            Else
                strIBoxMsg = strNotNumericErrMsg
            End If


            If intEntries <= intMaxEntries Then
                strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)
            End If
        Loop

        lblAverageInternetSpeed.Visible = True

        If intEntries > 1 Then
            decAverage = decSumofSpeeds / (intEntries - 1)
            lblAverageInternetSpeed.Text = "Average Internet Speed: " &
                decAverage.ToString("F2") & "Mbps"
        Else

            lblAverageInternetSpeed.Text = "No Speed Values Entered"
        End If

        btnSpeed.Enabled = True


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSpeed.Items.Clear()
        lblAverageInternetSpeed.Text = ""
        btnClear.Enabled = True
    End Sub
End Class
