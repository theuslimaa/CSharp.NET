using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator.Class
{
    public class Buttons
    {
        public Button Button { get; private set;} //Propertie to store the created button

        //Class contructor to inicialize the button with its properties
        public Buttons(string text, Point position, Size size, Font font, EventHandler eventClick)
        {
            //Button creation
            Button = new Button();
            Button.Text = text; //Text of the button
            Button.Location = position; //Position of the button
            Button.Size = size; //Size of the button
            Button.Font = font; //Font of the button
            Button.Click += eventClick; //Associates the event of the mouse click
        }
    }
}