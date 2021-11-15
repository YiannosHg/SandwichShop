
namespace Sandwich_Shop
{
    partial class SandwichOrderingForm
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
            this.breadGroupBox = new System.Windows.Forms.GroupBox();
            this.ingredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // breadGroupBox
            // 
            this.breadGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadGroupBox.Location = new System.Drawing.Point(12, 62);
            this.breadGroupBox.Name = "breadGroupBox";
            this.breadGroupBox.Size = new System.Drawing.Size(200, 100);
            this.breadGroupBox.TabIndex = 0;
            this.breadGroupBox.TabStop = false;
            this.breadGroupBox.Text = "Bread";
            // 
            // ingredientsGroupBox
            // 
            this.ingredientsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsGroupBox.Location = new System.Drawing.Point(376, 62);
            this.ingredientsGroupBox.Name = "ingredientsGroupBox";
            this.ingredientsGroupBox.Size = new System.Drawing.Size(200, 100);
            this.ingredientsGroupBox.TabIndex = 1;
            this.ingredientsGroupBox.TabStop = false;
            this.ingredientsGroupBox.Text = "Ingredients";
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Location = new System.Drawing.Point(12, 323);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(81, 36);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(165, 332);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 16);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // SandwichOrderingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.ingredientsGroupBox);
            this.Controls.Add(this.breadGroupBox);
            this.Name = "SandwichOrderingForm";
            this.Text = "SandwichOrdering";
            this.Load += new System.EventHandler(this.SandwichOrderingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox breadGroupBox;
        private System.Windows.Forms.GroupBox ingredientsGroupBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label priceLabel;
    }
}

