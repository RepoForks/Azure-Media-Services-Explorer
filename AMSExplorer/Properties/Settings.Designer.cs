﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMSExplorer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection LoginList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["LoginList"]));
            }
            set {
                this["LoginList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string WAMEPresetXMLFilesCurrentFolder {
            get {
                return ((string)(this["WAMEPresetXMLFilesCurrentFolder"]));
            }
            set {
                this["WAMEPresetXMLFilesCurrentFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CallUpgrade {
            get {
                return ((bool)(this["CallUpgrade"]));
            }
            set {
                this["CallUpgrade"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayAssetIDinGrid {
            get {
                return ((bool)(this["DisplayAssetIDinGrid"]));
            }
            set {
                this["DisplayAssetIDinGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayJobIDinGrid {
            get {
                return ((bool)(this["DisplayJobIDinGrid"]));
            }
            set {
                this["DisplayJobIDinGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool useStorageEncryption {
            get {
                return ((bool)(this["useStorageEncryption"]));
            }
            set {
                this["useStorageEncryption"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool useProtectedConfiguration {
            get {
                return ((bool)(this["useProtectedConfiguration"]));
            }
            set {
                this["useProtectedConfiguration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool useTransferQueue {
            get {
                return ((bool)(this["useTransferQueue"]));
            }
            set {
                this["useTransferQueue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int NbItemsDisplayedInGrid {
            get {
                return ((int)(this["NbItemsDisplayedInGrid"]));
            }
            set {
                this["NbItemsDisplayedInGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayLiveChannelIDinGrid {
            get {
                return ((bool)(this["DisplayLiveChannelIDinGrid"]));
            }
            set {
                this["DisplayLiveChannelIDinGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayLiveProgramIDinGrid {
            get {
                return ((bool)(this["DisplayLiveProgramIDinGrid"]));
            }
            set {
                this["DisplayLiveProgramIDinGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayOriginIDinGrid {
            get {
                return ((bool)(this["DisplayOriginIDinGrid"]));
            }
            set {
                this["DisplayOriginIDinGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoRefresh {
            get {
                return ((bool)(this["AutoRefresh"]));
            }
            set {
                this["AutoRefresh"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int AutoRefreshTime {
            get {
                return ((int)(this["AutoRefreshTime"]));
            }
            set {
                this["AutoRefreshTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:02")]
        public global::System.TimeSpan LiveKeyFrameInterval {
            get {
                return ((global::System.TimeSpan)(this["LiveKeyFrameInterval"]));
            }
            set {
                this["LiveKeyFrameInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public short LiveHLSFragmentsPerSegment {
            get {
                return ((short)(this["LiveHLSFragmentsPerSegment"]));
            }
            set {
                this["LiveHLSFragmentsPerSegment"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://amsplayer.azurewebsites.net/?player=flash&format=smooth&url={manifest url}" +
            "")]
        public string CustomPlayerUrl {
            get {
                return ((string)(this["CustomPlayerUrl"]));
            }
            set {
                this["CustomPlayerUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CustomPlayerEnabled {
            get {
                return ((bool)(this["CustomPlayerEnabled"]));
            }
            set {
                this["CustomPlayerEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int DefaultJobPriority {
            get {
                return ((int)(this["DefaultJobPriority"]));
            }
            set {
                this["DefaultJobPriority"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("365")]
        public int DefaultLocatorDurationDays {
            get {
                return ((int)(this["DefaultLocatorDurationDays"]));
            }
            set {
                this["DefaultLocatorDurationDays"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayAssetStorageinGrid {
            get {
                return ((bool)(this["DisplayAssetStorageinGrid"]));
            }
            set {
                this["DisplayAssetStorageinGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PremiumWorkflowPresetXMLFilesCurrentFolder {
            get {
                return ((string)(this["PremiumWorkflowPresetXMLFilesCurrentFolder"]));
            }
            set {
                this["PremiumWorkflowPresetXMLFilesCurrentFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.99")]
        public decimal AMEPrice {
            get {
                return ((decimal)(this["AMEPrice"]));
            }
            set {
                this["AMEPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.39")]
        public decimal LegacyEncodingPrice {
            get {
                return ((decimal)(this["LegacyEncodingPrice"]));
            }
            set {
                this["LegacyEncodingPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public decimal IndexingPrice {
            get {
                return ((decimal)(this["IndexingPrice"]));
            }
            set {
                this["IndexingPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("$")]
        public string Currency {
            get {
                return ((string)(this["Currency"]));
            }
            set {
                this["Currency"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int DefaultTokenDuration {
            get {
                return ((int)(this["DefaultTokenDuration"]));
            }
            set {
                this["DefaultTokenDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%programfiles32%\\ffmpeg\\bin")]
        public string ffmpegPath {
            get {
                return ((string)(this["ffmpegPath"]));
            }
            set {
                this["ffmpegPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%programfiles32%\\VideoLAN\\VLC")]
        public string VLCPath {
            get {
                return ((string)(this["VLCPath"]));
            }
            set {
                this["VLCPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Microphone (High Definition Audio Device)")]
        public string DirectShowAudioDevice {
            get {
                return ((string)(this["DirectShowAudioDevice"]));
            }
            set {
                this["DirectShowAudioDevice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Webcam (High Definition Audio Device)")]
        public string DirectShowVideoDevice {
            get {
                return ((string)(this["DirectShowVideoDevice"]));
            }
            set {
                this["DirectShowVideoDevice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultSlateCurrentFolder {
            get {
                return ((string)(this["DefaultSlateCurrentFolder"]));
            }
            set {
                this["DefaultSlateCurrentFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AMEStandardPresetXMLFilesCurrentFolder {
            get {
                return ((string)(this["AMEStandardPresetXMLFilesCurrentFolder"]));
            }
            set {
                this["AMEStandardPresetXMLFilesCurrentFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://testacs")]
        public string DynEncTokenIssuer {
            get {
                return ((string)(this["DynEncTokenIssuer"]));
            }
            set {
                this["DynEncTokenIssuer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("urn:test")]
        public string DynEncTokenAudience {
            get {
                return ((string)(this["DynEncTokenAudience"]));
            }
            set {
                this["DynEncTokenAudience"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3.99")]
        public decimal MEPremiumWorkflowPrice {
            get {
                return ((decimal)(this["MEPremiumWorkflowPrice"]));
            }
            set {
                this["MEPremiumWorkflowPrice"] = value;
            }
        }
    }
}
