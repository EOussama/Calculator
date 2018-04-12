Class MainWindow
    Dim active As Integer
    Dim values(1) As Double
    Dim optors As Char

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        CE_Click(sender, e)
    End Sub

    Private Sub Calcul()
        Try
            Select Case optors
                Case "+"
                    values(1) = values(0) + values(1)
                    resCreen.Text = values(1)
                Case "-"
                    values(1) = values(0) - values(1)
                    resCreen.Text = values(1)
                Case "*"
                    values(1) = values(0) * values(1)
                    resCreen.Text = values(1)
                Case "/"
                    values(1) = values(0) / values(1)
                    resCreen.Text = values(1)
            End Select
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
        End Try
    End Sub

    Private Sub CE_Click(sender As Object, e As RoutedEventArgs) Handles CE.Click
        active = 0
        values = {0, 0}
        optors = "+"

        resCreen.Text = 0
    End Sub

    Private Sub C_Click(sender As Object, e As RoutedEventArgs) Handles C.Click
        values(active) = 0
        resCreen.Text = 0
    End Sub

    Private Sub num0_Click(sender As Object, e As RoutedEventArgs) Handles num0.Click
        If resCreen.Text.Length <= 10 Then
            values(active) = Double.Parse(resCreen.Text + "0")
            resCreen.Text = values(active)
        End If
    End Sub

    Private Sub num1_Click(sender As Object, e As RoutedEventArgs) Handles num1.Click
        If resCreen.Text.Length <= 10 Then
            values(active) = Double.Parse(resCreen.Text + "1")
            resCreen.Text = values(active)
        End If
    End Sub

    Private Sub num2_Click(sender As Object, e As RoutedEventArgs) Handles num2.Click
        If resCreen.Text.Length <= 10 Then
            values(active) = Double.Parse(resCreen.Text + "2")
            resCreen.Text = values(active)
        End If
    End Sub

    Private Sub num3_Click(sender As Object, e As RoutedEventArgs) Handles num3.Click
        If resCreen.Text.Length <= 10 Then
            values(active) = Double.Parse(resCreen.Text + "3")
            resCreen.Text = values(active)
        End If
    End Sub

    Private Sub num4_Click(sender As Object, e As RoutedEventArgs) Handles num4.Click
        If resCreen.Text.Length <= 10 Then
            values(active) = Double.Parse(resCreen.Text + "4")
            resCreen.Text = values(active)
        End If
    End Sub

    Private Sub num5_Click(sender As Object, e As RoutedEventArgs) Handles num5.Click
        If resCreen.Text.Length <= 10 Then
            values(active) = Double.Parse(resCreen.Text + "5")
            resCreen.Text = values(active)
        End If
    End Sub

    Private Sub num6_Click(sender As Object, e As RoutedEventArgs) Handles num6.Click
        If resCreen.Text.Length <= 10 Then
            values(active) = Double.Parse(resCreen.Text + "6")
            resCreen.Text = values(active)
        End If
    End Sub

    Private Sub num7_Click(sender As Object, e As RoutedEventArgs) Handles num7.Click
        If resCreen.Text.Length <= 10 Then
            values(active) = Double.Parse(resCreen.Text + "7")
            resCreen.Text = values(active)
        End If
    End Sub

    Private Sub num8_Click(sender As Object, e As RoutedEventArgs) Handles num8.Click
        If resCreen.Text.Length <= 10 Then
            values(active) = Double.Parse(resCreen.Text + "8")
            resCreen.Text = values(active)
        End If
    End Sub

    Private Sub num9_Click(sender As Object, e As RoutedEventArgs) Handles num9.Click
        If resCreen.Text.Length <= 10 Then
            values(active) = Double.Parse(resCreen.Text + "9")
            resCreen.Text = values(active)
        End If
    End Sub

    Private Sub numDec_Click(sender As Object, e As RoutedEventArgs) Handles numDec.Click
        If Not resCreen.Text.Contains(".") Then
            resCreen.Text &= "."
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Call Calcul()
    End Sub

    Private Sub optPlus(sender As Object, e As RoutedEventArgs)
        optors = "+"
        values(active) = Double.Parse(resCreen.Text)
        active = If(active = 0, 1, 0)
        resCreen.Text = 0
    End Sub

    Private Sub optMin_Click(sender As Object, e As RoutedEventArgs) Handles optMin.Click
        optors = "-"
        values(active) = Double.Parse(resCreen.Text)
        active = If(active = 0, 1, 0)
        resCreen.Text = 0
    End Sub

    Private Sub optMul_Click(sender As Object, e As RoutedEventArgs) Handles optMul.Click
        optors = "*"
        values(active) = Double.Parse(resCreen.Text)
        active = If(active = 0, 1, 0)
        resCreen.Text = 0
    End Sub

    Private Sub optDiv_Click(sender As Object, e As RoutedEventArgs) Handles optDiv.Click
        optors = "/"
        values(active) = Double.Parse(resCreen.Text)
        active = If(active = 0, 1, 0)
        resCreen.Text = 0
    End Sub
End Class
