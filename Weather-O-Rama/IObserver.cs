namespace Weather_O_Rama
{   
    public interface IObserver  
    {
        public void Update(float temp, float humidity, float pressure);
    }
}