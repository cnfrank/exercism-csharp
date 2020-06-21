using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    public List<KeyValuePair<string, int>> Students { get; set; }

    public GradeSchool() 
    {
        Students = new List<KeyValuePair<string, int>>();
    }    
    
    public void Add(string student, int grade)
    {
        Students.Add(new KeyValuePair<string, int>(student, grade));
    }

    public IEnumerable<string> Roster()
    {
        return Students.OrderBy(s => s.Value)
                       .ThenBy(s => s.Key)
                       .Select(s => s.Key);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return Students.Where(s => s.Value == grade)
                       .OrderBy(s => s.Key)
                       .Select(s => s.Key);
    }
}