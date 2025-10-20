using NewsSubscriptionSystem.Models;

namespace NewsSubscriptionSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewsFeed newsFeed = new NewsFeed();

            User user1 = new User("Maksim");
            User user2 = new User("Vlad");
            User user3 = new User("Masha");

            newsFeed.Attach(user1);
            newsFeed.Attach(user2);
            newsFeed.Attach(user3);

            newsFeed.PublishNews("BREAKING: New law passed");

            newsFeed.Detach(user2);

            newsFeed.PublishNews("WARNING: Harsh weather approaching");

            newsFeed.Detach(user1);

            newsFeed.PublishNews("ATTENTION: Last subscriber remaining");

            newsFeed.Detach(user3);

            Console.ReadLine();
        }
    }
}
