// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SanityCheck.App.xaml.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Prism.Unity;

using SanityCheck.Models;
using SanityCheck.Views;

namespace SanityCheck
{
    public partial class App : PrismApplication
    {
        #region Constructors and Destructors

        public App(IPlatformInitializer initializer = null)
            : base(initializer)
        {
        }

        #endregion

        public IEnumerable<HliBar> HliBars { get; private set; }

        #region Methods

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