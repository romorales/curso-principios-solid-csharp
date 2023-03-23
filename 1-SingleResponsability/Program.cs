using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper<Student> export = new();
export.Export(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");