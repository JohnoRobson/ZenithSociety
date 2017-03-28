using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithSociety.Data;

namespace ZenithSociety.Models
{
    public class SeedData {

        public async static void Initialize(IServiceProvider serviceProvider, ApplicationDbContext db) {
            await AddRoles(serviceProvider);
            await AddUsers(serviceProvider);
            AddActivities(db);
            AddEvents(db);
        }

        public static void AddActivities(ApplicationDbContext _db) {
            if (!_db.Activities.Any()) {
                IList<Activity> activities = new List<Activity>();

                activities.Add(new Activity { ActivityDescription = "Go-Karting", CreationDate = new DateTime(2003, 01, 04) });
                activities.Add(new Activity { ActivityDescription = "Super Smash Bros Melee Tournament", CreationDate = new DateTime(2001, 11, 21) });
                activities.Add(new Activity { ActivityDescription = "Tennis", CreationDate = new DateTime(1990, 03, 12) });
                activities.Add(new Activity { ActivityDescription = "Polo", CreationDate = new DateTime(1976, 12, 12) });
                activities.Add(new Activity { ActivityDescription = "Water Polo", CreationDate = new DateTime(2002, 04, 28) });
                activities.Add(new Activity { ActivityDescription = "Competitive Vaping", CreationDate = new DateTime(2015, 10, 29) });

                foreach (Activity act in activities) {
                    _db.Add(act);
                }

                _db.SaveChanges();
            }
        }

        public static void AddEvents(ApplicationDbContext _db) {
            if (!_db.Events.Any()) {
                IList<Event> events = new List<Event>();

                events.Add(new Event {                    EventFromDate = new DateTime(2016, 02, 12, 10, 0, 0),
                    EventToDate = new DateTime(2016, 02, 12, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Go-Karting").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Go-Karting").FirstOrDefault(),
                    CreationDate = new DateTime(2016, 01, 01),
                    IsActive = false
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2016, 04, 14, 11, 0, 0),
                    EventToDate = new DateTime(2016, 04, 14, 13, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Super Smash Bros Melee Tournament").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Super Smash Bros Melee Tournament").FirstOrDefault(),
                    CreationDate = new DateTime(2016, 02, 01),
                    IsActive = false
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2016, 07, 17, 13, 0, 0),
                    EventToDate = new DateTime(2016, 07, 17, 15, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault(),
                    CreationDate = new DateTime(2016, 03, 10),
                    IsActive = false
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 4, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 4, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 5, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 5, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 6, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 6, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 7, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 7, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 8, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 8, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 09, 13, 0, 0),
                    EventToDate = new DateTime(2017, 02, 09, 15, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2016, 12, 22),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 10, 10, 0, 0),
                    EventToDate = new DateTime(2017, 02, 10, 15, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Water Polo").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Water Polo").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 10, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 10, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 11, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 11, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 12, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 12, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 13, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 13, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 14, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 14, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 15, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 15, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 16, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 16, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 17, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 17, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 18, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 18, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 19, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 19, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });
                foreach (Event eve in events) {
                    _db.Add(eve);
                }

                _db.SaveChanges();
            }
        }

        public static async Task AddRoles(IServiceProvider serviceProvider) {
            var _db = serviceProvider.GetService<ApplicationDbContext>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            //var roleStore = new RoleStore<IdentityRole>(_db);


            string[] roles = new string[] { "Member", "Admin" };

            foreach (string role in roles) {
                /*if  (!_db.Roles.Any(r => r.Name == role)) {
                    _db.Add(new IdentityRole(role));
                }*/
                if (!_db.Roles.Any(r => r.Name == role)) {
                    //_db.Add(new IdentityRole(role));
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            //_db.SaveChanges();
        }

        public static async Task AddUsers(IServiceProvider serviceProvider) {
            var _db = serviceProvider.GetService<ApplicationDbContext>();
            var _userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

            ApplicationUser admin  = new ApplicationUser() { Email = "a@a.a", UserName = "a", FirstName = "a", LastName = "a" };
            ApplicationUser member = new ApplicationUser() { Email = "m@m.m", UserName = "m", FirstName = "m", LastName = "m" };

            /*List<ApplicationUser> list = new List<ApplicationUser>();
            list.Add(admin);
            list.Add(member);
            
            foreach (var user in list) {
                if (!_db.Users.Any(u => u.UserName == user.UserName)) {*/
                    /*var password = new PasswordHasher<ApplicationUser>();
                    var hashed = password.HashPassword(user, "password");
                    user.PasswordHash = hashed;
                    _db.Add(user);*/
                    /*userManager.CreateAsync(user, "password");
                    userManager.AddToRoleAsync(_db.Users.Where(u => u.UserName == "a").FirstOrDefault(), "Admin");
                }
            }*/

            await _userManager.CreateAsync(admin, "P@$$w0rd");
            await _userManager.CreateAsync(member, "P@$$w0rd");
            _db.SaveChanges();

            await _userManager.AddToRoleAsync(_db.Users.Where(u => u.UserName == "a").FirstOrDefault(), "Admin");
            await _userManager.AddToRoleAsync(_db.Users.Where(u => u.UserName == "a").FirstOrDefault(), "Member");
            await _userManager.AddToRoleAsync(_db.Users.Where(u => u.UserName == "m").FirstOrDefault(), "Member");
            _db.SaveChanges();
        }
    }
}
