namespace CalculatorPractice
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button btn0, btn1, btn2, btn3, btn4;
        private System.Windows.Forms.Button btn5, btn6, btn7, btn8, btn9;
        private System.Windows.Forms.Button btnAdd, btnSubtract, btnMultiply, btnDivide;
        private System.Windows.Forms.Button btnEquals, btnClear, btnDecimal;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem colorSchemeMenu;
        private System.Windows.Forms.ToolStripMenuItem fontSizeMenu;
        private System.Windows.Forms.Button btnSave, btnLoad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSchemeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();

            // displayTextBox
            this.displayTextBox.Font = new System.Drawing.Font("Arial", 16F);
            this.displayTextBox.Location = new System.Drawing.Point(12, 40);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(320, 32);
            this.displayTextBox.TabIndex = 0;
            this.displayTextBox.Text = "0";
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Кнопки цифр (7,8,9)
            this.btn7.Font = new System.Drawing.Font("Arial", 14F);
            this.btn7.Location = new System.Drawing.Point(12, 90);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 50);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn8.Font = new System.Drawing.Font("Arial", 14F);
            this.btn8.Location = new System.Drawing.Point(92, 90);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 50);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn9.Font = new System.Drawing.Font("Arial", 14F);
            this.btn9.Location = new System.Drawing.Point(172, 90);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 50);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumberButton_Click);

            // Кнопки цифр (4,5,6)
            this.btn4.Font = new System.Drawing.Font("Arial", 14F);
            this.btn4.Location = new System.Drawing.Point(12, 150);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 50);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn5.Font = new System.Drawing.Font("Arial", 14F);
            this.btn5.Location = new System.Drawing.Point(92, 150);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 50);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn6.Font = new System.Drawing.Font("Arial", 14F);
            this.btn6.Location = new System.Drawing.Point(172, 150);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 50);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumberButton_Click);

            // Кнопки цифр (1,2,3)
            this.btn1.Font = new System.Drawing.Font("Arial", 14F);
            this.btn1.Location = new System.Drawing.Point(12, 210);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 50);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn2.Font = new System.Drawing.Font("Arial", 14F);
            this.btn2.Location = new System.Drawing.Point(92, 210);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 50);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn3.Font = new System.Drawing.Font("Arial", 14F);
            this.btn3.Location = new System.Drawing.Point(172, 210);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 50);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumberButton_Click);

            // Кнопки 0 и десятичная точка
            this.btn0.Font = new System.Drawing.Font("Arial", 14F);
            this.btn0.Location = new System.Drawing.Point(12, 270);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(150, 50);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumberButton_Click);

            this.btnDecimal.Font = new System.Drawing.Font("Arial", 14F);
            this.btnDecimal.Location = new System.Drawing.Point(172, 270);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(70, 50);
            this.btnDecimal.TabIndex = 11;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);

            // Операционные кнопки
            this.btnDivide.Font = new System.Drawing.Font("Arial", 14F);
            this.btnDivide.Location = new System.Drawing.Point(262, 90);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(70, 50);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OperatorButton_Click);

            this.btnMultiply.Font = new System.Drawing.Font("Arial", 14F);
            this.btnMultiply.Location = new System.Drawing.Point(262, 150);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(70, 50);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.OperatorButton_Click);

            this.btnSubtract.Font = new System.Drawing.Font("Arial", 14F);
            this.btnSubtract.Location = new System.Drawing.Point(262, 210);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(70, 50);
            this.btnSubtract.TabIndex = 14;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.OperatorButton_Click);

            this.btnAdd.Font = new System.Drawing.Font("Arial", 14F);
            this.btnAdd.Location = new System.Drawing.Point(262, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 50);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OperatorButton_Click);

            // Кнопки Equals и Clear
            this.btnEquals.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnEquals.Location = new System.Drawing.Point(172, 330);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(160, 50);
            this.btnEquals.TabIndex = 16;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);

            this.btnClear.Font = new System.Drawing.Font("Arial", 14F);
            this.btnClear.Location = new System.Drawing.Point(12, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Кнопки Save и Load
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSave.Location = new System.Drawing.Point(12, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 35);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnLoad.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLoad.Location = new System.Drawing.Point(172, 390);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(160, 35);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // MenuStrip
            this.settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.colorSchemeMenu,
                this.fontSizeMenu});
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(79, 20);
            this.settingsMenu.Text = "Настройки";

            this.colorSchemeMenu.Name = "colorSchemeMenu";
            this.colorSchemeMenu.Size = new System.Drawing.Size(180, 22);
            this.colorSchemeMenu.Text = "Цветовая схема";
            this.colorSchemeMenu.Click += new System.EventHandler(this.colorSchemeMenu_Click);

            this.fontSizeMenu.Name = "fontSizeMenu";
            this.fontSizeMenu.Size = new System.Drawing.Size(180, 22);
            this.fontSizeMenu.Text = "Размер шрифта";
            this.fontSizeMenu.Click += new System.EventHandler(this.fontSizeMenu_Click);

            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.settingsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(344, 24);
            this.menuStrip.TabIndex = 20;
            this.menuStrip.Text = "menuStrip1";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}