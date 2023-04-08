// See https://aka.ms/new-console-template for more information
using System.Text;
using DesingPatternBuilder.Classes.ContactBuilder;
using DesingPatternBuilder.Classes.ContactBuilder.Models;
using DesingPatternBuilder.Classes.EndPointBuilderPatern;




// StringBuilder sb = new StringBuilder();

// sb.Append("Hello World")
//     .Append("Hello World")
//     .Append(" derisman");


// Console.WriteLine(sb.ToString());




// var urlBuild=new EndpointBuilder("https://localhost:5001/");
// var url=urlBuild.Append("api/v1/dashboad")
//                 .Append("users//")
//                 .AppendParams("name","ISA")
//                 .AppendParams("age","25")
//                 .Build();
// Console.WriteLine(url);

var Emp=new EmployeeInternal();
            Emp
                .SetName("ISA").SetName("Yusuf")
                .SetLastName("KÖSEOĞLU")
                .SetEmail("isaparta.65@gmail.com")
                .SetPhone("0532 000 00 00")
                .SetName("Yunus")
                .SetAddress("İstanbul");

foreach (var item in Emp.Build().GetType().GetProperties())
{
    Console.WriteLine($"{item.Name} : {item.GetValue(Emp.Build())}");
}