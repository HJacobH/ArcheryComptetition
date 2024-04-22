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
    public partial class ArcherForm : Form
    {
        string nazevSouteze = "";
        string plnyNazev = "";
        int pocetUcastniku = 0;
        int aktualniPocetUcastniku = 0;

        public ArcherForm(string nazev)
        {
            InitializeComponent();
            this.plnyNazev = nazev;
            string[] split = nazev.Split(',');
            this.nazevSouteze = split[0];
            nazevLabel.Text = plnyNazev;
            this.pocetUcastniku = int.Parse(split[2]);

            LoadFiles();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (aktualniPocetUcastniku >= pocetUcastniku)
            {
                MessageBox.Show("Kapacita ucastniku byla naplnena");
                return;
            }
            else
            {
                this.Hide();
                AddArcherForm addArcherForm = new AddArcherForm(nazevSouteze, true, 0, pocetUcastniku, aktualniPocetUcastniku);
                addArcherForm.ShowDialog();
                this.Show();

                LoadFiles();
            }            
        }

        private void LoadFiles()
        {
            archerListBox.Items.Clear();

            aktualniPocetUcastniku = 0;

            XmlDocument xmlDoc = new XmlDocument();
            if (xmlDoc != null)
            {
                xmlDoc.Load(nazevSouteze + ".xml");
            }

            XmlElement root = xmlDoc.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "Archer")
                {
                    StringBuilder archerInfo = new StringBuilder();

                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        archerInfo.Append($"{childNode.Name}: {childNode.InnerText} | ");
                    }

                    string formattedArcherInfo = archerInfo.ToString().TrimEnd('|', ' ');

                    archerListBox.Items.Add(formattedArcherInfo);

                    aktualniPocetUcastniku++;
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (archerListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(nazevSouteze + ".xml");

                XmlNode nodeToDelete = xmlDoc.SelectSingleNode("/" + nazevSouteze + $"/Archer[{archerListBox.SelectedIndex + 1}]");

                if (nodeToDelete != null)
                {
                    nodeToDelete.ParentNode.RemoveChild(nodeToDelete);

                    xmlDoc.Save(nazevSouteze + ".xml");
                    aktualniPocetUcastniku--;

                    MessageBox.Show("Zaznam odstranen");
                    LoadFiles();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (archerListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                this.Hide();
                AddArcherForm editArcher = new AddArcherForm(nazevSouteze, false, archerListBox.SelectedIndex, pocetUcastniku, aktualniPocetUcastniku);
                editArcher.ShowDialog();
                this.Show();

                LoadFiles();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.ToLower();

            archerListBox.Items.Clear();

            XmlDocument xmlDoc = new XmlDocument();
            if (xmlDoc != null)
            {
                xmlDoc.Load(nazevSouteze + ".xml");
            }

            XmlElement root = xmlDoc.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "Archer" && node.InnerText.ToLower().Contains(searchTerm))
                {
                    StringBuilder archerInfo = new StringBuilder();

                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        archerInfo.Append($"{childNode.Name}: {childNode.InnerText} | ");
                    }

                    string formattedArcherInfo = archerInfo.ToString().TrimEnd('|', ' ');

                    archerListBox.Items.Add(formattedArcherInfo);
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            LoadFiles();
        }
    }
}
