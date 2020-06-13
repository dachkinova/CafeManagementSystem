using HotelMenagementSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagementSystem;

namespace CafeManagementSystem
{
    public class FileSaver
    {

        public static void CreateFile(string path, List<Product> productList1, string totalBill)
        {
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(@"D:\SavedOrder-CafeManagemnetSystem");
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Ordered products list: ");
                    sw.WriteLine();
                    foreach (var product in productList1)
                    {
                        sw.WriteLine(product);
                    }
                    sw.WriteLine();
                    sw.WriteLine("Total bill: {0} ", totalBill);
                }
                MessageBox.Show("Order successfully saved to file!");

            }
            else if (File.Exists(path))
            {
                String path_current = path;
                int count = 0;

                while (File.Exists(path_current))
                {
                    count++;
                    path_current = Path.GetDirectoryName(path)
                                     + Path.DirectorySeparatorChar
                                     + Path.GetFileNameWithoutExtension(path)
                                     + "("
                                     + count.ToString()
                                     + ")"
                                     + Path.GetExtension(path);
                }
                using (StreamWriter sw = new StreamWriter(path_current))
                {
                    sw.WriteLine("Ordered products list:");
                    sw.WriteLine();
                    foreach (var product in productList1)
                    {
                        sw.WriteLine(product);
                    }
                    sw.WriteLine();
                    sw.WriteLine("Total bill: {0}", totalBill);
                }
                MessageBox.Show("Order successfully saved to file!");
            }
        }

   
    }
}
