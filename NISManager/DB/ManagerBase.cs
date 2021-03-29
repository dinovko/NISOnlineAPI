using System;
using System.Collections.Generic;
using System.Text;

namespace NSIManager.DB
{
    public abstract class ManagerBase
    {
        public static bool IsLangkk()
        {
            //return Thread.CurrentThread.CurrentCulture.Name.Contains("kk");
            return true;
        }

        public static string LangFieldName()
        {
            return IsLangkk() ? "NameKZ" : "NameRU";
        }

        public static string LangFieldAddressName()
        {
            return IsLangkk() ? "AddressStringKZ" : "AddressStringRU";
        }
    }
}
