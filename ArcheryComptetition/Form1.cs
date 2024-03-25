using System;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArcheryComptetition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFiles();
        }

        string directoryPath = Directory.GetCurrentDirectory();

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCompetition addCompetition = new AddCompetition(true, "");
            addCompetition.ShowDialog();
            this.Show();

            LoadFiles();
        }

        private void LoadFiles()
        {
            udalostiListBox.Items.Clear();

            string[] files = Directory.GetFiles(directoryPath, "*.xml");

            foreach (string filePath in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                fileName += ".xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fileName);

                XmlElement root = xmlDoc.DocumentElement;

                string zaznam = "";

                foreach (XmlNode node in root.ChildNodes)
                {
                    if (node.Name == "Nazev")
                    {
                        zaznam = node.InnerText;
                    }
                    else if (node.Name == "Lokace")
                    {
                        zaznam += ", " + node.InnerText;
                    }
                    else if (node.Name == "Pocet")
                    {
                        zaznam += ", " + node.InnerText;
                        udalostiListBox.Items.Add(zaznam);
                    }
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (udalostiListBox.SelectedItem != null)
            {
                this.Hide();
                ArcherForm archerForm = new ArcherForm(udalostiListBox.SelectedItem.ToString());
                archerForm.ShowDialog();
                this.Show();
            }
        }

        private void rmvBtn_Click(object sender, EventArgs e)
        {
            if (udalostiListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                string[] split = udalostiListBox.SelectedItem.ToString().Split(',');
                udalostiListBox.Items.Remove(udalostiListBox.SelectedItem);
                File.Delete(directoryPath + @"\" + split[0] + ".xml");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (udalostiListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                string[] split = udalostiListBox.SelectedItem.ToString().Split(',');
                this.Hide();
                AddCompetition addCompetition = new AddCompetition(false, split[0]);
                addCompetition.ShowDialog();
                this.Show();

                LoadFiles();
            }
        }
    }
}
