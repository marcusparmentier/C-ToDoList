using System.Collections.Generic;

namespace ToDoLists.Models
{
  public class Task
  {
    private string _description;
    private static List<string> _instances = new List<string> {};

    public Task (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(_description);
    }
  }
}
