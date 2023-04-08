using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoposCRUD.Models
{
    public class Product:baseEnity
    {
        
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public float ProductPrice { get; set; }
        public int ProductKdv { get; set; }

    }
}
