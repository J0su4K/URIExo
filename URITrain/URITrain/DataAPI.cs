using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace URITrain
{
    public  class DataAPI
    {

        public string GetDataFromAPI(string _url)
        {
            if (string.IsNullOrEmpty(_url)) return null;
            HttpClient _client = new HttpClient();
            TaskAwaiter<string> _awaiter = _client.GetStringAsync(_url).GetAwaiter();
            return _awaiter.GetResult();
        }

        public void GetDataWithWebClient(string _url)
        {
            WebClient _request = new WebClient();
            if(string.IsNullOrEmpty(_url)) return;
            _request.DownloadStringAsync(new Uri(_url));
        }

    }
}
