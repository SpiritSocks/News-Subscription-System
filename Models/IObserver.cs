namespace NewsSubscriptionSystem.Models
{
    internal interface IObserver
    {
        //Notifies the observer (user) with the latest news
        void Update(string newsUpdate);
    }
}
