// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Forms.HliBar.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;

using HLI.Core.Models;

namespace SanityCheck.Models
{
    public class HliBar : ModelBase
    {
        #region Public Properties

        /// <summary>
        ///     The duration in <c>long</c> ticks
        /// </summary>
        public long Duration { get; set; }

        /// <summary>
        ///     The duration as <see cref="TimeSpan" />
        /// </summary>
        public TimeSpan DurationSpan => new TimeSpan(this.Duration);

        public double Quantity { get; set; }
        
        public string TimeLogType { get; set; }

        public string Title { get; set; }

        #endregion
    }
}