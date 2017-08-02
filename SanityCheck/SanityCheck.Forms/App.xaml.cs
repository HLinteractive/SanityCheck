// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SanityCheck.Forms.App.xaml.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2017
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using HLI.Forms.Prism.Extensions;

using Prism.Unity;

using SanityCheck.Forms.Models;
using SanityCheck.Forms.Pages;

namespace SanityCheck.Forms
{
    public partial class App
    {
        #region Constructors and Destructors

        public App(IPlatformInitializer initializer = null)
            : base(initializer)
        {
        }

        #endregion

        #region Public Properties

        public IEnumerable<HliBar> HliBars { get; private set; }

        #endregion

        #region Methods

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
            this.SetViewModelNamingPolicy();
        }

        protected override void OnInitialized()
        {
            this.InitializeComponent();

            var apples = new HliBar { Quantity = 34, Title = "Apples", TimeLogType = "Fruit", Duration = TimeSpan.FromSeconds(5).Ticks };
            var oranges = new HliBar { Quantity = 53, Title = "Oranges", TimeLogType = "Fruit", Duration = TimeSpan.FromSeconds(10).Ticks };
            var bananas = new HliBar { Quantity = 12, Title = "Bananas", TimeLogType = "Fruit", Duration = TimeSpan.FromSeconds(8).Ticks };
            this.HliBars = new ObservableCollection<HliBar> { bananas, apples, oranges };

            this.NavigationService.NavigateAsync($"{nameof(SanityNavigationPage)}/{nameof(ListPage)}");
        }

        protected override void RegisterTypes()
        {
            this.Container.RegisterTypeForNavigation<MainPage>();
            this.Container.RegisterTypeForNavigation<ChartPage>();
            this.Container.RegisterTypeForNavigation<ListPage>();
            this.Container.RegisterTypeForNavigation<SanityNavigationPage>();
        }

        #endregion
    }
}