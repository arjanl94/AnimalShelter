using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        Reservation reservation = new Reservation();
        Webshop webshop = new Webshop();
        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshListbox()
        {
            lbanimals.Items.Clear();
            foreach (var item in reservation.cats)
            {
                lbanimals.Items.Add(item);
            }
            foreach (var item in reservation.dogs)
            {
                lbanimals.Items.Add(item);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbanimal.Text == "Cat")
            {
                reservation.NewCat(tbname.Text, cmbgender.Text, tbhabits.Text);
            }
            else if (cmbanimal.Text == "Dog")
            {
                reservation.NewDog(tbname.Text, cmbgender.Text);
            }
            RefreshListbox();
        }

        private void cmbanimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbanimal.Text == "Dog")
            {
                label4.Visible = false;
                tbhabits.Visible = false;
            }
            else if (cmbanimal.Text == "Cat")
            {
                label4.Visible = true;
                tbhabits.Visible = true;
            }
        }
    }
}
