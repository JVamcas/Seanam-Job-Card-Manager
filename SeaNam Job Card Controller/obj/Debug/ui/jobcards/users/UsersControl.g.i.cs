﻿#pragma checksum "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5538E8B4B11C9EAA78DE8B9A505121E18DC63A62087C48BF1089F33794C0A137"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SeaNam_Job_Card_Controller.ui.jobcards.users;
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


namespace SeaNam_Job_Card_Controller.ui.jobcards.users {
    
    
    /// <summary>
    /// UsersControl
    /// </summary>
    public partial class UsersControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 93 "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveUser;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearUserDetails;
        
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
            System.Uri resourceLocater = new System.Uri("/SeaNam_Job_Card_Controller;component/ui/jobcards/users/userscontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml"
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
            
            #line 58 "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.EditJobTitle_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 59 "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteJobTitle_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 60 "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddJobTitle_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 75 "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.EditJobTitle_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 76 "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteJobTitle_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 77 "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddJobTitle_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SaveUser = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml"
            this.SaveUser.Click += new System.Windows.RoutedEventHandler(this.SaveUserBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ClearUserDetails = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\..\..\ui\jobcards\users\UsersControl.xaml"
            this.ClearUserDetails.Click += new System.Windows.RoutedEventHandler(this.ClearUserBtn_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

