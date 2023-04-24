namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            createPrizeLabel = new System.Windows.Forms.Label();
            placeNumberValue = new System.Windows.Forms.TextBox();
            placeNumberLabel = new System.Windows.Forms.Label();
            placeNameValue = new System.Windows.Forms.TextBox();
            placeNameLabel = new System.Windows.Forms.Label();
            prizeAmountValue = new System.Windows.Forms.TextBox();
            prizeAmountLabel = new System.Windows.Forms.Label();
            prizePercentageValue = new System.Windows.Forms.TextBox();
            prizePercentageLabel = new System.Windows.Forms.Label();
            orLabel = new System.Windows.Forms.Label();
            createPrizeButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            createPrizeLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            createPrizeLabel.Location = new System.Drawing.Point(12, 9);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new System.Drawing.Size(209, 50);
            createPrizeLabel.TabIndex = 12;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new System.Drawing.Point(216, 62);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new System.Drawing.Size(200, 35);
            placeNumberValue.TabIndex = 14;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            placeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            placeNumberLabel.Location = new System.Drawing.Point(27, 59);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new System.Drawing.Size(183, 37);
            placeNumberLabel.TabIndex = 13;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new System.Drawing.Point(216, 103);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new System.Drawing.Size(200, 35);
            placeNameValue.TabIndex = 16;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new System.Drawing.Point(27, 101);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new System.Drawing.Size(157, 37);
            placeNameLabel.TabIndex = 15;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new System.Drawing.Point(216, 144);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new System.Drawing.Size(200, 35);
            prizeAmountValue.TabIndex = 18;
            prizeAmountValue.Text = "0";
            prizeAmountValue.TextChanged += prizeAmountValue_TextChanged;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            prizeAmountLabel.Location = new System.Drawing.Point(27, 141);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new System.Drawing.Size(176, 37);
            prizeAmountLabel.TabIndex = 17;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new System.Drawing.Point(245, 222);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new System.Drawing.Size(171, 35);
            prizePercentageValue.TabIndex = 20;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            prizePercentageLabel.Location = new System.Drawing.Point(27, 219);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new System.Drawing.Size(212, 37);
            prizePercentageLabel.TabIndex = 19;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            orLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            orLabel.Location = new System.Drawing.Point(181, 182);
            orLabel.Name = "orLabel";
            orLabel.Size = new System.Drawing.Size(85, 37);
            orLabel.TabIndex = 21;
            orLabel.Text = "- or - ";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new System.Drawing.Point(80, 274);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new System.Drawing.Size(322, 73);
            createPrizeButton.TabIndex = 27;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(489, 366);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}