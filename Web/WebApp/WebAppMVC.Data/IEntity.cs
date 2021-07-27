using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppMVC.Data
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
