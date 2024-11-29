using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับ", "โปรแกรมทดสอบความอ้วนผอม");
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);

            //if (!double.TryParse(txtHeight.Text, out double height))
            //{
            //    MessageBox.Show("กรอกส่วนสูงเป็นตัวเลข", "Error");
            //    txtHeight.Focus();
            //    txtHeight.SelectAll();
            //    return;
            //}
            //if(!double.TryParse(txtWeight.Text, out double weight))
            //{
            //    MessageBox.Show("กรอกน้ำหนักเป็นตัวเลข", "Error");
            //    txtWeight.Focus();
            //    txtWeight.SelectAll();
            //    return;
            //}
            //double height = Convert.ToDouble(txtHeight.Text);
            //double weight = Convert.ToDouble(txtWeight.Text);

            double height = 0;
            double weight = 0;
            if(CheckDouble(txtWeight, txtHeight))
            {
                height =Convert.ToDouble(txtHeight.Text);
                weight =Convert.ToDouble(txtWeight.Text);
            }

            double bmi = BMI(height, weight);
            //double bmi = weight / Math.Pow(height / 100, 2);
            lblResult.Text = bmi.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            txtName.Focus();
         
            
        }

        private void color(TextBox name,TextBox age)
        {
            if (name.Text.Length != 0) 
            {
                name.ForeColor = Color.DarkGreen;
            }
            else
            {
                name.ForeColor = Color.Red;
            }
            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.DarkRed;
            }
            else
            {
                name.ForeColor = Color.Red;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            color(txtName, txtAge);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            color(txtName, txtAge);
        }
        private double BMI(double h, double w)
        {
            double bmi = w / Math.Pow(h/100, 2);
            return bmi;
        }
        private bool CheckDouble(TextBox txtW, TextBox txtH)
        {
            double x = 0;
            if(double.TryParse(txtW.Text, out x)==false || (double.TryParse(txtH.Text, out x)==false))
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return false;
            }return true;
        }
    }
}
