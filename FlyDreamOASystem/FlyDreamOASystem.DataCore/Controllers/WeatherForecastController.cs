using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FlyDreamOASystem.DataCore.DisposeMD5;
namespace FlyDreamOASystem.DataCore.Controllers
{
    [EnableCors("Allow")]
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        public IBLL.IDictionaryManage Dictionary { set; get; }
        public IBLL.IUserManage.IUserManage Users{ get; set; }
        public IBLL.IPersonneiMattersManage.IDepartmentManage Service { get; set; }
        public WeatherForecastController(ILogger<WeatherForecastController> logger,IBLL.IDictionaryManage dictionary, 
            IBLL.IUserManage.IUserManage users, IBLL.IPersonneiMattersManage.IDepartmentManage service)
        {
            _logger = logger;
            Dictionary = dictionary;
            Users = users;
            Service = service;
        }
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> CheckingUser(string userName, string pass)
        {
            if (await Users.ExistsUser(userName, pass.CalcMD5()))
            {
                var client = new HttpClient();
                var disco = await client.GetDiscoveryDocumentAsync("http://localhost:9999");
                if (disco.IsError)
                {

                    return Content(disco.Error);
                }
                var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
                {
                    Address = disco.TokenEndpoint,

                    ClientId = "clientApi",
                    ClientSecret = "511536EF-F270-4058-80CA-1C89C192F69A",
                    Scope = "DataCore"
                });
                if (tokenResponse.IsError)
                {
                    return Content(tokenResponse.Error);
                }
                Shared.ResponseData.UserName = userName;
                return Ok(new { token = tokenResponse.AccessToken });
            }
            else
            {

                return Ok(new { Message = "登录失败" });
            }
        }
        /// <summary>
        /// 注册账号
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> RegisterUser(string name, string pass)
        {
            return Ok(await Users.RegisterUser(name, pass.CalcMD5()));
        }


        /// <summary>
        /// 这是自定义接口
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public  IActionResult Self() 
        {   
           return Content("共享值"+Shared.ResponseData.UserName);
        }
        [HttpGet]
        public   IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
