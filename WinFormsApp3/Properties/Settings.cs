using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WinFormsApp3.Properties
{
    [CompilerGenerated]
    [SettingsProvider(typeof(LocalFileSettingsProvider))]
    internal sealed partial class Settings : ApplicationSettingsBase
    {
        private static readonly Settings instance =
            (Settings)Synchronized(new Settings());

        public static Settings Default => instance;

        [UserScopedSetting]
        [DefaultSettingValue("False")]
        [DebuggerNonUserCode]
        public bool IsMaximize
        {
            get => (bool)this[nameof(IsMaximize)];
            set => this[nameof(IsMaximize)] = value;
        }
        
        [UserScopedSetting]
        [DefaultSettingValue("-1")]
        [DebuggerNonUserCode]
        public string IsGroupSelected
        {
            get => (string)this[nameof(IsGroupSelected)];
            set => this[nameof(IsGroupSelected)] = value;
        }
    }
}