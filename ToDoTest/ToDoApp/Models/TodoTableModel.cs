using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    class TodoTableModel
    {
        public int TaskId { get; set; }
        public string TaskToDo { get; set; }
        public bool Complete { get; set; }

    }
}
