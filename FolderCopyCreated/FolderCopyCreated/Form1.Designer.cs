namespace FolderCopyCreated
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileProcces_Panel = new System.Windows.Forms.Panel();
            fileProcces_preccesCount_lbl = new System.Windows.Forms.Label();
            fileProcces_close_btn = new System.Windows.Forms.Button();
            fileProcces_counter_progresbar = new System.Windows.Forms.ProgressBar();
            fileProcces_approve_listbox = new System.Windows.Forms.ListBox();
            fileProcces_kasaPath_lbl = new System.Windows.Forms.Label();
            fileProcces_localPath_lbl = new System.Windows.Forms.Label();
            fileProcces_kasaPath_txt = new System.Windows.Forms.TextBox();
            fileProcces_localPath_txt = new System.Windows.Forms.TextBox();
            fileProcces_confirm_btn = new System.Windows.Forms.Button();
            FileSend_btn = new System.Windows.Forms.Button();
            fileProcces_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // fileProcces_Panel
            // 
            fileProcces_Panel.Controls.Add(fileProcces_preccesCount_lbl);
            fileProcces_Panel.Controls.Add(fileProcces_close_btn);
            fileProcces_Panel.Controls.Add(fileProcces_counter_progresbar);
            fileProcces_Panel.Controls.Add(fileProcces_approve_listbox);
            fileProcces_Panel.Controls.Add(fileProcces_kasaPath_lbl);
            fileProcces_Panel.Controls.Add(fileProcces_localPath_lbl);
            fileProcces_Panel.Controls.Add(fileProcces_kasaPath_txt);
            fileProcces_Panel.Controls.Add(fileProcces_localPath_txt);
            fileProcces_Panel.Controls.Add(fileProcces_confirm_btn);
            fileProcces_Panel.Location = new System.Drawing.Point(12, 59);
            fileProcces_Panel.Name = "fileProcces_Panel";
            fileProcces_Panel.Size = new System.Drawing.Size(483, 246);
            fileProcces_Panel.TabIndex = 0;
            fileProcces_Panel.Visible = false;
            // 
            // fileProcces_preccesCount_lbl
            // 
            fileProcces_preccesCount_lbl.BackColor = System.Drawing.Color.Transparent;
            fileProcces_preccesCount_lbl.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fileProcces_preccesCount_lbl.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
            fileProcces_preccesCount_lbl.Location = new System.Drawing.Point(253, 183);
            fileProcces_preccesCount_lbl.Name = "fileProcces_preccesCount_lbl";
            fileProcces_preccesCount_lbl.Size = new System.Drawing.Size(218, 18);
            fileProcces_preccesCount_lbl.TabIndex = 10;
            fileProcces_preccesCount_lbl.Text = "0 Dosya Kopyalandı ";
            fileProcces_preccesCount_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileProcces_close_btn
            // 
            fileProcces_close_btn.Enabled = false;
            fileProcces_close_btn.Location = new System.Drawing.Point(253, 138);
            fileProcces_close_btn.Name = "fileProcces_close_btn";
            fileProcces_close_btn.Size = new System.Drawing.Size(218, 40);
            fileProcces_close_btn.TabIndex = 9;
            fileProcces_close_btn.Text = "Kapat";
            fileProcces_close_btn.UseVisualStyleBackColor = true;
            fileProcces_close_btn.Click += fileProcces_close_btn_Click;
            // 
            // fileProcces_counter_progresbar
            // 
            fileProcces_counter_progresbar.Location = new System.Drawing.Point(12, 204);
            fileProcces_counter_progresbar.Name = "fileProcces_counter_progresbar";
            fileProcces_counter_progresbar.Size = new System.Drawing.Size(459, 36);
            fileProcces_counter_progresbar.TabIndex = 8;
            // 
            // fileProcces_approve_listbox
            // 
            fileProcces_approve_listbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fileProcces_approve_listbox.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
            fileProcces_approve_listbox.FormattingEnabled = true;
            fileProcces_approve_listbox.ItemHeight = 20;
            fileProcces_approve_listbox.Location = new System.Drawing.Point(12, 94);
            fileProcces_approve_listbox.Name = "fileProcces_approve_listbox";
            fileProcces_approve_listbox.Size = new System.Drawing.Size(235, 104);
            fileProcces_approve_listbox.TabIndex = 7;
            // 
            // fileProcces_kasaPath_lbl
            // 
            fileProcces_kasaPath_lbl.AutoSize = true;
            fileProcces_kasaPath_lbl.Location = new System.Drawing.Point(12, 53);
            fileProcces_kasaPath_lbl.Name = "fileProcces_kasaPath_lbl";
            fileProcces_kasaPath_lbl.Size = new System.Drawing.Size(64, 20);
            fileProcces_kasaPath_lbl.TabIndex = 6;
            fileProcces_kasaPath_lbl.Text = "Kasa Yol";
            // 
            // fileProcces_localPath_lbl
            // 
            fileProcces_localPath_lbl.AutoSize = true;
            fileProcces_localPath_lbl.Location = new System.Drawing.Point(12, 20);
            fileProcces_localPath_lbl.Name = "fileProcces_localPath_lbl";
            fileProcces_localPath_lbl.Size = new System.Drawing.Size(68, 20);
            fileProcces_localPath_lbl.TabIndex = 5;
            fileProcces_localPath_lbl.Text = "Local Yol";
            // 
            // fileProcces_kasaPath_txt
            // 
            fileProcces_kasaPath_txt.Location = new System.Drawing.Point(108, 46);
            fileProcces_kasaPath_txt.Name = "fileProcces_kasaPath_txt";
            fileProcces_kasaPath_txt.ReadOnly = true;
            fileProcces_kasaPath_txt.Size = new System.Drawing.Size(363, 27);
            fileProcces_kasaPath_txt.TabIndex = 4;
            // 
            // fileProcces_localPath_txt
            // 
            fileProcces_localPath_txt.Location = new System.Drawing.Point(108, 13);
            fileProcces_localPath_txt.Name = "fileProcces_localPath_txt";
            fileProcces_localPath_txt.ReadOnly = true;
            fileProcces_localPath_txt.Size = new System.Drawing.Size(363, 27);
            fileProcces_localPath_txt.TabIndex = 3;
            // 
            // fileProcces_confirm_btn
            // 
            fileProcces_confirm_btn.Location = new System.Drawing.Point(253, 94);
            fileProcces_confirm_btn.Name = "fileProcces_confirm_btn";
            fileProcces_confirm_btn.Size = new System.Drawing.Size(218, 40);
            fileProcces_confirm_btn.TabIndex = 2;
            fileProcces_confirm_btn.Text = "Başlat";
            fileProcces_confirm_btn.UseVisualStyleBackColor = true;
            fileProcces_confirm_btn.Click += fileProcces_confirm_btn_Click;
            // 
            // FileSend_btn
            // 
            FileSend_btn.Location = new System.Drawing.Point(12, 12);
            FileSend_btn.Name = "FileSend_btn";
            FileSend_btn.Size = new System.Drawing.Size(153, 41);
            FileSend_btn.TabIndex = 1;
            FileSend_btn.Text = "Dosya Gönder";
            FileSend_btn.UseVisualStyleBackColor = true;
            FileSend_btn.Click += FileSend_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(499, 307);
            Controls.Add(FileSend_btn);
            Controls.Add(fileProcces_Panel);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Copy File Window";
            fileProcces_Panel.ResumeLayout(false);
            fileProcces_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel fileProcces_Panel;
        private System.Windows.Forms.Button FileSend_btn;
        private System.Windows.Forms.ProgressBar fileProcces_counter_progresbar;
        private System.Windows.Forms.ListBox fileProcces_approve_listbox;
        private System.Windows.Forms.Label fileProcces_kasaPath_lbl;
        private System.Windows.Forms.Label fileProcces_localPath_lbl;
        private System.Windows.Forms.TextBox fileProcces_kasaPath_txt;
        private System.Windows.Forms.TextBox fileProcces_localPath_txt;
        private System.Windows.Forms.Button fileProcces_confirm_btn;
        private System.Windows.Forms.Label fileProcces_preccesCount_lbl;
        private System.Windows.Forms.Button fileProcces_close_btn;
    }
}
