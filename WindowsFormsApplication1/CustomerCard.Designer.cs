namespace WindowsFormsApplication1
{
    partial class CustomerCard
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
            this.components = new System.ComponentModel.Container();
            this.checkBoxLoyaltyMember = new System.Windows.Forms.CheckBox();
            this.textBoxMemberCard = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.textBoxmoblie = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelFax = new System.Windows.Forms.Label();
            this.labelmobile = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.labelloyaltyMember = new System.Windows.Forms.Label();
            this.labelMemberCard = new System.Windows.Forms.Label();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.labelwebsite = new System.Windows.Forms.Label();
            this.textBoxwebsite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxLoyaltyMember
            // 
            this.checkBoxLoyaltyMember.AutoSize = true;
            this.checkBoxLoyaltyMember.Location = new System.Drawing.Point(144, 168);
            this.checkBoxLoyaltyMember.Name = "checkBoxLoyaltyMember";
            this.checkBoxLoyaltyMember.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLoyaltyMember.TabIndex = 34;
            this.checkBoxLoyaltyMember.UseVisualStyleBackColor = true;
            // 
            // textBoxMemberCard
            // 
            this.textBoxMemberCard.Location = new System.Drawing.Point(144, 138);
            this.textBoxMemberCard.Name = "textBoxMemberCard";
            this.textBoxMemberCard.ReadOnly = true;
            this.textBoxMemberCard.Size = new System.Drawing.Size(130, 20);
            this.textBoxMemberCard.TabIndex = 33;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDOB.Location = new System.Drawing.Point(144, 108);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 32;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(144, 78);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(226, 20);
            this.textBoxEmail.TabIndex = 31;
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(144, 258);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(130, 20);
            this.textBoxFax.TabIndex = 37;
            // 
            // textBoxmoblie
            // 
            this.textBoxmoblie.Location = new System.Drawing.Point(144, 228);
            this.textBoxmoblie.Name = "textBoxmoblie";
            this.textBoxmoblie.Size = new System.Drawing.Size(130, 20);
            this.textBoxmoblie.TabIndex = 36;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(144, 192);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(130, 20);
            this.textBoxPhone.TabIndex = 35;
            // 
            // labelFax
            // 
            this.labelFax.AutoSize = true;
            this.labelFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFax.Location = new System.Drawing.Point(24, 258);
            this.labelFax.Name = "labelFax";
            this.labelFax.Size = new System.Drawing.Size(30, 16);
            this.labelFax.TabIndex = 30;
            this.labelFax.Text = "Fax";
            // 
            // labelmobile
            // 
            this.labelmobile.AutoSize = true;
            this.labelmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmobile.Location = new System.Drawing.Point(24, 228);
            this.labelmobile.Name = "labelmobile";
            this.labelmobile.Size = new System.Drawing.Size(49, 16);
            this.labelmobile.TabIndex = 29;
            this.labelmobile.Text = "Mobile";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(24, 198);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(47, 16);
            this.phone.TabIndex = 28;
            this.phone.Text = "Phone";
            // 
            // labelloyaltyMember
            // 
            this.labelloyaltyMember.AutoSize = true;
            this.labelloyaltyMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloyaltyMember.Location = new System.Drawing.Point(24, 168);
            this.labelloyaltyMember.Name = "labelloyaltyMember";
            this.labelloyaltyMember.Size = new System.Drawing.Size(101, 16);
            this.labelloyaltyMember.TabIndex = 27;
            this.labelloyaltyMember.Text = "LoyaltyMember";
            // 
            // labelMemberCard
            // 
            this.labelMemberCard.AutoSize = true;
            this.labelMemberCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberCard.Location = new System.Drawing.Point(24, 138);
            this.labelMemberCard.Name = "labelMemberCard";
            this.labelMemberCard.Size = new System.Drawing.Size(87, 16);
            this.labelMemberCard.TabIndex = 26;
            this.labelMemberCard.Text = "MemberCard";
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(24, 108);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(80, 16);
            this.labelDOB.TabIndex = 25;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(24, 78);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 16);
            this.labelEmail.TabIndex = 24;
            this.labelEmail.Text = "Email";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(274, 48);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 23;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(144, 48);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 22;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(24, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 16);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(98, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(192, 8);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(78, 16);
            this.labelCustomerID.TabIndex = 38;
            this.labelCustomerID.Text = "CustomerID";
            this.labelCustomerID.Click += new System.EventHandler(this.labelCustomerID_Click);
            // 
            // labelwebsite
            // 
            this.labelwebsite.AutoSize = true;
            this.labelwebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwebsite.Location = new System.Drawing.Point(24, 288);
            this.labelwebsite.Name = "labelwebsite";
            this.labelwebsite.Size = new System.Drawing.Size(58, 16);
            this.labelwebsite.TabIndex = 39;
            this.labelwebsite.Text = "Website";
            // 
            // textBoxwebsite
            // 
            this.textBoxwebsite.Location = new System.Drawing.Point(144, 287);
            this.textBoxwebsite.Name = "textBoxwebsite";
            this.textBoxwebsite.Size = new System.Drawing.Size(130, 20);
            this.textBoxwebsite.TabIndex = 40;
            // 
            // CustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 313);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxwebsite);
            this.Controls.Add(this.labelwebsite);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.checkBoxLoyaltyMember);
            this.Controls.Add(this.textBoxMemberCard);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxFax);
            this.Controls.Add(this.textBoxmoblie);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelFax);
            this.Controls.Add(this.labelmobile);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.labelloyaltyMember);
            this.Controls.Add(this.labelMemberCard);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerCard";
            this.Text = "CustomerCard";
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxLoyaltyMember;
        private System.Windows.Forms.TextBox textBoxMemberCard;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.TextBox textBoxmoblie;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelFax;
        private System.Windows.Forms.Label labelmobile;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label labelloyaltyMember;
        private System.Windows.Forms.Label labelMemberCard;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.TextBox textBoxwebsite;
        private System.Windows.Forms.Label labelwebsite;
    }
}