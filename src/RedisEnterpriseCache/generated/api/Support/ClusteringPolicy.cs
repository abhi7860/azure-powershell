// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support
{

    /// <summary>Clustering policy - default is OSSCluster. Specified at create time.</summary>
    public partial struct ClusteringPolicy :
        System.IEquatable<ClusteringPolicy>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy EnterpriseCluster = @"EnterpriseCluster";

        public static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy OssCluster = @"OSSCluster";

        /// <summary>the value for an instance of the <see cref="ClusteringPolicy" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ClusteringPolicy" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ClusteringPolicy(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ClusteringPolicy</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ClusteringPolicy" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ClusteringPolicy(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ClusteringPolicy</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ClusteringPolicy (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ClusteringPolicy && Equals((ClusteringPolicy)obj);
        }

        /// <summary>Returns hashCode for enum ClusteringPolicy</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ClusteringPolicy</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ClusteringPolicy</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ClusteringPolicy" />.</param>

        public static implicit operator ClusteringPolicy(string value)
        {
            return new ClusteringPolicy(value);
        }

        /// <summary>Implicit operator to convert ClusteringPolicy to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ClusteringPolicy" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ClusteringPolicy</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy e1, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ClusteringPolicy</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy e1, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy e2)
        {
            return e2.Equals(e1);
        }
    }
}