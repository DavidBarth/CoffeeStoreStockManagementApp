﻿#pragma checksum "..\..\..\View\CoffeeOverviewView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2C5FD83C36C07B73C1E8B374B70BF847"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace JoeCoffeeStore.StockManagement.App.View {
    
    
    /// <summary>
    /// CoffeeOverviewView
    /// </summary>
    public partial class CoffeeOverviewView : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\CoffeeOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CoffeeListView;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\View\CoffeeOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CoffeeImage;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\CoffeeOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CoffeeIdLabel;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\View\CoffeeOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CoffeeNameLabel;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\View\CoffeeOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DescriptionLabel;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\View\CoffeeOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PriceLabel;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\View\CoffeeOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label StockAmountLabel;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\View\CoffeeOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FirstTimeAddedLabel;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\View\CoffeeOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditCoffeeButton;
        
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
            System.Uri resourceLocater = new System.Uri("/JoeCoffeeStore.StockManagement.App;component/view/coffeeoverviewview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CoffeeOverviewView.xaml"
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
            this.CoffeeListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.CoffeeImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.CoffeeIdLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.CoffeeNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.DescriptionLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.PriceLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.StockAmountLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.FirstTimeAddedLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.EditCoffeeButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

