// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>The type of the column in the report.</summary>
    public partial struct ReportConfigColumnType :
        System.IEquatable<ReportConfigColumnType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportConfigColumnType Dimension = @"Dimension";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportConfigColumnType Tag = @"Tag";

        /// <summary>the value for an instance of the <see cref="ReportConfigColumnType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ReportConfigColumnType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ReportConfigColumnType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ReportConfigColumnType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ReportConfigColumnType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportConfigColumnType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ReportConfigColumnType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ReportConfigColumnType && Equals((ReportConfigColumnType)obj);
        }

        /// <summary>Returns hashCode for enum ReportConfigColumnType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ReportConfigColumnType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ReportConfigColumnType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ReportConfigColumnType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ReportConfigColumnType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ReportConfigColumnType" />.</param>

        public static implicit operator ReportConfigColumnType(string value)
        {
            return new ReportConfigColumnType(value);
        }

        /// <summary>Implicit operator to convert ReportConfigColumnType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ReportConfigColumnType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportConfigColumnType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ReportConfigColumnType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportConfigColumnType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportConfigColumnType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ReportConfigColumnType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportConfigColumnType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ReportConfigColumnType e2)
        {
            return e2.Equals(e1);
        }
    }
}