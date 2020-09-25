Public Class Form1
    Dim N As Integer
    Dim N2 As Integer
    Dim N3 As Integer
    Dim N4 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mode.Text = "Doubles"
    End Sub
    Protected Sub Mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Mode.SelectedIndexChanged
        Title.Text = "Roll " & Mode.SelectedItem
        Roll.Text = "0"
        If Mode.SelectedItem = "Doubles" Then
            X1.Visible = True
            X2.Visible = True
            Chance.Text = "1/6"
        End If
        If Mode.SelectedItem = "Triples" Then
            X1.Visible = False
            X2.Visible = True
            Chance.Text = "1/36"
        End If
        If Mode.SelectedItem = "Quadruples" Then
            X1.Visible = False
            X2.Visible = False
            Chance.Text = "1/216"
        End If
    End Sub
    Private Sub GetNumber()
        N = Math.Ceiling(Rnd() * 6)
        N2 = Math.Ceiling(Rnd() * 6)
        If Mode.SelectedItem = "Triples" Then
            N3 = Math.Ceiling(Rnd() * 6)
        End If
        If Mode.SelectedItem = "Quadruples" Then
            N3 = Math.Ceiling(Rnd() * 6)
            N4 = Math.Ceiling(Rnd() * 6)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RollDice.Click
        Me.RollDice.Enabled = False
        RollDice.Visible = False
        'Dice 1 = Shape#
        'Dice 2 = Shape##
        'Dice 3 = Shape###
        'Dice 4 = Shape####
        Shape0.Visible = False
        Shape1.Visible = False
        Shape2.Visible = False
        Shape3.Visible = False
        Shape4.Visible = False
        Shape5.Visible = False
        Shape6.Visible = False
        Shape7.Visible = False
        Shape8.Visible = False

        Shape00.Visible = False
        Shape11.Visible = False
        Shape22.Visible = False
        Shape33.Visible = False
        Shape44.Visible = False
        Shape55.Visible = False
        Shape66.Visible = False
        Shape77.Visible = False
        Shape88.Visible = False

        Shape000.Visible = False
        Shape111.Visible = False
        Shape222.Visible = False
        Shape333.Visible = False
        Shape444.Visible = False
        Shape555.Visible = False
        Shape666.Visible = False
        Shape777.Visible = False
        Shape888.Visible = False

        Shape0000.Visible = False
        Shape1111.Visible = False
        Shape2222.Visible = False
        Shape3333.Visible = False
        Shape4444.Visible = False
        Shape5555.Visible = False
        Shape6666.Visible = False
        Shape7777.Visible = False
        Shape8888.Visible = False

        Roll.Text = Roll.Text + 1

        Randomize()
        GetNumber()



        ' Dice Sound - Unusable Without Flash Drive 
        My.Computer.Audio.Play("D:\DiceComplete1\Shake And Roll Dice-SoundBible.com-591494296.wav")
        ' Original: System.Threading.Thread.Sleep(1200)
        Back.Width = 150
        Back.Height = 138
        Back2.Width = 150
        Back2.Height = 138
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 150
            Back3.Height = 138
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 150
            Back3.Height = 138
            Back4.Width = 150
            Back4.Height = 138
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 148
        Back.Height = 140
        Back2.Width = 148
        Back2.Height = 140
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 148
            Back3.Height = 140
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 148
            Back3.Height = 140
            Back4.Width = 148
            Back4.Height = 140
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 151
        Back.Height = 138
        Back2.Width = 151
        Back2.Height = 138
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 151
            Back3.Height = 138
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 151
            Back3.Height = 138
            Back4.Width = 151
            Back4.Height = 138
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 149
        Back.Height = 136
        Back2.Width = 149
        Back2.Height = 136
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 149
            Back3.Height = 136
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 149
            Back3.Height = 136
            Back4.Width = 149
            Back4.Height = 136
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 152
        Back.Height = 138
        Back2.Width = 152
        Back2.Height = 138
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 152
            Back3.Height = 138
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 152
            Back3.Height = 138
            Back4.Width = 152
            Back4.Height = 138
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 150
        Back.Height = 139
        Back2.Width = 150
        Back2.Height = 139
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 150
            Back3.Height = 139
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 150
            Back3.Height = 139
            Back4.Width = 150
            Back4.Height = 139
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 150
        Back.Height = 138
        Back2.Width = 150
        Back2.Height = 138
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 150
            Back3.Height = 138
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 150
            Back3.Height = 138
            Back4.Width = 150
            Back4.Height = 138
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 148
        Back.Height = 140
        Back2.Width = 148
        Back2.Height = 136
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 148
            Back3.Height = 136
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 148
            Back3.Height = 136
            Back4.Width = 148
            Back4.Height = 140
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 151
        Back.Height = 138
        Back2.Width = 151
        Back2.Height = 138
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 151
            Back3.Height = 138
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 151
            Back3.Height = 138
            Back4.Width = 151
            Back4.Height = 138
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 149
        Back.Height = 140
        Back2.Width = 146
        Back2.Height = 140
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 146
            Back3.Height = 140
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 146
            Back3.Height = 140
            Back4.Width = 149
            Back4.Height = 140
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 152
        Back.Height = 138
        Back2.Width = 152
        Back2.Height = 136
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 152
            Back3.Height = 136
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 152
            Back3.Height = 136
            Back4.Width = 152
            Back4.Height = 138
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 150
        Back.Height = 139
        Back2.Width = 150
        Back2.Height = 139
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 150
            Back3.Height = 139
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 150
            Back3.Height = 139
            Back4.Width = 150
            Back4.Height = 139
        End If
        System.Threading.Thread.Sleep(100)
        Back.Width = 150
        Back.Height = 138
        Back2.Width = 150
        Back2.Height = 138
        If Mode.SelectedItem = "Triples" Then
            Back3.Width = 150
            Back3.Height = 138
        End If
        If Mode.SelectedItem = "Quadruples" Then
            Back3.Width = 150
            Back3.Height = 138
            Back4.Width = 150
            Back4.Height = 138
        End If



        'Dice 1
        If N = 1 Then
            Shape3.Visible = True
        End If

        If N = 2 Then
            Shape7.Visible = True
            Shape8.Visible = True
        End If

        If N = 3 Then
            Shape1.Visible = True
            Shape3.Visible = True
            Shape5.Visible = True
        End If

        If N = 4 Then
            Shape0.Visible = True
            Shape1.Visible = True
            Shape5.Visible = True
            Shape6.Visible = True
        End If

        If N = 5 Then
            Shape0.Visible = True
            Shape1.Visible = True
            Shape3.Visible = True
            Shape5.Visible = True
            Shape6.Visible = True
        End If

        If N = 6 Then
            Shape0.Visible = True
            Shape1.Visible = True
            Shape2.Visible = True
            Shape4.Visible = True
            Shape5.Visible = True
            Shape6.Visible = True
        End If

        'Dice 2
        If N2 = 1 Then
            Shape33.Visible = True
        End If

        If N2 = 2 Then
            Shape77.Visible = True
            Shape88.Visible = True
        End If

        If N2 = 3 Then
            Shape11.Visible = True
            Shape33.Visible = True
            Shape55.Visible = True
        End If

        If N2 = 4 Then
            Shape00.Visible = True
            Shape11.Visible = True
            Shape55.Visible = True
            Shape66.Visible = True
        End If

        If N2 = 5 Then
            Shape00.Visible = True
            Shape11.Visible = True
            Shape33.Visible = True
            Shape55.Visible = True
            Shape66.Visible = True
        End If

        If N2 = 6 Then
            Shape00.Visible = True
            Shape11.Visible = True
            Shape22.Visible = True
            Shape44.Visible = True
            Shape55.Visible = True
            Shape66.Visible = True
        End If

        'Dice 3
        If Mode.SelectedItem = "Doubles" Then
            Shape333.Visible = True
        End If
        If N3 = 1 Then
            Shape333.Visible = True
        End If

        If N3 = 2 Then
            Shape777.Visible = True
            Shape888.Visible = True
        End If

        If N3 = 3 Then
            Shape111.Visible = True
            Shape333.Visible = True
            Shape555.Visible = True
        End If

        If N3 = 4 Then
            Shape000.Visible = True
            Shape111.Visible = True
            Shape555.Visible = True
            Shape666.Visible = True
        End If

        If N3 = 5 Then
            Shape000.Visible = True
            Shape111.Visible = True
            Shape333.Visible = True
            Shape555.Visible = True
            Shape666.Visible = True
        End If

        If N3 = 6 Then
            Shape000.Visible = True
            Shape111.Visible = True
            Shape222.Visible = True
            Shape444.Visible = True
            Shape555.Visible = True
            Shape666.Visible = True
        End If

        'Dice 4
        If Mode.SelectedItem = "Doubles" Then
            Shape3333.Visible = True
        End If
        If Mode.SelectedItem = "Triples" Then
            Shape3333.Visible = True
        End If
        If N4 = 1 Then
            Shape3333.Visible = True
        End If

        If N4 = 2 Then
            Shape7777.Visible = True
            Shape8888.Visible = True
        End If

        If N4 = 3 Then
            Shape1111.Visible = True
            Shape3333.Visible = True
            Shape5555.Visible = True
        End If

        If N4 = 4 Then
            Shape0000.Visible = True
            Shape1111.Visible = True
            Shape5555.Visible = True
            Shape6666.Visible = True
        End If

        If N4 = 5 Then
            Shape0000.Visible = True
            Shape1111.Visible = True
            Shape3333.Visible = True
            Shape5555.Visible = True
            Shape6666.Visible = True
        End If

        If N4 = 6 Then
            Shape0000.Visible = True
            Shape1111.Visible = True
            Shape2222.Visible = True
            Shape4444.Visible = True
            Shape5555.Visible = True
            Shape6666.Visible = True
        End If

        If Mode.SelectedItem = "Doubles" And N = N2 Then
            MessageBox.Show("You win!", "Congratulations!")
            Roll.Text = 0
        End If
        If Mode.SelectedItem = "Triples" And N = N2 And N = N3 Then
            MessageBox.Show("You win!", "Congratulations!")
            Roll.Text = 0
        End If
        If Mode.SelectedItem = "Quadruples" And N = N2 And N = N3 And N = N4 Then
            MessageBox.Show("You win!", "Congratulations!")
            Roll.Text = 0
        End If
        Me.RollDice.Enabled = True
        RollDice.Visible = True
    End Sub
End Class
