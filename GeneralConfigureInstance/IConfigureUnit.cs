using System;

namespace GeneralConfigureInstance
{
    public interface IConfigureUnit
    {
        string Key { get; }
        string Value { get; set; }
    }
}