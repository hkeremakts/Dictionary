using Autofac;

namespace DictionaryForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        ContainerBuilder builder = new ContainerBuilder();
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
            this.add = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.definitionLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.wordScroller = new System.Windows.Forms.NumericUpDown();
            this.definitionDalTextBox = new System.Windows.Forms.RichTextBox();
            this.nameDalTextBox = new System.Windows.Forms.RichTextBox();
            this.translationDalTextBox = new System.Windows.Forms.RichTextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wordScroller)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(272, 31);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 34);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(172, 31);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(94, 34);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(28, 31);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(125, 32);
            this.searchTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(28, 83);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 32);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // definitionLabel
            // 
            this.definitionLabel.AutoSize = true;
            this.definitionLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.definitionLabel.Location = new System.Drawing.Point(28, 131);
            this.definitionLabel.Name = "definitionLabel";
            this.definitionLabel.Size = new System.Drawing.Size(125, 32);
            this.definitionLabel.TabIndex = 4;
            this.definitionLabel.Text = "Definition:";
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.translationLabel.Location = new System.Drawing.Point(28, 238);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(134, 32);
            this.translationLabel.TabIndex = 5;
            this.translationLabel.Text = "Translation:";
            // 
            // wordScroller
            // 
            this.wordScroller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordScroller.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordScroller.Location = new System.Drawing.Point(113, 166);
            this.wordScroller.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wordScroller.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wordScroller.Name = "wordScroller";
            this.wordScroller.Size = new System.Drawing.Size(40, 28);
            this.wordScroller.TabIndex = 9;
            this.wordScroller.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wordScroller.ValueChanged += new System.EventHandler(this.wordScroller_ValueChanged);
            // 
            // definitionDalTextBox
            // 
            this.definitionDalTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.definitionDalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.definitionDalTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.definitionDalTextBox.Location = new System.Drawing.Point(159, 136);
            this.definitionDalTextBox.Name = "definitionDalTextBox";
            this.definitionDalTextBox.Size = new System.Drawing.Size(407, 101);
            this.definitionDalTextBox.TabIndex = 10;
            this.definitionDalTextBox.Text = "Default";
            // 
            // nameDalTextBox
            // 
            this.nameDalTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameDalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameDalTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameDalTextBox.Location = new System.Drawing.Point(159, 88);
            this.nameDalTextBox.Name = "nameDalTextBox";
            this.nameDalTextBox.Size = new System.Drawing.Size(407, 35);
            this.nameDalTextBox.TabIndex = 11;
            this.nameDalTextBox.Text = "Default";
            // 
            // translationDalTextBox
            // 
            this.translationDalTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.translationDalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.translationDalTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.translationDalTextBox.Location = new System.Drawing.Point(159, 243);
            this.translationDalTextBox.Name = "translationDalTextBox";
            this.translationDalTextBox.Size = new System.Drawing.Size(407, 35);
            this.translationDalTextBox.TabIndex = 12;
            this.translationDalTextBox.Text = "Default";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(372, 31);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(94, 34);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(472, 31);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 34);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 314);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.translationDalTextBox);
            this.Controls.Add(this.nameDalTextBox);
            this.Controls.Add(this.definitionDalTextBox);
            this.Controls.Add(this.wordScroller);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.definitionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.search);
            this.Controls.Add(this.add);
            this.Name = "MainForm";
            this.Text = "Dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.wordScroller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button add;
        private Button search;
        private TextBox searchTextBox;
        private Label nameLabel;
        private Label definitionLabel;
        private Label translationLabel;
        private NumericUpDown wordScroller;
        private RichTextBox definitionDalTextBox;
        private RichTextBox nameDalTextBox;
        private RichTextBox translationDalTextBox;
        private Button updateButton;
        private Button deleteButton;
    }
}