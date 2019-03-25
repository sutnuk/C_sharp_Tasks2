using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    abstract class PersonsProcessor
    {
        public abstract void Process(IEnumerable<Person> person);
    }
}
