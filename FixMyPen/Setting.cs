namespace PenFix
{
    public class Setting
    {
        private Microsoft.Win32.RegistryKey Root;
        private string KeyPath;
        private string ValueName;

        public Setting(Microsoft.Win32.RegistryKey registry, string k, string name)
        {
            this.Root = registry;
            this.KeyPath = k;
            this.ValueName = name;
        }

        public int? GetInt()
        {
            return this.Root.GetSubKeyValueSafeInt(this.KeyPath,this.ValueName);
        }

        public int GetInt(int defval)
        {
            var v = this.GetInt();
            if (v.HasValue)
            {
                return v.Value;
            }
            return defval;
        }

        public void SetInt(int v)
        {
            this.Root.CreateSubKeyValueSafe(this.KeyPath, this.ValueName, v);
        }

        public void Remove()
        {
            this.Root.DeleteSubKeyValueSafe(this.KeyPath,this.ValueName);
        }
    }
}