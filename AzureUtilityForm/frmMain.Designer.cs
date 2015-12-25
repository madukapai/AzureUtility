namespace AzureUtilityForm
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.digFile = new System.Windows.Forms.OpenFileDialog();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblContainer = new System.Windows.Forms.Label();
            this.txtContainer = new System.Windows.Forms.TextBox();
            this.plSplit = new System.Windows.Forms.Panel();
            this.lbxBlob = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.wbDownload = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(368, 83);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "上傳";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(72, 83);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(251, 22);
            this.txtFilePath.TabIndex = 1;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(13, 86);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(53, 12);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "上傳檔案";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.Location = new System.Drawing.Point(329, 83);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(33, 23);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // digFile
            // 
            this.digFile.FileOk += new System.ComponentModel.CancelEventHandler(this.digFile_FileOk);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(14, 12);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(53, 12);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "連接字串";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(73, 9);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(459, 22);
            this.txtKey.TabIndex = 1;
            this.txtKey.Text = "[請在這裡加上連接字串]";
            // 
            // lblContainer
            // 
            this.lblContainer.AutoSize = true;
            this.lblContainer.Location = new System.Drawing.Point(14, 48);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Size = new System.Drawing.Size(53, 12);
            this.lblContainer.TabIndex = 4;
            this.lblContainer.Text = "存取容器";
            // 
            // txtContainer
            // 
            this.txtContainer.Location = new System.Drawing.Point(73, 45);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Size = new System.Drawing.Size(251, 22);
            this.txtContainer.TabIndex = 1;
            this.txtContainer.Text = "[請在這裡放入Container名稱]";
            // 
            // plSplit
            // 
            this.plSplit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plSplit.Location = new System.Drawing.Point(12, 73);
            this.plSplit.Name = "plSplit";
            this.plSplit.Size = new System.Drawing.Size(520, 4);
            this.plSplit.TabIndex = 5;
            // 
            // lbxBlob
            // 
            this.lbxBlob.FormattingEnabled = true;
            this.lbxBlob.ItemHeight = 12;
            this.lbxBlob.Location = new System.Drawing.Point(72, 121);
            this.lbxBlob.Name = "lbxBlob";
            this.lbxBlob.Size = new System.Drawing.Size(252, 196);
            this.lbxBlob.TabIndex = 6;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(330, 294);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "列出清單";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(411, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "刪除Blob";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(492, 294);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "下載檔案";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // wbDownload
            // 
            this.wbDownload.Location = new System.Drawing.Point(330, 121);
            this.wbDownload.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDownload.Name = "wbDownload";
            this.wbDownload.Size = new System.Drawing.Size(237, 130);
            this.wbDownload.TabIndex = 9;
            this.wbDownload.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 329);
            this.Controls.Add(this.wbDownload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbxBlob);
            this.Controls.Add(this.plSplit);
            this.Controls.Add(this.lblContainer);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtContainer);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnUpload);
            this.Name = "frmMain";
            this.Text = "AzureUtility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog digFile;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblContainer;
        private System.Windows.Forms.TextBox txtContainer;
        private System.Windows.Forms.Panel plSplit;
        private System.Windows.Forms.ListBox lbxBlob;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.WebBrowser wbDownload;
    }
}

