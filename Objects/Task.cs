namespace nancytest.Objects
{
  using System;
  using System.Collections.Generic;
  public class Task
  {
    // private string _description;
    //
    // public Task(string Description)
    // {
    //   _description = Description;
    // }
    //
    // public string getDescription()
    // {
    //   return _description;
    // }
    //
    // public void setDescription(string newDescription)
    // {
    //   _description = newDescription;
    // }
    public string Description {get; set;}

    // public static string ListOfTasks = "List of Tasks";

    public static List<string> ListOfTasks = new List<string> {};

    public static void Save(string NewTask)
    {
      ListOfTasks.Add(NewTask);
    }
  }
}
