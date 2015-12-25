using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;

namespace AzureUtility.Storage
{
    public class BlobUtil
    {
        public string StorageConnectionString { get; set; }
        public string ErrorMessage { get; set; }

        CloudStorageAccount storageAccount;
        CloudBlobClient blobClient;

        public BlobUtil(string strStorageConnectionString)
        {
            this.StorageConnectionString = strStorageConnectionString;
            storageAccount = CloudStorageAccount.Parse(this.StorageConnectionString);
            blobClient = storageAccount.CreateCloudBlobClient();
        }

        public bool SaveFile(string strContainer, string strFileName, Stream objStream)
        {
            bool blflag = true;

            try
            {
                CloudBlobContainer container = blobClient.GetContainerReference(strContainer);
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(strFileName);
                blockBlob.UploadFromStream(objStream);
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                blflag = false;
            }

            return blflag;
        }

        public string GetFile(string strContainer, string strFileName)
        {
            CloudBlobContainer container = blobClient.GetContainerReference(strContainer);
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(strFileName);

            return (blockBlob.Exists()) ? blockBlob.Uri.AbsoluteUri : "";
        }

        public void DeleteFile(string strContainer, string strFileName)
        {
            CloudBlobContainer container = blobClient.GetContainerReference(strContainer);
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(strFileName);
            blockBlob.Delete(DeleteSnapshotsOption.IncludeSnapshots);
        }

        public List<BlobItem> ListFile(string strContainer)
        {
            CloudBlobContainer container = blobClient.GetContainerReference(strContainer);
            List<BlobItem> objBlobs = new List<BlobItem>();

            foreach (IListBlobItem item in container.ListBlobs(null, false))
            {
                if (item.GetType() == typeof(CloudBlockBlob))
                {
                    CloudBlockBlob blob = (CloudBlockBlob)item;
                    objBlobs.Add(new BlobItem(blob.Name, blob.Uri.ToString()));
                }
                else if (item.GetType() == typeof(CloudPageBlob))
                {
                    CloudPageBlob pageBlob = (CloudPageBlob)item;
                    objBlobs.Add(new BlobItem(pageBlob.Name, pageBlob.Uri.ToString()));

                }
                else if (item.GetType() == typeof(CloudBlobDirectory))
                {
                    CloudBlobDirectory directory = (CloudBlobDirectory)item;
                    objBlobs.Add(new BlobItem(directory.Uri.ToString(), directory.Uri.ToString()));
                }
            }

            return objBlobs;
        }
    }
}
