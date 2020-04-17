using System.Collections.Generic;
namespace GeneralConfigureInstance
{
    public interface IConfigureSet : IEnumerable<IConfigureCollection>
    {
        string Name { get; }
        void Close ();
        void Save ();
        void SaveAs (string filePath);
    }
}