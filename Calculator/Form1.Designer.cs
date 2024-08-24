using Calculator.Class;
using System.Data;
using System.Drawing.Drawing2D;

namespace Calculator;

partial class Calculator
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
        WinTitle = new Panel();
        PanelForText = new Panel();
        PictureBox = new PictureBox();
        CalculatorName = new Label();
        BtnMin = new Button();
        BtnClose = new Button();
        TxtDisplay2 = new TextBox();
        TxtDisplay1 = new TextBox();
        BtnPercentage = new Button();
        BtnCE = new Button();
        BtnC = new Button();
        BtnBackspace = new Button();
        BtnUp2 = new Button();
        BtnSqrt = new Button();
        Btn9 = new Button();
        Btn8 = new Button();
        Btn6 = new Button();
        BtnPoint = new Button();
        BtnMinus = new Button();
        Btn3 = new Button();
        BtnPlus = new Button();
        BtnEquals = new Button();
        Btn5 = new Button();
        Btn2 = new Button();
        Btn0 = new Button();
        BtnMultiply = new Button();
        BtnPM = new Button();
        Btn4 = new Button();
        Btn7 = new Button();
        Btn1X = new Button();
        Btn1 = new Button();
        BtnDivision = new Button();
        WinTitle.SuspendLayout();
        PanelForText.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
        SuspendLayout();
        // 
        // WinTitle
        // 
        WinTitle.BackColor = Color.FromArgb(76, 85, 106);
        WinTitle.BorderStyle = BorderStyle.FixedSingle;
        WinTitle.Controls.Add(PanelForText);
        WinTitle.Controls.Add(BtnMin);
        WinTitle.Controls.Add(BtnClose);
        WinTitle.Location = new Point(0, 1);
        WinTitle.Margin = new Padding(0);
        WinTitle.Name = "WinTitle";
        WinTitle.Size = new Size(350, 40);
        WinTitle.TabIndex = 0;
        // 
        // PanelForText
        // 
        PanelForText.Controls.Add(PictureBox);
        PanelForText.Controls.Add(CalculatorName);
        PanelForText.Location = new Point(0, 0);
        PanelForText.Name = "PanelForText";
        PanelForText.Size = new Size(126, 38);
        PanelForText.TabIndex = 26;
        // 
        // PictureBox
        // 
        PictureBox.BackgroundImage = (Image)resources.GetObject("PictureBox.BackgroundImage");
        PictureBox.BackgroundImageLayout = ImageLayout.Center;
        PictureBox.Location = new Point(0, 2);
        PictureBox.Name = "PictureBox";
        PictureBox.Size = new Size(34, 36);
        PictureBox.TabIndex = 1;
        PictureBox.TabStop = false;
        PictureBox.Click += PictureBox_Click;
        // 
        // CalculatorName
        // 
        CalculatorName.AutoSize = true;
        CalculatorName.BackColor = Color.FromArgb(76, 85, 106);
        CalculatorName.FlatStyle = FlatStyle.Flat;
        CalculatorName.Font = new Font("Impact", 14F);
        CalculatorName.ForeColor = SystemColors.Info;
        CalculatorName.Location = new Point(33, 8);
        CalculatorName.Name = "CalculatorName";
        CalculatorName.Size = new Size(93, 23);
        CalculatorName.TabIndex = 0;
        CalculatorName.Text = "Calculator";
        CalculatorName.Click += CalculatorName_Click;
        // 
        // BtnMin
        // 
        BtnMin.BackColor = Color.FromArgb(76, 85, 106);
        BtnMin.Dock = DockStyle.Right;
        BtnMin.FlatStyle = FlatStyle.Flat;
        BtnMin.ForeColor = Color.FromArgb(76, 85, 106);
        BtnMin.Image = (Image)resources.GetObject("BtnMin.Image");
        BtnMin.Location = new Point(264, 0);
        BtnMin.Margin = new Padding(0);
        BtnMin.Name = "BtnMin";
        BtnMin.Size = new Size(43, 38);
        BtnMin.TabIndex = 0;
        BtnMin.UseVisualStyleBackColor = false;
        BtnMin.Click += BtnMin_Click;
        // 
        // BtnClose
        // 
        BtnClose.BackColor = Color.FromArgb(76, 85, 106);
        BtnClose.Dock = DockStyle.Right;
        BtnClose.FlatAppearance.BorderSize = 0;
        BtnClose.FlatAppearance.MouseOverBackColor = Color.Red;
        BtnClose.FlatStyle = FlatStyle.Flat;
        BtnClose.ForeColor = Color.Black;
        BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
        BtnClose.Location = new Point(307, 0);
        BtnClose.Margin = new Padding(0);
        BtnClose.Name = "BtnClose";
        BtnClose.Size = new Size(41, 38);
        BtnClose.TabIndex = 0;
        BtnClose.UseVisualStyleBackColor = false;
        BtnClose.Click += BtnClose_Click;
        // 
        // TxtDisplay2
        // 
        TxtDisplay2.AllowDrop = true;
        TxtDisplay2.BackColor = Color.FromArgb(32, 32, 32);
        TxtDisplay2.BorderStyle = BorderStyle.None;
        TxtDisplay2.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        TxtDisplay2.ForeColor = SystemColors.MenuBar;
        TxtDisplay2.Location = new Point(0, 44);
        TxtDisplay2.Margin = new Padding(0);
        TxtDisplay2.Multiline = true;
        TxtDisplay2.Name = "TxtDisplay2";
        TxtDisplay2.Size = new Size(350, 25);
        TxtDisplay2.TabIndex = 1;
        TxtDisplay2.Text = "0";
        TxtDisplay2.TextAlign = HorizontalAlignment.Right;
        TxtDisplay2.TextChanged += textBox1_TextChanged;
        // 
        // TxtDisplay1
        // 
        TxtDisplay1.AllowDrop = true;
        TxtDisplay1.BackColor = Color.FromArgb(32, 32, 32);
        TxtDisplay1.BorderStyle = BorderStyle.None;
        TxtDisplay1.Font = new Font("Gadugi", 30F, FontStyle.Bold);
        TxtDisplay1.ForeColor = SystemColors.MenuBar;
        TxtDisplay1.Location = new Point(0, 67);
        TxtDisplay1.Margin = new Padding(0);
        TxtDisplay1.Multiline = true;
        TxtDisplay1.Name = "TxtDisplay1";
        TxtDisplay1.Size = new Size(350, 50);
        TxtDisplay1.TabIndex = 2;
        TxtDisplay1.Text = "0";
        TxtDisplay1.TextAlign = HorizontalAlignment.Right;
        // 
        // BtnPercentage
        // 
        BtnPercentage.BackColor = Color.FromArgb(75, 91, 130);
        BtnPercentage.FlatStyle = FlatStyle.Flat;
        BtnPercentage.ForeColor = SystemColors.InfoText;
        BtnPercentage.Location = new Point(4, 127);
        BtnPercentage.Name = "BtnPercentage";
        BtnPercentage.Size = new Size(80, 55);
        BtnPercentage.TabIndex = 3;
        BtnPercentage.Text = "%";
        BtnPercentage.UseVisualStyleBackColor = false;
        BtnPercentage.Click += BtnMath_Click;
        BtnPercentage.Paint += BtnOthers_Paint;
        // 
        // BtnCE
        // 
        BtnCE.BackColor = Color.FromArgb(75, 91, 130);
        BtnCE.FlatStyle = FlatStyle.Flat;
        BtnCE.ForeColor = SystemColors.InfoText;
        BtnCE.Location = new Point(91, 127);
        BtnCE.Name = "BtnCE";
        BtnCE.Size = new Size(80, 55);
        BtnCE.TabIndex = 4;
        BtnCE.Text = "CE";
        BtnCE.UseVisualStyleBackColor = false;
        BtnCE.Click += BtnCE_Click;
        BtnCE.Paint += BtnOthers_Paint;
        // 
        // BtnC
        // 
        BtnC.BackColor = Color.FromArgb(75, 91, 130);
        BtnC.FlatStyle = FlatStyle.Flat;
        BtnC.ForeColor = SystemColors.InfoText;
        BtnC.Location = new Point(179, 126);
        BtnC.Name = "BtnC";
        BtnC.Size = new Size(80, 55);
        BtnC.TabIndex = 5;
        BtnC.Text = "C";
        BtnC.UseVisualStyleBackColor = false;
        BtnC.Click += BtnC_Click;
        BtnC.Paint += BtnOthers_Paint;
        // 
        // BtnBackspace
        // 
        BtnBackspace.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BtnBackspace.BackColor = Color.FromArgb(75, 91, 130);
        BtnBackspace.BackgroundImage = (Image)resources.GetObject("BtnBackspace.BackgroundImage");
        BtnBackspace.BackgroundImageLayout = ImageLayout.Center;
        BtnBackspace.FlatStyle = FlatStyle.Flat;
        BtnBackspace.ForeColor = SystemColors.InfoText;
        BtnBackspace.Location = new Point(265, 127);
        BtnBackspace.Margin = new Padding(0);
        BtnBackspace.Name = "BtnBackspace";
        BtnBackspace.Size = new Size(80, 55);
        BtnBackspace.TabIndex = 0;
        BtnBackspace.UseVisualStyleBackColor = false;
        BtnBackspace.Click += BtnBackSpace_Click;
        BtnBackspace.Paint += BtnOthers_Paint;
        // 
        // BtnUp2
        // 
        BtnUp2.BackColor = Color.FromArgb(75, 91, 130);
        BtnUp2.FlatStyle = FlatStyle.Flat;
        BtnUp2.ForeColor = SystemColors.InfoText;
        BtnUp2.Location = new Point(91, 184);
        BtnUp2.Name = "BtnUp2";
        BtnUp2.Size = new Size(80, 55);
        BtnUp2.TabIndex = 6;
        BtnUp2.Text = "^2";
        BtnUp2.UseVisualStyleBackColor = false;
        BtnUp2.Click += BtnMath_Click;
        BtnUp2.Paint += BtnOthers_Paint;
        // 
        // BtnSqrt
        // 
        BtnSqrt.BackColor = Color.FromArgb(75, 91, 130);
        BtnSqrt.FlatStyle = FlatStyle.Flat;
        BtnSqrt.ForeColor = SystemColors.InfoText;
        BtnSqrt.Location = new Point(179, 183);
        BtnSqrt.Name = "BtnSqrt";
        BtnSqrt.Size = new Size(80, 55);
        BtnSqrt.TabIndex = 7;
        BtnSqrt.Text = "√x";
        BtnSqrt.UseVisualStyleBackColor = false;
        BtnSqrt.Click += BtnMath_Click;
        BtnSqrt.Paint += BtnOthers_Paint;
        // 
        // Btn9
        // 
        Btn9.BackColor = Color.FromArgb(76, 85, 106);
        Btn9.FlatStyle = FlatStyle.Flat;
        Btn9.ForeColor = SystemColors.InfoText;
        Btn9.Location = new Point(179, 240);
        Btn9.Name = "Btn9";
        Btn9.Size = new Size(80, 55);
        Btn9.TabIndex = 8;
        Btn9.Text = "9";
        Btn9.UseVisualStyleBackColor = false;
        Btn9.Click += BtnNum_Click;
        Btn9.Paint += BtnNum_Paint;
        // 
        // Btn8
        // 
        Btn8.BackColor = Color.FromArgb(76, 85, 106);
        Btn8.FlatStyle = FlatStyle.Flat;
        Btn8.ForeColor = SystemColors.InfoText;
        Btn8.Location = new Point(91, 241);
        Btn8.Name = "Btn8";
        Btn8.Size = new Size(80, 55);
        Btn8.TabIndex = 9;
        Btn8.Text = "8";
        Btn8.UseVisualStyleBackColor = false;
        Btn8.Click += BtnNum_Click;
        Btn8.Paint += BtnNum_Paint;
        // 
        // Btn6
        // 
        Btn6.BackColor = Color.FromArgb(76, 85, 106);
        Btn6.FlatStyle = FlatStyle.Flat;
        Btn6.ForeColor = SystemColors.InfoText;
        Btn6.Location = new Point(179, 297);
        Btn6.Name = "Btn6";
        Btn6.Size = new Size(80, 55);
        Btn6.TabIndex = 10;
        Btn6.Text = "6";
        Btn6.UseVisualStyleBackColor = false;
        Btn6.Click += BtnNum_Click;
        Btn6.Paint += BtnNum_Paint;
        // 
        // BtnPoint
        // 
        BtnPoint.BackColor = Color.FromArgb(76, 85, 106);
        BtnPoint.FlatStyle = FlatStyle.Flat;
        BtnPoint.ForeColor = SystemColors.InfoText;
        BtnPoint.Location = new Point(179, 411);
        BtnPoint.Name = "BtnPoint";
        BtnPoint.Size = new Size(80, 55);
        BtnPoint.TabIndex = 11;
        BtnPoint.Text = ".";
        BtnPoint.UseVisualStyleBackColor = false;
        BtnPoint.Click += BtnNum_Click;
        BtnPoint.Paint += BtnNum_Paint;
        // 
        // BtnMinus
        // 
        BtnMinus.BackColor = Color.FromArgb(75, 91, 130);
        BtnMinus.FlatStyle = FlatStyle.Flat;
        BtnMinus.ForeColor = SystemColors.InfoText;
        BtnMinus.Location = new Point(265, 298);
        BtnMinus.Name = "BtnMinus";
        BtnMinus.Size = new Size(80, 55);
        BtnMinus.TabIndex = 12;
        BtnMinus.Text = "-";
        BtnMinus.UseVisualStyleBackColor = false;
        BtnMinus.Click += BtnOperations;
        BtnMinus.Paint += BtnOthers_Paint;
        // 
        // Btn3
        // 
        Btn3.BackColor = Color.FromArgb(76, 85, 106);
        Btn3.FlatStyle = FlatStyle.Flat;
        Btn3.ForeColor = SystemColors.InfoText;
        Btn3.Location = new Point(179, 355);
        Btn3.Name = "Btn3";
        Btn3.Size = new Size(80, 55);
        Btn3.TabIndex = 13;
        Btn3.Text = "3";
        Btn3.UseVisualStyleBackColor = false;
        Btn3.Click += BtnNum_Click;
        Btn3.Paint += BtnNum_Paint;
        // 
        // BtnPlus
        // 
        BtnPlus.BackColor = Color.FromArgb(75, 91, 130);
        BtnPlus.FlatStyle = FlatStyle.Flat;
        BtnPlus.ForeColor = SystemColors.InfoText;
        BtnPlus.Location = new Point(265, 355);
        BtnPlus.Name = "BtnPlus";
        BtnPlus.Size = new Size(80, 55);
        BtnPlus.TabIndex = 14;
        BtnPlus.Text = "+";
        BtnPlus.UseVisualStyleBackColor = false;
        BtnPlus.Click += BtnOperations;
        BtnPlus.Paint += BtnOthers_Paint;
        // 
        // BtnEquals
        // 
        BtnEquals.BackColor = Color.FromArgb(11, 74, 223);
        BtnEquals.FlatStyle = FlatStyle.Flat;
        BtnEquals.ForeColor = SystemColors.InfoText;
        BtnEquals.Location = new Point(265, 412);
        BtnEquals.Name = "BtnEquals";
        BtnEquals.Size = new Size(80, 55);
        BtnEquals.TabIndex = 15;
        BtnEquals.Text = "=";
        BtnEquals.UseVisualStyleBackColor = false;
        BtnEquals.Click += BtnEquals_Click;
        BtnEquals.Paint += BtnOthers_Paint;
        // 
        // Btn5
        // 
        Btn5.BackColor = Color.FromArgb(76, 85, 106);
        Btn5.FlatStyle = FlatStyle.Flat;
        Btn5.ForeColor = SystemColors.InfoText;
        Btn5.Location = new Point(91, 298);
        Btn5.Name = "Btn5";
        Btn5.Size = new Size(80, 55);
        Btn5.TabIndex = 16;
        Btn5.Text = "5";
        Btn5.UseVisualStyleBackColor = false;
        Btn5.Click += BtnNum_Click;
        Btn5.Paint += BtnNum_Paint;
        // 
        // Btn2
        // 
        Btn2.BackColor = Color.FromArgb(76, 85, 106);
        Btn2.FlatStyle = FlatStyle.Flat;
        Btn2.ForeColor = SystemColors.InfoText;
        Btn2.Location = new Point(91, 355);
        Btn2.Name = "Btn2";
        Btn2.Size = new Size(80, 55);
        Btn2.TabIndex = 17;
        Btn2.Text = "2";
        Btn2.UseVisualStyleBackColor = false;
        Btn2.Click += BtnNum_Click;
        Btn2.Paint += BtnNum_Paint;
        // 
        // Btn0
        // 
        Btn0.BackColor = Color.FromArgb(76, 85, 106);
        Btn0.FlatStyle = FlatStyle.Flat;
        Btn0.ForeColor = SystemColors.InfoText;
        Btn0.Location = new Point(91, 412);
        Btn0.Name = "Btn0";
        Btn0.Size = new Size(80, 55);
        Btn0.TabIndex = 18;
        Btn0.Text = "0";
        Btn0.UseVisualStyleBackColor = false;
        Btn0.Click += BtnNum_Click;
        Btn0.Paint += BtnNum_Paint;
        // 
        // BtnMultiply
        // 
        BtnMultiply.BackColor = Color.FromArgb(75, 91, 130);
        BtnMultiply.FlatStyle = FlatStyle.Flat;
        BtnMultiply.ForeColor = SystemColors.InfoText;
        BtnMultiply.Location = new Point(265, 241);
        BtnMultiply.Name = "BtnMultiply";
        BtnMultiply.Size = new Size(80, 55);
        BtnMultiply.TabIndex = 19;
        BtnMultiply.Text = "x";
        BtnMultiply.UseVisualStyleBackColor = false;
        BtnMultiply.Click += BtnOperations;
        BtnMultiply.Paint += BtnOthers_Paint;
        // 
        // BtnPM
        // 
        BtnPM.BackColor = Color.FromArgb(75, 91, 130);
        BtnPM.FlatStyle = FlatStyle.Flat;
        BtnPM.ForeColor = SystemColors.InfoText;
        BtnPM.Location = new Point(5, 412);
        BtnPM.Name = "BtnPM";
        BtnPM.Size = new Size(80, 55);
        BtnPM.TabIndex = 20;
        BtnPM.Text = "±";
        BtnPM.UseVisualStyleBackColor = false;
        BtnPM.Click += BtnMath_Click;
        BtnPM.Paint += BtnOthers_Paint;
        // 
        // Btn4
        // 
        Btn4.BackColor = Color.FromArgb(76, 85, 106);
        Btn4.FlatStyle = FlatStyle.Flat;
        Btn4.ForeColor = SystemColors.InfoText;
        Btn4.Location = new Point(4, 298);
        Btn4.Name = "Btn4";
        Btn4.Size = new Size(80, 55);
        Btn4.TabIndex = 21;
        Btn4.Text = "4";
        Btn4.UseVisualStyleBackColor = false;
        Btn4.Click += BtnNum_Click;
        Btn4.Paint += BtnNum_Paint;
        // 
        // Btn7
        // 
        Btn7.BackColor = Color.FromArgb(76, 85, 106);
        Btn7.FlatStyle = FlatStyle.Flat;
        Btn7.ForeColor = SystemColors.InfoText;
        Btn7.Location = new Point(4, 241);
        Btn7.Name = "Btn7";
        Btn7.Size = new Size(80, 55);
        Btn7.TabIndex = 22;
        Btn7.Text = "7";
        Btn7.UseVisualStyleBackColor = false;
        Btn7.Click += BtnNum_Click;
        Btn7.Paint += BtnNum_Paint;
        // 
        // Btn1X
        // 
        Btn1X.BackColor = Color.FromArgb(75, 91, 130);
        Btn1X.FlatStyle = FlatStyle.Flat;
        Btn1X.ForeColor = SystemColors.InfoText;
        Btn1X.Location = new Point(4, 184);
        Btn1X.Name = "Btn1X";
        Btn1X.Size = new Size(80, 55);
        Btn1X.TabIndex = 23;
        Btn1X.Text = "1/x";
        Btn1X.UseVisualStyleBackColor = false;
        Btn1X.Click += BtnMath_Click;
        Btn1X.Paint += BtnOthers_Paint;
        // 
        // Btn1
        // 
        Btn1.BackColor = Color.FromArgb(76, 85, 106);
        Btn1.FlatStyle = FlatStyle.Flat;
        Btn1.ForeColor = SystemColors.InfoText;
        Btn1.Location = new Point(5, 355);
        Btn1.Name = "Btn1";
        Btn1.Size = new Size(80, 55);
        Btn1.TabIndex = 24;
        Btn1.Text = "1";
        Btn1.UseVisualStyleBackColor = false;
        Btn1.Click += BtnNum_Click;
        Btn1.Paint += BtnNum_Paint;
        // 
        // BtnDivision
        // 
        BtnDivision.BackColor = Color.FromArgb(75, 91, 130);
        BtnDivision.FlatStyle = FlatStyle.Flat;
        BtnDivision.ForeColor = SystemColors.InfoText;
        BtnDivision.Location = new Point(265, 184);
        BtnDivision.Name = "BtnDivision";
        BtnDivision.Size = new Size(80, 55);
        BtnDivision.TabIndex = 25;
        BtnDivision.Text = "÷";
        BtnDivision.UseVisualStyleBackColor = false;
        BtnDivision.Click += BtnOperations;
        BtnDivision.Paint += BtnOthers_Paint;
        // 
        // Calculator
        // 
        BackColor = Color.FromArgb(32, 32, 32);
        ClientSize = new Size(350, 481);
        Controls.Add(BtnDivision);
        Controls.Add(Btn1);
        Controls.Add(Btn1X);
        Controls.Add(Btn7);
        Controls.Add(Btn4);
        Controls.Add(BtnPM);
        Controls.Add(BtnMultiply);
        Controls.Add(Btn0);
        Controls.Add(Btn2);
        Controls.Add(Btn5);
        Controls.Add(BtnEquals);
        Controls.Add(BtnPlus);
        Controls.Add(Btn3);
        Controls.Add(BtnMinus);
        Controls.Add(BtnPoint);
        Controls.Add(Btn6);
        Controls.Add(Btn8);
        Controls.Add(Btn9);
        Controls.Add(BtnSqrt);
        Controls.Add(BtnUp2);
        Controls.Add(BtnBackspace);
        Controls.Add(BtnC);
        Controls.Add(BtnCE);
        Controls.Add(BtnPercentage);
        Controls.Add(TxtDisplay1);
        Controls.Add(TxtDisplay2);
        Controls.Add(WinTitle);
        Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ForeColor = Color.FromArgb(46, 52, 65);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Calculator";
        StartPosition = FormStartPosition.CenterScreen;
        Load += Calculator_Load;
        WinTitle.ResumeLayout(false);
        PanelForText.ResumeLayout(false);
        PanelForText.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion

    private Panel WinTitle;
    private Button BtnClose;
    private Button BtnMin;
    private TextBox TxtDisplay2;
    private TextBox TxtDisplay1;
    private Button BtnPercentage;
    private Button BtnCE;
    private Button BtnC;
    private Button BtnBackspace;
    private Button BtnUp2;
    private Button BtnSqrt;
    private Button Btn9;
    private Button Btn8;
    private Button Btn6;
    private Button BtnPoint;
    private Button BtnMinus;
    private Button Btn3;
    private Button BtnPlus;
    private Button BtnEquals;
    private Button Btn5;
    private Button Btn2;
    private Button Btn0;
    private Button BtnMultiply;
    private Button BtnPM;
    private Button Btn4;
    private Button Btn7;
    private Button Btn1X;
    private Button Btn1;
    private Button BtnDivision;
    private Panel PanelForText;
    private Label CalculatorName;
    private PictureBox PictureBox;
}
