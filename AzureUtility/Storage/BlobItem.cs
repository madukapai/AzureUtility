using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureUtility.Storage
{
    public class BlobItem
    {
        public string Uri { get; set; }
        public string Name { get; set; }

        public BlobItem(string strName, string strUri)
        {
            this.Uri = strUri;
            this.Name = strName;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
