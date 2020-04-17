using System.IO;
using GeneralConfigureInstance;
using OfficeOpenXml;
namespace ExcelTemplateConfigureReaderLib
{
    public class ExcelConfigureCollection : IConfigureCollection
    {
        public ExcelConfigureCollection (FileInfo fileInfo)
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
        ~ExcelConfigureCollection ()
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
        class ExcelConfigureList : IConfigureList
        {
            public ExcelConfigureList (ExcelWorksheet sheet)
            {
                var cell = sheet.Cells[0, 1];
            }
            class ExcelConfigureUnit : IConfigureUnit
            {
                public ExcelConfigureUnit ()
                public string Key { get; set; }
                public string Value { get; set; }
            }

        }

        ExcelPackage Package { get; set; }

    }
}