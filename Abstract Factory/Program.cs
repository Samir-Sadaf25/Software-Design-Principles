using Abstract_Factory;

IFurnitureFactory factory = new VictorianFurnitureFactory();
var chair = factory.CreateChair();
var sofa = factory.CreateSofa();
