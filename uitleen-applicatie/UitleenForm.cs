using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uitleen_applicatie
{
    public partial class UitleenForm : Form
    {
        public UitleenForm(int id, string opmerking)
        {
            InitializeComponent();

            //tbOpmerking.Text = opmerking;
        }

        private void UitleenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
