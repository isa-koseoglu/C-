using SQLite.API.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;

namespace SQLite.API.Classes.Service
{
    public class SqliteCRUDService_v2:IDatabaseCRUD
    {
        private readonly SQLiteConnection conn;
        public SqliteCRUDService_v2(string conString)
        {
            conn = new SQLiteConnection(conString);
            DBConnect();
        }
        private void DBConnect()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.OpenAsync().Wait();
            }
        }
        private string[] WordCreatedArray(int quantity)
        {
            string[] itemWords = new string[quantity];
            Random rnd =new Random();
            for (int i = 0; i < quantity; i++)
            {
                string word = "";
                int wordLength=rnd.Next(3,8);
                for (int x = 0; x < wordLength; x++)
                {
                    char charecter = (char)rnd.Next('A','Z');
                    word += charecter;
                }
                itemWords[i] = word;
            }
            return itemWords;
        }
        public string AddedDB(string tableName,int addedCount,int foreign)
        {
            Dictionary<string, object> cmdKeyValue = new Dictionary<string, object>();
            int cmdKeyValueCount = 0;
            Random rnd;
            int counteAdded = 0;
            string resultReturn = string.Empty;
            
            using (SQLiteTransaction transaction = conn.BeginTransaction())
            {
                using(SQLiteCommand cmd = conn.CreateCommand())
                {
                    switch (tableName)
                    {
                        case "Schools":
                            
                            cmd.CommandText = "insert into " + tableName + " (SchoolName,SchoolAdress,SchoolPicturePath,SchoolCategori) values( @name,@address,@picturePath,@categori)";

                            cmdKeyValue.Clear();
                            cmdKeyValue.Add("name", "");
                            cmdKeyValue.Add("address", "");
                            cmdKeyValue.Add("picturePath", "");
                            cmdKeyValue.Add("categori", "");
                            cmdKeyValueCount=cmdKeyValue.Count;
                            break;


                        case "SchoolClasses":

                            cmd.CommandText = "insert into " + tableName + " (ClassName,ClassCode,ClassCapacity,ClassActive,ClassSchoolID) values( @name,@code,@capacity,@active,@schoolid)";
                            cmdKeyValue.Add("name", "");
                            cmdKeyValue.Add("code", "");
                            cmdKeyValue.Add("capacity", 30);
                            cmdKeyValue.Add("active", true);
                            cmdKeyValue.Add("schoolid", foreign);
                            cmdKeyValueCount = 2;

                            break;
                        case "SchoolStudents":
                            cmd.CommandText = "insert into " + tableName + "" +
                                " (StudentTcNO,StudentName,SudentSurname,StudentpPicturePath,StudentAge,StudentActive,StudentClassID) " +
                                " values( @tcno,@name,@surname,@picture,@age,@active,@classid)";

                            cmdKeyValue.Add("tcno", "");
                            cmdKeyValue.Add("name", "");
                            cmdKeyValue.Add("surname", "");
                            cmdKeyValue.Add("picture", "");
                            cmdKeyValue.Add("age", 25);
                            cmdKeyValue.Add("active", true);
                            cmdKeyValue.Add("classid", true);
                            cmdKeyValueCount = 4;
                            break;
                        default:
                            break;
                    }


                    foreach (var item in cmdKeyValue)
                    {
                        cmd.Parameters.AddWithValue("@"+item.Key, item.Value);
                    }
                    for (int i = 0; i < addedCount; i++)
                    {
                        var words = WordCreatedArray(cmdKeyValueCount);/* colon  tane rastgele kelime üretti */
                        Dictionary<string, object> dicClone = new Dictionary<string, object>(cmdKeyValue);
                        int counterx = 0;
                        foreach (var item in dicClone)
                        {
                            if (cmdKeyValueCount == counterx)
                            {
                                break;
                            }
                            cmdKeyValue[item.Key] = words[counterx].ToString();
                            counterx++;
                        }

                        int count = ItemAdded(tableName, cmdKeyValue, cmd);
                        if (count == 1) counteAdded++;
                    }
                    
                }
                transaction.Commit();
            }

            

            resultReturn = counteAdded + " Adet " + tableName + " Tablosuna veri eklenedi ";



            return resultReturn;
        }
        private int ItemAdded(string tableName,Dictionary<string,object> keyValues,SQLiteCommand cmd)
        {
            if (keyValues == null) { return 0; }
            try
            {

                foreach (var item in keyValues)
                {
                    cmd.Parameters["@"+item.Key].Value = item.Value;
                }
                return cmd.ExecuteNonQuery();
                


            }
            catch (System.Exception e)
            {
                return 0;
                throw;
            }

        }

        

        public DataTable GetAll(string tableName)
        {
            throw new NotImplementedException();
        }

        public DataTable QueryRun(string query)
        {
            throw new NotImplementedException();
        }

        public string UpdatedDB(string tableName, int addedCount, int foreignKey)
        {
            throw new NotImplementedException();
        }

        public string DeletedDB(string tableName, int addedCount)
        {
            throw new NotImplementedException();
        }
    }
}
