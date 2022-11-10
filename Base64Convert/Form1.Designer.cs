namespace Base64Convert
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.selectedTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(12, 16);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(92, 23);
            this.fileButton.TabIndex = 0;
            this.fileButton.Text = "Archivo";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "To Base64",
            "To Base12"});
            this.comboBox1.Location = new System.Drawing.Point(110, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(237, 14);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(92, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convertir";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // selectedTextBox
            // 
            this.selectedTextBox.Location = new System.Drawing.Point(12, 45);
            this.selectedTextBox.Name = "selectedTextBox";
            this.selectedTextBox.Size = new System.Drawing.Size(313, 20);
            this.selectedTextBox.TabIndex = 3;
            this.selectedTextBox.TextChanged += new System.EventHandler(this.selectedTextBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 264);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(110, 342);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "Copiar";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 396);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.selectedTextBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ScaRe - Converte Base64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox selectedTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button copyButton;
    }
}

