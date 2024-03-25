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
        public ArcherForm(string nazev)
        {
            InitializeComponent();
            this.nazevSouteze = nazev;
            nazevLabel.Text = nazevSouteze;

            LoadFiles();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            string[] split = nazevSouteze.Split(',');
            AddArcherForm addArcherForm = new AddArcherForm(split[0]);
            addArcherForm.ShowDialog();
            this.Show();

            LoadFiles();
        }

        private void LoadFiles()
        {
            archerListBox.Items.Clear();

            XmlDocument xmlDoc = new XmlDocument();
            string[] split = nazevSouteze.Split(',');
            xmlDoc.Load(split[0] + ".xml");

            XmlElement root = xmlDoc.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "Archer")
                {
                    archerListBox.Items.Add(node.InnerText);
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
                string[] split = archerListBox.SelectedItem.ToString().Split(',');
                archerListBox.Items.Remove(archerListBox.SelectedItem);

                XmlDocument xmlDoc = new XmlDocument();
                string[] splits = nazevSouteze.Split(',');
                xmlDoc.Load(splits[0] + ".xml");

                //needs fixing
                XmlNodeList nodeList = xmlDoc.GetElementsByTagName(archerListBox.SelectedItem.ToString());

                foreach(XmlNode node in nodeList)
                {
                    XmlNode parentNode = node.ParentNode;

                    parentNode.RemoveChild(node);
                }

                xmlDoc.Save(splits[0] + ".xml");
            }
        }
    }
}
