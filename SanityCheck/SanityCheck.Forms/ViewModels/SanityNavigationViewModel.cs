// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SanityCheck.SanityNavigationPageViewModel.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System.Windows.Input;

using Prism.Mvvm;
using Prism.Navigation;

using Xamarin.Forms;

namespace SanityCheck.Forms.ViewModels
{
    public class SanityNavigationViewModel : BindableBase
    {
        #region Fields

        private readonly INavigationService navigationService;

        #endregion

        #region Constructors and Destructors

        public SanityNavigationViewModel(INavigationService navigationService)
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