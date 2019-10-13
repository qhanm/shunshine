using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shunshine.App.EntityCodeFirst
{
    public abstract class EntityPrimaryKey<T>
    {
        public T Id { get; set; }
    }
}
