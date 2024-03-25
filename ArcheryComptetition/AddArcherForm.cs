using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ArcheryComptetition
{
    public partial class AddArcherForm : Form
    {
        string nazevSouteze = "";
        public AddArcherForm(string nazevSouteze)
        {
            InitializeComponent();
            this.nazevSouteze = nazevSouteze;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(jmenoTextBox.Text) || string.IsNullOrWhiteSpace(prijmeniTextBox.Text) || string.IsNullOrWhiteSpace(vekTextBox.Text) || string.IsNullOrWhiteSpace(narodnostTextBox.Text) || string.IsNullOrWhiteSpace(umisteniTextBox.Text))
            {
                MessageBox.Show("Please fill in all the textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] split = nazevSouteze.Split(',');
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(split[0] + ".xml");

            XmlElement archerElemnt = xmlDoc.CreateElement("Archer");
            Archer newArcher = new Archer(jmenoTextBox.Text, prijmeniTextBox.Text, Int32.Parse(vekTextBox.Text), narodnostTextBox.Text, Int32.Parse(umisteniTextBox.Text));
            XmlAttribute attribute = xmlDoc.CreateAttribute("ArcherAtribute");
            attribute.Value = "atribute?";
            
            XmlNode parent = xmlDoc.SelectSingleNode("//" + split[0]);
            
            archerElemnt.InnerText = newArcher.ToString();
            parent.AppendChild(archerElemnt);

            xmlDoc.Save(nazevSouteze + ".xml");
            CleanTextBoxes();
        }

        private void CleanTextBoxes()
        {
            jmenoTextBox.Text = string.Empty;
            prijmeniTextBox.Text = string.Empty;
            vekTextBox.Text = string.Empty;
            narodnostTextBox.Text = string.Empty;
            umisteniTextBox.Text = string.Empty;
        }

        private void stornoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
