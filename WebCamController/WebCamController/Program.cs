using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebCamController
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectController = new ProjectController();
            projectController.TakePhoto();
        }
    }
}