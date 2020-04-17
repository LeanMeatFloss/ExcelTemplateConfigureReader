using System.IO;
using GeneralConfigureInstance;
using OfficeOpenXml;
namespace ExcelTemplateConfigureReaderLib
{
    public class ExcelConfigureSet : IConfigureSet
    {
        public ExcelConfigureSet (FileInfo fileInfo)
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
        ~ExcelConfigureSet ()
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
        class ExcelConfigureCollection : IConfigureCollection
        {
            public ExcelConfigureCollection (ExcelWorksheet sheet)
            {
                var cell = sheet.Cells[0, 1];
            }
            class ExcelConfigureList : IConfigureList
            {
                public ExcelConfigureList ()
                {

                }
                public string Key { get; set; }
                public string Value { get; set; }
                class ExcelConfigureUnit : IConfigureUnit
                {
                    public ExcelConfigureUnit (string key, ExcelRange cell)
                    {
                        Key = key;
                    }
                    ExcelRange cell { get; set; }
                    public string Key { get; }
                    public string Value { get => cell.GetValue<string> (); set => cell.Value = value; }
                }
            }

        }

        ExcelPackage Package { get; set; }

    }
}