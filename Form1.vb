Public Class Recipes

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database411DataSet.Recipes' table. You can move, or remove it, as needed.
        Me.RecipesTableAdapter.Fill(Me.Database411DataSet.Recipes)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        RecipesBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        RecipesBindingSource.EndEdit()
        RecipesTableAdapter.Update(Database411DataSet.Recipes)

    End Sub

    Private Sub SearchToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchToolStripButton.Click
        Try
            Me.RecipesTableAdapter.Search(Me.Database411DataSet.Recipes, TitleToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        RecipesTableAdapter.Search(Database411DataSet.Recipes, TextBox1.Text)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        RecipesBindingSource.RemoveCurrent()
        RecipesTableAdapter.Update(Database411DataSet.Recipes)

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        OpenFileDialog1.ShowDialog()
        TextBox8.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        RecipesBindingSource.MovePrevious()

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        RecipesBindingSource.MoveNext()

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        RecipesBindingSource.MoveFirst()

    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        RecipesBindingSource.MoveLast()

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Close()

    End Sub

    Private Sub TextBox8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox8.TextChanged
        If (System.IO.File.Exists(TextBox8.Text)) Then
            PictureBox1.Image = Image.FromFile(TextBox8.Text)
        End If
        If TextBox8.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
    End Sub

    Private Sub SearchToolStripButton1_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.RecipesTableAdapter.Search(Me.Database411DataSet.Recipes, TitleToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TypeSearchToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles TypeSearchToolStripButton.Click
        Try
            Me.RecipesTableAdapter.TypeSearch(Me.Database411DataSet.Recipes, TypeToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
