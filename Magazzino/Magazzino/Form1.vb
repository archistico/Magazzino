Public Class Form1

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        TextBox1.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Se lunghezza del testo pari a quello del codice AIC
        If TextBox1.Text.Length = 9 Then
            'Cerca farmaco
            If TextBox1.Text = "025038098" Then
                Label1.Text = "Sanipirina 500 mg compresse"
                TextBox2.Focus()
            ElseIf TextBox1.Text = "034420012" Then
                Label1.Text = "Lattulosio Ratiopharm  - 100 ml sciroppo"
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label1.Text IsNot "" Then
            DGV.Rows.Add(New String() {Label1.Text, TextBox2.Text, Nothing, NumericUpDown1.Value})
            MessageBox.Show("Scaricato")
            Label1.Text = ""
            TextBox1.Text = ""
            NumericUpDown1.Value = 1
            TextBox2.Text = ""
            TextBox1.Focus()
        Else
            MessageBox.Show("Nessun farmaco con questo codice")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label1.Text IsNot "" Then
            DGV.Rows.Add(New String() {Label1.Text, TextBox2.Text, NumericUpDown1.Value, Nothing})
            MessageBox.Show("Caricato")
            Label1.Text = ""
            TextBox1.Text = ""
            NumericUpDown1.Value = 1
            TextBox2.Text = ""
            TextBox1.Focus()
        Else
            MessageBox.Show("Nessun farmaco con questo codice")
        End If
    End Sub


    Private Sub HandleEnterAsTab(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim CurrentControl As Control = CType(sender, Control)
            'Me.SelectNextControl(CurrentControl, True, True, True, True)
            e.SuppressKeyPress = True

        End If
    End Sub
End Class
