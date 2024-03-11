namespace ArcheryComptetition
{
    partial class AddCompetition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pridatBtn = new Button();
            nazevTextBox = new TextBox();
            lokaceTextBox = new TextBox();
            pocetTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // pridatBtn
            // 
            pridatBtn.Location = new Point(30, 110);
            pridatBtn.Name = "pridatBtn";
            pridatBtn.Size = new Size(75, 23);
            pridatBtn.TabIndex = 0;
            pridatBtn.Text = "Pridat";
            pridatBtn.UseVisualStyleBackColor = true;
            pridatBtn.Click += button1_Click;
            // 
            // nazevTextBox
            // 
            nazevTextBox.Location = new Point(112, 12);
            nazevTextBox.Name = "nazevTextBox";
            nazevTextBox.Size = new Size(100, 23);
            nazevTextBox.TabIndex = 1;
            // 
            // lokaceTextBox
            // 
            lokaceTextBox.Location = new Point(112, 41);
            lokaceTextBox.Name = "lokaceTextBox";
            lokaceTextBox.Size = new Size(100, 23);
            lokaceTextBox.TabIndex = 2;
            // 
            // pocetTextBox
            // 
            pocetTextBox.Location = new Point(112, 70);
            pocetTextBox.Name = "pocetTextBox";
            pocetTextBox.Size = new Size(100, 23);
            pocetTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 15);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Nazev:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 44);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "Lokace:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 6;
            label3.Text = "Pocet ucastniku:";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(137, 110);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Zrusit";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AddCompetition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 168);
            Controls.Add(cancelBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pocetTextBox);
            Controls.Add(lokaceTextBox);
            Controls.Add(nazevTextBox);
            Controls.Add(pridatBtn);
            Name = "AddCompetition";
            Text = "AddCompetition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pridatBtn;
        private TextBox nazevTextBox;
        private TextBox lokaceTextBox;
        private TextBox pocetTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button cancelBtn;
    }
}