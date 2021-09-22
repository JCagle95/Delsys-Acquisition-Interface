using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DelsysAcquisitionInterface
{
    public struct TdSenseStruct
    {
        public ushort SequenceNumber;
        public double[] Channel1;
        public double[] Channel2;
        public double[] Channel3;
        public double[] Channel4;
    };

    public class DataManager
    {
        public string storagePath;

        private readonly object threadLocker = new object();

        public DataManager()
        {
            this.storagePath = AppDomain.CurrentDomain.BaseDirectory + "/";
        }

        public DataManager(string path)
        {
            this.storagePath = path;
        }

        public void WriteBinary_ThreadSafe(string filename, byte[] data)
        {
            lock (threadLocker)
            {
                var stream = new FileStream(this.storagePath + filename, FileMode.Append);
                stream.Write(data, 0, data.Length);
                stream.Close();
                return;
            }
        }
    }
}
