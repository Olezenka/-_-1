using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        public static Model1 DB = new Model1();

        List<Motorbike> motorbikes = DB.Motorbike.ToList();
        int AccNumber = 0;

        private void Loading()
        {
            Fill(motorbikes[AccNumber]);
        }

        private void Loading(bool Incr)
        {
            if (Incr == true && motorbikes.Count > AccNumber + 1)
                AccNumber++;
            else if (Incr == false && 0 < AccNumber)
                AccNumber--;
            else if (Incr == false && 0 == AccNumber)
                AccNumber = motorbikes.Count - 1;
            else if (Incr == true && motorbikes.Count == AccNumber + 1)
                AccNumber = 0;
            else
                return;

            Loading();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Loading(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void UserControlName_Load(object sender, EventArgs e)
        {
            Loading();
        }
    }
}
