namespace PenFix
{
    public static class Extensions
    {

        private static Microsoft.Win32.RegistryKey OpenSubKeySafe(this Microsoft.Win32.RegistryKey r, string path)
        {
            var sukbey = r.OpenSubKey(path, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (sukbey == null)
            {
                sukbey = r.CreateSubKey(path);
            }
            return sukbey;
        }

        public static void CreateSubKeyValueSafe(this Microsoft.Win32.RegistryKey r, string path, string valuename, object val)
        {
            var subkey = r.OpenSubKeySafe(path);
            subkey.SetValue(valuename, val);
            subkey.Close();
        }

        public static void DeleteSubKeyValueSafe(this Microsoft.Win32.RegistryKey r, string path, string valuename)
        {
            var subkey = r.OpenSubKey(path, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (subkey == null)
            {
                // subkey doesn't exist. so nothing to do
                return;
            }

            // Delete value if exists
            subkey.DeleteValue(valuename,false);
        }


        public static object GetSubKeyValueSafe(this Microsoft.Win32.RegistryKey r, string name, string valuename)
        {
            var subkey = r.OpenSubKey(name);
            if (subkey== null)
            {
                return null;
            }
            var o = subkey.GetValue(valuename);
            return o;
        }

        public static int? GetSubKeyValueSafeInt(this Microsoft.Win32.RegistryKey r, string path, string valuename)
        {
            var o = r.GetSubKeyValueSafe(path, valuename);
            r.Close();

            if (o == null)
            {
                return null;
            }

            if (o is int)
            {
                return (int)o;
            }

            else
            {
                throw new System.Exception();
            }
        }

        public static bool ToBool( this int? s)
        {
            if (s.HasValue)
            {
                return s.Value != 0;
            }
            else
            {
                return false;
            } 
        }

        public static bool ToBool(this int s)
        {
            return s != 0;
        }
    }
}