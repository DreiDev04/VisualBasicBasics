Public Class Arnoms_Forms
    'Define Status
    Dim ChickenStatus = 0
    Dim DuckStatus = 0
    Dim TurkeyStatus = 0
    'Define Price
    Dim ChickenPrice = 11
    Dim DuckPrice = 22
    Dim TurkeyPrice = 33

    Private Sub Arnoms_Forms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Define Handlers for Textbox to accept only numbers
        AddHandler Txtb_Chicken.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler TxtB_Duck.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler TxtB_Turkey.KeyPress, AddressOf NumericTextBox_KeyPress

        'Remove focus from all textboxes
        Me.BeginInvoke(Sub() Me.ActiveControl = Nothing)

        'Set the total to 0
        TxtB_Total.Text = FormatCurrency(0)
    End Sub

    Private Sub NumericTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Check if the key pressed is a digit or a control key
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the pressed key is not a digit and not a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub


    Private Sub Btn_ChickenIncrement_Click(sender As Object, e As EventArgs) Handles Btn_ChickenIncrement.Click
        'Increment the chicken status
        ChickenStatus += 1
        Txtb_Chicken.Text = ChickenStatus
    End Sub

    Private Sub Btn_ChickenDecrement_Click(sender As Object, e As EventArgs) Handles Btn_ChickenDecrement.Click
        'Decrement the chicken status
        If ChickenStatus > 0 Then 'If the chicken status is greater than 0, decrement the status
            ChickenStatus -= 1
            Txtb_Chicken.Text = ChickenStatus
        End If
    End Sub

    Private Sub Btn_DuckIncrement_Click(sender As Object, e As EventArgs) Handles Btn_DuckIncrement.Click
        'Increment the duck status
        DuckStatus += 1
        TxtB_Duck.Text = DuckStatus
    End Sub

    Private Sub Btn_DuckDecrement_Click(sender As Object, e As EventArgs) Handles Btn_DuckDecrement.Click
        'Decrement the duck status
        If DuckStatus > 0 Then 'If the duck status is greater than 0, decrement the status
            DuckStatus -= 1
            TxtB_Duck.Text = DuckStatus
        End If
    End Sub

    Private Sub Btn_TurkeyIncrement_Click(sender As Object, e As EventArgs) Handles Btn_TurkeyIncrement.Click
        'Increment the turkey status
        TurkeyStatus += 1
        TxtB_Turkey.Text = TurkeyStatus
    End Sub

    Private Sub Btn_TurkeyDecrement_Click(sender As Object, e As EventArgs) Handles Btn_TurkeyDecrement.Click
        'Decrement the turkey status
        If TurkeyStatus > 0 Then 'If the turkey status is greater than 0, decrement the status
            TurkeyStatus -= 1
            TxtB_Turkey.Text = TurkeyStatus
        End If
    End Sub

    Private Sub Txtb_Chicken_TextChanged(sender As Object, e As EventArgs) Handles Txtb_Chicken.TextChanged
        'Check if the textbox is empty
        If Txtb_Chicken.Text = "" Then 'If the textbox is empty, set the chicken status to 0
            ChickenStatus = 0
            Return
        End If

        ChickenStatus = CInt(Txtb_Chicken.Text) 'Convert the text to an integer and set the chicken status
    End Sub

    Private Sub TxtB_Duck_TextChanged(sender As Object, e As EventArgs) Handles TxtB_Duck.TextChanged
        'Check if the textbox is empty
        If TxtB_Duck.Text = "" Then 'If the textbox is empty, set the duck status to 0
            DuckStatus = 0
            Return
        End If
        DuckStatus = CInt(TxtB_Duck.Text) 'Convert the text to an integer and set the duck status
    End Sub

    Private Sub TxtB_Turkey_TextChanged(sender As Object, e As EventArgs) Handles TxtB_Turkey.TextChanged
        'Check if the textbox is empty
        If TxtB_Turkey.Text = "" Then 'If the textbox is empty, set the turkey status to 0
            TurkeyStatus = 0
            Return
        End If
        TurkeyStatus = CInt(TxtB_Turkey.Text) 'Convert the text to an integer and set the turkey status
    End Sub
    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        'Clear all the textboxes and set the total to 0
        TxtB_Total.Text = FormatCurrency(0)
        Txtb_Chicken.Text = ""
        TxtB_Duck.Text = ""
        TxtB_Turkey.Text = ""
    End Sub
    Private Sub Btn_Calculate_Click(sender As Object, e As EventArgs) Handles Btn_Calculate.Click
        Dim total = CInt(ChickenStatus * ChickenPrice) + CInt(DuckStatus * DuckPrice) + CInt(DuckStatus * TurkeyPrice)

        TxtB_Total.Text = FormatCurrency(total) 'Set the total to the formatted total

    End Sub
End Class
