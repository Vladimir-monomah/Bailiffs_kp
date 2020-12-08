using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приставы.Формы
{
    public partial class Калькулятор_задолженности : Form
    {
        public Калькулятор_задолженности()
        {
            this.InitializeComponent();
        }

        private void Калькулятор_задолженности_Load(object sender, EventArgs e)
        {
            this.pricePeriodCombo.SelectedIndex = 0;
        }

        private void Калькулятор_задолженности_Shown(object sender, EventArgs e)
        {
            this.pricePrice.Focus();
        }

        private void pricePrice_Enter(object sender, EventArgs e)
        {
            this.pricePrice.Select(0, this.pricePrice.Text.Length);
        }

        private void pricePeriod_Enter(object sender, EventArgs e)
        {
            this.pricePeriod.Select(0, this.pricePeriod.Text.Length);
        }

        private void priceProcent_Enter(object sender, EventArgs e)
        {
            this.priceProcent.Select(0, this.priceProcent.Text.Length);
        }

        private void PaymentScheduleAnnuitet(double SumCredit, double InterestRateMonth, int CreditPeriod) // Метод расчета Аннуитетного платежа
        {

            double Payment = SumCredit * (InterestRateMonth / (1 - Math.Pow(1 + InterestRateMonth, -CreditPeriod))); // Ежемесячный платеж
            double ItogCreditSum = Payment * CreditPeriod; // Итоговая сумма алиментов

            this.itogPayment.Text = Payment.ToString("N2"); // Выводим в результаты ежемесячный платёж
            this.itogSum.Text = (ItogCreditSum).ToString("N2"); // Выводим в результаты итоговую сумму алиментов

            // Заполняем график платежей
            double SumCreditOperation = SumCredit;
            double ItogCreditSumOperation = ItogCreditSum;
            double ItogPlus = 0;
            for (int i = 0; i < CreditPeriod; ++i)
            {
                this.dgvGrafik.Rows.Add();
                this.dgvGrafik[0, i].Value = i + 1; //номер месяца
                this.dgvGrafik[1, i].Value = Payment.ToString("N2"); //Ежемесячный платеж
                ItogCreditSumOperation -= Payment;
                ItogPlus = Convert.ToDouble(this.dgvGrafik[4, i].Value);
            }
            this.itogSum.Text = (ItogCreditSum - SumCredit + ItogPlus).ToString("N2");
        }

        private void PaymentScheduleDiffer(double SumCredit, double InterestRateMonth, int CreditPeriod) // Метод расчета Дифференцированного платежа
        {
            double MainPayment = SumCredit / CreditPeriod; // платеж по основному долгу
                                                           // Заполняем график платежей
            double ItogCreditSum = 0;
            double OverPaymentSum = 0;
            for (int i = 0; i < CreditPeriod; ++i)
            {
                double procentPart = SumCredit * InterestRateMonth; //подсчет процентной части ежемесячного платежа
                SumCredit -= MainPayment; //подсчет остатка основного долга (с каждым месяцем уменьшается)
                this.dgvGrafik.Rows.Add(); //добавляем строку в таблицу
                this.dgvGrafik[0, i].Value = i + 1; //номер месяца
                this.dgvGrafik[1, i].Value = (MainPayment + procentPart).ToString("N2"); //полный ежемесячный платеж
                this.dgvGrafik[2, i].Value = MainPayment.ToString("N2"); //платеж по основному долгу
                this.dgvGrafik[3, i].Value = procentPart.ToString("N2"); //процентная часть ежемесячного платежа
                this.dgvGrafik[4, i].Value = SumCredit.ToString("N2"); //Остаток по основному долгу
            }
            for (int i = 0; i < CreditPeriod; ++i) //Подсчет итоговой стоимости и переплаты по алиментам
            {
                ItogCreditSum += Convert.ToDouble(this.dgvGrafik[1, i].Value);
                OverPaymentSum += Convert.ToDouble(this.dgvGrafik[3, i].Value);
            }
            double ItogPlus = Convert.ToDouble(this.dgvGrafik[4, this.dgvGrafik.RowCount - 1].Value);
            this.itogSum.Text = ItogCreditSum.ToString("N2");
            this.itogPayment.Text = Convert.ToString(this.dgvGrafik[1, 0].Value) + "..." + Convert.ToString(this.dgvGrafik[1, this.dgvGrafik.RowCount - 1].Value);
        }

        private void butPriceGo_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(this.priceProcent.Value) > Convert.ToInt32(this.pricePrice.Value)))
            {
                MessageBox.Show("Сумма алиментов не может быть отрицательной или равной нулю.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.dgvGrafik.Rows.Clear(); // Очищаем таблицу
                try
                {
                    var itogPaymentValue = (this.pricePrice.Value * this.priceProcent.Value) / 100;
                    this.itogPayment.Text = itogPaymentValue.ToString();

                    var monthCount = 0m;
                    if (this.pricePeriodCombo.SelectedItem.ToString() == "лет")
                    {
                        monthCount = this.pricePeriod.Value * 12;
                    }
                    else if (this.pricePeriodCombo.SelectedItem.ToString() == "мес.")
                    {
                        monthCount = this.pricePeriod.Value;
                    }

                    var totalPayment = monthCount * itogPaymentValue;
                    this.itogSum.Text = totalPayment.ToString();
                    for (int i = 0; i < monthCount; i++)
                    {
                        totalPayment -= itogPaymentValue;
                        this.dgvGrafik.Rows.Add(
                            i + 1,
                            this.itogPayment.Text,
                            totalPayment);
                    }

                    this.butSaveAsCSV.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Входные данные имели не верный формат! Проверте правильность ввода", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.itogSum.Clear();
                    this.itogPayment.Clear();
                }
            }
        }

        private void ClearFunc() // Метод очистки расчетов
        {
            this.pricePrice.Value = this.pricePrice.Minimum;
            this.pricePeriod.Value = this.pricePeriod.Minimum;
            this.pricePeriodCombo.SelectedIndex = 0;
            this.itogSum.Clear();
            this.itogPayment.Clear();
            this.dgvGrafik.Rows.Clear();
            this.butSaveAsCSV.Enabled = false;
        }

        private void butPriceClear_Click(object sender, EventArgs e)
        {
            this.ClearFunc();
        }

        private void butSumClear_Click(object sender, EventArgs e)
        {
            this.ClearFunc();
        }

        private void butSaveAsCSV_Click(object sender, EventArgs e)
        {
            var saveTableAsCSV = new SaveFileDialog();
            saveTableAsCSV.Filter = "Документ CSV (*.csv) |*.csv";
            saveTableAsCSV.Title = "Сохранить результат расчетов";
            if (saveTableAsCSV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var file = new FileStream(saveTableAsCSV.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(file, Encoding.Default);
                    sw.Write("Итоговая стоимость алиментов:" + ";" + this.itogSum.Text);
                    sw.WriteLine();
                    sw.Write("Ежемесячный платеж:" + ";" + this.itogPayment.Text);
                    sw.WriteLine();
                    sw.Write("Месяц:" + ";" + "Сумма платежа" + ";" + "Остаток основного долга" + ";");
                    sw.WriteLine();
                    for (int i = 0; i < this.dgvGrafik.RowCount; i++)
                    {
                        for (int j = 0; j < this.dgvGrafik.ColumnCount; j++)
                        {
                            sw.Write(Convert.ToDouble(this.dgvGrafik.Rows[i].Cells[j].Value));
                            if (j < this.dgvGrafik.ColumnCount - 1)
                                sw.Write(";");
                        }
                        sw.WriteLine();
                    }
                    sw.Close();
                }
                catch
                {
                    MessageBox.Show("Перезаписываемый файл уже используется другой программой." +
                        "\nЗакройте его и повторите попытку, либо сохраните как новый файл.",
                        "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
