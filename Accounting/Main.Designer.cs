namespace Accounting
{
    partial class Main
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
            dataGridViewAccountingBook = new DataGridView();
            buttonAddition = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            button1 = new Button();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            excelファイル出力ToolStripMenuItem = new ToolStripMenuItem();
            設定ToolStripMenuItem = new ToolStripMenuItem();
            閉じるToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccountingBook).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAccountingBook
            // 
            dataGridViewAccountingBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAccountingBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccountingBook.Location = new Point(12, 98);
            dataGridViewAccountingBook.Name = "dataGridViewAccountingBook";
            dataGridViewAccountingBook.Size = new Size(776, 311);
            dataGridViewAccountingBook.TabIndex = 0;
            // 
            // buttonAddition
            // 
            buttonAddition.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddition.Location = new Point(12, 415);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(75, 23);
            buttonAddition.TabIndex = 1;
            buttonAddition.Text = "追加";
            buttonAddition.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEdit.Location = new Point(93, 415);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "編集";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDelete.Location = new Point(258, 415);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "削除";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(93, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "決議書作成";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 27);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "予算差引簿";
            button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excelファイル出力ToolStripMenuItem, 設定ToolStripMenuItem, 閉じるToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(53, 20);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // excelファイル出力ToolStripMenuItem
            // 
            excelファイル出力ToolStripMenuItem.Name = "excelファイル出力ToolStripMenuItem";
            excelファイル出力ToolStripMenuItem.Size = new Size(180, 22);
            excelファイル出力ToolStripMenuItem.Text = "Excelファイル出力";
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new Size(180, 22);
            設定ToolStripMenuItem.Text = "設定";
            設定ToolStripMenuItem.Click += 設定ToolStripMenuItem_Click;
            // 
            // 閉じるToolStripMenuItem
            // 
            閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
            閉じるToolStripMenuItem.Size = new Size(180, 22);
            閉じるToolStripMenuItem.Text = "閉じる";
            閉じるToolStripMenuItem.Click += 閉じるToolStripMenuItem_Click;
            // 
            // button3
            // 
            button3.Location = new Point(374, 56);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "決算書";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(374, 27);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "予算書";
            button4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAddition);
            Controls.Add(dataGridViewAccountingBook);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "会計ソフト";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccountingBook).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAccountingBook;
        private Button buttonAddition;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem excelファイル出力ToolStripMenuItem;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ToolStripMenuItem 閉じるToolStripMenuItem;
        private Button button3;
        private Button button4;
    }
}
