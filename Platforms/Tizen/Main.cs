using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Proyecto_MAUI_Parte_2_Rick_And_Morty;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
