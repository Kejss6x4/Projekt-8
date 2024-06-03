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

namespace Projekt_8
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int maxValue;
        private double result;
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Inicjalizacja suwaka i zdarzeń
            maxValue = random.Next(6, 11);
            trackBar1.Maximum = maxValue;
            trackBar1.Minimum = 1;
            trackBar1.ValueChanged += TrackBar1_ValueChanged;
            textBox2.TextChanged += TextBox2_TextChanged;

            // Inicjalizacja kolumny w kontrolce DataGridView
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Column1",
                HeaderText = "Wartość"
            });
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            label1.Text = "";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double number))
            {
                int trackBarValue = trackBar1.Value;
                if (maxValue % 2 == 0)
                {
                    result = trackBarValue - number;
                    label1.Text = $"{trackBarValue} - {number} = {result}";
                }
                else
                {
                    result = trackBarValue + number;
                    label1.Text = $"{trackBarValue} + {number} = {result}";
                }
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić poprawną liczbę.");
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string operation = (maxValue % 2 == 0) ? "-" : "+";
                string content = $"{trackBar1.Value} {operation} {textBox2.Text} = {result}";
                File.WriteAllText(saveFileDialog.FileName, content);
            }
        }

        private void buttonGeneruj_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            double[] values = new double[10];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.NextDouble() * 10 - 5;
                dataGridView1.Rows.Add(values[i]);
            }
            double average = values.Average();
            MessageBox.Show($"Średnia wartość: {average}");
        }
    }
}
