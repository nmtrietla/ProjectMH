namespace ProjectMaHoa
{
    partial class Form2
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_p = new System.Windows.Forms.Label();
            this.lbl_plain = new System.Windows.Forms.Label();
            this.lbl_q = new System.Windows.Forms.Label();
            this.rich_txt_plain = new System.Windows.Forms.RichTextBox();
            this.rich_txt_cipher = new System.Windows.Forms.RichTextBox();
            this.rich_txt_apterdecrypt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rich_txt_key = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_box_size = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_box_hash = new System.Windows.Forms.ComboBox();
            this.button_gen_key = new System.Windows.Forms.Button();
            this.button_encyprt = new System.Windows.Forms.Button();
            this.button_decypt = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.button_sign = new System.Windows.Forms.Button();
            this.button_verify = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rich_txt_sign = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(593, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "Thông điệp đã giải mã";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Thông điệp đã mã hóa";
            // 
            // lbl_p
            // 
            this.lbl_p.AutoSize = true;
            this.lbl_p.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p.ForeColor = System.Drawing.Color.Red;
            this.lbl_p.Location = new System.Drawing.Point(132, 87);
            this.lbl_p.Name = "lbl_p";
            this.lbl_p.Size = new System.Drawing.Size(0, 19);
            this.lbl_p.TabIndex = 34;
            // 
            // lbl_plain
            // 
            this.lbl_plain.AutoSize = true;
            this.lbl_plain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plain.Location = new System.Drawing.Point(17, 9);
            this.lbl_plain.Name = "lbl_plain";
            this.lbl_plain.Size = new System.Drawing.Size(136, 22);
            this.lbl_plain.TabIndex = 32;
            this.lbl_plain.Text = "Thông điệp gốc";
            // 
            // lbl_q
            // 
            this.lbl_q.AutoSize = true;
            this.lbl_q.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_q.ForeColor = System.Drawing.Color.Red;
            this.lbl_q.Location = new System.Drawing.Point(132, 119);
            this.lbl_q.Name = "lbl_q";
            this.lbl_q.Size = new System.Drawing.Size(0, 19);
            this.lbl_q.TabIndex = 31;
            // 
            // rich_txt_plain
            // 
            this.rich_txt_plain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_txt_plain.Location = new System.Drawing.Point(21, 34);
            this.rich_txt_plain.Name = "rich_txt_plain";
            this.rich_txt_plain.Size = new System.Drawing.Size(255, 96);
            this.rich_txt_plain.TabIndex = 39;
            this.rich_txt_plain.Text = "";
            this.rich_txt_plain.TextChanged += new System.EventHandler(this.rich_txt_plain_TextChanged);
            // 
            // rich_txt_cipher
            // 
            this.rich_txt_cipher.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_txt_cipher.Location = new System.Drawing.Point(309, 34);
            this.rich_txt_cipher.Name = "rich_txt_cipher";
            this.rich_txt_cipher.Size = new System.Drawing.Size(255, 96);
            this.rich_txt_cipher.TabIndex = 40;
            this.rich_txt_cipher.Text = "";
            // 
            // rich_txt_apterdecrypt
            // 
            this.rich_txt_apterdecrypt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_txt_apterdecrypt.Location = new System.Drawing.Point(598, 34);
            this.rich_txt_apterdecrypt.Name = "rich_txt_apterdecrypt";
            this.rich_txt_apterdecrypt.Size = new System.Drawing.Size(255, 96);
            this.rich_txt_apterdecrypt.TabIndex = 41;
            this.rich_txt_apterdecrypt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Khóa";
            // 
            // rich_txt_key
            // 
            this.rich_txt_key.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_txt_key.Location = new System.Drawing.Point(29, 174);
            this.rich_txt_key.Name = "rich_txt_key";
            this.rich_txt_key.Size = new System.Drawing.Size(823, 128);
            this.rich_txt_key.TabIndex = 43;
            this.rich_txt_key.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Kích thước";
            // 
            // combo_box_size
            // 
            this.combo_box_size.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_box_size.FormattingEnabled = true;
            this.combo_box_size.Location = new System.Drawing.Point(21, 344);
            this.combo_box_size.Name = "combo_box_size";
            this.combo_box_size.Size = new System.Drawing.Size(121, 23);
            this.combo_box_size.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "Hàm băm";
            // 
            // combo_box_hash
            // 
            this.combo_box_hash.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_box_hash.FormattingEnabled = true;
            this.combo_box_hash.Location = new System.Drawing.Point(183, 344);
            this.combo_box_hash.Name = "combo_box_hash";
            this.combo_box_hash.Size = new System.Drawing.Size(121, 23);
            this.combo_box_hash.TabIndex = 47;
            // 
            // button_gen_key
            // 
            this.button_gen_key.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gen_key.Location = new System.Drawing.Point(348, 340);
            this.button_gen_key.Name = "button_gen_key";
            this.button_gen_key.Size = new System.Drawing.Size(90, 28);
            this.button_gen_key.TabIndex = 48;
            this.button_gen_key.Text = "Tạo khóa";
            this.button_gen_key.UseVisualStyleBackColor = true;
            this.button_gen_key.Click += new System.EventHandler(this.button_gen_key_Click);
            // 
            // button_encyprt
            // 
            this.button_encyprt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_encyprt.Location = new System.Drawing.Point(447, 340);
            this.button_encyprt.Name = "button_encyprt";
            this.button_encyprt.Size = new System.Drawing.Size(90, 28);
            this.button_encyprt.TabIndex = 49;
            this.button_encyprt.Text = "Mã hóa";
            this.button_encyprt.UseVisualStyleBackColor = true;
            this.button_encyprt.Click += new System.EventHandler(this.button_encyprt_Click);
            // 
            // button_decypt
            // 
            this.button_decypt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_decypt.Location = new System.Drawing.Point(548, 340);
            this.button_decypt.Name = "button_decypt";
            this.button_decypt.Size = new System.Drawing.Size(90, 28);
            this.button_decypt.TabIndex = 50;
            this.button_decypt.Text = "Giải mã";
            this.button_decypt.UseVisualStyleBackColor = true;
            this.button_decypt.Click += new System.EventHandler(this.button_decypt_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(346, 322);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(104, 16);
            this.lbl_result.TabIndex = 51;
            this.lbl_result.Text = "label_result";
            // 
            // button_sign
            // 
            this.button_sign.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sign.Location = new System.Drawing.Point(664, 340);
            this.button_sign.Name = "button_sign";
            this.button_sign.Size = new System.Drawing.Size(90, 28);
            this.button_sign.TabIndex = 52;
            this.button_sign.Text = "Ký VB";
            this.button_sign.UseVisualStyleBackColor = true;
            this.button_sign.Click += new System.EventHandler(this.button_sign_Click);
            // 
            // button_verify
            // 
            this.button_verify.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_verify.Location = new System.Drawing.Point(762, 340);
            this.button_verify.Name = "button_verify";
            this.button_verify.Size = new System.Drawing.Size(90, 28);
            this.button_verify.TabIndex = 53;
            this.button_verify.Text = "Xác thực";
            this.button_verify.UseVisualStyleBackColor = true;
            this.button_verify.Click += new System.EventHandler(this.button_verify_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 22);
            this.label4.TabIndex = 54;
            this.label4.Text = "Thông điệp đã ký";
            // 
            // rich_txt_sign
            // 
            this.rich_txt_sign.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_txt_sign.Location = new System.Drawing.Point(21, 412);
            this.rich_txt_sign.Name = "rich_txt_sign";
            this.rich_txt_sign.Size = new System.Drawing.Size(831, 91);
            this.rich_txt_sign.TabIndex = 55;
            this.rich_txt_sign.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 515);
            this.Controls.Add(this.rich_txt_sign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_verify);
            this.Controls.Add(this.button_sign);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.button_decypt);
            this.Controls.Add(this.button_encyprt);
            this.Controls.Add(this.button_gen_key);
            this.Controls.Add(this.combo_box_hash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_box_size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rich_txt_key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rich_txt_apterdecrypt);
            this.Controls.Add(this.rich_txt_cipher);
            this.Controls.Add(this.rich_txt_plain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_p);
            this.Controls.Add(this.lbl_plain);
            this.Controls.Add(this.lbl_q);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_p;
        private System.Windows.Forms.Label lbl_plain;
        private System.Windows.Forms.Label lbl_q;
        private System.Windows.Forms.RichTextBox rich_txt_plain;
        private System.Windows.Forms.RichTextBox rich_txt_cipher;
        private System.Windows.Forms.RichTextBox rich_txt_apterdecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rich_txt_key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_box_size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_box_hash;
        private System.Windows.Forms.Button button_gen_key;
        private System.Windows.Forms.Button button_encyprt;
        private System.Windows.Forms.Button button_decypt;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button button_sign;
        private System.Windows.Forms.Button button_verify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rich_txt_sign;
    }
}