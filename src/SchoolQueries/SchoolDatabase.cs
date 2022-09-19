namespace SchoolQueries;

public class SchoolDatabase : ISchoolDatabase
{
    public Student[] Students { get; set; }
    public Project[] Projects { get; set; }
    public ProjectGrade[] ProjectGrades { get; set; }

    public Student[] GetStudentsByName(string name)
    {
        var result = from student in Students
            where student.Name == name
            select student;
        
        return result.ToArray();
    }

    public Student[] GetStudentsWithAverageGradeInProjectAbove(int gradeInput)
    {
        throw new NotImplementedException();
    }

    public Project[] GetProjectsWithMinimumGradeInProjectBelow(int gradeInput)
    {
        throw new NotImplementedException();
    }

    public Student[] GetStudentsDoneProject(string projectName)
    {
        throw new NotImplementedException();
    }
}
