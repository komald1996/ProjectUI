﻿#pragma checksum "..\..\Dashboard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "98D36C831D3ABD00B9DB9D9B9AE9F16B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using App1;
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


namespace App1 {
    
    
    /// <summary>
    /// Dashboard
    /// </summary>
    public partial class Dashboard : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUser;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fname;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lname;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label uId;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtbOrder;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtHoldings;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtbPositions;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtbOrderbook;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtbUser;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame NewFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/App1;component/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Dashboard.xaml"
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
            this.btnUser = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Dashboard.xaml"
            this.btnUser.Click += new System.Windows.RoutedEventHandler(this.btnUser_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fname = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lname = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.uId = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtbOrder = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\Dashboard.xaml"
            this.txtbOrder.Click += new System.Windows.RoutedEventHandler(this.txtbOrder_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtHoldings = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\Dashboard.xaml"
            this.txtHoldings.Click += new System.Windows.RoutedEventHandler(this.txtHoldings_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtbPositions = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\Dashboard.xaml"
            this.txtbPositions.Click += new System.Windows.RoutedEventHandler(this.txtbPositions_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtbOrderbook = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\Dashboard.xaml"
            this.txtbOrderbook.Click += new System.Windows.RoutedEventHandler(this.txtbOrderbook_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtbUser = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\Dashboard.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.NewFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 133 "..\..\Dashboard.xaml"
            this.NewFrame.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.NewFrame_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

