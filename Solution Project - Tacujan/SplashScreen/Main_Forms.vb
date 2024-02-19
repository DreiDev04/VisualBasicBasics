Public Class Main_Forms
    Private Sub Main_Forms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hexColorYellow As String = "#FFFD47"
        Dim colorFromHexYellow As Color = ColorTranslator.FromHtml(hexColorYellow)
        'Dim hexColorPink As String = "#EE3EC9"
        'Dim colorFromHexPink As Color = ColorTranslator.FromHtml(hexColorPink)
        lbl_Progress.ForeColor = colorFromHexYellow


        tmr_Main.Start()



    End Sub

    Private Sub tmr_Main_Tick(sender As Object, e As EventArgs) Handles tmr_Main.Tick
        ColoredBard1.Increment(1)
        lbl_Progress.Text = ColoredBard1.Value & "%"
        If (ColoredBard1.Value = ColoredBard1.Maximum) Then
            tmr_Main.Stop()
        End If
    End Sub


End Class
