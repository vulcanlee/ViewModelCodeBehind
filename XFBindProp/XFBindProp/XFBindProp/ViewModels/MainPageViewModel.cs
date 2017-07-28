using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFBindProp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }
        public bool NeedChangeBackground { get; set; } = false;
        public bool NeedChangePageBackground { get; set; } = false;

        public DelegateCommand ChangeColorCommand { get; set; }
        public DelegateCommand ChangePageColorCommand { get; set; }

        public MainPageViewModel()
        {
            ChangeColorCommand = new DelegateCommand(() =>
            {
                NeedChangeBackground = true;
            });
            ChangePageColorCommand = new DelegateCommand(() =>
            {
                NeedChangePageBackground = true;
            });

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
