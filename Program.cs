namespace Session05_AssignmentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1
            // a) it copies the reference of the object in heap, so any change in any object with change the another object
            // b) no it copies the reference of the object in heap, so the two objects will refer to the same object in heap
            // c) copying the reference means the to objects refer to the same object in heap soany change in any object with
            // change the another object
            // but coping an object is creating another object in heap
            #endregion

            #region Q2
            // a) shallow copy create a new object in heap, and copies the values inside the object value type or reference type,
            // and does not make new objects for the reference type values
            // b) deep copy create new object in heap, copy the value of value type, but create new objects for the reference type
            // values
            // c) the new object copies the reference of the reference type values
            // d) will create new objects for the reference type values
            // e) when getting a data from database in an object and we do not want to change that data but want to make calculation
            // or testing on it only
            #endregion

            #region Q3
            // a) static fields do not relate to an object, they shared along all objects, do not change from one object and another
            // on, but instance member relate to an object, they do not shared among objects, any object has a new copy of instance
            // members
            // b) the static method related to class not object, so it called by class, can not access instance members, contains only
            // static members
            // c) static constructor used to initialize values to static fields only, executed in run time the first constructor, and
            // does not execute another time (execute one time only)
            // d) static class contain static fields and methods only, can not create object of static class
            #endregion

            #region Q4
            // a) extension method is a method in a class but related to another class, as if we want to add method to a built-in class
            // so we make that by extension method
            // b) this
            // c) in static class
            // d) no
            #endregion

            #region Q5
            // a) a partial class is a part of class, when we have a big class so we separate it to parts, each part is a partial class,
            // but the compiler sees them as one class
            // b) when we have a big class so we separate it to parts, each part is a partial class, to make the code readable not complex
            // c) the partial method when we write the signature of method in partial class, and write the implementation of that method
            // in another partial class
            // d) it makes error
            #endregion
            #endregion

            #region Part 02 — Practical

            #region Q1
            //StandardShipment shipment01 = new StandardShipment("sh001", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Tahrir", 3));
            //StandardShipment shipment02 = shipment01.CopyShipment();
            //StandardShipment shipment03 = shipment01;
            //Console.WriteLine("Shipment01");
            //Console.WriteLine(shipment01.Description);
            //Console.WriteLine(shipment01.Weight);
            //Console.WriteLine(shipment01.Destination.City);
            //Console.WriteLine(shipment01.GetHashCode());
            //Console.WriteLine("Shipment02");
            //Console.WriteLine(shipment02.Description);
            //Console.WriteLine(shipment02.Weight);
            //Console.WriteLine(shipment02.Destination.City);
            //Console.WriteLine(shipment02.GetHashCode());
            //Console.WriteLine("Shipment03");
            //Console.WriteLine(shipment03.Description);
            //Console.WriteLine(shipment03.Weight);
            //Console.WriteLine(shipment03.Destination.City);
            //Console.WriteLine(shipment03.GetHashCode());
            //shipment02.Description = "Mobile";
            //shipment02.Weight = 7;

            //shipment02.Destination.City = "Alex";
            //shipment03.Description = "TV";
            //shipment03.Weight = 8;
            //shipment03.Destination.City = "Giza";
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("After update");
            //Console.WriteLine("Shipment01");
            //Console.WriteLine(shipment01.Description);
            //Console.WriteLine(shipment01.Weight);
            //Console.WriteLine(shipment01.Destination.City);
            //Console.WriteLine(shipment01.GetHashCode());
            //Console.WriteLine("Shipment02");
            //Console.WriteLine(shipment02.Description);
            //Console.WriteLine(shipment02.Weight);
            //Console.WriteLine(shipment02.Destination.City);
            //Console.WriteLine(shipment02.GetHashCode());
            //Console.WriteLine("Shipment03");
            //Console.WriteLine(shipment03.Description);
            //Console.WriteLine(shipment03.Weight);
            //Console.WriteLine(shipment03.Destination.City);
            //Console.WriteLine(shipment03.GetHashCode());
            #endregion

            #region Q2
            StandardShipment shipment01 = new StandardShipment("sh001", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Tahrir", 3));
            StandardShipment shipment02 = shipment01.ShallowCopy();
            //Console.WriteLine("Shipment01");
            //Console.WriteLine(shipment01.Description);
            //Console.WriteLine(shipment01.Weight);
            //Console.WriteLine(shipment01.Destination.City);
            //Console.WriteLine(shipment01.GetHashCode());
            //Console.WriteLine("Shipment02");
            //Console.WriteLine(shipment02.Description);
            //Console.WriteLine(shipment02.Weight);
            //Console.WriteLine(shipment02.Destination.City);
            //Console.WriteLine(shipment02.GetHashCode());
            //shipment02.Description = "Mobile";
            //shipment02.Weight = 7;
            //shipment02.Destination.City = "Alex";
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("After update");
            //Console.WriteLine("Shipment01");
            //Console.WriteLine(shipment01.Description);
            //Console.WriteLine(shipment01.Weight);
            //Console.WriteLine(shipment01.Destination.City);
            //Console.WriteLine(shipment01.GetHashCode());
            //Console.WriteLine("Shipment02");
            //Console.WriteLine(shipment02.Description);
            //Console.WriteLine(shipment02.Weight);
            //Console.WriteLine(shipment02.Destination.City);
            //Console.WriteLine(shipment02.GetHashCode());
            #endregion

            #region Q3
            //StandardShipment shipment01 = new StandardShipment("sh001", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Tahrir", 3));
            shipment02 = shipment01.DeepCopy();
            //Console.WriteLine("Shipment01");
            //Console.WriteLine(shipment01.Description);
            //Console.WriteLine(shipment01.Weight);
            //Console.WriteLine(shipment01.Destination.City);
            //Console.WriteLine(shipment01.GetHashCode());
            //Console.WriteLine("Shipment02");
            //Console.WriteLine(shipment02.Description);
            //Console.WriteLine(shipment02.Weight);
            //Console.WriteLine(shipment02.Destination.City);
            //Console.WriteLine(shipment02.GetHashCode());
            //shipment02.Description = "Mobile";
            //shipment02.Weight = 7;
            //shipment02.Destination.City = "Giza";
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("After update");
            //Console.WriteLine("Shipment01");
            //Console.WriteLine(shipment01.Description);
            //Console.WriteLine(shipment01.Weight);
            //Console.WriteLine(shipment01.Destination.City);
            //Console.WriteLine(shipment01.GetHashCode());
            //Console.WriteLine("Shipment02");
            //Console.WriteLine(shipment02.Description);
            //Console.WriteLine(shipment02.Weight);
            //Console.WriteLine(shipment02.Destination.City);
            //Console.WriteLine(shipment02.GetHashCode());
            #endregion

            #region Q4

            #endregion

            #region Q5

            #endregion

            #region Q6
            //Console.WriteLine($"Total Shipment Created : {Shipment.GetTotalShipmentsCreated()}");

            #endregion

            #region Q7
            //DeliveryUtilities.PrintSeparator();
            //DeliveryUtilities.PrintSystemTitle();
            //DeliveryUtilities.PrintSeparator();
            #endregion

            #region Q8
            //StandardShipment shipment = new StandardShipment("sh001", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Tahrir", 3));
            //Console.WriteLine(shipment.GetSummary());
            //Console.WriteLine(shipment.IsDelivered());

            #endregion

            #region Q9

            #endregion

            #region Q10
            StandardShipment shipment = new StandardShipment("sh001", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Tahrir", 3));
            shipment.UpdateTrackingStatus("Delivered");
            #endregion
            #endregion
        }
    }
}
