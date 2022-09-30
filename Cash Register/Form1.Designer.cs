namespace Cash_Register
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.coffeeLabel = new System.Windows.Forms.Label();
            this.pasteryLabel = new System.Windows.Forms.Label();
            this.sandwichLabel = new System.Windows.Forms.Label();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.pasteryInput = new System.Windows.Forms.TextBox();
            this.sandwichInput = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.TextBox();
            this.taxOutput = new System.Windows.Forms.TextBox();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.separationLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.tenderedButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.tenderedOutput = new System.Windows.Forms.TextBox();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.titleLabel.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(-36, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(991, 57);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Moonshine Cafe";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coffeeLabel
            // 
            this.coffeeLabel.AutoSize = true;
            this.coffeeLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.coffeeLabel.Location = new System.Drawing.Point(0, 87);
            this.coffeeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coffeeLabel.Name = "coffeeLabel";
            this.coffeeLabel.Size = new System.Drawing.Size(152, 23);
            this.coffeeLabel.TabIndex = 1;
            this.coffeeLabel.Text = "Number of Drinks";
            // 
            // pasteryLabel
            // 
            this.pasteryLabel.AutoSize = true;
            this.pasteryLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pasteryLabel.Location = new System.Drawing.Point(0, 133);
            this.pasteryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pasteryLabel.Name = "pasteryLabel";
            this.pasteryLabel.Size = new System.Drawing.Size(172, 23);
            this.pasteryLabel.TabIndex = 2;
            this.pasteryLabel.Text = "Number of Pasteries";
            // 
            // sandwichLabel
            // 
            this.sandwichLabel.AutoSize = true;
            this.sandwichLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sandwichLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sandwichLabel.Location = new System.Drawing.Point(0, 181);
            this.sandwichLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sandwichLabel.Name = "sandwichLabel";
            this.sandwichLabel.Size = new System.Drawing.Size(193, 23);
            this.sandwichLabel.TabIndex = 3;
            this.sandwichLabel.Text = "Number of Sandwiches";
            // 
            // drinkInput
            // 
            this.drinkInput.Location = new System.Drawing.Point(272, 91);
            this.drinkInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(89, 22);
            this.drinkInput.TabIndex = 4;
            // 
            // pasteryInput
            // 
            this.pasteryInput.Location = new System.Drawing.Point(272, 133);
            this.pasteryInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pasteryInput.Name = "pasteryInput";
            this.pasteryInput.Size = new System.Drawing.Size(89, 22);
            this.pasteryInput.TabIndex = 5;
            // 
            // sandwichInput
            // 
            this.sandwichInput.Location = new System.Drawing.Point(272, 181);
            this.sandwichInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sandwichInput.Name = "sandwichInput";
            this.sandwichInput.Size = new System.Drawing.Size(89, 22);
            this.sandwichInput.TabIndex = 6;
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalButton.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalButton.Location = new System.Drawing.Point(91, 229);
            this.totalButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(235, 43);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.subtotalLabel.Location = new System.Drawing.Point(0, 289);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(79, 23);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.taxLabel.Location = new System.Drawing.Point(0, 330);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(45, 23);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.totalLabel.Location = new System.Drawing.Point(0, 375);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(53, 23);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.SystemColors.Window;
            this.subtotalOutput.Location = new System.Drawing.Point(155, 293);
            this.subtotalOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(132, 22);
            this.subtotalOutput.TabIndex = 11;
            // 
            // taxOutput
            // 
            this.taxOutput.Location = new System.Drawing.Point(155, 334);
            this.taxOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(132, 22);
            this.taxOutput.TabIndex = 12;
            // 
            // totalOutput
            // 
            this.totalOutput.Location = new System.Drawing.Point(155, 379);
            this.totalOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(132, 22);
            this.totalOutput.TabIndex = 13;
            // 
            // separationLabel
            // 
            this.separationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.separationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.separationLabel.Location = new System.Drawing.Point(1, 420);
            this.separationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.separationLabel.Name = "separationLabel";
            this.separationLabel.Size = new System.Drawing.Size(404, 16);
            this.separationLabel.TabIndex = 14;
            this.separationLabel.Text = "hello";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tenderedLabel.Location = new System.Drawing.Point(0, 455);
            this.tenderedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(86, 23);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(155, 455);
            this.tenderedInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(132, 22);
            this.tenderedInput.TabIndex = 16;
            // 
            // tenderedButton
            // 
            this.tenderedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tenderedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tenderedButton.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tenderedButton.Location = new System.Drawing.Point(104, 501);
            this.tenderedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenderedButton.Name = "tenderedButton";
            this.tenderedButton.Size = new System.Drawing.Size(221, 34);
            this.tenderedButton.TabIndex = 17;
            this.tenderedButton.Text = "Calculate Change";
            this.tenderedButton.UseVisualStyleBackColor = false;
            this.tenderedButton.Click += new System.EventHandler(this.tenderedButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.changeLabel.Location = new System.Drawing.Point(0, 564);
            this.changeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(69, 23);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change";
            // 
            // tenderedOutput
            // 
            this.tenderedOutput.Location = new System.Drawing.Point(155, 567);
            this.tenderedOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenderedOutput.Name = "tenderedOutput";
            this.tenderedOutput.Size = new System.Drawing.Size(132, 22);
            this.tenderedOutput.TabIndex = 19;
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.receiptButton.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiptButton.Location = new System.Drawing.Point(5, 620);
            this.receiptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(400, 34);
            this.receiptButton.TabIndex = 20;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.Color.White;
            this.receiptOutput.Location = new System.Drawing.Point(435, 69);
            this.receiptOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(345, 537);
            this.receiptOutput.TabIndex = 21;
            this.receiptOutput.Text = "Moonshine Cafe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(893, 670);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.tenderedOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.separationLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.sandwichInput);
            this.Controls.Add(this.pasteryInput);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.sandwichLabel);
            this.Controls.Add(this.pasteryLabel);
            this.Controls.Add(this.coffeeLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label coffeeLabel;
        private System.Windows.Forms.Label pasteryLabel;
        private System.Windows.Forms.Label sandwichLabel;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.TextBox pasteryInput;
        private System.Windows.Forms.TextBox sandwichInput;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox subtotalOutput;
        private System.Windows.Forms.TextBox taxOutput;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.Label separationLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button tenderedButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.TextBox tenderedOutput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptOutput;
    }
}

