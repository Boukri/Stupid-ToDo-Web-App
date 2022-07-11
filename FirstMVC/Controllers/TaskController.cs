using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVC.Controllers
{
    public class TaskController : Controller
    {
        private static List<TaskModel> Tasks = new List<TaskModel>();
        public IActionResult Index()
        {
            return View(Tasks);
        }

        public IActionResult Create()
        {
            var task = new TaskModel();
            return View(task);
        }

        public IActionResult CreateTask(TaskModel _task)
        {
            Tasks.Add(_task);
            return RedirectToAction(nameof(Index));
        }
    }
}
