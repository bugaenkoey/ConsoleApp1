using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Home home1 = new Home { Street = "Лесная", HouseNumber = 11 };
                Home home2 = new Home { Street = "Горького", HouseNumber = 29 };
                Home home3 = new Home { Street = "Gagarina", HouseNumber = 44 };
                Home home4 = new Home { Street = "Vinogradnaya", HouseNumber = 6 };


             /*   db.Homes.Add(home2); 
                db.Homes.Add(home1);
             */   // создаем два объекта User
                User user1 = new User { Name = "Vova", Age = 33,Home = home3 };
                User user2 = new User { Name = "Luda", Age = 26, Home = home4 };


                // добавляем их в бд
             /*   db.Users.Add(user1);
                db.Users.Add(user2);
                db.Users.Add(new User { Name = "Vasa", Age = 14, Home = home3 });
                db.Users.Add(new User { Name = "Kola", Age = 47, Home = home3 });
                db.Users.Add(new User { Name = "Gena", Age = 51, Home = home4 });
*/
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}\t{u.Home?.Street}\t{u.Home?.HouseNumber}");
                }

                //var dbVar = db.Homes.Include(h => h.Street).OrderByDescending(h => h.Street).FirstOrDefault();
            }
            // Редактирование
            using (ApplicationContext db = new ApplicationContext())
            {
                // получаем первый объект
                User user = db.Users.OrderBy(u=> u.Age).FirstOrDefault();
                if (user != null)
                {
                    user.Name = "Gosha";
                    user.Age = 99;
                    //обновляем объект
                    //db.Users.Update(user);
                    db.SaveChanges();
                }
                var users = db.Users.ToList();

                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}\t{u.Home?.Street}\t{u.Home?.HouseNumber}");
                }
              //  User user22 = db.Users.Last();
                //Console.WriteLine(user22);


            }
                Console.Read();
        }
    }
    
}
