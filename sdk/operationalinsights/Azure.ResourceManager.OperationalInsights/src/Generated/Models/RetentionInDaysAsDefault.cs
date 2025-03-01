// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> True - Value originates from workspace retention in days, False - Customer specific. </summary>
    public readonly partial struct RetentionInDaysAsDefault : IEquatable<RetentionInDaysAsDefault>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RetentionInDaysAsDefault"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RetentionInDaysAsDefault(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> Value originates from workspace retention in days. </summary>
        public static RetentionInDaysAsDefault True { get; } = new RetentionInDaysAsDefault(TrueValue);
        /// <summary> Value is customer specific. </summary>
        public static RetentionInDaysAsDefault False { get; } = new RetentionInDaysAsDefault(FalseValue);
        /// <summary> Determines if two <see cref="RetentionInDaysAsDefault"/> values are the same. </summary>
        public static bool operator ==(RetentionInDaysAsDefault left, RetentionInDaysAsDefault right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RetentionInDaysAsDefault"/> values are not the same. </summary>
        public static bool operator !=(RetentionInDaysAsDefault left, RetentionInDaysAsDefault right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RetentionInDaysAsDefault"/>. </summary>
        public static implicit operator RetentionInDaysAsDefault(string value) => new RetentionInDaysAsDefault(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RetentionInDaysAsDefault other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RetentionInDaysAsDefault other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
