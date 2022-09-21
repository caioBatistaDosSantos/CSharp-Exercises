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
            // Pega os projetos com as medias acima da nota sinalizada
            from projectGrade in ProjectGrades
            where projectGrade.Grades.Average() > gradeInput

            // pega os estudantes que fizeram tais projetos
            from student in Students
            where student.Id == projectGrade.StudentId
            select student;
        

        return result.ToArray();
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
