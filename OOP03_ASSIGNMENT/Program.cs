namespace OOP03_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deriver deriver = new Deriver(1234, "mohamed", 010232424);

            // b. Create a DeliveryCenter
            DeliveryCenter Delivery_c = new DeliveryCenter();

            // c. Assign the Driver to the DeliveryCenter
            Delivery_c.Deriver = deriver;

            // d. Create one StandardShipment
            DeliveryAddress destination = new DeliveryAddress("cairo", "str1", 12);
            StandardShipment standard_S = new StandardShipment("mo", "standard", 12.3m, 300m, destination);

            // e. Create one ExpressShipment
            DeliveryAddress destination_e = new DeliveryAddress("giza", "str2", 13);
            ExpressShipment Express_s = new ExpressShipment("ahmed", "Express", 18.3m, 700m, destination_e, 233m);

            // f. Create one InternationalShipment
            DeliveryAddress destination_i = new DeliveryAddress("london", "str3", 14);
            InternationalShipment international_S = new InternationalShipment("Alex", "international", 18.3m, 700m, destination_i, "England", 233m);

            // g. Add all shipments to the DeliveryCenter
            Delivery_c.AddShipment(standard_S);
            Delivery_c.AddShipment(Express_s);
            Delivery_c.AddShipment(international_S);

            // h. Print all shipments using PrintAllShipments()
            Console.WriteLine("================= All Shipments ========================");
            Delivery_c.PrintAllShipments();

            // i. Call DeliveryHelper.PrintShipmentDetails() for each shipment
            Console.WriteLine("================= Shipment Details =====================");
            DeliveryHelper.PrintShipmentDetails(standard_S);
            DeliveryHelper.PrintShipmentDetails(Express_s);
            DeliveryHelper.PrintShipmentDetails(international_S);

            // j. Demonstrate both versions of UpdateWeight()
            Console.WriteLine("================= Update Weight ========================");
            decimal pack_weight = 2.9m;
            decimal new_weight = 3.9m;
            international_S.weight_update(new_weight, pack_weight); 
            international_S.weight_update(new_weight);              

            // k. Build a Shipment[] holding mixed types and print all of them in a loop
            Console.WriteLine("================= Shipment Array =======================");
            Shipment[] shipmentArray = { standard_S, Express_s, international_S };
            foreach (Shipment sh in shipmentArray)
            {
                sh.PrintShipment(); 
                Console.WriteLine();
            }

           
            Console.WriteLine("================= Sealed Class & Method ================");
            Console.WriteLine("Completed_Class--> sealed Class");

            Console.WriteLine("GenerateCustomsReport() --> sealed method");

        }
    }
}
