using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CaptchaGen;
using FlyDreamOASystem.DAL;
using FlyDreamOASystem.Model;
using IdentityModel.Client;
using Newtonsoft.Json.Linq;

namespace DataTest
{
    class Program
    {
        static  void Main(string[] args)
        {
            //var client = new HttpClient();
            //var disco = await client.GetDiscoveryDocumentAsync("http://localhost:9999");
            //if (disco.IsError)
            //{
            //    Console.WriteLine(disco.Error);
            //    return;
            //}
            //var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            //{
            //    Address = disco.TokenEndpoint,

            //    ClientId = "client",
            //    ClientSecret = "511536EF-F270-4058-80CA-1C89C192F69A",
            //    Scope = "DataCore"
            //});
            //if (tokenResponse.IsError)
            //{
            //    Console.WriteLine(tokenResponse.Error);
            //    return;
            //}
            //Console.WriteLine(tokenResponse.Json);
            //var client2 = new HttpClient();
            //client2.SetBearerToken(tokenResponse.AccessToken);
            //var response = await client2.GetAsync("http://localhost:50933/weatherforecast/get");
            //if (!response.IsSuccessStatusCode)
            //{
            //    Console.WriteLine(response.StatusCode);
            //}
            //else
            //{
            //    var content = await response.Content.ReadAsStringAsync();
            //    Console.WriteLine(JArray.Parse(content));
            //}
            //Assembly asm = Assembly.Load("FlyDreamOASystem.Model");
            //Type[] list = asm.GetTypes().Where(m => m.IsClass && !m.IsAbstract && m.BaseType == typeof(BaseEntity)).ToArray();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Name);
            //}

            Console.WriteLine("s".CalcMD5()) ;
            Console.WriteLine("s".CalcMD5());

        }


      
    }
}
