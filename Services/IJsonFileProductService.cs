﻿using System;
using ContosoCrafts.Website.Models;

namespace ContosoCrafts.Website.Services
{
	public interface IJsonFileProductService
	{
		IEnumerable<Product> GetProducts();

		void AddRating(string productId, int rating);
	}
}

