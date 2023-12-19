using AppShopping.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.ViewsModels.Cinemas
{
    [QueryProperty(nameof(Movie), "movie")]
    public partial class DetailPageMovieViewModel : ObservableObject
    {
        [ObservableProperty]
        private Movie movie;

        [RelayCommand]
        private async void BackToListPageMovies()
        {
            await Shell.Current.GoToAsync("..");
        }

    }

}
