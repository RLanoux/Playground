Public Class Cities

    Private Sub btnAddCity_Click(sender As System.Object, e As System.EventArgs) Handles btnAddCity.Click
        Dim sCity As String = txtCityName.Text
        If Not Form1.cboDepartCity.Items.Contains(sCity) Then
            Form1.cboDepartCity.Items.Add(sCity)
            MessageBox.Show(sCity & " successfully added.", _
                            "Playground", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
        End If

        If Not Form1.cboDestination.Items.Contains(sCity) Then
            Form1.cboDestination.Items.Add(sCity)
        End If
        txtCityName.Clear()
        txtCityName.Focus()

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRemoveCity_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveCity.Click
        Dim sCity As String = txtCityName.Text
        If Form1.cboDepartCity.Items.Contains(sCity) Then
            Form1.cboDepartCity.Items.Remove(sCity)
            MessageBox.Show(sCity & " successfully removed.", _
                            "Playground", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
        End If

        If Form1.cboDestination.Items.Contains(sCity) Then
            Form1.cboDestination.Items.Remove(sCity)
        End If
        txtCityName.Clear()
        txtCityName.Focus()

    End Sub
End Class