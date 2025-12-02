using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using РКИС_ЛР1.FolderModels;

namespace РКИС_ЛР1.FolderModels
{
    public partial class UserControlName : UserControl
    {
        public UserControlName()
        {
            InitializeComponent();
        }

        public void Fill (Motorbike motorbike)
        {
            labelIDData.Text = motorbike.ID.ToString();
            labelBrandData.Text = motorbike.Brand;
            labelHorsepowerData.Text = motorbike.Horsepower.ToString();
            labelModelData.Text = motorbike.Model;
            labelPriceData.Text = motorbike.Price.ToString();
            labelMileageData.Text = motorbike.Mileage.ToString();
            pictureBox1.Image = Image.FromFile($@"Pictures\{motorbike.Picture}");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
