using System;

namespace GeneralConfigureInstance
{
    public interface IConfigure
    {
        string Key{get;}
        string Value{ get; set; }
    }
}
