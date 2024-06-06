using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RestSharp;//依赖版本106.15.0 https://www.nuget.org/packages/RestSharp/106.15.0
using Newtonsoft.Json; //https://www.nuget.org/packages/Newtonsoft.Json

namespace projectT
{


    public class CarIdentity
    {

        const string API_KEY = "BxZFqBQDMQ3gLuif4De1NwWf";
        const string SECRET_KEY = "HgDGRJjvheqjjbvNwH7El8gOCw3mTlb7";

        public static string getNumber(string path)
        {
            var client = new RestClient($"https://aip.baidubce.com/rest/2.0/ocr/v1/license_plate?access_token={GetAccessToken()}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            // image 可以通过 GetFileBase64Content('C:\fakepath\OIP-C.jpg') 方法获取
            request.AddParameter("image", GetFileContentAsBase64(path));
            request.AddParameter("multi_detect", "false");
            request.AddParameter("multi_scale", "false");
            IRestResponse response = client.Execute(request);
            var licensePlateInfo = JsonConvert.DeserializeObject<LicensePlateResult>(response.Content);
            return licensePlateInfo.words_result.number;

        }

        /**
        * 获取文件base64编码
        * @param path 文件路径
        * @return base64编码信息，不带文件头
        */
        static string GetFileContentAsBase64(string path)
        {
            using (FileStream filestream = new FileStream(path, FileMode.Open))
            {
                byte[] arr = new byte[filestream.Length];
                filestream.Read(arr, 0, (int)filestream.Length);
                string base64 = Convert.ToBase64String(arr);
                return base64;
            }
        }


        /**
        * 使用 AK，SK 生成鉴权签名（Access Token）
        * @return 鉴权签名信息（Access Token）
        */
        static string GetAccessToken()
        {
            var client = new RestClient($"https://aip.baidubce.com/oauth/2.0/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", API_KEY);
            request.AddParameter("client_secret", SECRET_KEY);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var result = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return result.access_token.ToString();
        }
        public class LicensePlateResult
        {
            public WordsResult words_result { get; set; }
            public string log_id { get; set; }
        }

        public class WordsResult
        {
            public string number { get; set; }
            public List<Vertex> vertexes_location { get; set; }
            public string color { get; set; }
            public List<double> probability { get; set; }
        }

        public class Vertex
        {
            public int x { get; set; }
            public int y { get; set; }
        }

    }
}
