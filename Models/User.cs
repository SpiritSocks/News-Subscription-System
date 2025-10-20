namespace NewsSubscriptionSystem.Models
{
    internal sealed class User : IObserver
    {
        public string? UserName { get; }

        public User(string? UserName)
        {
            CheckUserNameValidity(UserName);
            this.UserName = UserName;
        }

        private void CheckUserNameValidity(string? userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentNullException(nameof(userName));
            }
        }

        public void Update(string newsUpdate)
        {
            Console.WriteLine($"{UserName} recieved: {newsUpdate}");
        }
    }
}
