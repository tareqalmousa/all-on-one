using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.redis;

namespace Vidly.Controllers
{
    public class CounterController : Controller
    {
        // GET: Counter
        [AllowAnonymous]
        public ActionResult Counter()
        {
            //var host = ConfigurationManager.AppSettings["host"].ToString();
            //var port = Convert.ToInt32(ConfigurationManager.AppSettings["port"]);
            //RedisEndpoint redisEndpoint = new RedisEndpoint(host, port);
            //var Foo = 0;
            //using (var client = new RedisClient(redisEndpoint))
            //{
            //    Foo = (int)client.Increment("Website_Counter", 1);
            //}
            //return Content(Foo.ToString());
            CacheStrigsStack CacheStrigsStack= new CacheStrigsStack();
            CacheStrigsStack.SetStrings("tareq", "this is value");

            return Content(CacheStrigsStack.GetStrings("tareq"));
        }
    }
}