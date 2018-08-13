using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LemmaSharp.Classes;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using Lemmatozator.Convertor;

namespace Lemmatozator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
			//var LemFilePath = @"C:\Users\D.Pugach\Downloads\full7z-mlteast-ru.lem";
			//var filePath = @"C:\Users\D.Pugach\Downloads\test.txt";
			//var stream = File.OpenRead(LemFilePath);
			var sb = new StringBuilder();
			var stream = new FileStream(@"C:\Users\D.Pugach\Downloads\full7z-mlteast-ru.lem", FileMode.Open);
			using (stream) {
				var allText = "Вазомоторный ринит что это такое Среди многочисленных видов ринита (насморка) эта патология занимает особое место, поскольку этиология ее возникновения до сих пор до конца не изучена. Вазомоторный ринит, чаще всего поражающий людей старше 20 лет, является заболеванием, которое может протекать в виде";
				var lemmatizer = new Lemmatizer(stream);
				
				lemmatizer.Lemmatize(allText.ToLower());
				foreach (var word in allText.Split(' ')) {
					sb.Append(lemmatizer.Lemmatize(word)).Append(" ");
				}
				Console.WriteLine(sb.ToString());
			}

			return new string[] { sb.ToString() };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

		[HttpPost]
		public ActionResult<string> Post([FromBody] string value) {
			var request = JsonConvert.DeserializeObject<JSONRequest>(value);
			var uniqueTextConvertor = new UniqueTextConvertor(request.Exacts);
			var str = uniqueTextConvertor.Convert(request.Content);
			return str;
		}

		[HttpPost("{id}")]
		public void Post(Object value) {
		}

		// PUT api/values/5
		[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
