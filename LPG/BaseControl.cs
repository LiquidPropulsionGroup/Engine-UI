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
    public partial class BaseControl : UserControl
    {
        bool open = false;

        public BaseControl()
        {
            InitializeComponent();
            
        }


        private void BaseControl_Load(object sender, EventArgs e)
        {

        }

        private void BaseControl_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("hello world");



            if( open == false)
            {
                currentLbl.Text = "hello people pickers packers. \n hello people pickers packers. " +
                "\n hello people pickers packers.";
                open = true;
            }
            else
            {
                currentLbl.Text = "cur: value";
                open = false;
            }


            

        }
    }
}
