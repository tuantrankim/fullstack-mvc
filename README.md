# fullstack-mvc

https://app.pluralsight.com/library/courses/full-stack-dot-net-developer-fundamentals/table-of-contents

## Become a Full-stack .NET Developer
by Mosh Hamedani

### Environment
visual studio 2019
dotnet framework 4.7.2

### Package Management Console
#### Enable code first migration
PM> enable-migrations

Clear console
PM> cls

Add a migration name Initial Model
PM> add-migration InitialModel

Update migration to database
PM> update-database

Add new model (class) Gig.cs
Create Gigs and Genres DbSet in ApplicationDbContext in IdentityModel.cs
```
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        ...
    }
```
Add a migration name CreateGigTable
PM> add-migration CreateGigTable

to overwrite, using -force
PM> add-migration CreateGigTable -force

Rollback database to a TargetMigration
PM> Update-Database -TargetMigration 202004220009554_CreateGigTable
