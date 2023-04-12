using Lekcja17___Events;

delegate void EventHandler(object sender, EventArgs e);

class OrderEventArgs : EventArgs
{
    public string Email { get; set; }
    public string Phone { get; set; } 
}

class Order
{
    public event EventHandler<OrderEventArgs> OnCreated;

    public void Create(string email, string phone)
    {
        Console.WriteLine("Order created");

        if (OnCreated != null)
        {
            OnCreated(this, new OrderEventArgs { Email = email, Phone = phone});
        }
    }
}

class Email
{
    public static void Send(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"Send an email to {e.Email}");
    }
}

class SMS
{
    public static void Send(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"Send an SMS to {e.Phone}");
    }
}

class Program
{
    public static void Main()
    {
        var order = new Order();

        order.OnCreated += Email.Send;
        order.OnCreated += SMS.Send;

        order.Create("john@test.com", "(408)-111-2222");

        Console.WriteLine();

        var sub = new YoutubeService();

        sub.OnMoviePublished += Movie.Publish;
        sub.OnShortsPublished += Shorts.Publish;

        sub.OnMovieUpload("https://www.youtube.com/", "Youtube", "Movie Service");
        sub.OnShortsUpload("https://www.youtube.com/shorts", "Short Youtube", new List<string> { "short", "youtube", "history", "foryou" });
        
    }
}