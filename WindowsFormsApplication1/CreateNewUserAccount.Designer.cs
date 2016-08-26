namespace WindowsFormsApplication1
{
    partial class CreateNewUserAccount
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
            this.labelmemberid = new System.Windows.Forms.Label();
            this.labelmembercard = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelmemberid
            // 
            this.labelmemberid.AutoSize = true;
            this.labelmemberid.Location = new System.Drawing.Point(48, 37);
            this.labelmemberid.Name = "labelmemberid";
            this.labelmemberid.Size = new System.Drawing.Size(56, 13);
            this.labelmemberid.TabIndex = 0;
            this.labelmemberid.Text = "MemberID";
            // 
            // labelmembercard
            // 
            this.labelmembercard.AutoSize = true;
            this.labelmembercard.Location = new System.Drawing.Point(120, 37);
            this.labelmembercard.Name = "labelmembercard";
            this.labelmembercard.Size = new System.Drawing.Size(0, 13);
            this.labelmembercard.TabIndex = 1;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Location = new System.Drawing.Point(48, 79);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(29, 13);
            this.labelusername.TabIndex = 2;
            this.labelusername.Text = "User";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Location = new System.Drawing.Point(48, 121);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(53, 13);
            this.labelpassword.TabIndex = 3;
            this.labelpassword.Text = "Password";
            // 
            // textBoxuser
            // 
            this.textBoxuser.Location = new System.Drawing.Point(123, 71);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(100, 20);
            this.textBoxuser.TabIndex = 4;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(123, 121);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxpassword.TabIndex = 5;
            this.textBoxpassword.UseSystemPasswordChar = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(51, 199);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(147, 198);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // CreateNewUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.labelmembercard);
            this.Controls.Add(this.labelmemberid);
            this.MinimizeBox = false;
            this.Name = "CreateNewUserAccount";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CreateNewUserAccount";
            this.Load += new System.EventHandler(this.CreateNewUserAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmemberid;
        private System.Windows.Forms.Label labelmembercard;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btncancel;
    }
}