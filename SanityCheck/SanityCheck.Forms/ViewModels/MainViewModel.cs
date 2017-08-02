// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SanityCheck.MainPageViewModel.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2017
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Mvvm;
using Prism.Navigation;

namespace SanityCheck.Forms.ViewModels
{
    public class MainViewModel : BindableBase, INavigationAware
    {
        #region Fields

        private string title;

        #endregion

        #region Public Properties

        public string Title
        {
            get => this.title;
            set => this.SetProperty(ref this.title, value);
        }

        #endregion

        #region Public Methods and Operators

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            var newTitle = "Xamarin + Prism + HLi ";
            if (parameters.ContainsKey("title"))
            {
                this.Title = (string)parameters["title"] + " " + newTitle;
            }
            else
            {
                this.Title = $"Sanity Check: {newTitle}";
            }
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        #endregion
    }
}