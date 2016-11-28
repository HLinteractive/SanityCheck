// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SanityCheck.ListPage.xaml.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Linq;

using HLI.Forms.Styles;

using Syncfusion.SfDataGrid.XForms;

using Xamarin.Forms;

namespace SanityCheck.Views
{
    public partial class ListPage : ContentPage
    {
        #region Constructors and Destructors

        public ListPage()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        private void ListViewOnGridViewCreated(object sender, GridViewCreatedEventArgs e)
        {
            try
            {
                this.ListView.GridStyle = new HliDataGridStyle();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        ////private void CreateTemplateColumn()
        ////{
        ////    if (this.ItemTemplate == null || this.ListView.Columns.Any())
        ////    {
        ////        return;
        ////    }

        ////    var gridTemplateColumn = new GridTemplateColumn { CellTemplate = this.ItemTemplate, MappingName = "", HeaderText = "" };
        ////    this.ListView.Columns.Add(gridTemplateColumn);
        ////}

        #endregion
    }
}