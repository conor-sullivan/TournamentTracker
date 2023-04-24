namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            teamNameValue = new System.Windows.Forms.TextBox();
            teamNameLabel = new System.Windows.Forms.Label();
            createTeamLabel = new System.Windows.Forms.Label();
            addMemberButton = new System.Windows.Forms.Button();
            selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            selectTeamMemberLabel = new System.Windows.Forms.Label();
            addNewMemberBox = new System.Windows.Forms.GroupBox();
            createMemberButton = new System.Windows.Forms.Button();
            cellphoneValue = new System.Windows.Forms.TextBox();
            cellphoneLabel = new System.Windows.Forms.Label();
            emailValue = new System.Windows.Forms.TextBox();
            emailLabel = new System.Windows.Forms.Label();
            lastNameValue = new System.Windows.Forms.TextBox();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameValue = new System.Windows.Forms.TextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            teamMembersListBox = new System.Windows.Forms.ListBox();
            removeSelectedMember = new System.Windows.Forms.Button();
            createTeamButton = new System.Windows.Forms.Button();
            addNewMemberBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new System.Drawing.Point(21, 100);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new System.Drawing.Size(371, 35);
            teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            teamNameLabel.Location = new System.Drawing.Point(15, 60);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new System.Drawing.Size(157, 37);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            createTeamLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            createTeamLabel.Location = new System.Drawing.Point(13, 10);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new System.Drawing.Size(213, 50);
            createTeamLabel.TabIndex = 11;
            createTeamLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            addMemberButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            addMemberButton.Location = new System.Drawing.Point(114, 222);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new System.Drawing.Size(191, 55);
            addMemberButton.TabIndex = 19;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // selectTeamMemberDropdown
            // 
            selectTeamMemberDropdown.FormattingEnabled = true;
            selectTeamMemberDropdown.Location = new System.Drawing.Point(21, 178);
            selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            selectTeamMemberDropdown.Size = new System.Drawing.Size(370, 38);
            selectTeamMemberDropdown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            selectTeamMemberLabel.Location = new System.Drawing.Point(15, 138);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberBox
            // 
            addNewMemberBox.Controls.Add(createMemberButton);
            addNewMemberBox.Controls.Add(cellphoneValue);
            addNewMemberBox.Controls.Add(cellphoneLabel);
            addNewMemberBox.Controls.Add(emailValue);
            addNewMemberBox.Controls.Add(emailLabel);
            addNewMemberBox.Controls.Add(lastNameValue);
            addNewMemberBox.Controls.Add(lastNameLabel);
            addNewMemberBox.Controls.Add(firstNameValue);
            addNewMemberBox.Controls.Add(firstNameLabel);
            addNewMemberBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            addNewMemberBox.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            addNewMemberBox.Location = new System.Drawing.Point(21, 295);
            addNewMemberBox.Name = "addNewMemberBox";
            addNewMemberBox.Size = new System.Drawing.Size(371, 308);
            addNewMemberBox.TabIndex = 20;
            addNewMemberBox.TabStop = false;
            addNewMemberBox.Text = "Add New Member";
            addNewMemberBox.Enter += addNewMemberBox_Enter;
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createMemberButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            createMemberButton.Location = new System.Drawing.Point(92, 234);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new System.Drawing.Size(191, 55);
            createMemberButton.TabIndex = 21;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new System.Drawing.Point(156, 181);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new System.Drawing.Size(200, 43);
            cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            cellphoneLabel.Location = new System.Drawing.Point(6, 177);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new System.Drawing.Size(138, 37);
            cellphoneLabel.TabIndex = 15;
            cellphoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.Location = new System.Drawing.Point(156, 135);
            emailValue.Name = "emailValue";
            emailValue.Size = new System.Drawing.Size(200, 43);
            emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emailLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            emailLabel.Location = new System.Drawing.Point(6, 131);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(82, 37);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new System.Drawing.Point(156, 88);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new System.Drawing.Size(200, 43);
            lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            lastNameLabel.Location = new System.Drawing.Point(6, 85);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(142, 37);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new System.Drawing.Point(156, 42);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new System.Drawing.Size(200, 43);
            firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            firstNameLabel.Location = new System.Drawing.Point(6, 39);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(144, 37);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 30;
            teamMembersListBox.Location = new System.Drawing.Point(420, 110);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new System.Drawing.Size(371, 484);
            teamMembersListBox.TabIndex = 21;
            // 
            // removeSelectedMember
            // 
            removeSelectedMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            removeSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
            removeSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            removeSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            removeSelectedMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            removeSelectedMember.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            removeSelectedMember.Location = new System.Drawing.Point(820, 316);
            removeSelectedMember.Name = "removeSelectedMember";
            removeSelectedMember.Size = new System.Drawing.Size(125, 90);
            removeSelectedMember.TabIndex = 25;
            removeSelectedMember.Text = "Remove Selected";
            removeSelectedMember.UseVisualStyleBackColor = true;
            removeSelectedMember.Click += removeSelectedMember_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createTeamButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            createTeamButton.Location = new System.Drawing.Point(306, 618);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new System.Drawing.Size(322, 73);
            createTeamButton.TabIndex = 26;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(968, 703);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedMember);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropdown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "CreateTeamForm";
            Text = "Create Team";
            Load += createTeamForm_Load;
            addNewMemberBox.ResumeLayout(false);
            addNewMemberBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberBox;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button removeSelectedMember;
        private System.Windows.Forms.Button createTeamButton;
    }
}