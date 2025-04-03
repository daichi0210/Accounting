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
            buttonSettings = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccountingBook).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAccountingBook
            // 
            dataGridViewAccountingBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAccountingBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccountingBook.Location = new Point(12, 12);
            dataGridViewAccountingBook.Name = "dataGridViewAccountingBook";
            dataGridViewAccountingBook.Size = new Size(776, 397);
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
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSettings.Location = new Point(713, 415);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(75, 23);
            buttonSettings.TabIndex = 1;
            buttonSettings.Text = "設定";
            buttonSettings.UseVisualStyleBackColor = true;
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSettings);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAddition);
            Controls.Add(dataGridViewAccountingBook);
            Name = "Main";
            Text = "会計ソフト";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccountingBook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAccountingBook;
        private Button buttonAddition;
        private Button buttonEdit;
        private Button buttonSettings;
        private Button buttonDelete;
    }
}
