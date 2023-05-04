using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SQLite.API.Classes;
using SQLite.API.Classes.Abstract;
using SQLite.API.Classes.Service;
using System.Collections.Generic;
using System.IO;


namespace SQLite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class SqliteCreatedItemController : ControllerBase
    {
        // GET: api/<SqliteCreatedItemController>
        private IConfiguration Configuration { get; }
        private IDatabaseCRUD crudService;
        private int ItemCount = 1;
        private int foreignKeyNum = 500;
        public SqliteCreatedItemController()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

            /* db connection string find */
            string connec = Configuration["SqliteConString:urlString"];

            connec += Path.GetFullPath(".")+ "\\" + Configuration["SqliteConString:fileName"];

            connec += Configuration["SqliteConString:version"];
            
            crudService = new SqliteCRUDService(connec);
        }
        [HttpGet]
        [HttpGet]
        [Route("[action]/{TableName}")]
        public string ItemAdded(string TableName)
        {
            Logger.LogWriter("SQLite ", " Ekleme İşlemi Başladı --> " + TableName, 0);
            var outResult = crudService.AddedDB(TableName, ItemCount, foreignKeyNum);
            Logger.LogWriter("SQLite ", outResult, 1);
            return outResult;/* tablo ismi, kayıt sayısı, yabancı anahtar */
        }

        [HttpGet]
        [Route("[action]/{TableName}")]
        public string ItemListAll(string TableName)
        {
            Logger.LogWriter("SQLite ", " Listeleme Başladı --> " + TableName, 0);
            var list = crudService.GetAll(TableName);
            string answer = list.Rows.Count + " Kayıt Listelendi..";
            Logger.LogWriter("SQLite ", answer, 1);
            return answer;
        }

        [HttpGet]
        [Route("[action]")]
        public string ItemListInnerJoin()
        {
            Logger.LogWriter("SQLite ", " Listeleme Başladı --> Tüm Tablolar", 0);
            string query = "select s.* ,c.*,d.* from Schools s INNER JOIN SchoolClasses c on s.SchoolID=c.ClassSchoolID INNER JOIN SchoolStudents d on c.ClassID=d.StudentClassID ";
            var list = crudService.QueryRun(query);
            string answer = list.Rows.Count + " Kayıt Listelendi..";
            Logger.LogWriter("SQLite ", answer, 1);
            return answer;
        }
        [HttpGet]
        [Route("[action]/{TableName}")]
        public string ItemUpdated(string TableName)
        {
            Logger.LogWriter("SQLite ", " Update İşlemi Başladı --> " + TableName, 0);
            var outResult = crudService.UpdatedDB(TableName, ItemCount, foreignKeyNum);
            Logger.LogWriter("SQLite ", outResult, 1);
            return outResult;/* tablo ismi, kayıt sayısı, yabancı anahtar */
        }
        [Route("[action]/{TableName}")]
        public string ItemDeleted(string TableName)
        {
            Logger.LogWriter("SQLite ", " Delete İşlemi Başladı --> Schools", 0);
            var outResult = crudService.DeletedDB(TableName, ItemCount);
            Logger.LogWriter("SQLite ", outResult, 1);
            return outResult;/* tablo ismi, kayıt sayısı, yabancı anahtar */
        }


    }
}
