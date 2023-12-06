namespace WindowsFormsAppOrarend
{
    partial class Form_Ora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_sorszam = new System.Windows.Forms.NumericUpDown();
            this.textBox_oranev = new System.Windows.Forms.TextBox();
            this.textBox_oraid = new System.Windows.Forms.TextBox();
            this.button_muvelet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sorszam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_muvelet);
            this.groupBox1.Controls.Add(this.numericUpDown_sorszam);
            this.groupBox1.Controls.Add(this.textBox_oranev);
            this.groupBox1.Controls.Add(this.textBox_oraid);
            this.groupBox1.Location = new System.Drawing.Point(21, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 228);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Óra adatai";
            // 
            // numericUpDown_sorszam
            // 
            this.numericUpDown_sorszam.Location = new System.Drawing.Point(57, 134);
            this.numericUpDown_sorszam.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_sorszam.Name = "numericUpDown_sorszam";
            this.numericUpDown_sorszam.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_sorszam.TabIndex = 2;
            // 
            // textBox_oranev
            // 
            this.textBox_oranev.Location = new System.Drawing.Point(57, 84);
            this.textBox_oranev.Name = "textBox_oranev";
            this.textBox_oranev.Size = new System.Drawing.Size(165, 20);
            this.textBox_oranev.TabIndex = 1;
            // 
            // textBox_oraid
            // 
            this.textBox_oraid.Location = new System.Drawing.Point(57, 40);
            this.textBox_oraid.Name = "textBox_oraid";
            this.textBox_oraid.Size = new System.Drawing.Size(100, 20);
            this.textBox_oraid.TabIndex = 0;
            // 
            // button_muvelet
            // 
            this.button_muvelet.Location = new System.Drawing.Point(57, 181);
            this.button_muvelet.Name = "button_muvelet";
            this.button_muvelet.Size = new System.Drawing.Size(271, 23);
            this.button_muvelet.TabIndex = 3;
            this.button_muvelet.UseVisualStyleBackColor = true;
            this.button_muvelet.Click += new System.EventHandler(this.button_muvelet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÓraID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tantárgy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sorszám";
            // 
            // Form_Ora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 326);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Ora";
            this.Text = "Form_Ora";
            this.Load += new System.EventHandler(this.Form_Ora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sorszam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_sorszam;
        private System.Windows.Forms.TextBox textBox_oranev;
        private System.Windows.Forms.Button button_muvelet;
        public System.Windows.Forms.TextBox textBox_oraid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}