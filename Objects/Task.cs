namespace nancytest.Objects
{
  public class Task
  {
    private string _description;

    public Task(string Description)
    {
      _description = Description;
    }

    public string getDescription()
    {
      return _description;
    }

    public void setDescription(string newDescription)
    {
      _description = newDescription;
    }
  }
}
