#pragma checksum "..\..\..\Windows\WebhookListItem.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "654203EDD23F69A56437F0FBBCD7DA741F52278201865B2644CC83DB798770AD"
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
    /// WebhookListItem
    /// </summary>
    public partial class WebhookListItem : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Windows\WebhookListItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border B_SelectCurrentWebhook;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\WebhookListItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush IB_Avatar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\WebhookListItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_WebhookName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Windows\WebhookListItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B_DeleteWebhook;
        
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
            System.Uri resourceLocater = new System.Uri("/DiscordWebhookQM;component/windows/webhooklistitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\WebhookListItem.xaml"
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
            
            #line 8 "..\..\..\Windows\WebhookListItem.xaml"
            ((DiscordWebhookQM.Windows.WebhookListItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.B_SelectCurrentWebhook_MouseEnter);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Windows\WebhookListItem.xaml"
            ((DiscordWebhookQM.Windows.WebhookListItem)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.B_SelectCurrentWebhook_MouseLeave);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Windows\WebhookListItem.xaml"
            ((DiscordWebhookQM.Windows.WebhookListItem)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.B_SelectCurrentWebhook_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.B_SelectCurrentWebhook = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.IB_Avatar = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 4:
            this.TB_WebhookName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.B_DeleteWebhook = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Windows\WebhookListItem.xaml"
            this.B_DeleteWebhook.Click += new System.Windows.RoutedEventHandler(this.B_DeleteWebhook_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

