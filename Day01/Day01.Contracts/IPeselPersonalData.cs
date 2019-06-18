using System;

namespace Day01.Contracts
{
    /// <summary>
    /// This is interface
    /// Person is dedicated for ....
    /// Created because ...
    /// </summary>
    /// <exception cref="InvalidCastException"></exception>
    public interface IPeselPersonalData
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        DateTime BirthDate { get; set; }
        string NIN { get; set; }
        Sex Sex { get; set; }
#pragma warning restore CS1591
    }
}