using System.Collections;
using System.Text;

namespace SingleResponsability
{
    public class ExportHelper<T> where T : class
    {
        public void ExportStudents(IEnumerable<Student> students)
        {
            string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Id;Fullname;Grades");
            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);

        }

        public void Export(IEnumerable<T> lista)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            var properties = typeof(T).GetProperties();
            var headers = string.Join(";", properties.Select(p => p.Name)); 
            sb.AppendLine(headers);

            foreach (var item in lista)
            {
                string lineaCsv = string.Empty;
                foreach (var prop in properties)
                {
                    var value = prop.GetValue(item);
                    if (value is not string && value is IEnumerable valuearray)
                    {
                        var values = valuearray.Cast<object>().Select(v => v);
                        lineaCsv += string.Join("|", values);
                        continue;
                    }

                    lineaCsv += $"{value};";
                }
                sb.AppendLine(lineaCsv);
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);

        }
    }
}
