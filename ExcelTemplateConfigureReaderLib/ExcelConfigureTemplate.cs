using System.IO;
using GeneralConfigureInstance;
using OfficeOpenXml;
namespace ExcelTemplateConfigureReaderLib
{
    public class ExcelConfigureTemplate : IConfigureCollection
    {
        public ExcelConfigureTemplate (FileInfo fileInfo)
        {
            Package = new ExcelPackage (fileInfo);
            // Package.Workbook.Worksheets
            Name = fileInfo.Name.Substring (0, fileInfo.Name.Length - fileInfo.Extension.Length - fileInfo.Extension.Length > 0 ? 1 : 0);
            // ("." + fileInfo.Extension, "");
        }
        public string Name { get; private set; }
        public void Close ()
        {
            Package.Dispose ();
        }
        ~ExcelConfigureTemplate ()
        {
            Close ();
        }
        public void Save ()
        {
            Package.Save ();
        }
        public void SaveAs (string filePath)
        {
            Package.SaveAs (new FileInfo (filePath));
        }
        class Excel

        ExcelPackage Package { get; set; }
        class ExcelConfigureUnit : IConfigure
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }

    }
}