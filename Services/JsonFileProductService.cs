using System;
using System.Text.Json;
using ContosoCrafts.Website.Models;

namespace ContosoCrafts.Website.Services
{
	public class JsonFileProductService : IJsonFileProductService
	{
		public JsonFileProductService(IWebHostEnvironment webHostEnvironment) // Constructor
			=> WebHostEnvironment = webHostEnvironment;
		// WebApps are hosted, they live in a host.
		//WebHostEnvironment knows where things are
		// WebHostEnvironment is service.




        public IWebHostEnvironment WebHostEnvironment { get; }

		private string JsonFileName
		{
			get
			{
				return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json");
			}
		}

		public IEnumerable<Product> GetProducts()
		{
			using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
					{
						PropertyNameCaseInsensitive = true
                    });
			}

		
		}
	}
}

