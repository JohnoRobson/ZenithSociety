using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithSociety.Data;

namespace ZenithSociety.Models
{
    public class SeedData {
        public static void Initialize(ApplicationDbContext db) {
            AddUsersAndRoles(db);
            AddActivities(db);
            AddEvents(db);
        }

        public static void AddActivities(ApplicationDbContext db) {
            if (!db.Activities.Any()) {
                IList<Activity> activities = new List<Activity>();

                activities.Add(new Activity { ActivityDescription = "Go-Karting", CreationDate = new DateTime(2003, 01, 04) });
                activities.Add(new Activity { ActivityDescription = "Super Smash Bros Melee Tournament", CreationDate = new DateTime(2001, 11, 21) });
                activities.Add(new Activity { ActivityDescription = "Tennis", CreationDate = new DateTime(1990, 03, 12) });
                activities.Add(new Activity { ActivityDescription = "Polo", CreationDate = new DateTime(1976, 12, 12) });
                activities.Add(new Activity { ActivityDescription = "Water Polo", CreationDate = new DateTime(2002, 04, 28) });
                activities.Add(new Activity { ActivityDescription = "Competitive Vaping", CreationDate = new DateTime(2015, 10, 29) });

                foreach (Activity act in activities) {
                    db.Add(act);
                }

                db.SaveChanges();
            }
        }

        public static void AddEvents(ApplicationDbContext db) {
            if (!db.Events.Any()) {
                IList<Event> events = new List<Event>();

                events.Add(new Event {
                    EventFromDate = new DateTime(2016, 02, 12, 10, 0, 0),
                    EventToDate = new DateTime(2016, 02, 12, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Go-Karting").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Go-Karting").FirstOrDefault(),
                    CreationDate = new DateTime(2016, 01, 01),
                    IsActive = false
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2016, 04, 14, 11, 0, 0),
                    EventToDate = new DateTime(2016, 04, 14, 13, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Super Smash Bros Melee Tournament").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Super Smash Bros Melee Tournament").FirstOrDefault(),
                    CreationDate = new DateTime(2016, 02, 01),
                    IsActive = false
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2016, 07, 17, 13, 0, 0),
                    EventToDate = new DateTime(2016, 07, 17, 15, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault(),
                    CreationDate = new DateTime(2016, 03, 10),
                    IsActive = false
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 4, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 4, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 5, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 5, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 6, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 6, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 7, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 7, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 8, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 8, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 09, 13, 0, 0),
                    EventToDate = new DateTime(2017, 02, 09, 15, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2016, 12, 22),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 10, 10, 0, 0),
                    EventToDate = new DateTime(2017, 02, 10, 15, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Water Polo").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Water Polo").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 10, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 10, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 11, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 11, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 12, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 12, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 13, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 13, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 14, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 14, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 15, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 15, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 16, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 16, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 17, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 17, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 18, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 18, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });

                events.Add(new Event {
                    EventFromDate = new DateTime(2017, 02, 19, 15, 0, 0),
                    EventToDate = new DateTime(2017, 02, 19, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 01, 11),
                    IsActive = true
                });
                foreach (Event eve in events) {
                    db.Add(eve);
                }

                db.SaveChanges();
            }
        }

        public static void AddUsersAndRoles(ApplicationDbContext db) {
            string[] roles = new string[] { "User", "Admin"};
            foreach (string role in roles) {
                var roleStore = new RoleStore<IdentityRole>(db);
                if (!db.Roles.Any(r => r.Name == role)) {
                    roleStore.CreateAsync(new IdentityRole(role));
                }
            }

            ApplicationUser admin  = new ApplicationUser() { Email = "a@a.a", UserName = "a", EmailConfirmed = true };
            ApplicationUser member = new ApplicationUser() { Email = "m@m.m", UserName = "m", EmailConfirmed = true };

            if (!db.ApplicationUser.Any(u => u.UserName == admin.UserName)) {
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(admin, "a");
                admin.PasswordHash = hashed;

                var userStore = new UserStore<ApplicationUser>(db);
                var result = userStore.CreateAsync(admin);
                userStore.AddToRoleAsync(admin, "Admin");
            }

            if (!db.ApplicationUser.Any(u => u.UserName == member.UserName)) {
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(member, "m");
                member.PasswordHash = hashed;

                var userStore = new UserStore<ApplicationUser>(db);
                var result = userStore.CreateAsync(member);
                userStore.AddToRoleAsync(member, "User");
            }

            db.SaveChangesAsync();
        }
    }
}
