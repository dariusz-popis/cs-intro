using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Day01.Contracts
{
    public interface ICycleProvider<T> //where TClass : class
    {
        T CurrentItem { get; }
        T Next();
        ICycleProvider<T> Add(T item);
    }
}
#pragma warning restore CS1591
