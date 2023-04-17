namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            headerLabel = new System.Windows.Forms.Label();
            tournamentNameValue = new System.Windows.Forms.TextBox();
            tournamentNameLabel = new System.Windows.Forms.Label();
            entryFeeValue = new System.Windows.Forms.TextBox();
            entryFeeLabel = new System.Windows.Forms.Label();
            selectTeamDropdown = new System.Windows.Forms.ComboBox();
            selectTeamLabel = new System.Windows.Forms.Label();
            createNewTeamLink = new System.Windows.Forms.LinkLabel();
            addTeamButton = new System.Windows.Forms.Button();
            createPrizeButton = new System.Windows.Forms.Button();
            tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            tournamentPlayersLabel = new System.Windows.Forms.Label();
            removeSelectedPrizeButton = new System.Windows.Forms.Button();
            prizesLabel = new System.Windows.Forms.Label();
            prizesListBox = new System.Windows.Forms.ListBox();
            removeSelectedPlayerButton = new System.Windows.Forms.Button();
            createTournamentButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            headerLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            headerLabel.Location = new System.Drawing.Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new System.Drawing.Size(317, 50);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new System.Drawing.Point(21, 118);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new System.Drawing.Size(308, 35);
            tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            tournamentNameLabel.Location = new System.Drawing.Point(14, 68);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new System.Drawing.Point(145, 174);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new System.Drawing.Size(82, 35);
            entryFeeValue.TabIndex = 12;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            entryFeeLabel.Location = new System.Drawing.Point(14, 171);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new System.Drawing.Size(125, 37);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropdown
            // 
            selectTeamDropdown.FormattingEnabled = true;
            selectTeamDropdown.Location = new System.Drawing.Point(20, 263);
            selectTeamDropdown.Name = "selectTeamDropdown";
            selectTeamDropdown.Size = new System.Drawing.Size(308, 38);
            selectTeamDropdown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new System.Drawing.Point(14, 224);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new System.Drawing.Size(156, 37);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new System.Drawing.Point(214, 230);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new System.Drawing.Size(114, 30);
            createNewTeamLink.TabIndex = 15;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            createNewTeamLink.LinkClicked += createNewTeamLink_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            addTeamButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            addTeamButton.Location = new System.Drawing.Point(73, 309);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new System.Drawing.Size(195, 55);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new System.Drawing.Point(73, 370);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new System.Drawing.Size(195, 55);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 30;
            tournamentTeamsListBox.Location = new System.Drawing.Point(387, 68);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new System.Drawing.Size(302, 154);
            tournamentTeamsListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            tournamentPlayersLabel.Location = new System.Drawing.Point(381, 29);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new System.Drawing.Size(198, 37);
            tournamentPlayersLabel.TabIndex = 19;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
            removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            removeSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            removeSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            removeSelectedPrizeButton.Location = new System.Drawing.Point(727, 307);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new System.Drawing.Size(125, 90);
            removeSelectedPrizeButton.TabIndex = 23;
            removeSelectedPrizeButton.Text = "Remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            prizesLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            prizesLabel.Location = new System.Drawing.Point(382, 237);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new System.Drawing.Size(85, 37);
            prizesLabel.TabIndex = 22;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new System.Drawing.Point(388, 276);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new System.Drawing.Size(302, 154);
            prizesListBox.TabIndex = 21;
            // 
            // removeSelectedPlayerButton
            // 
            removeSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            removeSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
            removeSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            removeSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            removeSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            removeSelectedPlayerButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            removeSelectedPlayerButton.Location = new System.Drawing.Point(726, 97);
            removeSelectedPlayerButton.Name = "removeSelectedPlayerButton";
            removeSelectedPlayerButton.Size = new System.Drawing.Size(125, 90);
            removeSelectedPlayerButton.TabIndex = 24;
            removeSelectedPlayerButton.Text = "Remove Selected";
            removeSelectedPlayerButton.UseVisualStyleBackColor = true;
            removeSelectedPlayerButton.Click += deleteSelectedPlayerButton_Click;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new System.Drawing.Point(257, 447);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new System.Drawing.Size(322, 73);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(883, 533);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPlayerButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropdown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropdown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button removeSelectedPrizeButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button removeSelectedPlayerButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}