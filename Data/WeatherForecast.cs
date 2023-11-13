namespace Proyecto_MAUI_Parte_2_Rick_And_Morty.Data;

public class WeatherForecast
{
	public DateTime Date { get; set; }

	public int TemperatureC { get; set; }

	public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

	public string Summary { get; set; }
}
