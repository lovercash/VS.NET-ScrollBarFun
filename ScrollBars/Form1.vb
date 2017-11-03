Public Class Form1
    Private Sub HsbRed_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbRed.Scroll, hsbGreen.Scroll, hsbBlue.Scroll
        lblRed.Text = hsbRed.Value
        lblGreen.Text = hsbGreen.Value
        lblBlue.Text = hsbBlue.Value
        picSample.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value)
    End Sub

    Private Sub HsbTextHeight_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbTextHeight.Scroll, hsbTextWidth.Scroll
        lblTextHeight.Text = hsbTextHeight.Value
        lblTextWidth.Text = hsbTextWidth.Value
        lblSampleText.Location = New Point(hsbTextHeight.Value, hsbTextWidth.Value)
    End Sub
End Class
