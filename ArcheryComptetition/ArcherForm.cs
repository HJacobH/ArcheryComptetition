using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheryComptetition
{
    public partial class ArcherForm : Form
    {
        public ArcherForm(string nazev)
        {
            InitializeComponent();
            nazevLabel.Text = nazev;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
