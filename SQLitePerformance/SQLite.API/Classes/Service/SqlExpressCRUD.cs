using SQLite.API.Classes.Abstract;
using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace SQLite.API.Classes.Service
{
    public class SqlExpressCRUD : IDatabaseCRUD
    {
        private readonly SqlConnection conn;
        public SqlExpressCRUD(string connectionString)
        {
            conn=new SqlConnection(connectionString);
            DbConnection();
        }
        private void DbConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.OpenAsync().Wait();
                }
            }
            catch (System.Exception)
            {

                throw new System.Exception("Connection Erro = " + conn.ConnectionString);
            }


        }
        public string AddedDB(string tableName, int addedCount, int foreignKey = 0)
        {
            string answerComponet = "hatatatatatatatata....";
            switch (tableName)
            {
                case "Schools":

                    try
                    {
                        string commandQuery = "";
                        Random rnd;

                        for (int i = 0; i < addedCount; i++)
                        {
                            string name = "", address = "", picturePath = "", categori = "";
                            for (int x = 0; x < 6; x++)
                            {
                                rnd = new Random();
                                name += ((char)rnd.Next('A', 'Z')).ToString();
                                address += ((char)rnd.Next('A', 'Z')).ToString();
                                picturePath += ((char)rnd.Next('A', 'Z')).ToString();
                                categori += ((char)rnd.Next('A', 'Z')).ToString();
                            }
                            commandQuery = "insert into " + tableName + " (SchoolName,SchoolAdress,SchoolPicturePath,SchoolCategori) values( @name,@address,@picturePath,@categori)";
                            using (SqlCommand com = new SqlCommand(commandQuery, conn))
                            {
                                com.Parameters.AddWithValue("@name", name.ToString());
                                com.Parameters.AddWithValue("@address", address.ToString());
                                com.Parameters.AddWithValue("@picturePath", picturePath);
                                com.Parameters.AddWithValue("@categori", categori);
                                com.ExecuteNonQuery();
                            }

                        }
                        answerComponet = addedCount+" Adet  School Kayıt etti";

                    }
                    catch (System.Exception e)
                    {
                        answerComponet = "School Kayıt ederken hata verdi";
                        throw;
                    }

                    break;
                case "SchoolClasses":

                    try
                    {
                        string commandQuery = "";
                        Random rnd;

                        for (int i = 0; i < addedCount; i++)
                        {
                            string name = "", capacity = "", code = "";
                            int schoolID = foreignKey;
                            bool active = false;
                            for (int x = 0; x < 6; x++)
                            {
                                rnd = new Random();
                                name += ((char)rnd.Next('A', 'Z')).ToString();
                                code += ((char)rnd.Next('A', 'Z')).ToString();
                                capacity = ((char)rnd.Next('A', 'Z')).ToString();
                                active = Convert.ToBoolean(rnd.Next(0, 2));

                            }
                            commandQuery = "insert into " + tableName + " (ClassName,ClassCapacity,ClassCode,ClassActive,ClassSchoolID) values( @name,@capacity,@code,@ative,@schoolid)";
                            using (SqlCommand com = new SqlCommand(commandQuery, conn))
                            {
                                com.Parameters.AddWithValue("@name", name.ToString());
                                com.Parameters.AddWithValue("@capacity", capacity.ToString());
                                com.Parameters.AddWithValue("@code", code);
                                com.Parameters.AddWithValue("@ative", active);
                                com.Parameters.AddWithValue("@schoolid", schoolID);
                                com.ExecuteNonQuery();
                            }

                        }
                        answerComponet = addedCount+" Adet SchoolClass Kayıt etti";

                    }
                    catch (System.Exception e)
                    {
                        answerComponet = "SchoolClass Kayıt ederken hata verdi";
                        throw;
                    }

                    break;
                case "SchoolStudents":

                    try
                    {
                        string commandQuery = "";
                        Random rnd;

                        for (int i = 0; i < addedCount; i++)
                        {
                            string tcNO="", name = "", surname = "", code = "", picturePath = "";
                            int classID = foreignKey, age = 0;
                            bool active = false;
                            for (int x = 0; x < 9; x++)
                            {
                                rnd = new Random();
                                name += ((char)rnd.Next('A', 'Z')).ToString();
                                code += ((char)rnd.Next('A', 'Z')).ToString();
                                picturePath = ((char)rnd.Next('A', 'Z')).ToString();
                                active = Convert.ToBoolean(rnd.Next(0, 2));
                                age = Convert.ToInt32(rnd.Next(1, 80));
                                tcNO += Convert.ToString(rnd.Next(1, 10));

                            }
                            commandQuery = "insert into " + tableName + "" +
                                " (StudentTcNO,StudentName,SudentSurname,StudentAge,StudentpPicturePath,StudentActive,StudentClassID) " +
                                " values( @tcno,@name,@surname,@age,@picture,@ative,@classid)";
                            using (SqlCommand com = new SqlCommand(commandQuery, conn))
                            {
                                com.Parameters.AddWithValue("@tcno", tcNO);
                                com.Parameters.AddWithValue("@name", name.ToString());
                                com.Parameters.AddWithValue("@surname", surname.ToString());
                                com.Parameters.AddWithValue("@age", age);
                                com.Parameters.AddWithValue("@picture", picturePath);
                                com.Parameters.AddWithValue("@ative", active);
                                com.Parameters.AddWithValue("@classid", classID);
                                com.ExecuteNonQuery();
                            }

                        }
                        answerComponet = "SchoolStudents " + addedCount + " item Kayıt etti";

                    }
                    catch (System.Exception e)
                    {
                        answerComponet = "SchoolStudents Kayıt ederken hata verdi";
                        throw;
                    }

                    break;
                default:
                    break;
            }


            return answerComponet;

        }

        public DataTable GetAll(string tableName)
        {
            DataTable dtAnswer = new DataTable();
            try
            {

                string query = "select * from " + tableName;
                using (SqlDataAdapter adp = new SqlDataAdapter(query, conn))
                {
                    adp.Fill(dtAnswer);
                }
            }
            catch (Exception e)
            {

                throw;
            }


            return dtAnswer;
        }

        public DataTable QueryRun(string query)
        {
            DataTable dtAnswer = new DataTable();
            try
            {
                using (SqlDataAdapter adp = new SqlDataAdapter(query, conn))
                {
                    adp.Fill(dtAnswer);
                }
            }
            catch (Exception e)
            {

                throw;
            }


            return dtAnswer;
        }

        public string UpdatedDB(string tableName, int addedCount, int foreignKey)
        {
            string answerComponet = "hatatatatatatatata....";
            switch (tableName)
            {
                case "Schools":

                    try
                    {
                        string commandQuery = "";
                        Random rnd;

                        

                        string name = "", address = "", picturePath = "", categori = "";
                        for (int x = 0; x < 6; x++)
                        {
                            rnd = new Random();
                            name += ((char)rnd.Next('A', 'Z')).ToString();
                            address += ((char)rnd.Next('A', 'Z')).ToString();
                            picturePath += ((char)rnd.Next('A', 'Z')).ToString();
                            categori += ((char)rnd.Next('A', 'Z')).ToString();
                        }
                        commandQuery = "update top(" + addedCount + ") " + tableName + " set " +
                            "SchoolName= @name,SchoolAdress=@address,SchoolPicturePath=@picturePath,SchoolCategori=@categori  ";
                        using (SqlCommand com = new SqlCommand(commandQuery, conn))
                        {
                            com.Parameters.AddWithValue("@name", name.ToString());
                            com.Parameters.AddWithValue("@address", address.ToString());
                            com.Parameters.AddWithValue("@picturePath", picturePath);
                            com.Parameters.AddWithValue("@categori", categori);
                            com.ExecuteNonQuery();
                        }

                        
                        answerComponet = addedCount + " Adet School Update etti";

                    }
                    catch (System.Exception e)
                    {
                        answerComponet = "School update ederken hata verdi";
                        throw;
                    }

                    break;
                case "SchoolClasses":

                    try
                    {
                        string commandQuery = "";
                        Random rnd;


                        string name = "", capacity = "", code = "";
                        int schoolID = foreignKey;
                        bool active = false;
                        for (int x = 0; x < 6; x++)
                        {
                            rnd = new Random();
                            name += ((char)rnd.Next('A', 'Z')).ToString();
                            code += ((char)rnd.Next('A', 'Z')).ToString();
                            capacity = ((char)rnd.Next('A', 'Z')).ToString();
                            active = Convert.ToBoolean(rnd.Next(0, 2));

                        }
                        commandQuery = "update top(" + addedCount + ") " + tableName + " set " +
                            " ClassName=@name,ClassCapacity=@capacity,ClassActive=@ative,ClassCode=@code,ClassSchoolID=@schoolid ";
                        using (SqlCommand com = new SqlCommand(commandQuery, conn))
                        {
                            com.Parameters.AddWithValue("@name", name.ToString());
                            com.Parameters.AddWithValue("@capacity", capacity.ToString());
                            com.Parameters.AddWithValue("@code", code);
                            com.Parameters.AddWithValue("@ative", active);
                            com.Parameters.AddWithValue("@schoolid", schoolID);
                            com.ExecuteNonQuery();
                        }

                        
                        answerComponet =  addedCount+" Adet SchoolClass Kayıt etti";

                    }
                    catch (System.Exception e)
                    {
                        answerComponet = "SchoolClass Kayıt ederken hata verdi";
                        throw;
                    }

                    break;
                case "SchoolStudents":

                    try
                    {
                        string commandQuery = "";
                        Random rnd;

                        string tcNO, name = "", surname = "", code = "", picturePath = "";
                        int classID = foreignKey, age = 0;
                        bool active = false;
                        for (int x = 0; x < 9; x++)
                        {
                            rnd = new Random();
                            name += ((char)rnd.Next('A', 'Z')).ToString();
                            code += ((char)rnd.Next('A', 'Z')).ToString();
                            picturePath = ((char)rnd.Next('A', 'Z')).ToString();
                            active = Convert.ToBoolean(rnd.Next(0, 2));
                            age = Convert.ToInt32(rnd.Next(1, 80));
                            tcNO = Convert.ToString(rnd.Next(1, 10));

                        }
                        commandQuery = " update top(" + addedCount + ") " + tableName + " set " +
                            " StudentTcNO= @tcno,StudentName=@name,SudentSurname=@surname,StudentAge=@age , " +
                            " StudentpPicturePath=@picture,StudentActive=@ative,StudentClassID=@classid ";
                        using (SqlCommand com = new SqlCommand(commandQuery, conn))
                        {
                            com.Parameters.AddWithValue("@tcno", name.ToString());
                            com.Parameters.AddWithValue("@name", name.ToString());
                            com.Parameters.AddWithValue("@surname", surname.ToString());
                            com.Parameters.AddWithValue("@age", age);
                            com.Parameters.AddWithValue("@picture", picturePath);
                            com.Parameters.AddWithValue("@ative", active);
                            com.Parameters.AddWithValue("@classid", classID);
                            com.ExecuteNonQuery();
                        }

                        
                        answerComponet = "SchoolStudents " + addedCount + " item Kayıt etti";

                    }
                    catch (System.Exception e)
                    {
                        answerComponet = "SchoolStudents Kayıt ederken hata verdi";
                        throw;
                    }

                    break;
                default:
                    break;
            }


            return answerComponet;
        }

        public string DeletedDB(string tableName, int addedCount)
        {
            string answerComponet = "hatatatatatatatata....";

            try
            {
                string commandQuery = "";
                commandQuery = " delete top(" + addedCount + ") " + tableName;
                using (SqlCommand com = new SqlCommand(commandQuery, conn))
                {
                    com.ExecuteNonQuery();
                }
                answerComponet = addedCount + " Adet School Sildi item";

            }
            catch (System.Exception e)
            {
                answerComponet = "School update ederken hata verdi";
                throw;
            }
            return answerComponet;

        }

    }
}
