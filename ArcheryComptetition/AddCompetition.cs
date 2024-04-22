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

                CleanTextBoxes();
                MessageBox.Show("Zaznam byl pridan");
            }
            else
            {
                XmlDocument xmlDocc = new XmlDocument();
                xmlDocc.Load(selectedCompetition + ".xml");

                XmlElement root = xmlDocc.DocumentElement;
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
                if (selectedCompetition == nazevTextBox.Text)
                {
                    xmlDocc.Save(nazevTextBox.Text + ".xml");
                }
                else
                {
                    int numberOfArchers = 0;
                    foreach (XmlNode node in root.ChildNodes)
                    {
                        if (node.Name == "Archer")
                        {
                            numberOfArchers++;
                        }
                    }

                    Archer[] archers = new Archer[numberOfArchers];
                    int i = 0;
                    string jmeno = "", prijmeni = "", narodnost = "", luk = "";
                    int vek = 0, umisteni = 0;
                    ArrowTypes arrow = ArrowTypes.WOOD;
                    foreach (XmlNode node in root.ChildNodes)
                    {
                        if (node.Name == "Archer")
                        {
                            foreach (XmlNode childNode in node.ChildNodes)
                            {
                                if (childNode.Name == "Jmeno")
                                {
                                    jmeno = childNode.InnerText;
                                }
                                if (childNode.Name == "Prijmeni")
                                {
                                    prijmeni = childNode.InnerText;
                                }
                                if (childNode.Name == "Vek")
                                {
                                    vek = int.Parse(childNode.InnerText);
                                }
                                if (childNode.Name == "Narodnost")
                                {
                                    narodnost = childNode.InnerText;
                                }
                                if (childNode.Name == "Umisteni")
                                {
                                    umisteni = int.Parse(childNode.InnerText);
                                }
                                if (childNode.Name == "Luk")
                                {
                                    luk = childNode.InnerText;
                                }
                                if (childNode.Name == "Sip")
                                {
                                    arrow = ArrowTypesInfo.GetEnum(childNode.InnerText.ToUpper());
                                }
                                archers[i] = new Archer(jmeno, prijmeni, vek, narodnost, umisteni, luk, arrow);
                            }
                            i++;
                        }
                    }

                    File.Delete(Directory.GetCurrentDirectory() + @"\" + selectedCompetition + ".xml");

                    XmlDocument xmlD = new XmlDocument();
                    XmlDeclaration xmlDeclaration = xmlD.CreateXmlDeclaration("1.0", "UTF-8", null);
                    xmlD.AppendChild(xmlDeclaration);

                    XmlElement rooot = xmlD.CreateElement(nazevTextBox.Text);
                    xmlD.AppendChild(rooot);

                    string fileName = nazevTextBox.Text + ".xml";

                    XmlElement nazevElement = xmlD.CreateElement("Nazev");
                    nazevElement.InnerText = nazevTextBox.Text;
                    rooot.AppendChild(nazevElement);

                    XmlElement lokaceElement = xmlD.CreateElement("Lokace");
                    lokaceElement.InnerText = lokaceTextBox.Text;
                    rooot.AppendChild(lokaceElement);

                    XmlElement pocetElement = xmlD.CreateElement("Pocet");
                    pocetElement.InnerText = pocetTextBox.Text;
                    rooot.AppendChild(pocetElement);                                       


                    for (int j = 0; j < archers.Length; j++)
                    {
                        XmlElement archerElemnt = xmlD.CreateElement("Archer");
                        XmlNode parent = xmlD.SelectSingleNode("//" + nazevTextBox.Text);

                        parent.AppendChild(archerElemnt);

                        XmlElement nameElement = xmlD.CreateElement("Jmeno");
                        nameElement.InnerText = archers[j].jmeno;
                        archerElemnt.AppendChild(nameElement);

                        XmlElement prijmeniElement = xmlD.CreateElement("Prijmeni");
                        prijmeniElement.InnerText = archers[j].prijmeni;
                        archerElemnt.AppendChild(prijmeniElement);

                        XmlElement vekElement = xmlD.CreateElement("Vek");
                        vekElement.InnerText = archers[j].vek.ToString();
                        archerElemnt.AppendChild(vekElement);

                        XmlElement narodnostElement = xmlD.CreateElement("Narodnost");
                        narodnostElement.InnerText = archers[j].narodnost;
                        archerElemnt.AppendChild(narodnostElement);

                        XmlElement umisteniElement = xmlD.CreateElement("Umisteni");
                        umisteniElement.InnerText = archers[j].umisteni.ToString();
                        archerElemnt.AppendChild(umisteniElement);

                        XmlElement lukElement = xmlD.CreateElement("Luk");
                        lukElement.InnerText = archers[j].luk;
                        archerElemnt.AppendChild(lukElement);

                        XmlElement sipElement = xmlD.CreateElement("Sip");
                        sipElement.InnerText = archers[j].sip.ToString();
                        archerElemnt.AppendChild(sipElement);
                    }

                    xmlD.Save(fileName);
                }

                CleanTextBoxes();
                MessageBox.Show("Zaznam byl upraven");
            }
        }

        private void CleanTextBoxes()
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
