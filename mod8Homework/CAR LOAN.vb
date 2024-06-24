'' Author: Francisco Bumanglag
'' Project: Car Loan
'' Assignment: Module 8 Homework
'' Course: Visual Basic, Santa Ana College
'' Class: CMPR105 Derendal Huynh 
'' Date: October 12, 2022


Public Class CAR_LOAN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim costVehcile As Double = 25000
        Dim yrCost As Double = 5000
        Dim price As Double

        price = FormatCurrency(costVehcile - yrCost)

        For yr As Integer = 2019 To 2023

            ListBox1.Items.Add(yr & vbTab & FormatCurrency(price))

            price = price - yrCost

        Next

    End Sub
End Class