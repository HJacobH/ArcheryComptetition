namespace ArcheryComptetition
{
    partial class AddArcherForm
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
            jmenoLabel = new Label();
            prijmeniLabel = new Label();
            vekLabel = new Label();
            narodnostLabel = new Label();
            umisteniLabel = new Label();
            jmenoTextBox = new TextBox();
            prijmeniTextBox = new TextBox();
            vekTextBox = new TextBox();
            narodnostTextBox = new TextBox();
            umisteniTextBox = new TextBox();
            okButton = new Button();
            stornoButton = new Button();
            lukLabel = new Label();
            sipLabel = new Label();
            lukTextBox = new TextBox();
            sipComboBox = new ComboBox();
            SuspendLayout();
            // 
            // jmenoLabel
            // 
            jmenoLabel.AutoSize = true;
            jmenoLabel.Location = new Point(33, 21);
            jmenoLabel.Name = "jmenoLabel";
            jmenoLabel.Size = new Size(45, 15);
            jmenoLabel.TabIndex = 0;
            jmenoLabel.Text = "Jmeno:";
            // 
            // prijmeniLabel
            // 
            prijmeniLabel.AutoSize = true;
            prijmeniLabel.Location = new Point(24, 49);
            prijmeniLabel.Name = "prijmeniLabel";
            prijmeniLabel.Size = new Size(54, 15);
            prijmeniLabel.TabIndex = 1;
            prijmeniLabel.Text = "Prijmeni:";
            // 
            // vekLabel
            // 
            vekLabel.AutoSize = true;
            vekLabel.Location = new Point(50, 79);
            vekLabel.Name = "vekLabel";
            vekLabel.Size = new Size(28, 15);
            vekLabel.TabIndex = 2;
            vekLabel.Text = "Vek:";
            // 
            // narodnostLabel
            // 
            narodnostLabel.AutoSize = true;
            narodnostLabel.Location = new Point(12, 109);
            narodnostLabel.Name = "narodnostLabel";
            narodnostLabel.Size = new Size(66, 15);
            narodnostLabel.TabIndex = 3;
            narodnostLabel.Text = "Narodnost:";
            // 
            // umisteniLabel
            // 
            umisteniLabel.AutoSize = true;
            umisteniLabel.Location = new Point(21, 140);
            umisteniLabel.Name = "umisteniLabel";
            umisteniLabel.Size = new Size(57, 15);
            umisteniLabel.TabIndex = 4;
            umisteniLabel.Text = "Umisteni:";
            // 
            // jmenoTextBox
            // 
            jmenoTextBox.Location = new Point(84, 18);
            jmenoTextBox.Name = "jmenoTextBox";
            jmenoTextBox.Size = new Size(100, 23);
            jmenoTextBox.TabIndex = 5;
            // 
            // prijmeniTextBox
            // 
            prijmeniTextBox.Location = new Point(84, 46);
            prijmeniTextBox.Name = "prijmeniTextBox";
            prijmeniTextBox.Size = new Size(100, 23);
            prijmeniTextBox.TabIndex = 6;
            // 
            // vekTextBox
            // 
            vekTextBox.Location = new Point(84, 76);
            vekTextBox.Name = "vekTextBox";
            vekTextBox.Size = new Size(100, 23);
            vekTextBox.TabIndex = 7;
            // 
            // narodnostTextBox
            // 
            narodnostTextBox.Location = new Point(84, 106);
            narodnostTextBox.Name = "narodnostTextBox";
            narodnostTextBox.Size = new Size(100, 23);
            narodnostTextBox.TabIndex = 8;
            // 
            // umisteniTextBox
            // 
            umisteniTextBox.Location = new Point(84, 137);
            umisteniTextBox.Name = "umisteniTextBox";
            umisteniTextBox.Size = new Size(100, 23);
            umisteniTextBox.TabIndex = 9;
            // 
            // okButton
            // 
            okButton.Location = new Point(12, 236);
            okButton.Name = "okButton";
            okButton.Size = new Size(84, 32);
            okButton.TabIndex = 10;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // stornoButton
            // 
            stornoButton.Location = new Point(118, 236);
            stornoButton.Name = "stornoButton";
            stornoButton.Size = new Size(84, 32);
            stornoButton.TabIndex = 11;
            stornoButton.Text = "Storno";
            stornoButton.UseVisualStyleBackColor = true;
            stornoButton.Click += stornoButton_Click;
            // 
            // lukLabel
            // 
            lukLabel.AutoSize = true;
            lukLabel.Location = new Point(40, 169);
            lukLabel.Name = "lukLabel";
            lukLabel.Size = new Size(29, 15);
            lukLabel.TabIndex = 12;
            lukLabel.Text = "Luk:";
            // 
            // sipLabel
            // 
            sipLabel.AutoSize = true;
            sipLabel.Location = new Point(40, 198);
            sipLabel.Name = "sipLabel";
            sipLabel.Size = new Size(26, 15);
            sipLabel.TabIndex = 13;
            sipLabel.Text = "Sip:";
            // 
            // lukTextBox
            // 
            lukTextBox.Location = new Point(84, 166);
            lukTextBox.Name = "lukTextBox";
            lukTextBox.Size = new Size(100, 23);
            lukTextBox.TabIndex = 14;
            // 
            // sipComboBox
            // 
            sipComboBox.FormattingEnabled = true;
            sipComboBox.Location = new Point(81, 198);
            sipComboBox.Name = "sipComboBox";
            sipComboBox.Size = new Size(103, 23);
            sipComboBox.TabIndex = 15;
            // 
            // AddArcherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 280);
            Controls.Add(sipComboBox);
            Controls.Add(lukTextBox);
            Controls.Add(sipLabel);
            Controls.Add(lukLabel);
            Controls.Add(stornoButton);
            Controls.Add(okButton);
            Controls.Add(umisteniTextBox);
            Controls.Add(narodnostTextBox);
            Controls.Add(vekTextBox);
            Controls.Add(prijmeniTextBox);
            Controls.Add(jmenoTextBox);
            Controls.Add(umisteniLabel);
            Controls.Add(narodnostLabel);
            Controls.Add(vekLabel);
            Controls.Add(prijmeniLabel);
            Controls.Add(jmenoLabel);
            Name = "AddArcherForm";
            Text = "AddArcherForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label jmenoLabel;
        private Label prijmeniLabel;
        private Label vekLabel;
        private Label narodnostLabel;
        private Label umisteniLabel;
        private TextBox jmenoTextBox;
        private TextBox prijmeniTextBox;
        private TextBox vekTextBox;
        private TextBox narodnostTextBox;
        private TextBox umisteniTextBox;
        private Button okButton;
        private Button stornoButton;
        private Label lukLabel;
        private Label sipLabel;
        private TextBox lukTextBox;
        private ComboBox sipComboBox;
    }
}