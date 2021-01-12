using ProjectMaHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;

namespace ProjectMaHoa
{
    public partial class Form2 : Form
    {
        RSAParameters rsa_paras;
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        byte[] cipher_text;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.lbl_result.Visible = false;

            this.combo_box_size.DisplayMember = "Text";
            this.combo_box_size.ValueMember = "Value";
            var size_items = new[] {
                new { Text = "512", Value = "512" },
                new { Text = "1024", Value = "1024" },
                new { Text = "2048", Value = "2048" }
            };
            this.combo_box_size.DataSource = size_items;
            this.combo_box_size.SelectedIndex = 0;

            this.combo_box_hash.DisplayMember = "Text";
            this.combo_box_hash.ValueMember = "Value";
            var hash_items = new[] {
                new { Text = "SHA1", Value = "SHA1" },
                new { Text = "SHA256", Value = "SHA256" },
                new { Text = "SHA512", Value = "SHA512" }
            };
            this.combo_box_hash.DataSource = hash_items;
            this.combo_box_hash.SelectedIndex = 0;

            this.button_gen_key.Select();
        }

        private void button_gen_key_Click(object sender, EventArgs e)
        {
            try
            {
                int _size = Convert.ToInt32(this.combo_box_size.SelectedValue);
                var _rsa = new RSACryptoServiceProvider(_size);
                var xml_key = _rsa.ToXmlString(true);
                this.rich_txt_key.Text = xml_key.ToString();
                Get_RSA_Parameters(_rsa.ExportParameters(true));
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Vui lòng kiểm tra lại Kích thước!", "Thông báo");
                MessageBox.Show(ex.ToString(), "Thông báo");
            }
        }

        private void button_encyprt_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] message = Encoding.UTF8.GetBytes(this.rich_txt_plain.Text.ToString().Trim());
                var rsa = new RSACryptoServiceProvider();
                rsa.ImportParameters(rsa_paras);
                var ciphertext = rsa.Encrypt(message, false);
                cipher_text = ciphertext;
                this.rich_txt_cipher.Text = ByteConverter.GetString(ciphertext);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Vui lòng kiểm tra lại Kích thước!", "Thông báo");
                MessageBox.Show(ex.ToString(), "Thông báo");
            }
        }

        private void button_decypt_Click(object sender, EventArgs e)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(rsa_paras);
            var text_decrypt = rsa.Decrypt(cipher_text, false);
            //string[] str = Encoding.UTF8.GetString(text_decrypt).Split(':');
            this.rich_txt_apterdecrypt.Text = Encoding.UTF8.GetString(text_decrypt);
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            try
            {
                string hash_code = this.combo_box_hash.SelectedValue.ToString();
                string message = this.rich_txt_plain.Text.ToString().Trim();
                string signed_text = RSA_1.SignData(message, rsa_paras, hash_code);
                this.rich_txt_sign.Text = signed_text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo");
            }
        }

        private void button_verify_Click(object sender, EventArgs e)
        {
            try
            {
                string hash_code = this.combo_box_hash.SelectedValue.ToString();
                string original_message = this.rich_txt_plain.Text.ToString().Trim();
                string signed_message = this.rich_txt_sign.Text.ToString().Trim();
                bool verify = RSA_1.VerifyData(original_message, signed_message, rsa_paras, hash_code);

                if (verify)
                    MessageBox.Show("Xác thực thành công", "Thông báo");
                else
                    MessageBox.Show("Xác thực thất bại", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo");
            }
        }

        private void rich_txt_plain_TextChanged(object sender, EventArgs e)
        {
            this.lbl_plain.Text = "Thông điệp gốc (" + this.rich_txt_plain.Text.Length + ")";
        }

        private void Get_RSA_Parameters(RSAParameters rsa_parameters)
        {
            byte[] _D = rsa_parameters.D; //số mũ (khóa) bí mật
            byte[] _DP = rsa_parameters.DP; //số mũ 1, dp = d (mod p)
            byte[] _DQ = rsa_parameters.DQ; //số mũ 2, dq = d (mod q)
            byte[] _Exponent = rsa_parameters.Exponent; //số mũ (khóa) công khai
            byte[] _InverseQ = rsa_parameters.InverseQ; //nghịch đảo InverseQ(q) = 1 (mod p)
            byte[] _Modulus = rsa_parameters.Modulus; //n = p * q
            byte[] _P = rsa_parameters.P; //số nguyên tố 1
            byte[] _Q = rsa_parameters.Q; //số nguyên tố 2
            
            BigInteger e = new BigInteger(RSA_2.CopyAndReverse(_Exponent));
            BigInteger modulus = new BigInteger(RSA_2.CopyAndReverse(_Modulus));
            BigInteger p = new BigInteger(RSA_2.CopyAndReverse(_P));
            BigInteger q = new BigInteger(RSA_2.CopyAndReverse(_Q));

            var n = p * q;
            var phiOfN = n - p - q + 1; // OR: (p - 1) * (q - 1);

            var d = RSA_2.ModInverse(e, phiOfN);
            Assert.Equal(1, (d * e) % phiOfN);
            var dp = d % (p - 1);
            var dq = d % (q - 1);

            var qInv = RSA_2.ModInverse(q, p);

            rsa_paras = new RSAParameters
            {
                D = RSA_2.CopyAndReverse(d.ToByteArray()),
                DP = RSA_2.CopyAndReverse(dp.ToByteArray()),
                DQ = RSA_2.CopyAndReverse(dq.ToByteArray()),
                Exponent = _Exponent,
                InverseQ = RSA_2.CopyAndReverse(qInv.ToByteArray()),
                Modulus = _Modulus,
                P = _P,
                Q = _Q
            };

            this.lbl_result.Text = "e: " + e.ToString() + " ; n: " + n.ToString();
            this.lbl_result.Visible = true;
        }
    }
}
