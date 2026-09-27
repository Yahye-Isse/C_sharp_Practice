## Displaying a Message Using `MessageBox`

In this example, a button click event is used to display a simple message to the user.

When the user clicks **Button 2**, the `button2_Click` event runs and shows a message box containing:

**Welcome C#**

### Code

```csharp
private void button2_Click(object sender, EventArgs e)
{
    // Display the first C# code using Message Box
    MessageBox.Show("Welcome C#");
}

## Displaying Text in a Label

In this example, a button click event is used to display text inside a Label control.

When the user clicks the **Show Answer** button, the `showAnswerButton_Click` event runs and changes the text of the label to:

**Jamhuriya University**

### Code

```csharp
private void showAnswerButton_Click(object sender, EventArgs e)
{
    answerLabel.Text = "Jamhuriya University";
}


## Hiding a PictureBox When It Is Clicked

In this example, a `PictureBox` click event is used to hide an image from the Windows Form.

When the user clicks the `studentpicturebox`, the `studentpicturebox_Click` event runs and changes the `Visible` property to `false`.

As a result, the PictureBox disappears from the form.

### Code

```csharp
private void studentpicturebox_Click(object sender, EventArgs e)
{
    studentpicturebox.Visible = false;
}