using Xunit;
using System;
using FluentAssertions;
using SchoolQueries;
using Moq;

namespace SchoolQueries.Test;

[Collection("Sequential")]
public class TestSchoolDatabase
{
    [Theory(DisplayName = "Test GetStudentsByName")]
    [MemberData(nameof(DataTestGetStudentsByName))]
    public void TestGetStudentsByName(SchoolDatabase databaseEntry, string nameEntry, Student[] studentsExpected)
    {
        var result = databaseEntry.GetStudentsByName(nameEntry);
        result.Should().BeEquivalentTo(studentsExpected);
    }
    
    [Theory(DisplayName = "Test GetStudentsWithAverageGradeInProjectAbove")]
    [MemberData(nameof(DataTestGetStudentsWithAverageGradeInProjectAbove))]
    public void TestGetStudentsWithAverageGradeInProjectAbove(SchoolDatabase databaseEntry, int gradeEntry, Student[] studentsExpected)
    {
        var result = databaseEntry.GetStudentsWithAverageGradeInProjectAbove(gradeEntry);
        result.Should().BeEquivalentTo(studentsExpected);
    }

    [Theory(DisplayName = "Test GetProjectsWithMinimumGradeInProjectBelow")]
    [MemberData(nameof(DataTestGetProjectsWithMinimumGradeInProjectBelow))]
    public void TestGetProjectsWithMinimumGradeInProjectBelow(SchoolDatabase databaseEntry, int gradeEntry, Project[] projectsExprected)
    {
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Test GetStudentsDoneProject")]
    [MemberData(nameof(DataTestGetStudentsDoneProject))]
    public void TestGetStudentsDoneProject(SchoolDatabase databaseEntry, string projectNameEntry, Student[] studentsExpected)
    {
        throw new NotImplementedException();
    }

    public static TheoryData<SchoolDatabase, string, Student[]> DataTestGetStudentsByName => 
        new(){
            // Primeiro caso de teste
            {
                GetSchoolDatabaseInstanceToTest(),
                "Student 1",
                new Student[]{
                    new Student() {
                        Id = 1,
                        Name = "Student 1",
                        Age = 20,
                    },
                }
            },
            // Segundo caso de teste
            {
                GetSchoolDatabaseInstanceToTest(),
                "Student 3",
                new Student[]{
                    new Student() {
                        Id = 3,
                        Name = "Student 3",
                        Age = 22,
                    }
                }
            }
        };

    public static TheoryData<SchoolDatabase, int, Student[]> DataTestGetStudentsWithAverageGradeInProjectAbove => 
        new(){
            // Primeiro caso de teste
            {
                GetSchoolDatabaseInstanceToTest(),
                80,
                new Student[]{
                    new Student() {
                        Id = 1,
                        Name = "Student 1",
                        Age = 20,
                    },
                }
            },
            // Segundo caso de teste
            {
                GetSchoolDatabaseInstanceToTest(),
                50,
                new Student[]{
                    new Student() {
                    Id = 1,
                    Name = "Student 1",
                    Age = 20,
                },
                new Student() {
                    Id = 2,
                    Name = "Student 2",
                    Age = 21,
                },
                new Student() {
                    Id = 3,
                    Name = "Student 3",
                    Age = 22,
                }
                }
            }
        };

    public static TheoryData<SchoolDatabase, int, Project[]> DataTestGetProjectsWithMinimumGradeInProjectBelow => 
        new(){};

    public static TheoryData<SchoolDatabase, string, Student[]> DataTestGetStudentsDoneProject => 
        new(){};

    public static SchoolDatabase GetSchoolDatabaseInstanceToTest()
    {
        var databaseInstance = new SchoolDatabase{
            Students = new Student[] {
                new Student() {
                    Id = 1,
                    Name = "Student 1",
                    Age = 20,
                },
                new Student() {
                    Id = 2,
                    Name = "Student 2",
                    Age = 21,
                },
                new Student() {
                    Id = 3,
                    Name = "Student 3",
                    Age = 22,
                }
            },
            Projects = new Project[] {
                new Project() {
                    Id = 1,
                    Name = "Project 1",
                    Requirements = new string[] { "Requirement 1", "Requirement 2" },
                    BonusRequirements = new string[] { "Bonus 1", "Bonus 2" }
                },
                new Project() {
                    Id = 2,
                    Name = "Project 2",
                    Requirements = new string[] { "Requirement 1", "Requirement 2" },
                    BonusRequirements = new string[] { "Bonus 1", "Bonus 2" }
                },
                new Project() {
                    Id = 3,
                    Name = "Project 3",
                    Requirements = new string[] { "Requirement 1", "Requirement 2" },
                    BonusRequirements = new string[] { "Bonus 1", "Bonus 2" }
                }
            },
            ProjectGrades = new ProjectGrade[] {
                new ProjectGrade() {
                    ProjectId = 1,
                    StudentId = 1,
                    Grades = new int[] { 90, 90 }
                },
                new ProjectGrade() {
                    ProjectId = 3,
                    StudentId = 2,
                    Grades = new int[] { 70, 70 }
                },
                new ProjectGrade() {
                    ProjectId = 2,
                    StudentId = 3,
                    Grades = new int[] { 60, 60 }
                }
            }
        };

        return databaseInstance;
    }
}
