﻿#pragma checksum "..\..\..\Windows\SendMessagePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "16085C657531431D203CD61A390F82CB86E7CC373AEB8E2834B740F3A18CD979"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DiscordWebhookQM.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace DiscordWebhookQM.Windows {
    
    
    /// <summary>
    /// SendMessagePage
    /// </summary>
    public partial class SendMessagePage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Windows\SendMessagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_WebhookNameTitle;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\SendMessagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBx_WebhookURL;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Windows\SendMessagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBx_Message;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Windows\SendMessagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B_SendMessage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DiscordWebhookQM;component/windows/sendmessagepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\SendMessagePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\Windows\SendMessagePage.xaml"
            ((DiscordWebhookQM.Windows.SendMessagePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.SendMessagePage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TB_WebhookNameTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TBx_WebhookURL = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBx_Message = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.B_SendMessage = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Windows\SendMessagePage.xaml"
            this.B_SendMessage.Click += new System.Windows.RoutedEventHandler(this.B_SendMessage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

