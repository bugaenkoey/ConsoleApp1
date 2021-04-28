using System;
using System.Collections.Generic;
using System.Text;

namespace MyListEnum
{
    interface IMyList<T>: IEnumerable<T> , ICollection<T>
    {
    }
}
