﻿

#pragma checksum "C:\Users\Mobitech\Documents\Visual Studio 2015\Projects\WinApp\WinApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "977E091C83ACC36DE84E3F1DD12D981C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinApp
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 20 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.WebView_Loaded;
                 #line default
                 #line hidden
                #line 21 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.WebView)(target)).NavigationFailed += this.WebView_NavigationFailed;
                 #line default
                 #line hidden
                #line 22 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.WebView)(target)).LoadCompleted += this.Browser_LoadCompleted;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


