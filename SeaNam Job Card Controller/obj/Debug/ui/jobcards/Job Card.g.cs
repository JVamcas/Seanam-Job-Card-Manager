﻿#pragma checksum "..\..\..\..\ui\jobcards\Job Card.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9BF085B316729D736EE22C63482E9E6207F021576610D3B8BA63F6CA7DE0ED0D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SeaNam_Job_Card_Controller;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace SeaNam_Job_Card_Controller.ui.jobcards {
    
    
    /// <summary>
    /// JobCard
    /// </summary>
    public partial class JobCard : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\ui\jobcards\Job Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox WorkAreaCombo;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\ui\jobcards\Job Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox JobClassCombo;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\ui\jobcards\Job Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OrdersCombo;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\ui\jobcards\Job Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WorkDescription;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\ui\jobcards\Job Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveJobCardBtn;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\ui\jobcards\Job Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearJobCardForm;
        
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
            System.Uri resourceLocater = new System.Uri("/SeaNam_Job_Card_Controller;component/ui/jobcards/job%20card.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ui\jobcards\Job Card.xaml"
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
            this.WorkAreaCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            
            #line 49 "..\..\..\..\ui\jobcards\Job Card.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddWorkArea_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.JobClassCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.OrdersCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.WorkDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.SaveJobCardBtn = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\..\..\ui\jobcards\Job Card.xaml"
            this.SaveJobCardBtn.Click += new System.Windows.RoutedEventHandler(this.SaveJobCardBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ClearJobCardForm = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\..\..\ui\jobcards\Job Card.xaml"
            this.ClearJobCardForm.Click += new System.Windows.RoutedEventHandler(this.ClearJobCardForm_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
