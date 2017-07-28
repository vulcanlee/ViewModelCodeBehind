using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFDelegate.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        #region 宣告要連結 Code Behind 的委派方法
        public Action ChangeColorDelegate;
        public Action ChangePageColorDelegate;
        #endregion

        public DelegateCommand ChangeColorCommand { get; set; }
        public DelegateCommand ChangePageColorCommand { get; set; }

        public MainPageViewModel()
        {
            ChangeColorCommand = new DelegateCommand(() =>
            {
                ChangeColorDelegate();
            });
            ChangePageColorCommand = new DelegateCommand(() =>
            {
                ChangePageColorDelegate();
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
