﻿using CsvImporter.Application.Implementation;
using CsvImporter.Application.Interfaces;
using CsvImporter.DataAccess;
using CsvImporter.Domain.Common;
using Microsoft.Extensions.DependencyInjection;

namespace CsvImporter.Application
{
	public static class IOCConfiguration
	{
		public static void RegisterApplicationDependencies(this IServiceCollection container)
		{
			container.AddScoped<IApplicationSettingsManager, ApplicationSettingsManager>();
			container.RegisterDataAccessDependencies();
			container.AddScoped<IStockProductService, StockProductService>();
			container.AddScoped<IDataBaseStructureService, DataBaseStructureService>();
			container.AddScoped<IBlobService, BlobService>();
		}
	}
}
