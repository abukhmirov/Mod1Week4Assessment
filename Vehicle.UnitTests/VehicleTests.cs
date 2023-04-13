namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }


        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");


            Assert.Equal("This Blue vehicle has 2 wheels, and has driven 0 miles.", andysBike.Sumary());


        }

        [Fact]
        public void MilesDriven_IsAddedCorrectly()
        {
            Vehicle megansCar = new Vehicle(2, "Blue");
            megansCar.Drive();
            Assert.Equal(5, megansCar.MilesDriven);
        }
        [Fact]
        public void Paint_IsChangedCorrectly()
        {
            Vehicle megansCar = new Vehicle(4, "Green");
            megansCar.Paint("Blue");
            Assert.Equal("Blue", megansCar.Color);
        }
    }
}