using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StampIt
{
    static class FileManager
    {
        public static string path = Properties.Settings.Default.StoreLocation;
        public static string fileName = "";
        public static Stopwatch stopWatch = new Stopwatch();

        public static void HandleStart()
        {

            if (stopWatch.IsRunning)
            {
                stopWatch.Reset();
                PutStamp(true);
                return;
            }

            stopWatch.Start();

            fileName = $"{path}\\{GetNow()}.txt";

            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);

                File.Create(fileName).Close();
                PutStamp(true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void PutStamp(bool stampDate = false)
        {
            if (!File.Exists(fileName) && fileName.Length == 0) { return; }

            try
            {
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);

                using (FileStream fs = File.Open(fileName, FileMode.Append))
                {
                    var recordString = !stampDate ? $" {elapsedTime}" : GetNow(isInFile: true);

                    Byte[] record = new UTF8Encoding(true).GetBytes(recordString + Environment.NewLine);
                    fs.Write(record, 0, record.Length);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        private static string GetNow(bool isInFile = false) => DateTime.Now.ToString("HH" + (isInFile ? ':' : '.') + "mm-dd.MM.yy");
    }
}
