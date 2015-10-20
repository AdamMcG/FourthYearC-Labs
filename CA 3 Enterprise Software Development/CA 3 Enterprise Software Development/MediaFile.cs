using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_3_Enterprise_Software_Development
{
    public abstract class MediaFile
    {
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set
            {
                //Checks if value is null, defaults to NameToBeAdded
                if (string.IsNullOrEmpty(value))
                    fileName = "No Name Added";
                else
                    fileName = value;
            }
        }

        protected MediaFile(string fileName)
        {
            this.FileName = fileName;
        }

        public override string ToString()
        {
            return "File: \n" + "Name: " + FileName;
        }
    }
}
