using System.Collections.Generic;
namespace GeneralConfigureInstance
{
    public interface IConfigureCollection : IEnumerable<IConfigureList>
    {
        string Name { get; }

    }
}