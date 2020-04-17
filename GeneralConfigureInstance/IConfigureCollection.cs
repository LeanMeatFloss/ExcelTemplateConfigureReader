using System.Collections.Generic;
namespace GeneralConfigureInstance
{
    public interface IConfigureCollection : IEnumerable<IConfigureList>
    {
        string Name { get; }
        void Close ();
        void Save ();
        void SaveAs (string filePath);
    }
}