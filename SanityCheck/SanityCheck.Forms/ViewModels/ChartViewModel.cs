﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SanityCheck.ChartPageViewModel.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Prism.Mvvm;

namespace SanityCheck.Forms.ViewModels
{
    public class ChartViewModel : BindableBase
    {
        #region Public Properties

        public App Application => Xamarin.Forms.Application.Current as App;

        #endregion
    }
}