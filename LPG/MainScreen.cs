using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPG
{
    public partial class MainScreen : Form
    {
        string connection = "";

        private ValvesForm valveForm = new ValvesForm();
        


        public MainScreen()
        {
            InitializeComponent();
        }

        private void connectionMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");




        }

        private void valvesMenuItem_Click(object sender, EventArgs e)
        {
            
            //if valve form has never been created then make it
            if ( valveForm == null)
            {
                //MessageBox.Show("hello");
                valveForm = new ValvesForm();
                valveForm.BringToFront();
            }
            else
            {
                //bring to front if valve form not focused
                valveForm.BringToFront();
            }

        }
    }
}
