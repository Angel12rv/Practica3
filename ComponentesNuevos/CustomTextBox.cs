using System.Drawing;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
public class CustomTextBox : TextBox
{
    public enum InputType { NumbersOnly, LettersOnly, Both }

    private InputType inputType = InputType.Both;

    public InputType AllowedInputType
    {
        get { return inputType; }
        set { inputType = value; }
    }

    public CustomTextBox()
    {
        this.TextChanged += OnTextChanged;
    }

    private void OnTextChanged(object sender, EventArgs e)
    {
        bool isValid = true;

        foreach (char c in this.Text)
        {
            if (inputType == InputType.NumbersOnly && !char.IsDigit(c))
            {
                isValid = false;
                break;
            }
            else if (inputType == InputType.LettersOnly && !char.IsLetter(c))
            {
                isValid = false;
                break;
            }
        }

        if (!isValid)
        {
            this.BackColor = Color.LightPink; // Cambia el color si el carácter no es válido
        }
        else
        {
            this.BackColor = SystemColors.Window; // Restaura el color original
        }
    }
}