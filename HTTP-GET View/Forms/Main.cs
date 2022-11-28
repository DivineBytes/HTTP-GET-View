using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HTTP_GET_View.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void UC_Request_RequestResponseChanged(object sender, EventArgs.RequestResponseArgs eventArgs)
        {
            TB_View.Text = eventArgs.Response;
        }
    }
}
