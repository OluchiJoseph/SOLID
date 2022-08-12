using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.SRP
{
    //OCP CONFIRMED
    public interface IUploadOrderFile
    {
        object ProcessOrderFile();
    }
    public class UploadXMLOrderFile : IUploadOrderFile
    {
        public object ProcessOrderFile()
        {
            object orderObj = null;

            //Parse XML File to DTO Object
            return orderObj;
        }
    }

    public class UploadPdfOrderFile : IUploadOrderFile
    {
        public object ProcessOrderFile()
        {
            object orderObj = null;
            //Parse PDF File to DTO Object
            return orderObj;
        }
    }
    public class UploadProcess
    {
        public bool UploadFile()
        {
            IUploadOrderFile orderFile = null;
            //if XML File
            {
                orderFile = new UploadXMLOrderFile();
            }
            //if PDF File
            {
                orderFile = new UploadPdfOrderFile();
            }
            Object orderObj = orderFile.ProcessOrderFile();
            //Validate Records
            //Save Records
            return true;
        }
    }
}
