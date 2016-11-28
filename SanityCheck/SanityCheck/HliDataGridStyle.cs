// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SanityCheck.HliDataGridStyle.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Syncfusion.SfDataGrid.XForms;

using Xamarin.Forms;

namespace HLI.Forms.Styles
{
    public class HliDataGridStyle : DataGridStyle
    {
        #region Public Methods and Operators

        public override Color GetAlternatingRowBackgroundColor()
        {
            return Color.Transparent;
        }

        public override Color GetBordercolor()
        {
            return Color.Transparent;
        }

        public override Color GetCaptionSummaryRowBackgroundColor()
        {
            return Color.Transparent;
        }

        public override Color GetCaptionSummaryRowForeGroundColor()
        {
            return Color.FromRgb(255, 255, 255);
        }

        public override Color GetHeaderBackgroundColor()
        {
            return Color.Transparent;
        }

        public override Color GetHeaderForegroundColor()
        {
            return Color.Black;
        }

        public override Color GetLoadMoreViewBackgroundColor()
        {
            return Color.Transparent;
        }

        public override Color GetLoadMoreViewForegroundColor()
        {
            return Color.FromRgb(34, 31, 31);
        }

        public override Color GetRecordBackgroundColor()
        {
            return Color.Transparent;
        }

        public override Color GetRecordForegroundColor()
        {
            return Color.Black;
        }

        public override Color GetSelectionBackgroundColor()
        {
            return Color.FromRgba(51, 153, 51, 70);
        }

        public override Color GetSelectionForegroundColor()
        {
            return Color.Gray;
        }

        #endregion
    }
}