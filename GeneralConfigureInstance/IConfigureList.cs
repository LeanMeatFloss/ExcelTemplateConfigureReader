using System.Collections.Generic;
namespace GeneralConfigureInstance
{
    public interface IConfigureList : IEnumerable<IConfigure>
    {
        string Name { get; }

    }
}