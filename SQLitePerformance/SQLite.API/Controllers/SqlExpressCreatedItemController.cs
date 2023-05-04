using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SQLite.API.Classes;
using SQLite.API.Classes.Abstract;
using SQLite.API.Classes.Service;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SQLite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SqlExpressCreatedItemController : ControllerBase
    {
        private IConfiguration Configuration { get; }
        private IDatabaseCRUD crudService;
       
        private int ItemCount = 1000000;
        private int foreignKeyNum = 5;
        public SqlExpressCreatedItemController()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

            /* db connection string find */
            string connec = Configuration.GetConnectionString("sqlExpressConnect");

            crudService = new SqlExpressCRUD(connec);
        }
        [HttpGet]
        [Route("[action]/{TableName}")]
        public string ItemAdded(string TableName)
        {
            Logger.LogWriter("SQLExpress ", " Ekleme İşlemi Başladı --> "+ TableName , 0);
            var outResult= crudService.AddedDB(TableName, ItemCount, foreignKeyNum);
            Logger.LogWriter("SQLExpress ", outResult,1 );
            return outResult;/* tablo ismi, kayıt sayısı, yabancı anahtar */
        }

        [HttpGet]
        [Route("[action]/{TableName}")]
        public string ItemListAll(string TableName)
        {
            Logger.LogWriter("SQLExpress ", " Listeleme Başladı --> "+ TableName, 0);
            var list = crudService.GetAll(TableName);
            string answer = list.Rows.Count + " Kayıt Listelendi..";
            Logger.LogWriter("SQLExpress ", answer,1);
            return answer;
        }

        [HttpGet]
        [Route("[action]")]
        public string ItemListInnerJoin()
        {
            Logger.LogWriter("SQLExpress ", " Listeleme Başladı --> Tüm Tablolar", 0);
            string query = "select s.* ,c.*,d.* from Schools s INNER JOIN SchoolClasses c on s.SchoolID=c.ClassSchoolID INNER JOIN SchoolStudents d on c.ClassID=d.StudentClassID ";
            var list = crudService.QueryRun(query);
            string answer = list.Rows.Count + " Kayıt Listelendi..";
            Logger.LogWriter("SQLExpress ", answer, 1);
            return answer;
        }
        [HttpGet]
        [Route("[action]/{TableName}")]
        public string ItemUpdated(string TableName)
        {
            Logger.LogWriter("SQLExpress ", " Update İşlemi Başladı --> "+ TableName, 0);
            var outResult = crudService.UpdatedDB(TableName, ItemCount, foreignKeyNum);
            Logger.LogWriter("SQLExpress ", outResult, 1);
            return outResult;/* tablo ismi, kayıt sayısı, yabancı anahtar */
        }
        [HttpGet]
        [Route("[action]/{TableName}")]
        public string ItemDeleted(string TableName)
        {
            Logger.LogWriter("SQLExpress ", " Delete İşlemi Başladı --> Schools", 0);
            var outResult = crudService.DeletedDB(TableName, ItemCount);
            Logger.LogWriter("SQLExpress ", outResult, 1);
            return outResult;/* tablo ismi, kayıt sayısı, yabancı anahtar */
        }
    }
}
