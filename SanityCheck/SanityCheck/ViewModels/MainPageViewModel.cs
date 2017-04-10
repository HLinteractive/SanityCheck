// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SanityCheck.MainPageViewModel.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2017
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Mvvm;
using Prism.Navigation;

namespace SanityCheck.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        #region Fields

        private string title;

        #endregion

        #region Public Properties

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.SetProperty(ref this.title, value);
            }
        }

        #endregion

        #region Public Methods and Operators

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            var prismSyncfusion = " + Prism + SyncFusion ";
            if (parameters.ContainsKey("title"))
            {
                this.Title = (string)parameters["title"] + prismSyncfusion;
            }
            else
            {
                this.Title = "Sanity Check: XF" + prismSyncfusion;
            }
        }

        #region Implementation of INavigatingAware

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        #endregion

        #endregion
    }
}