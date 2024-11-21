using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;
using System.IO;
using System.Data;

namespace AwarderPro
{
    public partial class Form1 : Form
    {
        public int id;
        QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
        Image certificate;
        bool isGenerated = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            id = db_table.RowCount;
            db_table.Rows.Add(id, input_name.Text,
                input_surname.Text,
                input_certtype.Text,
                input_date.Text,
                input_issuedby.Text,
                input_company.Text);
        }

        private void GenCertificate()
        {

            Bitmap certificate_image_bitmap = new Bitmap(1920, 1080);
            Font drawFont = new Font("Montserrat", 50);
            Graphics flagGraphics = Graphics.FromImage(certificate_image_bitmap);
            flagGraphics.Clear(Color.White);

            try
            {

                Font titleFont = new Font("Montserrat", 70);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                string title = "Certificate";
                SizeF titleSize = flagGraphics.MeasureString(title, titleFont);
                float titleX = (certificate_image_bitmap.Width - titleSize.Width) / 2;
                float titleY = 200;
                flagGraphics.DrawString(title, titleFont, drawBrush, titleX, titleY);


                Font certFont = new Font("Montserrat", 30);
                string certType = input_certtype.Text;
                SizeF certTypeSize = flagGraphics.MeasureString(certType, certFont);
                float certTypeX = (certificate_image_bitmap.Width - certTypeSize.Width) / 2;
                float certTypeY = 310;
                flagGraphics.DrawString(certType, certFont, drawBrush, certTypeX, certTypeY);

                Font nameFont = new Font("Montserrat", 85);
                drawBrush.Color = Color.Purple;
                string name_surname = input_name.Text + " " + input_surname.Text;
                SizeF name_surnameSize = flagGraphics.MeasureString(name_surname, nameFont);
                float namesurX = (certificate_image_bitmap.Width - name_surnameSize.Width) / 2;
                float namesurY = 480;
                flagGraphics.DrawString(name_surname, nameFont, drawBrush, namesurX, namesurY);

                drawFont = new Font("Montserrat", 25);
                drawBrush = new SolidBrush(Color.Black);

                string date = "Date of issue\n" + input_date.Text;
                SizeF dateSize = flagGraphics.MeasureString(date, drawFont);
                float dateX = certificate_image_bitmap.Width - dateSize.Width - 70;
                float dateY = certificate_image_bitmap.Height - dateSize.Height - 50;
                flagGraphics.DrawString(date, drawFont, drawBrush, dateX, dateY);


                string issuedby = "Issued by\n" + input_issuedby.Text;
                SizeF issuedbySize = flagGraphics.MeasureString(issuedby, drawFont);
                float issuedbyX = 70;
                float issuedbyY = certificate_image_bitmap.Height - issuedbySize.Height - 50;
                flagGraphics.DrawString(issuedby, drawFont, drawBrush, issuedbyX, issuedbyY);
                string qrcode_info = string.Format("This certificate was issued by {0} on behalf of {1} by the company or institution of {2}. Unique certificate number: {3}\r\nDate of issue: {4}",
                    name_surname, input_issuedby.Text, input_company.Text, id, input_date.Text);
                QRCodeData qrdata = qrCodeGenerator.CreateQrCode(qrcode_info, QRCodeGenerator.ECCLevel.L);

                QRCode qrcode = new QRCode(qrdata);
                Bitmap qrCodeImg = qrcode.GetGraphic(10);
                int qrCodeSize = 150;
                int qrCodeX = (certificate_image_bitmap.Width - qrCodeSize) / 2;
                int qrCodeY = certificate_image_bitmap.Height - qrCodeSize - 50;

                flagGraphics.DrawImage(qrCodeImg, qrCodeX, qrCodeY, qrCodeSize, qrCodeSize);

                certificate = certificate_image_bitmap;

                certificate_image.Image = certificate;
                certificate_image.SizeMode = PictureBoxSizeMode.Zoom;

                isGenerated = true;

                MessageBox.Show("Сертификат успешно сгенерирован!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании сертификата: " + ex.Message);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            GenCertificate();
        }

        private void addtodb_btn_Click(object sender, EventArgs e)
        {
            btn_add_Click(sender, e);
        }

        private void to_db_button_Click(object sender, EventArgs e)
        {
            db_table.Visible = true;
            pan_table.Visible = true;
            certificate_image.Visible = false;
            btn_add.Visible = true;
            gen_btn.Visible = false;
            addtodb_btn.Visible = false;
            btn_export.Visible = true;
            btn_import.Visible = true;
            btn_remove.Visible = true;
            Certificate_construstor_pan.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_table.Visible = false;
            pan_table.Visible = true;
            certificate_image.Visible = true;
            btn_add.Visible = false;
            gen_btn.Visible = true;
            addtodb_btn.Visible = true;
            btn_export.Visible = false;
            btn_import.Visible = false;
            btn_remove.Visible = false;
            Certificate_construstor_pan.Visible = true;
        }

        private void saveimg_btn_Click(object sender, EventArgs e)
        {
            if (isGenerated)
            {
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    saveFileDialog.Title = "Save certificate image...";
                    saveFileDialog.FileName = "Certificate_" + input_name.Text + "_" + input_surname.Text;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Определяем формат в зависимости от выбранного расширения
                        System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
                        if (saveFileDialog.FileName.EndsWith(".jpg"))
                            format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        else if (saveFileDialog.FileName.EndsWith(".bmp"))
                            format = System.Drawing.Imaging.ImageFormat.Bmp;

                        // Сохраняем изображение сертификата
                        try
                        {
                            certificate.Save(saveFileDialog.FileName, format);
                            MessageBox.Show("The image is saved successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            else
            {
                MessageBox.Show("The certificate was not generated.");
            }

        }

        private void btn_export_Click(object sender, EventArgs e)
        {

        }

        private void btn_import_Click(object sender, EventArgs e)
        {

        }

        private void git_btn_Click(object sender, EventArgs e)
        {
            string git_url = "https://github.com/strike11/AwarderPro";
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = git_url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = db_table.SelectedRows[0].Index;
                db_table.Rows.RemoveAt(rowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
