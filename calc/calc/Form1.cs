using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        int somm = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            agg_UI("0");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            agg_UI("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_calcoli.Text = "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_calcoli.Text = "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            lbl_calcoli.Text = "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_calcoli.Text = "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl_calcoli.Text = "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lbl_calcoli.Text = "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl_calcoli.Text = "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lbl_calcoli.Text = "9";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {

        }

        private void btn_less_Click(object sender, EventArgs e)
        {

        }

        private void btn_times_Click(object sender, EventArgs e)
        {

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {

        }

        private void btn_uguale_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void lbl_calcoli_Click(object sender, EventArgs e)
        {

        }

        private void lbl_storico_Click(object sender, EventArgs e)
        {

        }

        private void agg_UI(string num)
        {
            string num1 = "";

            lbl_calcoli.Text = $"{num1}{num}";

            num1 = num;
        }
    }
}
