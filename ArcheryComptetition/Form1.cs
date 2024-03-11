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
            //LoadData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCompetition addCompetition = new AddCompetition();
            addCompetition.ShowDialog();
            addCompetition = null;
            this.Show();

            LoadFiles();
            //LoadData();
        }

        private void LoadFiles()
        {
            listBox1.Items.Clear();

            string directoryPath = Directory.GetCurrentDirectory();
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
                        listBox1.Items.Add(zaznam);
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
            if (listBox1.SelectedItem != null)
            {

            }
        }
    }
}
