
using System.Text;
namespace DesingPatternBuilder.Classes.EndPointBuilderPatern
{
    public class EndpointBuilder
    {

        // https://localhost:5001/api/v1/Products

      private string BaseUrl { get; set; }
        private readonly StringBuilder sbUrl = new();
        private readonly StringBuilder sbUrlPrams = new();

        private const char defaultDelemiter = '/';
        private const char defaultDelemiterParams = '&';
        public EndpointBuilder(string baseUrl)
       {
            this.BaseUrl=baseUrl;
       }
       public EndpointBuilder Append(string path)
       {
            // localhost:5001/api/v1/Products
            this.sbUrl.Append(path);
            this.sbUrl.Append(defaultDelemiter);
            return this;
       }
        public EndpointBuilder AppendParams(string name, string value)
        {
            // localhost:5001/api/v1/Products?[name=value]
            this.sbUrlPrams.Append($"{name}={value}");
            this.sbUrlPrams.Append(defaultDelemiterParams);
            return this;
        }
        public string Build()
        {
            if (this.BaseUrl.EndsWith(defaultDelemiter))
                
                sbUrl.Insert(0, this.BaseUrl);
                
            else 
                sbUrl.Insert(0, this.BaseUrl + defaultDelemiter);

            var urlPath = sbUrl.ToString().TrimEnd(defaultDelemiter)+defaultDelemiter;
            if(this.sbUrlPrams.Length>0){
                urlPath = urlPath.TrimEnd(defaultDelemiter).TrimEnd('?');
                urlPath += "?";
                urlPath += sbUrlPrams.ToString().TrimEnd(defaultDelemiterParams);
            }
                
            return urlPath.TrimEnd(defaultDelemiter);
        }
    }
}