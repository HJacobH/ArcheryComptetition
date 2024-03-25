using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Xml;
using System.Security.Cryptography.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArcheryComptetition
{
    public partial class AddCompetition : Form
    {
        bool add = false;
        string selectedCompetition = "";

        public AddCompetition(bool add, string selectedCompetition)
        {
            InitializeComponent();

            this.add = add;
            this.selectedCompetition = selectedCompetition;

            if (!add)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(selectedCompetition + ".xml");

                XmlElement root = xmlDoc.DocumentElement;

                foreach (XmlNode node in root.ChildNodes)
                {
                    if (node.Name == "Nazev")
                    {
                        nazevTextBox.Text = node.InnerText;
                    }
                    else if (node.Name == "Lokace")
                    {
                        lokaceTextBox.Text = node.InnerText;
                    }
                    else if (node.Name == "Pocet")
                    {
                        pocetTextBox.Text = node.InnerText;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nazevTextBox.Text) || string.IsNullOrWhiteSpace(lokaceTextBox.Text) || string.IsNullOrWhiteSpace(pocetTextBox.Text))
            {
                MessageBox.Show("Please fill in all the textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (add)
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDoc.AppendChild(xmlDeclaration);

                XmlElement root = xmlDoc.CreateElement(nazevTextBox.Text);
                xmlDoc.AppendChild(root);

                string fileName = nazevTextBox.Text + ".xml";

                XmlElement nazevElement = xmlDoc.CreateElement("Nazev");
                nazevElement.InnerText = nazevTextBox.Text;
                root.AppendChild(nazevElement);

                XmlElement lokaceElement = xmlDoc.CreateElement("Lokace");
                lokaceElement.InnerText = lokaceTextBox.Text;
                root.AppendChild(lokaceElement);

                XmlElement pocetElement = xmlDoc.CreateElement("Pocet");
                pocetElement.InnerText = pocetTextBox.Text;
                root.AppendChild(pocetElement);

                xmlDoc.Save(fileName);

                cleanTextBoxes();
                MessageBox.Show("Zaznam byl pridan");
            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(selectedCompetition + ".xml");

                XmlElement root = xmlDoc.DocumentElement;
                foreach (XmlNode node in root.ChildNodes)
                {
                    if (node.Name == "Nazev")
                    {
                        node.InnerText = nazevTextBox.Text;
                    }
                    else if (node.Name == "Lokace")
                    {
                        node.InnerText = lokaceTextBox.Text;
                    }
                    else if (node.Name == "Pocet")
                    {
                        node.InnerText = pocetTextBox.Text;
                    }
                }
                xmlDoc.Save(nazevTextBox.Text + ".xml");
                File.Delete(Directory.GetCurrentDirectory() + @"\" + selectedCompetition + ".xml");

                cleanTextBoxes();
                MessageBox.Show("Zaznam byl upraven");
            }
        }

        private void cleanTextBoxes()
        {
            nazevTextBox.Text = "";
            lokaceTextBox.Text = "";
            pocetTextBox.Text = "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
