namespace eShop
{
    partial class searchProduct
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
            this.keyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startWithKeyword = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.uppercase = new System.Windows.Forms.RadioButton();
            this.lowercase = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(13, 60);
            this.keyword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(422, 33);
            this.keyword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "عبارت جستجو";
            // 
            // startWithKeyword
            // 
            this.startWithKeyword.AutoSize = true;
            this.startWithKeyword.Location = new System.Drawing.Point(100, 122);
            this.startWithKeyword.Name = "startWithKeyword";
            this.startWithKeyword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startWithKeyword.Size = new System.Drawing.Size(336, 30);
            this.startWithKeyword.TabIndex = 2;
            this.startWithKeyword.Text = "نتایجی که فقط با این کلمه شروع شود";
            this.startWithKeyword.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(13, 288);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(423, 45);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // uppercase
            // 
            this.uppercase.AutoSize = true;
            this.uppercase.Location = new System.Drawing.Point(226, 161);
            this.uppercase.Name = "uppercase";
            this.uppercase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uppercase.Size = new System.Drawing.Size(210, 30);
            this.uppercase.TabIndex = 4;
            this.uppercase.TabStop = true;
            this.uppercase.Tag = "caseSensitive";
            this.uppercase.Text = "حساس به حروف بزرگ";
            this.uppercase.UseVisualStyleBackColor = true;
            // 
            // lowercase
            // 
            this.lowercase.AutoSize = true;
            this.lowercase.Location = new System.Drawing.Point(212, 198);
            this.lowercase.Name = "lowercase";
            this.lowercase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lowercase.Size = new System.Drawing.Size(224, 30);
            this.lowercase.TabIndex = 4;
            this.lowercase.TabStop = true;
            this.lowercase.Tag = "caseSensitive";
            this.lowercase.Text = "حساس به حروف کوچک";
            this.lowercase.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(291, 234);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(145, 30);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "caseSensitive";
            this.radioButton1.Text = "حساس نباشد";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // searchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(448, 617);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lowercase);
            this.Controls.Add(this.uppercase);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.startWithKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyword);
            this.Font = new System.Drawing.Font("IRANYekanX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "searchProduct";
            this.Text = "searchProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox startWithKeyword;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton uppercase;
        private System.Windows.Forms.RadioButton lowercase;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}