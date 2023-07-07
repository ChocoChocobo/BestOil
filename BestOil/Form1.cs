using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> fuelPrices;
        private string selectedFuelType;
        private double fuelPricePerLiter;
        private double overallRevenue = 0.0;

        public Form1()
        {
            InitializeComponent();
            shiftTimer.Start();
            //Цена и топливо
            fuelPrices = new Dictionary<string, double>
            {
            { "АИ-92", 48.72 },
            { "АИ-95", 54.36 },
            { "ДТ", 58.82 }
            };

            foreach (string fuelType in fuelPrices.Keys)
            {
                petrolLitersComboBox.Items.Add(fuelType);
            }

            if (petrolLitersComboBox.Items.Count > 0)
            {
                petrolLitersComboBox.SelectedIndex = 0;
            }

            selectedFuelType = petrolLitersComboBox.SelectedItem.ToString();
            fuelPricePerLiter = fuelPrices[selectedFuelType];
            petrolPriceTextBox.Text = fuelPricePerLiter.ToString();
        }

        //Изменение индекса цены топлива ивент
        private void petrolLitersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFuelType = petrolLitersComboBox.SelectedItem.ToString();
            fuelPricePerLiter = fuelPrices[selectedFuelType];
            petrolPriceTextBox.Text = fuelPricePerLiter.ToString();
            CalculatePrice();
        }

        //Кол-во топлива радио-кнопка логика: необходимое кол-во литров
        private void petrolQuantityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (petrolQuantityRadioButton.Checked)
            {
                petrolLitersTextBox.Enabled = true;
                petrolSumPriceTextBox.Enabled = false;
                CalculatePrice();
            }
        }

        //Цена топлива радио-кнопка логика: цена
        private void petrolPriceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (petrolPriceRadioButton.Checked)
            {
                petrolLitersTextBox.Enabled = false;
                petrolSumPriceTextBox.Enabled = true;
                CalculatePrice();
            }
        }

        //Обработчик изменения значений в текстовых полях бензина
        private void petrolLitersTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void petrolSumPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        //Расчет цены за бенз
        private void CalculatePrice()
        {
            double totalPrice = 0.0;

            if (petrolQuantityRadioButton.Checked)
            {
                label4.Text = "руб.";
                // Расчёт по литрам
                if (double.TryParse(petrolLitersTextBox.Text, out double liters))
                {
                    totalPrice = liters * fuelPricePerLiter;
                }
            }
            else if (petrolPriceRadioButton.Checked)
            {
                label4.Text = "л.";
                // Расчёт по цене
                if (double.TryParse(petrolSumPriceTextBox.Text, out double price))
                {
                    totalPrice = price / fuelPricePerLiter;                   
                }
            }

            gasStationToPayLabel.Text = totalPrice.ToString("0.00");
        }
        //Чек бокс хот догов
        private void hotDogCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (hotDogCheckBox.Checked)
            {
                hotDogQuantityTextBox.Enabled = true;
                hotDogQuantityTextBox.Clear();
            }
            else
            {
                hotDogQuantityTextBox.Enabled = false;
                hotDogQuantityTextBox.Clear();
            }
            CalculateCafePrice();
        }
        //Чек бокс бургеров
        private void burgerCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (burgerCheckBox.Checked)
            {
                burgerQuantityTextBox.Enabled = true;
                burgerQuantityTextBox.Clear();
            }
            else
            {
                burgerQuantityTextBox.Enabled = false;
                burgerQuantityTextBox.Clear();
            }
            CalculateCafePrice();
        }
        //Чек бокс картошки
        private void friesCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (friesCheckBox.Checked)
            {
                friesQuantityTextBox.Enabled = true;
                friesQuantityTextBox.Clear();
            }
            else
            {
                friesQuantityTextBox.Enabled = false;
                friesQuantityTextBox.Clear();
            }
            CalculateCafePrice();
        }
        //Чек бокс кока колы
        private void cokeCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cokeCheckBox.Checked)
            {
                cokeQuantityTextBox.Enabled = true;
                cokeQuantityTextBox.Clear();
            }
            else
            {
                cokeQuantityTextBox.Enabled = false;
                cokeQuantityTextBox.Clear();
            }
            CalculateCafePrice();
        }
        //Рассчёт цены кафе
        private void CalculateCafePrice()
        {
            double totalCafePrice = 0.0;

            if(hotDogCheckBox.Checked)
            {
                if(double.TryParse(hotDogQuantityTextBox.Text, out double hotDogQuantity))
                {
                    double hotDogPrice = Convert.ToDouble(hotDogPriceTextBox.Text);
                    totalCafePrice += hotDogQuantity * hotDogPrice;
                }
            }
            if (burgerCheckBox.Checked)
            {
                if (double.TryParse(burgerQuantityTextBox.Text, out double burgerQuantity))
                {
                    double burgerPrice = Convert.ToDouble(burgerPriceTextBox.Text);
                    totalCafePrice += burgerQuantity * burgerPrice;
                }
            }

            if (friesCheckBox.Checked)
            {
                if (double.TryParse(friesQuantityTextBox.Text, out double friesQuantity))
                {
                    double friesPrice = Convert.ToDouble(friesPriceTextBox.Text);
                    totalCafePrice += friesQuantity * friesPrice;
                }
            }

            if (cokeCheckBox.Checked)
            {
                if (double.TryParse(cokeQuantityTextBox.Text, out double cokeQuantity))
                {
                    double cokePrice = Convert.ToDouble(cokePriceTextBox.Text);
                    totalCafePrice += cokeQuantity * cokePrice;
                }
            }

            cafeToPaylabel.Text = totalCafePrice.ToString("0.00");
        }
        //Изменение общей цены кафе после прописания кол-ва товара
        private void hotDogQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateCafePrice();
        }
        private void burgerQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateCafePrice();
        }
        private void friesQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateCafePrice();
        }
        private void cokeQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateCafePrice();
        }
        //Большая кнопка РАССЧИТАТЬ
        private void toCalculateAllButton_Click(object sender, EventArgs e)
        {
            if(petrolQuantityRadioButton.Checked)
            {
                double totalAmount = double.Parse(gasStationToPayLabel.Text) + double.Parse(cafeToPaylabel.Text);
                toPayAllLabel.Text = totalAmount.ToString("0.00");

                overallRevenue += totalAmount;
            }
            else if(petrolPriceRadioButton.Checked)
            {
                double totalAmount = double.Parse(petrolSumPriceTextBox.Text) + double.Parse(cafeToPaylabel.Text);
                toPayAllLabel.Text = totalAmount.ToString("0.00");

                overallRevenue += totalAmount;
            }
            else
            {
                toPayAllLabel.Text = "0,00";
            }
        }
        //Таймер на смену в 10 сек
        private void shiftTimer_Tick(object sender, EventArgs e)
        {
            shiftTimer.Stop();
            DialogResult result = MessageBox.Show("С клиентом закончили?", "Обработка клиента", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                petrolLitersComboBox.SelectedIndex = 0;
                petrolQuantityRadioButton.Checked = false;
                petrolPriceRadioButton.Checked = false;
                petrolLitersTextBox.Text = "";
                petrolSumPriceTextBox.Text = "";
                hotDogCheckBox.Checked = false;
                burgerCheckBox.Checked = false;
                friesCheckBox.Checked = false;
                cokeCheckBox.Checked = false;
                hotDogQuantityTextBox.Text = "";
                burgerQuantityTextBox.Text = "";
                friesQuantityTextBox.Text = "";
                cokeQuantityTextBox.Text = "";
                shiftTimer.Start();
                MessageBox.Show($"Выручка за клиента составила: {toPayAllLabel.Text}", "Выручка");
            }
            else
            {
                shiftTimer.Start();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //double totalRevenue = double.Parse(toPayAllLabel.Text);
            MessageBox.Show($"Выручка за день: {overallRevenue.ToString("0.00")}", "Выручка");
        }
    }

}
