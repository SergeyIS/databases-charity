using System;
using Overview.Models;
using System.Linq;

namespace Overview
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataContext context = new DataContext("OracleDbContext"))
            {
                try
                {
                    context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

                    //How to select user with id = 0
                    Console.WriteLine("How to select user with id = 0");
                    User user0 = context.Users.Where(c => c.Id == 0).FirstOrDefault();
                    Console.WriteLine(user0);


                    //How to select credentials for user id = 0
                    Console.WriteLine("How to select credentials for user id = 0");
                    UserCredentials credentials0 = context.Credentials.Where(c => c.Username == "David").FirstOrDefault();
                    Console.WriteLine(credentials0);

                    //Join operation
                    Console.WriteLine("Join operation example");
                    var joinExampleSet = context.Users
                        .Join(context.Credentials,
                       u => u.Id,
                       c => c.UserId,
                       (u, c) => new
                       {
                           Id = u.Id,
                           FirstName = u.FirstName,
                           LastName = u.LastName,
                           Username = c.Username,
                           Password = c.Password
                       })
                       .ToList();


                    foreach (var item in joinExampleSet)
                    {
                        Console.WriteLine($"Id: {item.Id}, FirstName: {item.FirstName}, LastName: {item.LastName}, " +
                            $"Username: {item.Username}, Password: {item.Password}");
                    }

                    //Add new user example. Universal approach :)
                    Console.WriteLine("Add new user");
                    int newxId = context.Users.Count();
                    User newUser = new User()
                    {
                        Id = newxId,
                        FirstName = "Mac",
                        LastName = "Duck",
                        Email = "mac.duck@example.com"
                    };

                    context.Users.Add(newUser);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    //Something goes wrong
                    Console.WriteLine(ex.StackTrace);
                }
            }

            Console.ReadKey();
        }
    }
}
