' Program Name: Smart Home App
' Wesley Barron

Option Strict On

Public Class frmSmartHome
    Private _intArraySize As Integer = 11
    Private _strSavings(_intArraySize) As String
    Private _decBill(_intArraySize) As Decimal

    Private Sub frmSmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        lblMonthlySavings.Text = ""
        lblMonthlyAverage.Text = ""
        lblSignificant.Text = ""
        btnStats.Visible = False

        Try
            'Does the file Exists?
            If IO.File.Exists("C:\Users\barron_wesley\source\repos\SmartHome\Smart Home\savings.txt") = True Then
                objReader = IO.File.OpenText("C:\Users\barron_wesley\source\repos\SmartHome\Smart Home\savings.txt")
                'Read the file line by line
                Do While objReader.Peek <> -1
                    _strSavings(intCount) = objReader.ReadLine()
                    strSavingsAmount = objReader.ReadLine()
                    _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                    intCount += 1
                Loop
                objReader.Close()
                'Populate Combo Box
                For intFill = 0 To (_strSavings.Length - 1)
                    comBoxMonth.Items.Add(_strSavings(intFill))
                Next
            Else
                MsgBox("The file is not available. Restart the program when the file is available", , "Error")
                Close()
            End If
        Catch ex As Exception
            MsgBox("The file is not available. Restart the program when the file is available", , ex)
            Close()
        End Try
    End Sub

    Private Sub comBoxMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxMonth.SelectedIndexChanged
        'Combo Box selected index value changes, display the savings for the selected month
        Dim intSelectedCityIndex As Integer

        intSelectedCityIndex = comBoxMonth.SelectedIndex
        lblMonthlySavings.Text = "The electric savings for " & _strSavings(intSelectedCityIndex) & " is $" & _decBill(intSelectedCityIndex).ToString()
        btnStats.Visible = True
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        'Click event gets the average and the max savings for the electric bill for each month
        ComputeAverage()
        ComputeMaxSavings()
    End Sub

    Private Sub ComputeMaxSavings()
        Dim intMonths As Integer
        Dim intLargestSavingsValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strYearValue As String = ""

        For Each intMonths In _decBill
            intLargestSavingsValue = Math.Max(intLargestSavingsValue, intMonths)
            If (intMonths >= intLargestSavingsValue) Then
                strYearValue = _strSavings(intIndexValue)
            End If
            intIndexValue += 1
        Next
        lblSignificant.Text = strYearValue & " had the most significant monthly savings"
    End Sub

    Private Sub ComputeAverage()
        Dim intCountYears As Integer
        Dim intYears As Integer = 0
        Dim decTotalBill As Decimal = 0
        Dim decAverageNumberOfBill As Decimal = 0D

        For Each intCountYears In _decBill
            decTotalBill += _decBill(intYears)
            intYears += 1
        Next
        decAverageNumberOfBill = decTotalBill / Convert.ToDecimal(_decBill.Length())
        lblMonthlyAverage.Text = "The average monthly savings: " & decAverageNumberOfBill.ToString("C2")
    End Sub
End Class
