﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Elucidate.Properties {
    
    
    [CompilerGenerated()]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("c:\\SnapRAID\\SnapRAID.exe")]
        public string SnapRAIDFileLocation {
            get {
                return ((string)(this["SnapRAIDFileLocation"]));
            }
            set {
                this["SnapRAIDFileLocation"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("c:\\SnapRAID\\SnapRAID.config")]
        public string ConfigFileLocation {
            get {
                return ((string)(this["ConfigFileLocation"]));
            }
            set {
                this["ConfigFileLocation"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool ConfigFileIsValid {
            get {
                return ((bool)(this["ConfigFileIsValid"]));
            }
            set {
                this["ConfigFileIsValid"] = value;
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool UseWindowsSettings {
            get {
                return ((bool)(this["UseWindowsSettings"]));
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool UseVerboseMode {
            get {
                return ((bool)(this["UseVerboseMode"]));
            }
            set {
                this["UseVerboseMode"] = value;
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("1000")]
        public ushort MaxNumberOfRealTimeLines {
            get {
                return ((ushort)(this["MaxNumberOfRealTimeLines"]));
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool UseGUIMode {
            get {
                return ((bool)(this["UseGUIMode"]));
            }
            set {
                this["UseGUIMode"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool FindByNameInSync {
            get {
                return ((bool)(this["FindByNameInSync"]));
            }
            set {
                this["FindByNameInSync"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool HiddenFilesExcluded {
            get {
                return ((bool)(this["HiddenFilesExcluded"]));
            }
            set {
                this["HiddenFilesExcluded"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("")]
        public string WindowLocation {
            get {
                return ((string)(this["WindowLocation"]));
            }
            set {
                this["WindowLocation"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool UpdateRequired {
            get {
                return ((bool)(this["UpdateRequired"]));
            }
            set {
                this["UpdateRequired"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool RunWithoutCapture {
            get {
                return ((bool)(this["RunWithoutCapture"]));
            }
            set {
                this["RunWithoutCapture"] = value;
            }
        }
    }
}
