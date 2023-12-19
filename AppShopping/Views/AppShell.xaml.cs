namespace AppShopping
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("stores/detail", typeof(Views.Stores.DetailPage));
            Routing.RegisterRoute("restaurants/detail", typeof (Views.Restaurants.RestaurantDetailPage));
            Routing.RegisterRoute("cinemas/detail", typeof(Views.Cinemas.DetailPageMovie));
            Routing.RegisterRoute("tickets/pay", typeof(Views.Tickets.PayPage));
            Routing.RegisterRoute("tickets/list", typeof(Views.Tickets.ListPageTickets));
            Routing.RegisterRoute("tickets/result", typeof(Views.Tickets.ResultPage));
        }
    }
}