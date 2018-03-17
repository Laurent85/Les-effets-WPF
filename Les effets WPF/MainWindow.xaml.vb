Class MainWindow 

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Dim newwindow As New Effets_1
        newwindow.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button2.Click
        Dim newwindow As New Effets_3
        newwindow.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button3.Click
        Dim newwindow As New Effets_2
        newwindow.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button5.Click
        Dim newwindow As New Effets_4
        newwindow.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button4.Click
        Dim newwindow As New Effets_5
        newwindow.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button7.Click
        Dim newwindow As New Styles
        newwindow.Show()
    End Sub
End Class
