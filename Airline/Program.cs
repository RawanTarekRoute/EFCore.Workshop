using Airline.Enities;
using Microsoft.EntityFrameworkCore;
using AirlineModel = Airline.Enities.Airline;

namespace Airline
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ################################################ Assignment 03 ###########################################

            using AirlineDbContext airlineDbContext = new();


            #region  a. Insert a new airline named "EgyptAir" with contact person "Ahmed Ali", phone "0123456789" and “0113654789”, and address "Cairo".

            // Detached
            //var airline = new AirlineModel()
            //{
            //    Name = "EgyptAir",
            //    ContactPerson = "Ahmed Ali",
            //    Phones = [new AirlinePhones { Phone = "0123456789" }, new AirlinePhones { Phone = "0113654789" }],
            //    Address = "Cairo"
            //};

            //Console.WriteLine(airlineDbContext.Entry(airline).State); // Detached

            //airlineDbContext.Airlines.Add(airline); // Added

            //airlineDbContext.SaveChanges(); // Unchaanged
            #endregion

            #region b. Add a new aircraft with model "Model01", capacity 180, and airline = "EgyptAir".

            //var airline = airlineDbContext.Airlines.FirstOrDefault(a => a.Name == "EgyptAir");

            //if (airline is not null)
            //{
            //    var aircraft = new Aircraft()
            //    {
            //        Model = "Model01",
            //        Capacity = 180,
            //        AirlineId = airline.Id
            //    };

            //     airlineDbContext.Aircrafts.Add(aircraft);
            //     airlineDbContext.SaveChanges();
            //}






            #endregion

            #region c.Record a new transaction of amount 50000 with description "Tickets" for "EgyptAir".

            //var airline = airlineDbContext.Airlines.FirstOrDefault(a => a.Name == "EgyptAir");

            //if (airline is not null)
            //{
            //    var transaction = new Transaction()
            //    {
            //        Amount = 50000,
            //        Description = "Tickets",
            //        AirlineId = airline.Id
            //    };

            //        airlineDbContext.Transactions.Add(transaction);
            //        airlineDbContext.SaveChanges();
            //}





            #endregion

            #region d. Select all employees who work in "EgyptAir".

            //var airline = airlineDbContext.Airlines.FirstOrDefault(a => a.Name == "EgyptAir");


            // Insertion for employee

            //var Employee = new Employee
            //{
            //    Name = "Aliaa Tarek",
            //    Position = "Instructor",
            //    Address = "Cairo",
            //    AirlineId = airline.Id // The id of the airline "EgyptAir"
            //};

            //airlineDbContext.Employees.Add(Employee);
            //airlineDbContext.SaveChanges();




            //var employees = airlineDbContext.Employees
            //                                  .Where(e => e.AirlineId == airline.Id)
            //                                  .ToList();


            //foreach (var employee in employees)
            //    Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}, Address: {employee.Address}");






            #endregion

            #region e. Show all transactions (id, description, amount) recorded by "EgyptAir".
            //var airline = airlineDbContext.Airlines.FirstOrDefault(a => a.Name == "EgyptAir");

            //var transactions = airlineDbContext.Transactions
            //                                     .Where(t => t.AirlineId == airline.Id)
            //                                     .Select(t => new { t.Id, t.Description, t.Amount })
            //                                     .ToList();

            //foreach (var transaction in transactions)
            //    Console.WriteLine($"Id: {transaction.Id}, Description: {transaction.Description}, Amount: {transaction.Amount}");




            #endregion

            #region f. Get the total number of employees working in each airline.

            //var employeeCount = airlineDbContext.Airlines
            //                                                .Select(a => new
            //                                                {
            //                                                    AirlineName = a.Name,
            //                                                    EmployeesCount = a.Employees.Count()
            //                                                });


            //foreach (var item in employeeCount)
            //    Console.WriteLine($"Airline: {item.AirlineName}, Employees Count: {item.EmployeesCount}");



            #endregion

            #region g. Change the capacity of the “Model01”  aircraft to 200.

            //var aircraft = airlineDbContext.Aircrafts.FirstOrDefault(a => a.Model == "Model01");

            //if (aircraft is not null)
            //{
            //    aircraft.Capacity = 200;
            //    airlineDbContext.SaveChanges();
            //}


            #endregion

            #region h. Delete all transactions older than 2020.

            //var OldTransactions = airlineDbContext.Transactions
            //                                                      .Where(t => t.Date.Year < 2020)
            //                                                      .ToList();



            //if (OldTransactions.Count != 0)
            //{
            //   foreach (var transaction in OldTransactions)
            //        Console.WriteLine($"Id: {transaction.Id}, Description: {transaction.Description}, Amount: {transaction.Amount}, Date: {transaction.Date}");

            //    airlineDbContext.Transactions.RemoveRange(OldTransactions);
            //    airlineDbContext.SaveChanges();

            //}



            #endregion

            #region i. Insert a new route from "Cairo" to "Dubai", classification "International", distance 2400 km.

            //var route = new Route()
            //{
            //    Origin = "Cairo",
            //    Destination = "Dubai",
            //    Classification = "International",
            //    Distance = 2400
            //};

            //airlineDbContext.Routes.Add(route);
            //airlineDbContext.SaveChanges();


            #endregion

            #region j. Assign  “Model01”  aircraft to Route From  "Cairo" to "Dubai". With duration 4 hours, price 3000 LE

            //var aircraft = airlineDbContext.Aircrafts.FirstOrDefault(a => a.Model == "Model01");
            //var route = airlineDbContext.Routes.FirstOrDefault(r => r.Origin == "Cairo" && r.Destination == "Dubai");

            //if (aircraft is not null && route is not null)
            //{
            //    var aircraftAssignedToRoute = new AircraftRoute()
            //    {
            //        AircraftId = aircraft.Id,
            //        RouteId = route.Id,
            //        Duration = 4,
            //        Price = 3000
            //    };

            //    airlineDbContext.AircraftRoutes.Add(aircraftAssignedToRoute);
            //    airlineDbContext.SaveChanges();
            //}

            #endregion


            // ################################################ Assignment 04 ###########################################

            #region 1. Load "EgyptAir" With all its aircrafts and their routes

            // Eager Loading

            //var airline = airlineDbContext.Airlines
            //                                        .Include(a => a.Aircrafts)
            //                                        .ThenInclude(ac => ac.AircraftRoutes)
            //                                        .ThenInclude(ar => ar.Route)
            //                                        .FirstOrDefault(a => a.Name == "EgyptAir");


            //if (airline is not null)
            //{
            //    Console.WriteLine($"Airline: {airline.Name}");
            //    foreach (var aircraft in airline.Aircrafts)
            //    {
            //        Console.WriteLine($"\tAircraft Model: {aircraft.Model}, Capacity: {aircraft.Capacity}");
            //        foreach (var aircraftRoute in aircraft.AircraftRoutes)
            //        {
            //            Console.WriteLine($"\t\tRoute: {aircraftRoute.Route.Origin} to {aircraftRoute.Route.Destination}, Classification: {aircraftRoute.Route.Classification}, Distance: {aircraftRoute.Route.Distance} km");
            //        }
            //    }
            //}



            #endregion

            #region 2. Retrieve all airlines with their employees, and for each employee load their qualifications.


            // 1. Inserting a new Employee with Qualifications to demonstrate the functionality
            var empployee = new Employee()
            {
                Name = "Rawan Tarek",
                Address = "Giza",
                Position = "Mentor",
                Qualifications = [new EmployeeQualifications { Qualification = "Software Engineer" }, new EmployeeQualifications { Qualification = ".Net Developer" }],
                AirlineId = 1
            };

            //airlineDbContext.Employees.Add(empployee);
            //airlineDbContext.SaveChanges();


            // Eager Loading

            //var airlineWithEmployees = airlineDbContext.Airlines
            //                                           .Include(a => a.Employees)
            //                                           .ThenInclude(e => e.Qualifications);



            //foreach (var airline in airlineWithEmployees)
            //{
            //    Console.WriteLine(airline.Name);
            //    foreach (var employee in airline.Employees)
            //    {
            //        Console.WriteLine(employee.Name);
            //        foreach (var qualification in employee.Qualifications)
            //            Console.Write($"Qualification: {qualification.Qualification} ");
            //    }

            //}




            #endregion

            #region 3. Load all airlines with their transactions, but only include transactions where Amount > 10000

            //var transactionAbove10000 = new Transaction
            //{
            //    Amount = 15000,
            //    Description = "Tickets",
            //    Date = new DateTime(2021, 5, 1),
            //    AirlineId = 1
            //};

            //var transactionBelow10000 = new Transaction
            //{
            //    Amount = 8000,
            //    Description = "Tickets",
            //    Date = new DateTime(2019, 3, 1),
            //    AirlineId = 1
            //};

            //airlineDbContext.Transactions.AddRange(transactionAbove10000, transactionBelow10000);
            //airlineDbContext.SaveChanges();


            // Explicit Loading
            //var airlines = airlineDbContext.Airlines.ToList();

            //foreach( var airline in airlines)
            //{
            //    airlineDbContext.Entry(airline).Collection(a => a.Transactions)
            //                                          .Query()
            //                                          .Where(t => t.Amount > 10000)
            //                                          .Load();


            //    Console.WriteLine(airline.Name);
            //    foreach (var transaction in airline.Transactions)
            //        Console.WriteLine($"Transaction Id: {transaction.Id}, Amount: {transaction.Amount}, Description: {transaction.Description}");

            //}




            #endregion

            #region  4. Select all routes along with the model of aircrafts assignedto them

            // Using Select [Projection]

            //var routes = airlineDbContext.Routes
            //                                        .Select(r => new
            //                                        {
            //                                            r.Origin,
            //                                            r.Destination,
            //                                            AircraftModels = r.AircraftRoutes.Select(ar => ar.Aircraft.Model).ToList()
            //                                        });


            //foreach (var route in routes)
            //{
            //    Console.WriteLine($"Route Origin: {route.Origin}");
            //    Console.WriteLine($"Route Destination: {route.Destination}");
            //    foreach (var aircraftModel in route.AircraftModels)
            //        Console.WriteLine($"Aircraft Model: {aircraftModel}");
            //}




            #endregion

            #region 5. Retrieve all aircrafts with their airline and the airline’s phones.

            // 1. Install the package Microsoft.EntityFrameworkCore.Proxies
            // 2. UseLazyLoadingProxies in OnConfiguring method in DbContext class
            // 3. Make navigation properties virtual
            // 4. Ensure all classes are public or internal but add the annotation [assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

            var aircrafts = airlineDbContext.Aircrafts.ToList();

            foreach (var aircraft in aircrafts)
            {
                Console.WriteLine($"Aircraft Model: {aircraft.Model}, Capacity: {aircraft.Capacity}");
                Console.WriteLine($"Airline: {aircraft.Airline.Name}");
                foreach (var phone in aircraft.Airline.Phones)
                    Console.WriteLine($"Phone: {phone.Phone}");
            }


            #endregion

        }
    }
}

