using System.Data; 
using System.Drawing.Drawing2D; 
using Calculator.Class; 
using System.Runtime.InteropServices; 
using Timer = System.Windows.Forms.Timer; 

//Namespace of the project
namespace Calculator
{
    public partial class Calculator : Form
    {
        // Fields to store values and operations
        Double result = 0; // Current result of the calculation.
        string operations = string.Empty; // Current operation (+, -, x, ÷).
        string fstNum, secNum; // First and second numbers in the calculation.
        bool addValue = false; // Flag to determine if a new value should be added.

        // Import external methods for window manipulation
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constants for window manipulation messages
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public Calculator()
        {
            InitializeComponent(); // Initializes the form and its components.
            this.FormBorderStyle = FormBorderStyle.None; // Removes the form border.
            this.StartPosition = FormStartPosition.CenterScreen; // Centers the form on the screen.
            this.Load += new EventHandler(Calculator_Load); // Attaches Load event handler.

            // Attach MouseDown event handlers for dragging the form
            WinTitle.MouseDown += new MouseEventHandler(Calculator_MouseDown);
            this.MouseDown += new MouseEventHandler(Calculator_MouseDown);
            CalculatorName.MouseDown += new MouseEventHandler(Calculator_MouseDown);
            PictureBox.MouseDown += new MouseEventHandler(Calculator_MouseDown);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // Create rounded corners for the window
            int radius = 20; // Radius of the rounded corners.
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseAllFigures();
            this.Region = new Region(path); // Apply the rounded path to the form’s region.
        }

        private void Calculator_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Check if the left mouse button is pressed
            {
                ReleaseCapture(); // Release the mouse capture from the form.
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0); // Send message to move the form.
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for TextChanged event handling (not used).
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            // Handles number button clicks
            if (TxtDisplay1.Text == "0" || addValue) TxtDisplay1.Text = string.Empty; // Clear display if needed.

            addValue = false; // Reset flag.
            Button btn = (Button)sender; // Get the clicked button.
            if (btn.Text == ".")
            {
                // Handle decimal point
                if (!TxtDisplay1.Text.Contains("."))
                {
                    TxtDisplay1.Text = TxtDisplay1.Text + btn.Text;
                }
            }
            else
            {
                TxtDisplay1.Text = TxtDisplay1.Text + btn.Text; // Append the button text to the display.
            }
        }

        private void BtnOperations(object sender, EventArgs e)
        {
            // Handles operation button clicks
            if (result != 0) BtnEquals.PerformClick(); // Calculate result if an operation was already performed.
            else result = Double.Parse(TxtDisplay1.Text); // Set the result to the current display value.

            Button btn = (Button)sender; // Get the clicked button.
            operations = btn.Text; // Set the operation.
            addValue = true; // Set flag to add new value.

            if (TxtDisplay1.Text != "0")
            {
                TxtDisplay2.Text = fstNum = $"{result} {operations}"; // Update the secondary display.
                TxtDisplay1.Text = string.Empty; // Clear the primary display.
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            // Handles the equals button click
            secNum = TxtDisplay1.Text; // Get the second number.
            TxtDisplay2.Text = $"{TxtDisplay2.Text} {TxtDisplay1.Text} ="; // Update the secondary display.

            if (TxtDisplay1.Text != string.Empty)
            {
                if (TxtDisplay1.Text == "0") TxtDisplay2.Text = string.Empty; // Clear secondary display if zero.
                switch (operations)
                {
                    case "+":
                        TxtDisplay1.Text = (result + Double.Parse(TxtDisplay1.Text)).ToString(); // Perform addition.
                        break;
                    case "-":
                        TxtDisplay1.Text = (result - Double.Parse(TxtDisplay1.Text)).ToString(); // Perform subtraction.
                        break;
                    case "x":
                        TxtDisplay1.Text = (result * Double.Parse(TxtDisplay1.Text)).ToString(); // Perform multiplication.
                        break;
                    case "÷":
                        TxtDisplay1.Text = (result / Double.Parse(TxtDisplay1.Text)).ToString(); // Perform division.
                        break;
                    default:
                        TxtDisplay2.Text = $"{TxtDisplay1.Text}="; // Default case.
                        break;
                }

                result = Double.Parse(TxtDisplay1.Text); // Update result with the new value.
                operations = string.Empty; // Clear the operation.
            }
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            // Handles the backspace button click
            if (TxtDisplay1.Text.Length > 0)
            {
                TxtDisplay1.Text = TxtDisplay1.Text.Remove(TxtDisplay1.Text.Length - 1, 1); // Remove last character.
            }
            if (TxtDisplay1.Text == string.Empty) TxtDisplay1.Text = "0"; // Set to "0" if empty.
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            // Handles the clear button click
            TxtDisplay1.Text = "0"; // Reset primary display.
            TxtDisplay2.Text = string.Empty; // Clear secondary display.
            result = 0; // Reset result.
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            // Handles the clear entry button click
            TxtDisplay1.Text = "0"; // Reset primary display.
        }

        private void BtnMath_Click(object sender, EventArgs e)
        {
            // Handles additional math operations
            Button btn = (Button)sender; // Get the clicked button.
            operations = btn.Text; // Set the operation.
            switch (operations)
            {
                case "√x":
                    TxtDisplay2.Text = $"√({TxtDisplay1.Text})"; // Update secondary display for square root.
                    TxtDisplay1.Text = Convert.ToString(Math.Sqrt(Double.Parse(TxtDisplay1.Text))); // Perform square root.
                    break;
                case "^2":
                    TxtDisplay2.Text = $"({TxtDisplay1.Text})^2"; // Update secondary display for square.
                    TxtDisplay1.Text = Convert.ToString(Convert.ToDouble(TxtDisplay1.Text) * Convert.ToDouble(TxtDisplay1.Text)); // Perform squaring.
                    break;
                case "1/x":
                    TxtDisplay2.Text = $"1/({TxtDisplay1.Text})"; // Update secondary display for reciprocal.
                    TxtDisplay1.Text = Convert.ToString(1.0 / Convert.ToDouble(TxtDisplay1.Text)); // Perform reciprocal.
                    break;
                case "%":
                    TxtDisplay2.Text = $"%({TxtDisplay1.Text})"; // Update secondary display for percentage.
                    TxtDisplay1.Text = Convert.ToString(Convert.ToDouble(TxtDisplay1.Text) / Convert.ToDouble(100)); // Perform percentage calculation.
                    break;
                case "±":
                    TxtDisplay1.Text = Convert.ToString(-1 * Convert.ToDouble(TxtDisplay1.Text)); // Toggle the sign of the number.
                    break;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Handles the close button click
            Application.Exit(); // Exit the application.
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            // Handles the minimize button click
            this.WindowState = FormWindowState.Minimized; // Minimize the form.
        }

        private void BtnNum_Paint(object sender, PaintEventArgs e)
        {
            // Handles custom painting for number buttons
            Button btn = sender as Button; // Get the button.
            if (btn != null)
            {
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                int borderRadius = 20; // Radius for rounded corners.

                // Define rounded rectangle for the button
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90); // Top-left corner
                path.AddArc(new Rectangle(btn.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90); // Top-right corner
                path.AddArc(new Rectangle(btn.Width - borderRadius, btn.Height - borderRadius, borderRadius, borderRadius), 0, 90); // Bottom-right corner
                path.AddArc(new Rectangle(0, btn.Height - borderRadius, borderRadius, borderRadius), 90, 90); // Bottom-left corner
                path.CloseAllFigures();

                btn.Region = new Region(path); // Apply the rounded path to the button’s region.

                // Optional: Draw border
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Smooth edges.
                e.Graphics.DrawPath(Pens.Black, path); // Draw the button border (color and thickness can be changed).
            }
        }

        private void BtnOthers_Paint(object sender, PaintEventArgs e)
        {
            // Handles custom painting for other buttons (similar to BtnNum_Paint)
            Button btn = sender as Button; // Get the button.
            if (btn != null)
            {
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                int borderRadius = 20; // Radius for rounded corners.

                // Define rounded rectangle for the button
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90); // Top-left corner
                path.AddArc(new Rectangle(btn.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90); // Top-right corner
                path.AddArc(new Rectangle(btn.Width - borderRadius, btn.Height - borderRadius, borderRadius, borderRadius), 0, 90); // Bottom-right corner
                path.AddArc(new Rectangle(0, btn.Height - borderRadius, borderRadius, borderRadius), 90, 90); // Bottom-left corner
                path.CloseAllFigures();

                btn.Region = new Region(path); // Apply the rounded path to the button’s region.

                // Optional: Draw border
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Smooth edges.
                e.Graphics.DrawPath(Pens.Black, path); // Draw the button border (color and thickness can be changed).
            }
        }

        private void CalculatorName_Click(object sender, EventArgs e)
        {
            // Placeholder for CalculatorName click event handling (not used).
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Placeholder for PictureBox click event handling (not used).
        }
    }
}
