using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    private IStudentRepository studentRepository;
    private ILogbook logbook;

    public StudentController(IStudentRepository studentRepository, ILogbook logbook)
    {
        this.studentRepository = studentRepository;
        this.logbook = logbook;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");
    }
}
