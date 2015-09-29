using Nancy;
using nancytest.Objects;
using Nancy.ModelBinding;
using System.Collections.Generic;
using System;

namespace ToDoList
{

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
              Task TestTask = new Task("Learn C#");
              Task AnotherTestTask = new Task("Learn .NET");
              Task ThirdTask = new Task("Conquer the internet");

              Task[] ListOfTasks = new Task[] {TestTask, AnotherTestTask, ThirdTask};

              string Output = "";

              foreach (Task task in ListOfTasks) {
                Output = Output + "<p>" + task.getDescription() + "</p>";
              }

              return Output;
            };
        }
    }
}
