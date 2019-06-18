using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Day01.Contracts
{
    public interface ICycleProvider
    {
        object CurrentItem { get; }
        object Next();
        void Add(object item);
    }
}
#pragma warning restore CS1591
