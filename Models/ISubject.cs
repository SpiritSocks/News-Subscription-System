namespace NewsSubscriptionSystem.Models
{
    internal interface ISubject
    {
        //Adds the observer to the subscription list
        void Attach(IObserver observer);

        //Removes the observer
        void Detach(IObserver observer);

        //Sends an update to all subscribed observers
        void Notify();
    }
}
