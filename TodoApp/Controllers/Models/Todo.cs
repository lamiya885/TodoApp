using System;
using System.Collections.Generic;

namespace TodoApp.Controllers.Models;

public partial class Todo
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime DeadLine { get; set; }


    public bool IsDone { get; set; }
    public string Condition()
    {

        if (IsDone)
        {
            return "Bitib!";
        }
        else if (DeadLine < DateTime.Now)
        {
            return "Gozlenilir!";

        }
        else
        {
            return "Yerine yetirilmedi!";
        }
    }
}
