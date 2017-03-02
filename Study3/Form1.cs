using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study3
{
    public partial class Form1 : Form
    {
        int id = 111;
        int counter = 1;
        PropertyManager manager = new PropertyManager();
        public Form1()
        {          
          
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string suburb = txtSuburb.Text;
            int bedrooms = int.Parse(txtBedrooms.Text);
            double rent = double.Parse(txtRent.Text);
            MyProperty prop = new MyProperty((counter*id), suburb, bedrooms, rent);
            if (manager.AddProperty(prop))
            {
                MessageBox.Show("A New property was added");
                counter++;
                

            }else
            {
                MessageBox.Show("No Property was added!");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int search = int.Parse(txtPropertyNumber.Text);
            string suburb = txtSuburb.Text;
            int bedrooms = int.Parse(txtBedrooms.Text);
            double rent = double.Parse(txtRent.Text);
            MyProperty prop = new MyProperty(search, suburb, bedrooms, rent);
            if (manager.UpdateProperty(prop))
            {
               
                MessageBox.Show("Your property was succesfully Updated");
            }else
            {
                MessageBox.Show("No property matched the id");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int search = int.Parse(txtPropertyNumber.Text);
            if(manager.DeleteProperty(search))
            {
                MessageBox.Show("Your property was deleted");
            }else
            {
                MessageBox.Show("No property matched the id");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(manager.DisplayAll());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The total is :" + manager.Total());
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Average is :" + manager.Average());
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            MyProperty prop = manager.Max();
            MessageBox.Show("The Max property value is :" + prop.PrintInfo());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            MyProperty prop = manager.Min();
            MessageBox.Show("The Min property value is :" + prop.PrintInfo());
        }
    }
}
