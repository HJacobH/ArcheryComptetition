namespace ArcheryComptetition
{
    partial class ArcherForm
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
            archerListBox = new ListBox();
            nazevLabel = new Label();
            backBtn = new Button();
            addButton = new Button();
            editButton = new Button();
            removeButton = new Button();
            SuspendLayout();
            // 
            // archerListBox
            // 
            archerListBox.FormattingEnabled = true;
            archerListBox.ItemHeight = 15;
            archerListBox.Location = new Point(12, 49);
            archerListBox.Name = "archerListBox";
            archerListBox.Size = new Size(306, 379);
            archerListBox.TabIndex = 0;
            // 
            // nazevLabel
            // 
            nazevLabel.AutoSize = true;
            nazevLabel.Location = new Point(12, 9);
            nazevLabel.Name = "nazevLabel";
            nazevLabel.Size = new Size(38, 15);
            nazevLabel.TabIndex = 1;
            nazevLabel.Text = "label1";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(324, 405);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 2;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(324, 49);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(324, 78);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(324, 107);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 5;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // ArcherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 450);
            Controls.Add(removeButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(backBtn);
            Controls.Add(nazevLabel);
            Controls.Add(archerListBox);
            Name = "ArcherForm";
            Text = "ArcherForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox archerListBox;
        private Label nazevLabel;
        private Button backBtn;
        private Button addButton;
        private Button editButton;
        private Button removeButton;
    }
}