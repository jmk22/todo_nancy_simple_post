using Nancy;
using nancytest.Objects;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;

namespace ToDoList
{

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            // Get["/"] = _ => {
            //   Task TestTask = new Task("Learn C#");
            //   Task AnotherTestTask = new Task("Learn .NET");
            //   Task ThirdTask = new Task("Conquer the internet");
            //
            //   Task[] ListOfTasks = new Task[] {TestTask, AnotherTestTask, ThirdTask};
            //
            //   string Output = "";
            //
            //   foreach (Task task in ListOfTasks) {
            //     Output = Output + "<p>" + task.getDescription() + "</p>";
            //   }
            //
            //   return Output;
            //
            // };

            Get["/"] = _ => View["index.html"];

            Post["/newtaskadded"] = _ => {
              var NewTask = new Task
              {
                Description = Request.Form["newtask"]
              };

              //add NewTask to ListOfTasks
              Console.WriteLine(NewTask.Description);
              Task.Save(NewTask.Description);
              Console.WriteLine(Task.ListOfTasks);
              var NewTaskAdded = this.BindTo(NewTask);
              return View["newtaskadded.html", NewTaskAdded];
            };

            Get["/addnewtask"] = _ => {
              string[] TaskList = {"Task 1", "Task 2"};

              var MyTasks = this.BindTo(TaskList);
              return View["addnewtask.html", MyTasks];
            };
        }
    }
}
