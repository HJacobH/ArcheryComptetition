namespace ArcheryComptetition
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            udalostiListBox = new ListBox();
            addBtn = new Button();
            editBtn = new Button();
            rmvBtn = new Button();
            exitBtn = new Button();
            searchTextBox = new TextBox();
            searchBtn = new Button();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // udalostiListBox
            // 
            udalostiListBox.FormattingEnabled = true;
            udalostiListBox.ItemHeight = 15;
            udalostiListBox.Location = new Point(12, 42);
            udalostiListBox.Name = "udalostiListBox";
            udalostiListBox.Size = new Size(695, 394);
            udalostiListBox.TabIndex = 0;
            udalostiListBox.DoubleClick += listBox1_DoubleClick;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(713, 57);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(713, 86);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // rmvBtn
            // 
            rmvBtn.Location = new Point(713, 115);
            rmvBtn.Name = "rmvBtn";
            rmvBtn.Size = new Size(75, 23);
            rmvBtn.TabIndex = 3;
            rmvBtn.Text = "Remove";
            rmvBtn.UseVisualStyleBackColor = true;
            rmvBtn.Click += rmvBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(713, 413);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(534, 23);
            searchTextBox.TabIndex = 5;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(552, 11);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 6;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click_1;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(633, 11);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(74, 23);
            clearBtn.TabIndex = 7;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearBtn);
            Controls.Add(searchBtn);
            Controls.Add(searchTextBox);
            Controls.Add(exitBtn);
            Controls.Add(rmvBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(udalostiListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox udalostiListBox;
        private Button addBtn;
        private Button editBtn;
        private Button rmvBtn;
        private Button exitBtn;
        private TextBox searchTextBox;
        private Button searchBtn;
        private Button clearBtn;
    }
}
