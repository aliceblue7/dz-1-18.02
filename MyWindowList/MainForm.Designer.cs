namespace MyWindowList
{
    partial class MainForm
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
            btnContactView = new Button();
            mHeadMenu = new MenuStrip();
            mHeadMenuFile = new ToolStripMenuItem();
            mFileExit = new ToolStripMenuItem();
            mHelp = new ToolStripMenuItem();
            mHelpContacts = new ToolStripMenuItem();
            mHeadMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnContactView
            // 
            btnContactView.Location = new Point(22, 29);
            btnContactView.Margin = new Padding(1, 1, 1, 1);
            btnContactView.Name = "btnContactView";
            btnContactView.Size = new Size(106, 43);
            btnContactView.TabIndex = 0;
            btnContactView.Text = "Контакти";
            btnContactView.UseVisualStyleBackColor = true;
            btnContactView.Click += btnContactView_Click;
            // 
            // mHeadMenu
            // 
            mHeadMenu.ImageScalingSize = new Size(24, 24);
            mHeadMenu.Items.AddRange(new ToolStripItem[] { mHeadMenuFile, mHelp });
            mHeadMenu.Location = new Point(0, 0);
            mHeadMenu.Name = "mHeadMenu";
            mHeadMenu.Padding = new Padding(4, 1, 0, 1);
            mHeadMenu.Size = new Size(560, 24);
            mHeadMenu.TabIndex = 1;
            mHeadMenu.Text = "menuStrip1";
            // 
            // mHeadMenuFile
            // 
            mHeadMenuFile.DropDownItems.AddRange(new ToolStripItem[] { mFileExit });
            mHeadMenuFile.Name = "mHeadMenuFile";
            mHeadMenuFile.Size = new Size(37, 22);
            mHeadMenuFile.Text = "File";
            // 
            // mFileExit
            // 
            mFileExit.Name = "mFileExit";
            mFileExit.ShortcutKeys = Keys.Control | Keys.X;
            mFileExit.Size = new Size(180, 22);
            mFileExit.Text = "Вихід";
            mFileExit.Click += mFileExit_Click;
            // 
            // mHelp
            // 
            mHelp.DropDownItems.AddRange(new ToolStripItem[] { mHelpContacts });
            mHelp.Name = "mHelp";
            mHelp.Size = new Size(44, 22);
            mHelp.Text = "Help";
            // 
            // mHelpContacts
            // 
            mHelpContacts.Name = "mHelpContacts";
            mHelpContacts.ShortcutKeys = Keys.Control | Keys.M;
            mHelpContacts.Size = new Size(166, 22);
            mHelpContacts.Text = "Contacts";
            mHelpContacts.Click += mHelpContacts_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnContactView);
            Controls.Add(mHeadMenu);
            MainMenuStrip = mHeadMenu;
            Margin = new Padding(1, 1, 1, 1);
            Name = "MainForm";
            Text = "Головне вікно";
            FormClosing += MainForm_FormClosing_1;
            mHeadMenu.ResumeLayout(false);
            mHeadMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContactView;
        private MenuStrip mHeadMenu;
        private ToolStripMenuItem mHeadMenuFile;
        private ToolStripMenuItem mFileExit;
        private ToolStripMenuItem mHelp;
        private ToolStripMenuItem mHelpContacts;
    }
}