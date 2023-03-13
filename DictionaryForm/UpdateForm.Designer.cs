namespace DictionaryForm
{
    partial class UpdateForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.definitionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.RichTextBox();
            this.definitionTextBox1 = new System.Windows.Forms.RichTextBox();
            this.translationTextBox = new System.Windows.Forms.RichTextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.definitionsScroller = new System.Windows.Forms.NumericUpDown();
            this.definitionTextBox2 = new System.Windows.Forms.RichTextBox();
            this.definitionTextBox3 = new System.Windows.Forms.RichTextBox();
            this.definitionTextBox4 = new System.Windows.Forms.RichTextBox();
            this.definitionTextBox5 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.definitionsScroller)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(26, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 32);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.translationLabel.Location = new System.Drawing.Point(26, 270);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(134, 32);
            this.translationLabel.TabIndex = 1;
            this.translationLabel.Text = "Translation:";
            // 
            // definitionLabel
            // 
            this.definitionLabel.AutoSize = true;
            this.definitionLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.definitionLabel.Location = new System.Drawing.Point(26, 100);
            this.definitionLabel.Name = "definitionLabel";
            this.definitionLabel.Size = new System.Drawing.Size(135, 32);
            this.definitionLabel.TabIndex = 2;
            this.definitionLabel.Text = "Definitions:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(167, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 37);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.Text = "";
            // 
            // definitionTextBox1
            // 
            this.definitionTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.definitionTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.definitionTextBox1.Location = new System.Drawing.Point(167, 102);
            this.definitionTextBox1.Name = "definitionTextBox1";
            this.definitionTextBox1.Size = new System.Drawing.Size(387, 133);
            this.definitionTextBox1.TabIndex = 5;
            this.definitionTextBox1.Text = "";
            // 
            // translationTextBox
            // 
            this.translationTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.translationTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.translationTextBox.Location = new System.Drawing.Point(167, 271);
            this.translationTextBox.Name = "translationTextBox";
            this.translationTextBox.Size = new System.Drawing.Size(214, 37);
            this.translationTextBox.TabIndex = 7;
            this.translationTextBox.Text = "";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(460, 270);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(94, 37);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // definitionsScroller
            // 
            this.definitionsScroller.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.definitionsScroller.Location = new System.Drawing.Point(560, 203);
            this.definitionsScroller.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.definitionsScroller.Name = "definitionsScroller";
            this.definitionsScroller.Size = new System.Drawing.Size(44, 32);
            this.definitionsScroller.TabIndex = 9;
            this.definitionsScroller.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.definitionsScroller.ValueChanged += new System.EventHandler(this.definitionsScroller_ValueChanged);
            // 
            // definitionTextBox2
            // 
            this.definitionTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.definitionTextBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.definitionTextBox2.Location = new System.Drawing.Point(167, 102);
            this.definitionTextBox2.Name = "definitionTextBox2";
            this.definitionTextBox2.Size = new System.Drawing.Size(387, 133);
            this.definitionTextBox2.TabIndex = 10;
            this.definitionTextBox2.Text = "";
            this.definitionTextBox2.Visible = false;
            // 
            // definitionTextBox3
            // 
            this.definitionTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.definitionTextBox3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.definitionTextBox3.Location = new System.Drawing.Point(167, 102);
            this.definitionTextBox3.Name = "definitionTextBox3";
            this.definitionTextBox3.Size = new System.Drawing.Size(387, 133);
            this.definitionTextBox3.TabIndex = 11;
            this.definitionTextBox3.Text = "";
            this.definitionTextBox3.Visible = false;
            // 
            // definitionTextBox4
            // 
            this.definitionTextBox4.BackColor = System.Drawing.SystemColors.Control;
            this.definitionTextBox4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.definitionTextBox4.Location = new System.Drawing.Point(167, 102);
            this.definitionTextBox4.Name = "definitionTextBox4";
            this.definitionTextBox4.Size = new System.Drawing.Size(387, 133);
            this.definitionTextBox4.TabIndex = 12;
            this.definitionTextBox4.Text = "";
            this.definitionTextBox4.Visible = false;
            // 
            // definitionTextBox5
            // 
            this.definitionTextBox5.BackColor = System.Drawing.SystemColors.Control;
            this.definitionTextBox5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.definitionTextBox5.Location = new System.Drawing.Point(167, 102);
            this.definitionTextBox5.Name = "definitionTextBox5";
            this.definitionTextBox5.Size = new System.Drawing.Size(387, 133);
            this.definitionTextBox5.TabIndex = 13;
            this.definitionTextBox5.Text = "";
            this.definitionTextBox5.Visible = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(626, 326);
            this.Controls.Add(this.definitionTextBox5);
            this.Controls.Add(this.definitionTextBox4);
            this.Controls.Add(this.definitionTextBox3);
            this.Controls.Add(this.definitionTextBox2);
            this.Controls.Add(this.definitionsScroller);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.translationTextBox);
            this.Controls.Add(this.definitionTextBox1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.definitionLabel);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "UpdateForm";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.definitionsScroller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label translationLabel;
        private Label definitionLabel;
        private RichTextBox nameTextBox;
        private RichTextBox definitionTextBox1;
        private RichTextBox translationTextBox;
        private Button updateButton;
        private NumericUpDown definitionsScroller;
        private RichTextBox definitionTextBox2;
        private RichTextBox definitionTextBox3;
        private RichTextBox definitionTextBox4;
        private RichTextBox definitionTextBox5;
    }
}