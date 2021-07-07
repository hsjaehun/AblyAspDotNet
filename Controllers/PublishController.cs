using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IO.Ably;

namespace AblyAspDotNet.Controllers
{
    public class PublishController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult castVote(string button)
        {
            var realtime = new AblyRealtime("0BaVrg.FPCCkg:Bi_JOu2bl5MuCDZ5");
            var channel = realtime.Channels.Get("voting-channel");
            channel.Publish("vote", button);

            return RedirectToAction("Index");
        }
    }
}