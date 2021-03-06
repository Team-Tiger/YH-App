﻿using System.Collections.Generic;

namespace Tiger_YH_Admin.Models
{
	public interface IDataStore<T> where T: class
	{
		IEnumerable<T> Load();
		void Save();
		T FindById(string id);
	}
}
