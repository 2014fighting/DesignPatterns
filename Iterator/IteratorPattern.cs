using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public interface Iterator
    {
        public bool HasNext();
        public object Next();
    }

    public interface Container
    {
        public Iterator GetIterator();
    }


    public class NameRepository : Container
    {
        public Iterator GetIterator()
        {
            return new NameIterator();
        }
    }

    public class NameIterator : Iterator
    {
        public string[] names = { "Robert", "John", "Julie", "Lora" };

        int index;

        public bool HasNext()
        {
            if (index < names.Length)
            {
                return true;
            }
            return false;
        }

        public object? Next()
        {
            if (this.HasNext())
            {
                return names[index++];
            }
            return default;
        }
    }


}
