Public Class Form1

    Dim intStay As Integer
    Dim decMeds As Decimal
    Dim decSurCharg As Decimal
    Dim decLabFee As Decimal
    Dim decPhysical As Decimal

    Dim decStayCharges As Decimal
    Dim decMiscCharges As Decimal
    Dim decTotalCharges As Decimal
    Const decROOM_CHARGE As Decimal = 350

    Function ValidateInputFields() As Boolean
        If Not Integer.TryParse(txtStay.Text, intStay) Then
            MessageBox.Show("Number of days must be integer")
            Return False
        End If
        If Not Decimal.TryParse(txtMeds.Text, decMeds) Then
            MessageBox.Show("Medication costs must be numeric")
            Return False
        End If
        If Not Decimal.TryParse(txtSurCharg.Text, decSurCharg) Then
            MessageBox.Show("Surgery costs must be numeric")
            Return False
        End If
        If Not Decimal.TryParse(txtLabFee.Text, decLabFee) Then
            MessageBox.Show("Lab Fee must be numeric")
            Return False
        End If
        If Not Decimal.TryParse(txtPhysical.Text, decPhysical) Then
            MessageBox.Show("Physical rehab cost must be numeric")
            Return False
        End If

        Return True
    End Function

    Function CalcStayCharges(ByVal decROOM_CHARGE As Decimal, ByVal intStay As Integer) As Decimal
        decStayCharges = decROOM_CHARGE * intStay
        Return decStayCharges
    End Function
    Function CalcMiscCharges(ByVal decMeds, ByVal decSurCharg, ByVal decLabFee, ByVal decPhysical) As Decimal
        decMiscCharges = decMeds + decSurCharg + decLabFee + decPhysical
        Return decMiscCharges
    End Function
    Function CalcTotalCharges(ByVal decStayCharges, ByVal decMiscCharges)
        decTotalCharges = decStayCharges + decMiscCharges
        Return decTotalCharges
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtStay.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCalcCharges.Click

        intStay = Int(txtStay.Text)
        decMeds = CDec(txtMeds.Text)
        decSurCharg = CDec(txtSurCharg.Text)
        decLabFee = CDec(txtLabFee.Text)
        decPhysical = CDec(txtPhysical.Text)

        If ValidateInputFields() Then
            decStayCharges = CalcStayCharges(decROOM_CHARGE, intStay)
        End If
        If ValidateInputFields() Then
            decMiscCharges = CalcMiscCharges(decMeds, decSurCharg, decLabFee, decPhysical)
        End If
        If ValidateInputFields() Then
            decTotalCharges = CalcTotalCharges(decStayCharges, decMiscCharges)
            'Display Total Costs.
            lblTotal.Text = decTotalCharges.ToString("c")
        End If
    End Sub

    Private Sub txtMeds_TextChanged(sender As Object, e As EventArgs) Handles txtMeds.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtStay.Clear()
        txtMeds.Clear()
        txtSurCharg.Clear()
        txtLabFee.Clear()
        txtPhysical.Clear()
        lblTotal.Text = String.Empty


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtSurCharg_TextChanged(sender As Object, e As EventArgs) Handles txtSurCharg.TextChanged

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub
End Class
