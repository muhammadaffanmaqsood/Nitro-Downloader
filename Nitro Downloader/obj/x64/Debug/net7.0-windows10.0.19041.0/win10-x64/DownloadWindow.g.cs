﻿#pragma checksum "D:\Code\UET\Semester 5\SE Lab\Project\Nitro Downloader\DownloadWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AC1ABB8D2CB62D7AF49579CE0ED4FDABF656E5BDC555627FB776F997737354A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nitro_Downloader
{
    partial class DownloadWindow : 
        global::WinUIEx.WindowEx, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // DownloadWindow.xaml line 15
                {
                    this.AppTitleBar = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 3: // DownloadWindow.xaml line 75
                {
                    this.ProgressRingStackPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 4: // DownloadWindow.xaml line 80
                {
                    this.BodyContainer = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 5: // DownloadWindow.xaml line 312
                {
                    this.Location_TextBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 6: // DownloadWindow.xaml line 316
                {
                    this.ChangeLocationButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.ChangeLocationButton).Click += this.ChangeLocationButton_ClickAsync;
                }
                break;
            case 7: // DownloadWindow.xaml line 294
                {
                    this.URL_TextBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 8: // DownloadWindow.xaml line 298
                {
                    this.OpenURL_Button = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.OpenURL_Button).Click += this.OpenURL_Button_Click;
                }
                break;
            case 9: // DownloadWindow.xaml line 89
                {
                    this.Expander = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Expander>(target);
                }
                break;
            case 10: // DownloadWindow.xaml line 99
                {
                    this.TitleTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 11: // DownloadWindow.xaml line 104
                {
                    this.ChannelNameTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 12: // DownloadWindow.xaml line 234
                {
                    this.DateUploadedTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 13: // DownloadWindow.xaml line 223
                {
                    this.FileSizeTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 14: // DownloadWindow.xaml line 212
                {
                    this.ExtensionTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 15: // DownloadWindow.xaml line 201
                {
                    this.WebsiteTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 16: // DownloadWindow.xaml line 175
                {
                    this.ViewsTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 17: // DownloadWindow.xaml line 164
                {
                    this.CommentsTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 18: // DownloadWindow.xaml line 153
                {
                    this.LikesTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 19: // DownloadWindow.xaml line 142
                {
                    this.ResolutionTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 20: // DownloadWindow.xaml line 131
                {
                    this.DurationTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 21: // DownloadWindow.xaml line 94
                {
                    this.ThumbnailImage = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Image>(target);
                }
                break;
            case 22: // DownloadWindow.xaml line 29
                {
                    this.titleBar = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 23: // DownloadWindow.xaml line 52
                {
                    this.MinimizeToTrayButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.MinimizeToTrayButton).PointerEntered += this.MinimizeToTrayButton_PointerEntered;
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.MinimizeToTrayButton).PointerExited += this.MinimizeToTrayButton_PointerExited;
                }
                break;
            case 24: // DownloadWindow.xaml line 43
                {
                    this.AppTitleBarText = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

