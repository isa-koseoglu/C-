using FolderCopyCreated.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderCopyCreated
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        IFolderTask folderTask = new FolderTaskService();
        private void FileSend_btn_Click(object sender, EventArgs e)
        {
            try
            {
                fileProcces_approve_listbox.Items.Clear();
                fileProcces_counter_progresbar.Value = 0;
                fileProcces_preccesCount_lbl.Text = "0 Dosya Kopyalandı.";
                fileProcces_Panel.Visible = true;
                fileProcces_localPath_txt.Text = @"C:\TOOLS";
                fileProcces_kasaPath_txt.Text = @"C:\TOOLSSEND";
                fileProcces_close_btn.Enabled = false;
                fileProcces_confirm_btn.Enabled = true;
            }
            catch (Exception)
            {
                fileProcces_Panel.Visible = false;
                MessageBox.Show("Programda Hataya Testip Eildi..\nProgram Sağlyıcınıza İletişime Geçiniz", "İletişime Geçiniz.."
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void fileProcces_confirm_btn_Click(object sender, EventArgs e)
        {
            // listbox clear
            try
            {
                fileProcces_approve_listbox.Items.Clear();
                fileProcces_counter_progresbar.Value = 0;
                var resultFiles = folderTask.GetFile(fileProcces_localPath_txt.Text);
                if (resultFiles == null)
                {
                    MessageBox.Show("Belirtilen Adreste Dosya Bulunmuyor...", "Echo Uyarı !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int fileCount = resultFiles.Count();
                int fileDivide = (100 / fileCount);
                int progresComplete = 0;
                if ((fileDivide * fileCount) == 100) progresComplete = 0;
                else progresComplete = 100 - (fileDivide * fileCount);

                foreach (var resultFile in resultFiles)
                {

                    var CheckComplete = await folderTask.FileCopy(resultFile, fileProcces_kasaPath_txt.Text);
                    if (!CheckComplete)
                    {
                        MessageBox.Show(resultFile + "\n Dosya Kopyalanırken Hata Oluştu", "Ehco Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    fileProcces_approve_listbox.Items.Add(resultFile);
                    fileProcces_counter_progresbar.Value += fileDivide;
                    fileProcces_preccesCount_lbl.Text = fileProcces_approve_listbox.Items.Count.ToString() + " Dosya Kopyalandı.";
                }
                fileProcces_counter_progresbar.Value += progresComplete;
                fileProcces_close_btn.Enabled = true;
                fileProcces_confirm_btn.Enabled = false;
                if (fileProcces_counter_progresbar.Value == 100)
                {
                    MessageBox.Show("Kopyalama İşlemleri Gerçekleşti..", "Başarılı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                fileProcces_counter_progresbar.Value = 0;
            }
            catch (Exception)
            {
                fileProcces_Panel.Visible = false;
                MessageBox.Show("Programda Hataya Testip Eildi..\nProgram Sağlyıcınıza İletişime Geçiniz", "İletişime Geçiniz.."
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fileProcces_close_btn_Click(object sender, EventArgs e)
        {
            fileProcces_Panel.Visible = false;
        }
    }
}
