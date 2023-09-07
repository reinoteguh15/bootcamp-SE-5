namespace VehicleDealer;

class Car : Vehicle
{
	public string? carBrand;
	public new string? fuelType;
	
	public Car(string carBrand, string fuelType)
	{
		this.carBrand = carBrand;
		this.fuelType = fuelType;
	}
	
}
