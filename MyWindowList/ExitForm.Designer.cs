namespace MyWindowList
{
    partial class ExitForm
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
            btn1 = new Button();
            btn2 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(227, 145);
            btn1.Name = "btn1";
            btn1.Size = new Size(83, 43);
            btn1.TabIndex = 0;
            btn1.Text = "Хочу вийти";
            btn1.UseVisualStyleBackColor = true;
            
            // 
            // btn2
            // 
            btn2.Location = new Point(351, 145);
            btn2.Name = "btn2";
            btn2.Size = new Size(85, 43);
            btn2.TabIndex = 1;
            btn2.Text = "Лишитися в програмі";
            btn2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(173, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 219);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(183, 85);
            label1.Name = "label1";
            label1.Size = new Size(317, 40);
            label1.TabIndex = 3;
            label1.Text = "Справді хочете вийти?";
            // 
            // ExitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "ExitForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}