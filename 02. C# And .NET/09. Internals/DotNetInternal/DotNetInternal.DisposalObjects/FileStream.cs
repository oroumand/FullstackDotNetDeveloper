using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInternal.DisposalObjects
{
    public class MyFileStream:IDisposable
    {
        //private File _localFile;

        public MyFileStream()
        {
            //_localFile.Open("a.txt");
        }

        public void Dispose()
        {
            //_localFile.Close();   
        }
    }
}
