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
        public BaseControl()
        {
            InitializeComponent();
        }

        private void BaseControl_Load(object sender, EventArgs e)
        {

        }

        private void BaseControl_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("hello world");
        }
    }
}
