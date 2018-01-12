using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCone
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new ToDoListContext())

            {

                Console.WriteLine("Enter a To Do item:");
                string newItem = Console.ReadLine();
                ToDoList items = new ToDoList() { ToDoItemContent = newItem, ToDoItemDateCompleted = DateTime.Now };
                ctx.ToDoItems.Add(items);
                ctx.SaveChanges();
            }


        }
    }

}

