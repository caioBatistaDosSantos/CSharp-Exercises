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
        
        // var result = Students.Where(e => e.Name == name);

        return result.ToArray();
    }

    public Student[] GetStudentsWithAverageGradeInProjectAbove(int gradeInput)
    {
        var result =
            from projectGrade in ProjectGrades
            where projectGrade.Grades.Average() > gradeInput

            from student in Students
            where student.Id == projectGrade.StudentId
            select student;
        

        return result.ToArray();
    }

    public Project[] GetProjectsWithMinimumGradeInProjectBelow(int gradeInput)
    {
        var result =
            from projectGrade in ProjectGrades
            where projectGrade.Grades.Min() < gradeInput

            from project in Projects
            where project.Id == projectGrade.ProjectId
            select project;
        

        return result.ToArray();
    }

    public Student[] GetStudentsDoneProject(string projectName)
    {
        var result =
            from project in Projects
            where project.Name == projectName

            from projectGrade in ProjectGrades
            where project.Id == projectGrade.ProjectId

            from student in Students
            where student.Id == projectGrade.StudentId
            select student;
        

        return result.ToArray();
    }
}
