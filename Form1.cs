using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyt_Ayt_Net_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double TD, TY, TN;
            double SD, SY, SN;
            double MD, MY, MN;
            double FD, FY, FN;
            double toplamnet = 0;


            try
            {
                //Turkisch

                TD = double.Parse(txtTD.Text);
                TY = double.Parse(txtTY.Text);
                TN = TD - (TY / 4);
                double türkçetoplam = (TD + TY);

                //Social

                SD = double.Parse(txtSD.Text);
                SY = double.Parse(txtTY.Text);
                SN = SD - (SY / 4);
                double sosyaltoplam = (SD + SY);

                //Math

                MD = double.Parse(txtMD.Text);
                MY = double.Parse(txtMY.Text);
                MN= MD - (MY / 4);
                double mattoplam = (MD + MY);

                // Science

                FD = double.Parse(txtFD.Text);
                FY = double.Parse(txtFY.Text);
                FN = FD - (FY / 4);
                double fentoplam = (FD + FY);


                toplamnet = TN + SN + MN + FN;

                txtTN.Text = TN.ToString();
                txtSN.Text = SN.ToString();
                txtMN.Text = MN.ToString();
                txtFN.Text = FN.ToString();


                if (türkçetoplam > 40)
                {
                    txtTD.Text = "0";
                    txtTY.Text = "0";
                    TN = 0;
                    MessageBox.Show("Lütfen Verilerinizi Doğru Giriniz");
                }


                if (sosyaltoplam > 20)
                {
                    txtSD.Text = "0";
                    txtSY.Text = "0";
                    SN = 0;
                    MessageBox.Show("Lütfen Verilerinizi Doğru Giriniz");
                }

                if (mattoplam > 40)
                {
                    txtMD.Text = "0";
                    txtMY.Text = "0";
                    MN = 0;
                    MessageBox.Show("Lütfen Verilerinizi Doğru Giriniz");
                }


                if (fentoplam > 20)
                {
                    txtFD.Text = "0";
                    txtFY.Text = "0";
                    FN = 0;
                    MessageBox.Show("Lütfen Verilerinizi Doğru Giriniz");
                }

                lblTN.Text = (TN + SN + MN + FN).ToString();

            }
            catch (Exception)
            {
             
            }
           
        }

        private void txtTD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double uzunluk1 = double.Parse(txtTD.Text);
                if (uzunluk1>40)
                {
                    MessageBox.Show("Doğru Değer Giriniz");
                    txtTD.Clear();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtTY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double uzunluk2 = double.Parse(txtTY.Text);
                if (uzunluk2 > 40)
                {
                    MessageBox.Show("Doğru Değer Giriniz");
                    txtTY.Clear();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtSD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double uzunluk3 = double.Parse(txtSD.Text);
                if (uzunluk3 > 20)
                {
                    MessageBox.Show("Doğru Değer Giriniz");
                    txtSD.Clear();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtSY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double uzunluk4 = double.Parse(txtSY.Text);
                if (uzunluk4 > 20)
                {
                    MessageBox.Show("Doğru Değer Giriniz");
                    txtSY.Clear();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtMD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double uzunluk5 = double.Parse(txtMD.Text);
                if (uzunluk5 > 40)
                {
                    MessageBox.Show("Doğru Değer Giriniz");
                    txtMD.Clear();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtMY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double uzunluk6 = double.Parse(txtMY.Text);
                if (uzunluk6 > 40)
                {
                    MessageBox.Show("Doğru Değer Giriniz");
                    txtMY.Clear();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtFD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double uzunluk7 = double.Parse(txtFD.Text);
                if (uzunluk7 > 20)
                {
                    MessageBox.Show("Doğru Değer Giriniz");
                    txtFD.Clear();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtFY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double uzunluk8 = double.Parse(txtFY.Text);
                if (uzunluk8 > 20)
                {
                    MessageBox.Show("Doğru Değer Giriniz");
                    txtFY.Clear();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
