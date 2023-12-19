using AppShopping.Models;
using AppShopping.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.ViewsModels.Cinemas
{
    public partial class ListPageMoviesViewMode : ObservableObject 
    {
        [ObservableProperty]
        private List<Movie> movies;

        public ListPageMoviesViewMode()
        {
            var service = App.Current.Handler.MauiContext.Services.GetService<CinemaService>();
            movies = service.GetAllMovies();
        }

        [RelayCommand]
        private void TapMovieGoToDetailPage(Movie movie)
        {
            var param = new Dictionary<string, object>()
            {
                {"movie", movie }
            };
            Shell.Current.GoToAsync("detail", param);
        }
    }
}
