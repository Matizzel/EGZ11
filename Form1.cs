using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EGZ11
{
    public partial class Form1 : Form
    {
        private int sum = 0;
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            sum += number;
            count++;

            if (sum >= 100)
            {
                MessageBox.Show($"Сумма: {sum}, кол-во чисел: {count}");
                sum = 0;
                count = 0;
            }
        }
    }
}