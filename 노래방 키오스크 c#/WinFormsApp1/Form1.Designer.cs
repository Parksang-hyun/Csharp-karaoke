namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tb_login = new System.Windows.Forms.TextBox();
            btn_login = new System.Windows.Forms.Button();
            btn_make = new System.Windows.Forms.Button();
            tb_make = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // tb_login
            // 
            tb_login.Font = new System.Drawing.Font("한컴 훈민정음 가로쓰기", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tb_login.Location = new System.Drawing.Point(338, 351);
            tb_login.Name = "tb_login";
            tb_login.PasswordChar = '@';
            tb_login.Size = new System.Drawing.Size(100, 20);
            tb_login.TabIndex = 0;
            // 
            // btn_login
            // 
            btn_login.Font = new System.Drawing.Font("한컴 훈민정음 가로쓰기", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_login.Location = new System.Drawing.Point(444, 351);
            btn_login.Name = "btn_login";
            btn_login.Size = new System.Drawing.Size(75, 23);
            btn_login.TabIndex = 1;
            btn_login.Text = "로그인";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_make
            // 
            btn_make.Font = new System.Drawing.Font("한컴 훈민정음 가로쓰기", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_make.Location = new System.Drawing.Point(444, 380);
            btn_make.Name = "btn_make";
            btn_make.Size = new System.Drawing.Size(75, 23);
            btn_make.TabIndex = 2;
            btn_make.Text = "가입하기";
            btn_make.UseVisualStyleBackColor = true;
            btn_make.Click += btn_make_Click;
            // 
            // tb_make
            // 
            tb_make.Font = new System.Drawing.Font("한컴 훈민정음 가로쓰기", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tb_make.Location = new System.Drawing.Point(338, 381);
            tb_make.Name = "tb_make";
            tb_make.Size = new System.Drawing.Size(100, 20);
            tb_make.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tb_make);
            Controls.Add(btn_make);
            Controls.Add(btn_login);
            Controls.Add(tb_login);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_make;
        private System.Windows.Forms.TextBox tb_make;
    }
}