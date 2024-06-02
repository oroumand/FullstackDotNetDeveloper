namespace Students;
/// <summary>
/// Represents a grade value.
/// </summary>
public class Grade
{
    /// <summary>
    /// Gets the value of the grade.
    /// </summary>
    public int Value { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Grade"/> class with the specified value.
    /// </summary>
    /// <param name="value">The value of the grade (0 to 100).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the value is not between 0 and 100.</exception>
    public Grade(int value)
    {
        if (value < 0 || value > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Grade must be between 0 and 100.");
        }
        Value = value;
    }
}

/// <summary>
/// Represents a student with a name and a grade.
/// </summary>
public class Student
{
    /// <summary>
    /// Gets the name of the student.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets or sets the grade of the student.
    /// </summary>
    public Grade Grade { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Student"/> class with the specified name and grade.
    /// </summary>
    /// <param name="name">The name of the student.</param>
    /// <param name="grade">The grade of the student.</param>
    /// <exception cref="ArgumentException">Thrown when the name is null or empty.</exception>
    public Student(string name, Grade grade)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Student name cannot be null or empty.", nameof(name));
        }

        Name = name;
        Grade = grade;
    }

    /// <summary>
    /// Updates the grade of the student.
    /// </summary>
    /// <param name="newGrade">The new grade of the student.</param>
    public void UpdateGrade(Grade newGrade)
    {
        Grade = newGrade;
    }
}

/// <summary>
/// Manages a collection of students.
/// </summary>
public class StudentsInformation
{
    private readonly List<Student> _students = new List<Student>();

    /// <summary>
    /// Gets the collection of students.
    /// </summary>
    public IReadOnlyCollection<Student> Students => _students.AsReadOnly();

    /// <summary>
    /// Adds a new student with the specified name and grade.
    /// </summary>
    /// <param name="studentName">The name of the student.</param>
    /// <param name="gradeValue">The value of the grade.</param>
    /// <exception cref="InvalidOperationException">Thrown when a student with the same name already exists.</exception>
    public void AddNewStudent(string studentName, int gradeValue)
    {
        var grade = new Grade(gradeValue);
        var student = new Student(studentName, grade);
        if (_students.Contains(student))
        {
            throw new InvalidOperationException("Student already exists.");
        }

        _students.Add(student);
    }

    /// <summary>
    /// Removes the student with the specified name.
    /// </summary>
    /// <param name="studentName">The name of the student to remove.</param>
    /// <exception cref="ArgumentException">Thrown when the student with the specified name does not exist.</exception>
    public void RemoveStudent(string studentName)
    {
        var student = _students.FirstOrDefault(s => s.Name.Equals(studentName, StringComparison.OrdinalIgnoreCase));
        if (student == null)
        {
            throw new ArgumentException("Student not found.", nameof(studentName));
        }

        _students.Remove(student);
    }

    /// <summary>
    /// Removes all students with the specified grade.
    /// </summary>
    /// <param name="gradeValue">The value of the grade to remove.</param>
    public void RemoveAllStudentsWithGrade(int gradeValue)
    {
        var grade = new Grade(gradeValue);
        _students.RemoveAll(s => s.Grade.Equals(grade));
    }

    /// <summary>
    /// Displays the information of all students.
    /// </summary>
    public void Display()
    {
        foreach (var student in _students)
        {
            Console.WriteLine($"Name: {student.Name} Grade: {student.Grade.Value}");
        }
    }
}


