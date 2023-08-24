namespace ObserverDesignPattern
{
    public interface IObserver
    {
        //receive notification from subject
        void Update(string availability);
    }
}
