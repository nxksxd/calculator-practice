using System;
using System.IO;
using System.Windows.Forms;

namespace CalculatorPractice
{
    public partial class Form1 : Form
    {
        // Переменные для хранения операций
        private double currentValue = 0;
        private double previousValue = 0;
        private string currentOperation = "";
        private bool operationPressed = false;
        private bool isDarkMode = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик для цифровых кнопок (0-9)
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (displayTextBox.Text == "0" || operationPressed)
            {
                displayTextBox.Text = button.Text;
                operationPressed = false;
            }
            else
            {
                displayTextBox.Text += button.Text;
            }
        }

        // Обработчик для десятичной точки
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!displayTextBox.Text.Contains("."))
            {
                displayTextBox.Text += ".";
            }
        }

        // Обработчик для операционных кнопок (+, -, ×, ÷)
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            try
            {
                // Если уже была операция, выполняем её
                if (!string.IsNullOrEmpty(currentOperation) && !operationPressed)
                {
                    PerformCalculation();
                }
                else
                {
                    previousValue = double.Parse(displayTextBox.Text);
                }

                currentOperation = button.Text;
                operationPressed = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Некорректный ввод данных", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearCalculator();
            }
        }

        // Обработчик для кнопки "="
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                PerformCalculation();
                currentOperation = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearCalculator();
            }
        }

        // Выполнение вычислений
        private void PerformCalculation()
        {
            try
            {
                currentValue = double.Parse(displayTextBox.Text);
                double result = 0;

                switch (currentOperation)
                {
                    case "+":
                        result = previousValue + currentValue;
                        break;
                    case "-":
                        result = previousValue - currentValue;
                        break;
                    case "×":
                        result = previousValue * currentValue;
                        break;
                    case "÷":
                        // Обработка деления на ноль
                        if (currentValue == 0)
                        {
                            MessageBox.Show("Ошибка: Деление на ноль невозможно!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearCalculator();
                            return;
                        }
                        result = previousValue / currentValue;
                        break;
                    default:
                        return;
                }

                displayTextBox.Text = result.ToString();
                previousValue = result;
                operationPressed = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Некорректный формат числа", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearCalculator();
            }
        }

        // Обработчик для кнопки "C" (очистка)
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCalculator();
        }

        // Очистка калькулятора
        private void ClearCalculator()
        {
            displayTextBox.Text = "0";
            currentValue = 0;
            previousValue = 0;
            currentOperation = "";
            operationPressed = false;
        }

        // Сохранение результата в файл
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "calculator_results.txt";
                string result = displayTextBox.Text;
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"[{timestamp}] Результат: {result}");
                }
                
                MessageBox.Show($"Результат сохранён в файл: {filePath}", "Успешно",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Загрузка последнего результата из файла
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "calculator_results.txt";
                
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл с результатами не найден", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    string lastLine = lines[lines.Length - 1];
                    // Извлекаем число из строки формата "[дата] Результат: число"
                    int colonIndex = lastLine.LastIndexOf(':');
                    if (colonIndex >= 0)
                    {
                        string value = lastLine.Substring(colonIndex + 1).Trim();
                        displayTextBox.Text = value;
                        MessageBox.Show("Последний результат загружен", "Успешно",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Файл с результатами пуст", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Изменение цветовой схемы
        private void colorSchemeMenu_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                // Тёмная тема
                this.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                displayTextBox.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
                displayTextBox.ForeColor = System.Drawing.Color.White;

                foreach (Control control in this.Controls)
                {
                    if (control is Button)
                    {
                        control.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
                        control.ForeColor = System.Drawing.Color.White;
                    }
                }
            }
            else
            {
                // Светлая тема
                this.BackColor = System.Drawing.SystemColors.Control;
                displayTextBox.BackColor = System.Drawing.Color.White;
                displayTextBox.ForeColor = System.Drawing.Color.Black;

                foreach (Control control in this.Controls)
                {
                    if (control is Button)
                    {
                        control.BackColor = System.Drawing.SystemColors.Control;
                        control.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
        }

        // Изменение размера шрифта
        private void fontSizeMenu_Click(object sender, EventArgs e)
        {
            using (var fontDialog = new FontDialog())
            {
                fontDialog.Font = displayTextBox.Font;
                
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    displayTextBox.Font = fontDialog.Font;
                }
            }
        }
    }
}