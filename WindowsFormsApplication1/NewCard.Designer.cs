namespace WindowsFormsApplication1
{
    partial class NewCard
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelMemberCard = new System.Windows.Forms.Label();
            this.labelloyaltyMember = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.labelmobile = new System.Windows.Forms.Label();
            this.labelFax = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.textBoxMemberCard = new System.Windows.Forms.TextBox();
            this.checkBoxLoyaltyMember = new System.Windows.Forms.CheckBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBox1moblie = new System.Windows.Forms.TextBox();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelwebsite = new System.Windows.Forms.Label();
            this.textBoxwebsite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(104, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(30, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(150, 50);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 3;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(280, 50);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 4;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(30, 80);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 16);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(30, 110);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(80, 16);
            this.labelDOB.TabIndex = 6;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelMemberCard
            // 
            this.labelMemberCard.AutoSize = true;
            this.labelMemberCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberCard.Location = new System.Drawing.Point(30, 140);
            this.labelMemberCard.Name = "labelMemberCard";
            this.labelMemberCard.Size = new System.Drawing.Size(87, 16);
            this.labelMemberCard.TabIndex = 7;
            this.labelMemberCard.Text = "MemberCard";
            // 
            // labelloyaltyMember
            // 
            this.labelloyaltyMember.AutoSize = true;
            this.labelloyaltyMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloyaltyMember.Location = new System.Drawing.Point(30, 170);
            this.labelloyaltyMember.Name = "labelloyaltyMember";
            this.labelloyaltyMember.Size = new System.Drawing.Size(101, 16);
            this.labelloyaltyMember.TabIndex = 8;
            this.labelloyaltyMember.Text = "LoyaltyMember";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(30, 200);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(47, 16);
            this.phone.TabIndex = 9;
            this.phone.Text = "Phone";
            // 
            // labelmobile
            // 
            this.labelmobile.AutoSize = true;
            this.labelmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmobile.Location = new System.Drawing.Point(30, 230);
            this.labelmobile.Name = "labelmobile";
            this.labelmobile.Size = new System.Drawing.Size(49, 16);
            this.labelmobile.TabIndex = 10;
            this.labelmobile.Text = "Mobile";
            // 
            // labelFax
            // 
            this.labelFax.AutoSize = true;
            this.labelFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFax.Location = new System.Drawing.Point(30, 260);
            this.labelFax.Name = "labelFax";
            this.labelFax.Size = new System.Drawing.Size(30, 16);
            this.labelFax.TabIndex = 11;
            this.labelFax.Text = "Fax";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(150, 80);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(226, 20);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDOB.Location = new System.Drawing.Point(150, 110);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 13;
            // 
            // textBoxMemberCard
            // 
            this.textBoxMemberCard.Location = new System.Drawing.Point(150, 140);
            this.textBoxMemberCard.Name = "textBoxMemberCard";
            this.textBoxMemberCard.Size = new System.Drawing.Size(130, 20);
            this.textBoxMemberCard.TabIndex = 14;
            // 
            // checkBoxLoyaltyMember
            // 
            this.checkBoxLoyaltyMember.AutoSize = true;
            this.checkBoxLoyaltyMember.Location = new System.Drawing.Point(150, 170);
            this.checkBoxLoyaltyMember.Name = "checkBoxLoyaltyMember";
            this.checkBoxLoyaltyMember.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLoyaltyMember.TabIndex = 15;
            this.checkBoxLoyaltyMember.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(150, 200);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(130, 20);
            this.textBoxPhone.TabIndex = 16;
            // 
            // textBox1moblie
            // 
            this.textBox1moblie.Location = new System.Drawing.Point(150, 230);
            this.textBox1moblie.Name = "textBox1moblie";
            this.textBox1moblie.Size = new System.Drawing.Size(130, 20);
            this.textBox1moblie.TabIndex = 17;
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(150, 260);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(130, 20);
            this.textBoxFax.TabIndex = 18;
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // labelwebsite
            // 
            this.labelwebsite.AutoSize = true;
            this.labelwebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwebsite.Location = new System.Drawing.Point(30, 290);
            this.labelwebsite.Name = "labelwebsite";
            this.labelwebsite.Size = new System.Drawing.Size(58, 16);
            this.labelwebsite.TabIndex = 19;
            this.labelwebsite.Text = "Website";
            // 
            // textBoxwebsite
            // 
            this.textBoxwebsite.Location = new System.Drawing.Point(150, 290);
            this.textBoxwebsite.Name = "textBoxwebsite";
            this.textBoxwebsite.Size = new System.Drawing.Size(130, 20);
            this.textBoxwebsite.TabIndex = 20;
            // 
            // NewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 320);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxwebsite);
            this.Controls.Add(this.labelwebsite);
            this.Controls.Add(this.textBoxFax);
            this.Controls.Add(this.textBox1moblie);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.checkBoxLoyaltyMember);
            this.Controls.Add(this.textBoxMemberCard);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.textBoxEmail);
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
            this.Name = "NewCard";
            this.Text = "AddNew";
            this.Load += new System.EventHandler(this.AddNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelMemberCard;
        private System.Windows.Forms.Label labelloyaltyMember;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label labelmobile;
        private System.Windows.Forms.Label labelFax;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox textBoxMemberCard;
        private System.Windows.Forms.CheckBox checkBoxLoyaltyMember;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBox1moblie;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.TextBox textBoxwebsite;
        private System.Windows.Forms.Label labelwebsite;
    }
}