namespace NewsSubscriptionSystem.Models
{
    internal sealed class NewsFeed : ISubject
    {
        private readonly List<IObserver> observerList = new List<IObserver>();
        private string? latestNews;


        //Sets the latest news and calls Notify
        public void PublishNews(string news)
        {
            if (string.IsNullOrEmpty(news))
            {
                throw new ArgumentNullException("News cannot be empty");
            }

            latestNews = news;
            Console.WriteLine($"\nNew news published: {latestNews}\n");
            Notify();
        }

        //Get the name of the current observer
        private string? GetObserverName(IObserver observer)
        {
            return observer is User user ? user.UserName : "Unknown";
        }


        public void Attach(IObserver observer)
        {
            if (!observerList.Contains(observer))
            {
                observerList.Add(observer);
                Console.WriteLine($"Subscribed: {GetObserverName(observer)}");
            }
        }

        public void Detach(IObserver observer)
        {
            if (observerList.Remove(observer))
            {
                Console.WriteLine($"Unsubscribed: {GetObserverName(observer)}");
            }

            if (observerList.Count == 0)
            {
                Console.WriteLine("\nNo subscribers left!");
            }
        }

        public void Notify()
        {
            foreach (var observer in observerList)
            {
                observer.Update(latestNews);
            }
        }
    }
}
