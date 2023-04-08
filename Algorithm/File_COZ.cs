using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class File_COZ
    {
        public int COZ_Style()
        {
            int veri_count = 0; // total number of data first 0
            string xconv_file = "data.json";//              json file 
            string xnew_file = "data_akt.txt";//           file to overwrite txt  

            FileStream xfs = new FileStream(xnew_file, FileMode.Append, FileAccess.Write, FileShare.Write);  // json file stream properties
            FileStream zfs = new FileStream(xconv_file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);// json file stream properties

            StreamWriter xwrite = new StreamWriter(xfs); // json file we are reading the file
            StreamReader zread = new StreamReader(zfs);  // txt write to file

            string zline = ""; // json 
            string zline_contact = "";
            string[] separate;
            while (true)
            {
                zline = zread.ReadLine();  // Storing each line into zline

                if (zline != null) //zline line not nul  
                {

                    zline_contact = zline_contact + (zline.Replace('"', ' '));  // converting quotes to spaces

                    if (zline_contact.IndexOf(']') > 0) // if it is in
                    {
                        zline_contact = zline_contact.Replace("]", ""); // We remove the [ sign
                    }
                    //zline_contact
                    if (zline_contact.IndexOf('}') > 0) // if it is in 
                    {
                        separate = zline_contact.Split('}'); // } separate by

                        if (separate.Count() > 2) //separate  If there are more than 2 values ​​in the array
                        {
                            for (int i = 0; i < separate.Count() - 1; i++)
                            {
                                xwrite.WriteLine(separate[i].Substring(2)); //write to txt file if condition is true
                                veri_count++;
                            }
                            zline_contact = separate[separate.Count() - 1]; //pass last remaining value to variable 
                        }
                    }

                    continue;  //back to top if condition is true
                }
                break; //exit the loop
            }
            xwrite.Close(); //StreamWriter close
            zread.Close();  //StreamReader close

            zfs.Close();    //FileStream Close
            xfs.Close();    //FileStream Close
            return veri_count; // total number of data
        }
    }
}
