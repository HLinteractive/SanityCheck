// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SanityCheck.ListPageViewModel.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Mvvm;

namespace SanityCheck.Forms.ViewModels
{
    public class ListViewModel : BindableBase
    {
        #region Public Properties

        public App Application => Xamarin.Forms.Application.Current as App;

        #endregion
    }
}