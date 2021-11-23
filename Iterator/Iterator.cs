using System;
namespace Iterator
{
    public interface Iterator
    {
        public bool hasNext();

        MenuItem next();
    }
}
