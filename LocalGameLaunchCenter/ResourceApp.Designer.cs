﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocalGameLaunchCenter {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ResourceApp {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceApp() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LocalGameLaunchCenter.ResourceApp", typeof(ResourceApp).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;MainSettings&gt;
        ///  &lt;PathConfig&gt;
        ///    &lt;MyDateFiles&gt;MyDateFiles\&lt;/MyDateFiles&gt;
        ///    &lt;PCImg&gt;Resource\images\PC\&lt;/PCImg&gt;
        ///    &lt;EmuImg&gt;Resource\images\Emulator\&lt;/EmuImg&gt;
        ///    &lt;PCContent&gt;Resource\ExplanatoryText\PC\&lt;/PCContent&gt;
        ///    &lt;EmuContent&gt;Resource\ExplanatoryText\Emulator\&lt;/EmuContent&gt;
        ///    &lt;PCShortcut&gt;Shortcut\PC\&lt;/PCShortcut&gt;
        ///    &lt;EmuShortcut&gt;Shortcut\Emulator\&lt;/EmuShortcut&gt;
        ///    &lt;BackupData&gt;ProgramData\Backup\&lt;/BackupData&gt;
        ///    &lt;DefaultData&gt;ProgramData\DefaultData [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string AppConfig {
            get {
                return ResourceManager.GetString("AppConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;EmuMenu&gt;
        ///  &lt;EmuPath name=&quot;NES&quot; GamePath=&quot;I:\ClassicSimulatorGame\GameROM\FC\&quot; FilePath=&quot;I:\ClassicSimulatorGame\Emulator\FC\VirtuaNES\&quot; EmuName=&quot;VirtuaNES.exe&quot; Explain=&quot;Nintendo Entertainment System 家用主机游戏&quot;&gt;&lt;/EmuPath&gt;
        ///  &lt;EmuPath name=&quot;SNES&quot; GamePath=&quot;I:\ClassicSimulatorGame\GameROM\SFC&quot; FilePath=&quot;I:\ClassicSimulatorGame\Emulator\SFC\snes9x\&quot; EmuName=&quot;snes9x.exe&quot; Explain=&quot;Super Nintendo Entertainment System 家用主机游戏&quot;&gt;&lt;/EmuPath&gt;
        ///  &lt;EmuPath name=&quot;PCE&quot; GamePath=&quot;I:\Cla [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string EmuPath {
            get {
                return ResourceManager.GetString("EmuPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Emu默认图像 {
            get {
                object obj = ResourceManager.GetObject("Emu默认图像", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon GamePad {
            get {
                object obj = ResourceManager.GetObject("GamePad", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Main {
            get {
                object obj = ResourceManager.GetObject("Main", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;PCMenu&gt;
        ///  &lt;PCPath GameName=&quot;鬼泣123HD合集&quot; GameType=&quot;动作&quot; GamePath=&quot;I:\WindowsGameCenter\Devil May Cry HD Collection\&quot; SavePath=&quot;I:\WindowsGameCenter\Devil May Cry HD Collection\RemoteStorage&quot; StartName=&quot;dmcLauncher.exe&quot;&gt;
        ///  &lt;/PCPath&gt;
        ///  &lt;PCPath GameName=&quot;鬼泣4&quot; GameType=&quot;动作&quot; GamePath=&quot;E:\Devil May Cry 4\&quot; SavePath=&quot;C:\Users\ZHANGLEI\Documents\CAPCOM\DEVILMAYCRY4\&quot; StartName=&quot;DMC4Launcher.exe&quot;&gt;
        ///  &lt;/PCPath&gt;
        ///  &lt;PCPath GameName=&quot;鬼泣5&quot; GameType=&quot;动作&quot; GamePath=&quot;E:\Devil May Cry [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string PCPath {
            get {
                return ResourceManager.GetString("PCPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap PC默认图像 {
            get {
                object obj = ResourceManager.GetObject("PC默认图像", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;UsersInformation&gt;
        ///  &lt;Users uName=&quot;冬日晨曦&quot; uSex=&quot;男&quot; uTitle=&quot;游戏大师&quot; runCount=&quot;219&quot;&gt;
        ///  &lt;/Users&gt;
        ///&lt;/UsersInformation&gt; 的本地化字符串。
        /// </summary>
        internal static string UserConfig {
            get {
                return ResourceManager.GetString("UserConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Windows应用程序 {
            get {
                object obj = ResourceManager.GetObject("Windows应用程序", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 下载 {
            get {
                object obj = ResourceManager.GetObject("下载", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 修改器 {
            get {
                object obj = ResourceManager.GetObject("修改器", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 关于 {
            get {
                object obj = ResourceManager.GetObject("关于", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 删除 {
            get {
                object obj = ResourceManager.GetObject("删除", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 刷新 {
            get {
                object obj = ResourceManager.GetObject("刷新", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 刷新2 {
            get {
                object obj = ResourceManager.GetObject("刷新2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 备份 {
            get {
                object obj = ResourceManager.GetObject("备份", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 存档 {
            get {
                object obj = ResourceManager.GetObject("存档", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 家用机 {
            get {
                object obj = ResourceManager.GetObject("家用机", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 工具箱 {
            get {
                object obj = ResourceManager.GetObject("工具箱", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 帮助 {
            get {
                object obj = ResourceManager.GetObject("帮助", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 快捷方式 {
            get {
                object obj = ResourceManager.GetObject("快捷方式", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 恢复 {
            get {
                object obj = ResourceManager.GetObject("恢复", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 搜索 {
            get {
                object obj = ResourceManager.GetObject("搜索", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 文件夹 {
            get {
                object obj = ResourceManager.GetObject("文件夹", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 文件夹2 {
            get {
                object obj = ResourceManager.GetObject("文件夹2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 新增 {
            get {
                object obj = ResourceManager.GetObject("新增", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 日志 {
            get {
                object obj = ResourceManager.GetObject("日志", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 清空 {
            get {
                object obj = ResourceManager.GetObject("清空", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 游戏手柄 {
            get {
                object obj = ResourceManager.GetObject("游戏手柄", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 用户 {
            get {
                object obj = ResourceManager.GetObject("用户", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 磁盘 {
            get {
                object obj = ResourceManager.GetObject("磁盘", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 编辑 {
            get {
                object obj = ResourceManager.GetObject("编辑", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 设置 {
            get {
                object obj = ResourceManager.GetObject("设置", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap 退出 {
            get {
                object obj = ResourceManager.GetObject("退出", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
