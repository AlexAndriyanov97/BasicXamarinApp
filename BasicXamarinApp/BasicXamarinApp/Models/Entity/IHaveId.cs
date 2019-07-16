using System;
using System.Collections.Generic;
using System.Text;

namespace BasicXamarinApp.Models.Entity
{
    public interface IHaveId<T>
    {
        T Id { get; set; }
    }
}
