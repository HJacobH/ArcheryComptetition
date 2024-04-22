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
        int maxPocetUcastniku = 0;
        int aktualniPocetUcastniku = 0;

        public AddArcherForm(string nazev, bool add, int index, int maxPocetUcastniku, int aktualniPocetUcastniku)
        {
            InitializeComponent();
            string[] split = nazev.Split(',');
            this.nazevSouteze = split[0];
            this.add = add;
            this.selectedArcher = index + 1;
            this.maxPocetUcastniku = maxPocetUcastniku;
            this.aktualniPocetUcastniku = aktualniPocetUcastniku;

            foreach (var item in Enum.GetValues(typeof(ArrowTypes)))
            {
                sipComboBox.Items.Add(item);
            }

            if(aktualniPocetUcastniku >= maxPocetUcastniku && add)
            {
                MessageBox.Show("Kapacita ucastniku byla naplnena");
                return;
            }

            if (!add) 
            { 
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(nazevSouteze + ".xml");

                XmlNode archerNode = xmlDoc.SelectSingleNode("/" + nazevSouteze + $"/Archer[{selectedArcher}]");

                jmenoTextBox.Text = archerNode.SelectSingleNode("Jmeno").InnerText;
                prijmeniTextBox.Text = archerNode.SelectSingleNode("Prijmeni").InnerText;
                vekTextBox.Text = archerNode.SelectSingleNode("Vek").InnerText;
                narodnostTextBox.Text = archerNode.SelectSingleNode("Narodnost").InnerText;
                umisteniTextBox.Text = archerNode.SelectSingleNode("Umisteni").InnerText;
                lukTextBox.Text = archerNode.SelectSingleNode("Luk").InnerText;
                sipComboBox.SelectedItem = ArrowTypesInfo.GetEnum(archerNode.SelectSingleNode("Sip").InnerText.ToUpper());
            }
            else
            {
                sipComboBox.SelectedItem = ArrowTypes.WOOD;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(jmenoTextBox.Text) || string.IsNullOrWhiteSpace(prijmeniTextBox.Text) || string.IsNullOrWhiteSpace(vekTextBox.Text) || string.IsNullOrWhiteSpace(narodnostTextBox.Text) || string.IsNullOrWhiteSpace(umisteniTextBox.Text) || string.IsNullOrWhiteSpace(lukTextBox.Text))
            {
                MessageBox.Show("Vyplnte vsechny textboxy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (add)
            {
                if (aktualniPocetUcastniku >= maxPocetUcastniku)
                {
                    MessageBox.Show("Kapacita ucastniku byla naplnena");
                    return;
                }

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(nazevSouteze + ".xml");

                XmlElement archerElemnt = xmlDoc.CreateElement("Archer");
                Archer newArcher = new Archer(jmenoTextBox.Text, prijmeniTextBox.Text, Int32.Parse(vekTextBox.Text), narodnostTextBox.Text, Int32.Parse(umisteniTextBox.Text), lukTextBox.Text, ArrowTypesInfo.GetEnum(sipComboBox.SelectedItem.ToString()));
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

                XmlElement lukElement = xmlDoc.CreateElement("Luk");
                lukElement.InnerText = lukTextBox.Text;
                archerElemnt.AppendChild(lukElement);

                XmlElement sipElement = xmlDoc.CreateElement("Sip");
                sipElement.InnerText = sipComboBox.SelectedItem.ToString();
                archerElemnt.AppendChild(sipElement);

                xmlDoc.Save(nazevSouteze + ".xml");
                ClearTextBoxes();
                MessageBox.Show("Zaznam byl pridan");
                aktualniPocetUcastniku++;
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
                archerNode.SelectSingleNode("Luk").InnerText = lukTextBox.Text;
                archerNode.SelectSingleNode("Sip").InnerText = sipComboBox.SelectedItem.ToString();

                xmlDoc.Save(nazevSouteze + ".xml");                
                

                ClearTextBoxes();
                MessageBox.Show("Zaznam byl upraven");
            }
        }

        private void ClearTextBoxes()
        {
            jmenoTextBox.Clear();
            prijmeniTextBox.Clear();
            vekTextBox.Clear();
            narodnostTextBox.Clear();
            umisteniTextBox.Clear();
            lukTextBox.Clear();
        }

        private void stornoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
