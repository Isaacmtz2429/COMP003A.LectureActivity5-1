/*
// Author: Isaac Martinez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Demonstrate the creation and usage of classes in C#
*/
namespace COMP003A.LectureActivity5_1
{
    internal class Car
    {
        // Fields
        private static int carCount = 0;
        public string make;
        public string model;
        public int year;

        // Properties
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { if (value >= 1886) year = value; }
        }


        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            carCount++;
        }

        /// <summary>
        /// Display the car information
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Year} {Make} {Model}");
        }

        /// <summary>
        /// Display the car information
        /// </summary>
        public static void DisplayCarCount()
        {
            Console.WriteLine($"Total cars created: {carCount}");
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Civic", 2021); // Create a new Car object using the constructor
            myCar.DisplayInfo(); // display the car information


            myCar.Make = "Toyota"; // Set the car's make
            myCar.Model = "Corolla"; // Set the car's model
            myCar.Year = 2020; // Set the car's year
            myCar.DisplayInfo(); // Display the car's information

            Car myCar2 = new Car("Ford", "Mustang", 2020); // Create a new Car object
            Car myCar3 = new Car("Chevrolet", "Camaro", 2021); // Create a new Car object
            Car.DisplayCarCount();
        }
    }
}
