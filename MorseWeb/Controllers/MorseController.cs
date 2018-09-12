using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using MorseWeb.Utilities;

namespace MorseWeb.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MorseController : ControllerBase
  {
    public struct MorseText
    {
      public string original;
      public string result;
    }
    // GET: api/Morse/SOS
    [HttpGet("{id}", Name = "Get")]
    public MorseText Get(string id)
    {
      MorseText mt = new MorseText();
      mt.original = id;
      string[] words = id.ToUpper().Split(' ');
      mt.result = Utilities.ConvertWordsToMorse(words);
      return mt;
    }
  }
}
