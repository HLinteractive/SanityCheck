// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SanityCheck.SanityNavigationPageViewModel.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System.Windows.Input;

using Prism.Mvvm;
using Prism.Navigation;

using Xamarin.Forms;

namespace SanityCheck.ViewModels
{
    public class SanityNavigationPageViewModel : BindableBase
    {
        #region Fields

        private readonly INavigationService navigationService;

        #endregion

        #region Constructors and Destructors

        public SanityNavigationPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            this.NavigateCommand = new Command<string>(this.OnNavigate);
        }

        #endregion

        #region Public Properties

        public ICommand NavigateCommand { get; }

        #endregion

        #region Methods

        private async void OnNavigate(string s)
        {
            await this.navigationService.NavigateAsync(s);
        }

        #endregion
    }
}