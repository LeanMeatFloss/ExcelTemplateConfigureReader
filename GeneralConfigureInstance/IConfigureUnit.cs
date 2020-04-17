using System;

namespace GeneralConfigureInstance
{
    public interface IConfigureUint
    {
        string Key { get; }
        string Value { get; set; }
    }
}