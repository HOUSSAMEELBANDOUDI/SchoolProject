# School Management System

An ASP.NET Core MVC application for managing students, teachers, rooms, and courses. Built with Entity Framework Core and SQL Server using the Repository Pattern and Dependency Injection.

---

## Tech Stack

- **ASP.NET Core MVC** (.NET 8)
- **Entity Framework Core 8** (Code First)
- **SQL Server** (LocalDB)
- **Bootstrap 5** (UI)
- **C#**

---

## Features

### Students
- View all students
- Add new student (with validation: name 5-50 chars, age 5-18)
- Delete student
- Register student in a course

### Teachers
- View all teachers
- Add new teacher
- Delete teacher

### Rooms
- View all rooms
- Add new room
- Delete room

### Courses
- View all courses
- Add new course (with teacher dropdown selection)
- Delete course

---

## Database Schema

```
Students          Teachers          Rooms
├── StudentId     ├── TeacherId     ├── RoomId
├── StudentName   ├── TeacherName   └── RoomName
├── StudentAge    └── TeacherAge
└── isActive

Courses                    StudentCourses (Many-to-Many)
├── CourseId               ├── StudentCourseId
├── CourseName             ├── StudentId → Students
├── CourseCapacity         └── CourseId  → Courses
└── TeacherId → Teachers
```

---

## Project Structure

```
SchoolProject/
│
├── Context/
│   └── MyDbContext.cs                 # Database context with DbSets
│
├── Models/
│   ├── Student.cs                     # Student entity
│   ├── Teacher.cs                     # Teacher entity
│   ├── Room.cs                        # Room entity
│   ├── Course.cs                      # Course entity (FK → Teacher)
│   └── StudentCourse.cs              # Many-to-many link table
│
├── Repository/
│   ├── Student/
│   │   ├── IStudentRepository.cs      # Interface
│   │   └── StudentRepository.cs       # Implementation (CRUD + Register)
│   ├── Teacher/
│   │   ├── ITeacherRepository.cs
│   │   └── TeacherRepository.cs
│   ├── Room/
│   │   ├── IRoomRepository.cs
│   │   └── RoomRepository.cs
│   └── Course/
│       ├── ICourseRepository.cs
│       └── CourseRepository.cs
│
├── Controllers/
│   ├── StudentController.cs           # Student CRUD + Register action
│   ├── TeacherController.cs           # Teacher CRUD
│   ├── RoomController.cs              # Room CRUD
│   └── CourseController.cs            # Course CRUD with teacher dropdown
│
├── Views/
│   ├── Student/
│   │   ├── Index.cshtml               # Student list table
│   │   ├── Create.cshtml              # Add student form
│   │   └── Register.cshtml            # Register student in course
│   ├── Teacher/
│   │   ├── Index.cshtml
│   │   └── Create.cshtml
│   ├── Room/
│   │   ├── Index.cshtml
│   │   └── Create.cshtml
│   ├── Course/
│   │   ├── Index.cshtml
│   │   └── Create.cshtml              # With teacher dropdown select
│   └── Shared/
│       └── _Layout.cshtml             # Navigation layout
│
├── Migrations/
│   └── InitialCreate.cs               # EF migration
│
├── Program.cs                         # DI registration & app config
├── appsettings.json                   # Connection string
└── SchoolProject.csproj
```

---

## Design Patterns Used

- **Repository Pattern** — separates data access logic from controllers
- **Dependency Injection** — repositories registered as Transient services
- **MVC Pattern** — Models, Views, Controllers separation

---

## How to Run

### Prerequisites
- Visual Studio 2022
- .NET 8 SDK
- SQL Server (LocalDB)

### Steps

1. Clone the repository
```bash
git clone https://github.com/HOUSSAMEELBANDOUDI/SchoolProject.git
cd SchoolProject
```

2. Restore packages
```bash
dotnet restore
```

3. Apply migrations and create database
```bash
dotnet ef database update
```

4. Run the application
```bash
dotnet run
```

The app runs on: **https://localhost:5001**

---

## Connection String

In `appsettings.json`:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\mssqllocaldb;Database=SchoolDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

---

## Author

**Houssame El Bandoudi** — [GitHub](https://github.com/HOUSSAMEELBANDOUDI)
