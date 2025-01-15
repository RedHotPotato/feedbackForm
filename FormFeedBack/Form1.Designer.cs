namespace FormFeedBack
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRating5 = new System.Windows.Forms.Button();
            this.btnRating4 = new System.Windows.Forms.Button();
            this.btnRating3 = new System.Windows.Forms.Button();
            this.btnRating2 = new System.Windows.Forms.Button();
            this.btnRating1 = new System.Windows.Forms.Button();
            this.textBoxFeedback = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.BtnSubmitFeedback = new System.Windows.Forms.Button();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.BtnAdminLogin = new System.Windows.Forms.Button();
            this.BtnDeleteFeedback = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.listBoxFeedbacks = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabAdmin);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 434);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.ClearListbox);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnRating5);
            this.tabPage1.Controls.Add(this.btnRating4);
            this.tabPage1.Controls.Add(this.btnRating3);
            this.tabPage1.Controls.Add(this.btnRating2);
            this.tabPage1.Controls.Add(this.btnRating1);
            this.tabPage1.Controls.Add(this.textBoxFeedback);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.BtnSubmitFeedback);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(967, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FeedBack";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // btnRating5
            // 
            this.btnRating5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRating5.Image = global::FormFeedBack.Properties.Resources.star;
            this.btnRating5.Location = new System.Drawing.Point(668, 104);
            this.btnRating5.Margin = new System.Windows.Forms.Padding(2);
            this.btnRating5.Name = "btnRating5";
            this.btnRating5.Size = new System.Drawing.Size(115, 103);
            this.btnRating5.TabIndex = 7;
            this.btnRating5.Text = "5";
            this.btnRating5.UseVisualStyleBackColor = true;
            this.btnRating5.Click += new System.EventHandler(this.BtnRating_Click);
            // 
            // btnRating4
            // 
            this.btnRating4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRating4.Image = global::FormFeedBack.Properties.Resources.star;
            this.btnRating4.Location = new System.Drawing.Point(549, 104);
            this.btnRating4.Margin = new System.Windows.Forms.Padding(2);
            this.btnRating4.Name = "btnRating4";
            this.btnRating4.Size = new System.Drawing.Size(115, 103);
            this.btnRating4.TabIndex = 6;
            this.btnRating4.Text = "4";
            this.btnRating4.UseVisualStyleBackColor = true;
            this.btnRating4.Click += new System.EventHandler(this.BtnRating_Click);
            // 
            // btnRating3
            // 
            this.btnRating3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRating3.Image = global::FormFeedBack.Properties.Resources.star;
            this.btnRating3.Location = new System.Drawing.Point(430, 104);
            this.btnRating3.Margin = new System.Windows.Forms.Padding(2);
            this.btnRating3.Name = "btnRating3";
            this.btnRating3.Size = new System.Drawing.Size(115, 103);
            this.btnRating3.TabIndex = 5;
            this.btnRating3.Text = "3";
            this.btnRating3.UseVisualStyleBackColor = true;
            this.btnRating3.Click += new System.EventHandler(this.BtnRating_Click);
            // 
            // btnRating2
            // 
            this.btnRating2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRating2.Image = global::FormFeedBack.Properties.Resources.star;
            this.btnRating2.Location = new System.Drawing.Point(310, 104);
            this.btnRating2.Margin = new System.Windows.Forms.Padding(2);
            this.btnRating2.Name = "btnRating2";
            this.btnRating2.Size = new System.Drawing.Size(116, 103);
            this.btnRating2.TabIndex = 4;
            this.btnRating2.Text = "2";
            this.btnRating2.UseVisualStyleBackColor = true;
            this.btnRating2.Click += new System.EventHandler(this.BtnRating_Click);
            // 
            // btnRating1
            // 
            this.btnRating1.BackgroundImage = global::FormFeedBack.Properties.Resources.full;
            this.btnRating1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRating1.Image = global::FormFeedBack.Properties.Resources.star;
            this.btnRating1.Location = new System.Drawing.Point(191, 104);
            this.btnRating1.Margin = new System.Windows.Forms.Padding(2);
            this.btnRating1.Name = "btnRating1";
            this.btnRating1.Size = new System.Drawing.Size(116, 103);
            this.btnRating1.TabIndex = 3;
            this.btnRating1.Text = "1";
            this.btnRating1.UseVisualStyleBackColor = true;
            this.btnRating1.Click += new System.EventHandler(this.BtnRating_Click);
            // 
            // textBoxFeedback
            // 
            this.textBoxFeedback.Location = new System.Drawing.Point(191, 211);
            this.textBoxFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFeedback.Multiline = true;
            this.textBoxFeedback.Name = "textBoxFeedback";
            this.textBoxFeedback.Size = new System.Drawing.Size(591, 122);
            this.textBoxFeedback.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(191, 78);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(240, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // BtnSubmitFeedback
            // 
            this.BtnSubmitFeedback.Location = new System.Drawing.Point(191, 352);
            this.BtnSubmitFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSubmitFeedback.Name = "BtnSubmitFeedback";
            this.BtnSubmitFeedback.Size = new System.Drawing.Size(165, 49);
            this.BtnSubmitFeedback.TabIndex = 0;
            this.BtnSubmitFeedback.Text = "Submit Feedback";
            this.BtnSubmitFeedback.UseVisualStyleBackColor = true;
            this.BtnSubmitFeedback.Click += new System.EventHandler(this.BtnSubmitFeedback_Click_1);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.label5);
            this.tabAdmin.Controls.Add(this.label4);
            this.tabAdmin.Controls.Add(this.BtnAdminLogin);
            this.tabAdmin.Controls.Add(this.BtnDeleteFeedback);
            this.tabAdmin.Controls.Add(this.txtAdminPassword);
            this.tabAdmin.Controls.Add(this.listBoxFeedbacks);
            this.tabAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.tabAdmin.Size = new System.Drawing.Size(967, 405);
            this.tabAdmin.TabIndex = 1;
            this.tabAdmin.Text = "Admin Access";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // BtnAdminLogin
            // 
            this.BtnAdminLogin.Location = new System.Drawing.Point(108, 123);
            this.BtnAdminLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdminLogin.Name = "BtnAdminLogin";
            this.BtnAdminLogin.Size = new System.Drawing.Size(135, 39);
            this.BtnAdminLogin.TabIndex = 3;
            this.BtnAdminLogin.Text = "Log In";
            this.BtnAdminLogin.UseVisualStyleBackColor = true;
            this.BtnAdminLogin.Click += new System.EventHandler(this.BtnAdminLogin_Click_1);
            // 
            // BtnDeleteFeedback
            // 
            this.BtnDeleteFeedback.Location = new System.Drawing.Point(346, 327);
            this.BtnDeleteFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteFeedback.Name = "BtnDeleteFeedback";
            this.BtnDeleteFeedback.Size = new System.Drawing.Size(154, 42);
            this.BtnDeleteFeedback.TabIndex = 2;
            this.BtnDeleteFeedback.Text = "Remove Feedback";
            this.BtnDeleteFeedback.UseVisualStyleBackColor = true;
            this.BtnDeleteFeedback.Click += new System.EventHandler(this.BtnDeleteFeedback_Click_1);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(108, 97);
            this.txtAdminPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(201, 22);
            this.txtAdminPassword.TabIndex = 1;
            // 
            // listBoxFeedbacks
            // 
            this.listBoxFeedbacks.FormattingEnabled = true;
            this.listBoxFeedbacks.ItemHeight = 16;
            this.listBoxFeedbacks.Location = new System.Drawing.Point(346, 95);
            this.listBoxFeedbacks.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFeedbacks.Name = "listBoxFeedbacks";
            this.listBoxFeedbacks.Size = new System.Drawing.Size(598, 228);
            this.listBoxFeedbacks.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "Smart Student House Feedback";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "Admin Dashboard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 455);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.Button BtnSubmitFeedback;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFeedback;
        private System.Windows.Forms.ListBox listBoxFeedbacks;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Button BtnAdminLogin;
        private System.Windows.Forms.Button BtnDeleteFeedback;
        private System.Windows.Forms.Button btnRating5;
        private System.Windows.Forms.Button btnRating4;
        private System.Windows.Forms.Button btnRating3;
        private System.Windows.Forms.Button btnRating2;
        private System.Windows.Forms.Button btnRating1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

