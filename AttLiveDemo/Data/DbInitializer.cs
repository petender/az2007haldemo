using AttLiveDemo.Models;

namespace AttLiveDemo.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Check if database already has data
            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
                new Employee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    HiringDate = "2020-03-15",
                    Department = "Engineering",
                    JobTitle = "Senior Software Engineer"
                },
                new Employee
                {
                    FirstName = "Sarah",
                    LastName = "Johnson",
                    HiringDate = "2019-07-22",
                    Department = "Marketing",
                    JobTitle = "Marketing Manager"
                },
                new Employee
                {
                    FirstName = "Michael",
                    LastName = "Williams",
                    HiringDate = "2021-01-10",
                    Department = "Sales",
                    JobTitle = "Sales Representative"
                },
                new Employee
                {
                    FirstName = "Emily",
                    LastName = "Brown",
                    HiringDate = "2018-11-05",
                    Department = "Human Resources",
                    JobTitle = "HR Director"
                },
                new Employee
                {
                    FirstName = "David",
                    LastName = "Martinez",
                    HiringDate = "2022-02-28",
                    Department = "Engineering",
                    JobTitle = "DevOps Engineer"
                },
                new Employee
                {
                    FirstName = "Jessica",
                    LastName = "Garcia",
                    HiringDate = "2020-09-14",
                    Department = "Finance",
                    JobTitle = "Financial Analyst"
                },
                new Employee
                {
                    FirstName = "Robert",
                    LastName = "Davis",
                    HiringDate = "2019-05-20",
                    Department = "Engineering",
                    JobTitle = "Software Architect"
                },
                new Employee
                {
                    FirstName = "Amanda",
                    LastName = "Rodriguez",
                    HiringDate = "2021-06-18",
                    Department = "Customer Success",
                    JobTitle = "Customer Success Manager"
                },
                new Employee
                {
                    FirstName = "Christopher",
                    LastName = "Wilson",
                    HiringDate = "2020-12-01",
                    Department = "Product",
                    JobTitle = "Product Manager"
                },
                new Employee
                {
                    FirstName = "Jennifer",
                    LastName = "Anderson",
                    HiringDate = "2018-08-30",
                    Department = "Operations",
                    JobTitle = "Operations Director"
                }
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();
        }
    }
}
