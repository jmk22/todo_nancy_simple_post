using Nancy;
using nancytest.Objects;
using Nancy.ModelBinding;
using System.Collections.Generic;

namespace ToDoList
{

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
              Task TestTask = new Task();
              TestTask.Description = "Learn C#";
              Task AnotherTestTask = new Task();
              AnotherTestTask.Description = "Learn .NET";
              Task ThirdTask = new Task();
              ThirdTask.Description = "Conquer the world";

              Task[] ListOfTasks = new Task[] {TestTask, AnotherTestTask, ThirdTask};

              string Output = "";

              foreach (Task task in ListOfTasks) {
                Output = Output + "<p>" + task.Description + "</p>";
              }

              return Output;
            };
        }
    }
}
