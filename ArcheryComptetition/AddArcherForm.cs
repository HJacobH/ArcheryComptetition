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
        bool add = false;
        int selectedArcher = 0;

        public AddArcherForm(string nazev, bool add, int index)
        {
            InitializeComponent();
            string[] split = nazev.Split(',');
            this.nazevSouteze = split[0];
            this.add = add;
            this.selectedArcher = index + 1;

            if(!add) 
            { 
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(nazevSouteze + ".xml");

                XmlNode archerNode = xmlDoc.SelectSingleNode("/" + nazevSouteze + $"/Archer[{selectedArcher}]");

                jmenoTextBox.Text = archerNode.SelectSingleNode("Jmeno").InnerText;
                prijmeniTextBox.Text = archerNode.SelectSingleNode("Prijmeni").InnerText;
                vekTextBox.Text = archerNode.SelectSingleNode("Vek").InnerText;
                narodnostTextBox.Text = archerNode.SelectSingleNode("Narodnost").InnerText;
                umisteniTextBox.Text = archerNode.SelectSingleNode("Umisteni").InnerText;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(jmenoTextBox.Text) || string.IsNullOrWhiteSpace(prijmeniTextBox.Text) || string.IsNullOrWhiteSpace(vekTextBox.Text) || string.IsNullOrWhiteSpace(narodnostTextBox.Text) || string.IsNullOrWhiteSpace(umisteniTextBox.Text))
            {
                MessageBox.Show("Please fill in all the textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (add)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(nazevSouteze + ".xml");

                XmlElement archerElemnt = xmlDoc.CreateElement("Archer");
                Archer newArcher = new Archer(jmenoTextBox.Text, prijmeniTextBox.Text, Int32.Parse(vekTextBox.Text), narodnostTextBox.Text, Int32.Parse(umisteniTextBox.Text));
                XmlAttribute attribute = xmlDoc.CreateAttribute("ArcherAtribute");
                attribute.Value = "atribute?";

                XmlNode parent = xmlDoc.SelectSingleNode("//" + nazevSouteze);

                parent.AppendChild(archerElemnt);

                XmlElement nameElement = xmlDoc.CreateElement("Jmeno");
                nameElement.InnerText = jmenoTextBox.Text;
                archerElemnt.AppendChild(nameElement);

                XmlElement prijmeniElement = xmlDoc.CreateElement("Prijmeni");
                prijmeniElement.InnerText = prijmeniTextBox.Text;
                archerElemnt.AppendChild(prijmeniElement);

                XmlElement vekElement = xmlDoc.CreateElement("Vek");
                vekElement.InnerText = vekTextBox.Text;
                archerElemnt.AppendChild(vekElement);

                XmlElement narodnostElement = xmlDoc.CreateElement("Narodnost");
                narodnostElement.InnerText = narodnostTextBox.Text;
                archerElemnt.AppendChild(narodnostElement);

                XmlElement umisteniElement = xmlDoc.CreateElement("Umisteni");
                umisteniElement.InnerText = umisteniTextBox.Text;
                archerElemnt.AppendChild(umisteniElement);

                xmlDoc.Save(nazevSouteze + ".xml");
                CleanTextBoxes();
                MessageBox.Show("Zaznam byl pridan");
            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(nazevSouteze + ".xml");

                XmlNode archerNode = xmlDoc.SelectSingleNode("/" + nazevSouteze + $"/Archer[{selectedArcher}]");

                archerNode.SelectSingleNode("Jmeno").InnerText = jmenoTextBox.Text;
                archerNode.SelectSingleNode("Prijmeni").InnerText = prijmeniTextBox.Text;
                archerNode.SelectSingleNode("Vek").InnerText = vekTextBox.Text;
                archerNode.SelectSingleNode("Narodnost").InnerText = narodnostTextBox.Text;
                archerNode.SelectSingleNode("Umisteni").InnerText = umisteniTextBox.Text;

                xmlDoc.Save(nazevSouteze + ".xml");                
                

                CleanTextBoxes();
                MessageBox.Show("Zaznam byl upraven");
            }
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
