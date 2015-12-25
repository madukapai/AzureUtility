using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzureUtility.Storage;
using System.IO;

namespace AzureUtilityForm
{
    public partial class frmMain : Form
    {
        string strFileName;

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 開啟檔案的選擇
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            digFile.ShowDialog();
        }

        private void digFile_FileOk(object sender, CancelEventArgs e)
        {
            txtFilePath.Text = digFile.FileName;
            strFileName = Path.GetFileName(digFile.FileName);
        }

        /// <summary>
        /// 進行檔案的上傳
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            BlobUtil objBlob = new BlobUtil(txtKey.Text);
            if (txtFilePath.Text != "")
            {
               bool blflag =  objBlob.SaveFile(txtContainer.Text, strFileName, File.OpenRead(txtFilePath.Text));

                if (blflag)
                    MessageBox.Show("上傳完成");
                else
                    MessageBox.Show("上傳失敗," + objBlob.ErrorMessage);
            }
        }

        /// <summary>
        /// 取得Container上的Blob檔案清單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnList_Click(object sender, EventArgs e)
        {
            BlobUtil objBlob = new BlobUtil(txtKey.Text);
            List<BlobItem> objBlobs = objBlob.ListFile(txtContainer.Text);

            lbxBlob.Items.Clear();
            for (int i=0; i<objBlobs.Count; i++)
                lbxBlob.Items.Add(objBlobs[i]);
        }

        /// <summary>
        /// 刪除Container上的Blob檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxBlob.SelectedItem != null)
            {
                BlobUtil objBlob = new BlobUtil(txtKey.Text);
                string strFileName = ((BlobItem)lbxBlob.SelectedItem).Name;
                objBlob.DeleteFile(txtContainer.Text, strFileName);

                MessageBox.Show("已送出刪除");
                this.btnList_Click(sender, e);
            }
        }

        /// <summary>
        /// 下載檔案的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (lbxBlob.SelectedItem != null)
            {
                wbDownload.Navigate(((BlobItem)lbxBlob.SelectedItem).Uri);
            }
        }
    }
}
