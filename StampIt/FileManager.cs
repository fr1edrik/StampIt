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
                return;
            }

            stopWatch.Start();

            fileName = path + @"\" + DateTime.Now.ToString("HH.mm-dd.MM.yy") + ".txt";

            Console.WriteLine(fileName);
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                File.Create(fileName).Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void PutStamp()
        {
            if (!File.Exists(fileName) && fileName.Length == 0)
            {
                return;
            }

            try
            {
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);

                using (FileStream fs = File.Open(fileName, FileMode.Append))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes(elapsedTime + Environment.NewLine);
                    fs.Write(title, 0, title.Length);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
