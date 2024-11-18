namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            btn_pay = new System.Windows.Forms.Button();
            combo_songs = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btn_pay
            // 
            btn_pay.BackColor = System.Drawing.Color.Transparent;
            btn_pay.FlatAppearance.BorderSize = 3;
            btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_pay.Font = new System.Drawing.Font("한컴 훈민정음 가로쓰기", 11.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_pay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_pay.Location = new System.Drawing.Point(478, 264);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new System.Drawing.Size(91, 36);
            btn_pay.TabIndex = 0;
            btn_pay.Text = "결제";
            btn_pay.UseVisualStyleBackColor = false;
            btn_pay.Click += btn_pay_Click;
            // 
            // combo_songs
            // 
            combo_songs.FormattingEnabled = true;
            combo_songs.Items.AddRange(new object[] { "1000원에 3곡", "2000원에 6곡", "3000원에 10곡", "5000원에 17곡", "10000원에 36곡" });
            combo_songs.Location = new System.Drawing.Point(351, 272);
            combo_songs.Name = "combo_songs";
            combo_songs.Size = new System.Drawing.Size(121, 23);
            combo_songs.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("한컴 훈민정음 가로쓰기", 11.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(182, 274);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(163, 17);
            label1.TabIndex = 2;
            label1.Text = "곡수를 선택해주세요!";
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(combo_songs);
            Controls.Add(btn_pay);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.ComboBox combo_songs;
        private System.Windows.Forms.Label label1;
    }
}