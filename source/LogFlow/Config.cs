﻿using System;
using System.Configuration;
using System.IO;

namespace LogFlow
{
	internal static class Config
	{
		public static string StoragePath
		{
			get
			{
				return ConfigurationManager.AppSettings["StoragePath"] ??
				       Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StateStorage");
			}
		}

		private static bool IsTrue(this string str)
		{
			if (!string.IsNullOrWhiteSpace(str))
			{
				return str.Equals("1") || str.ToLower().Equals("true");
			}

			return false;
		}
	}
}
