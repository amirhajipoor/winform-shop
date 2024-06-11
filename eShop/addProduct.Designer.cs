namespace eShop
{
    partial class editProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.saleAmountInput = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.browseImageButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "* نام محصول";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(30, 62);
            this.title.Name = "title";
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.title.Size = new System.Drawing.Size(509, 33);
            this.title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 121);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "توضیحات*";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(30, 155);
            this.description.Name = "description";
            this.description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.description.Size = new System.Drawing.Size(509, 76);
            this.description.TabIndex = 2;
            this.description.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "*قیمت";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(295, 301);
            this.amount.Name = "amount";
            this.amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amount.Size = new System.Drawing.Size(244, 33);
            this.amount.TabIndex = 1;
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.AutoSize = true;
            this.salePriceLabel.Location = new System.Drawing.Point(120, 266);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(154, 26);
            this.salePriceLabel.TabIndex = 0;
            this.salePriceLabel.Text = "قیمت فروش ویژه";
            this.salePriceLabel.Visible = false;
            // 
            // saleAmountInput
            // 
            this.saleAmountInput.Location = new System.Drawing.Point(30, 301);
            this.saleAmountInput.Name = "saleAmountInput";
            this.saleAmountInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.saleAmountInput.Size = new System.Drawing.Size(244, 33);
            this.saleAmountInput.TabIndex = 1;
            this.saleAmountInput.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(326, 352);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(213, 30);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "فعال کردن فروش ویژه";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.Color.Navy;
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(367, 637);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(172, 53);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "ذخیره";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(186, 637);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(172, 53);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // browseImageButton
            // 
            this.browseImageButton.AutoSize = true;
            this.browseImageButton.Location = new System.Drawing.Point(364, 445);
            this.browseImageButton.Name = "browseImageButton";
            this.browseImageButton.Size = new System.Drawing.Size(172, 36);
            this.browseImageButton.TabIndex = 5;
            this.browseImageButton.Text = "انتخاب عکس";
            this.browseImageButton.UseVisualStyleBackColor = true;
            this.browseImageButton.Click += new System.EventHandler(this.browseImageButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "* عکس";
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(570, 761);
            this.Controls.Add(this.browseImageButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saleAmountInput);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("IRANYekanX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "addProduct";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.TextBox saleAmountInput;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button browseImageButton;
        private System.Windows.Forms.Label label5;
    }
}