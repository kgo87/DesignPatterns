using System;
namespace Observer
{
    public interface Observer
    {
        public void update(float temp, float humidity, float pressure);
    }
}
