Public Class ColoredBard
    Inherits ProgressBar

    Dim hexColorPink As String = "#EE3EC9"
    Dim colorFromHexPink As Color = ColorTranslator.FromHtml(hexColorPink)

    Private _progressColor As Color = colorFromHexPink

    Public Property ProgressColor As Color
        Get
            Return _progressColor
        End Get
        Set(value As Color)
            _progressColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim rect As Rectangle = e.ClipRectangle
        rect.Width = CInt(rect.Width * (CDbl(Value) / Maximum)) - 4
        If ProgressBarRenderer.IsSupported Then ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle)
        rect.Height = rect.Height - 4
        Using brush As New SolidBrush(_progressColor)
            e.Graphics.FillRectangle(brush, 2, 2, rect.Width, rect.Height)
        End Using
    End Sub

End Class
