﻿#pragma checksum "..\..\..\View\CoffeeDetailView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1D45EDC67FAC2659EACB5699271296F7"
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
using System.Windows.Interactivity;
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
    /// CoffeeDetailView
    /// </summary>
    public partial class CoffeeDetailView : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\View\CoffeeDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CoffeeNameLabel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\CoffeeDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CoffeeImage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\View\CoffeeDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CoffeeIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\CoffeeDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CoffeeDescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\View\CoffeeDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CoffeePriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\View\CoffeeDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StockAmountTextBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\View\CoffeeDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstTimeAddedTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\View\CoffeeDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ExtraDescriptionTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/JoeCoffeeStore.StockManagement.App;component/view/coffeedetailview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CoffeeDetailView.xaml"
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
            this.CoffeeNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.CoffeeImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.CoffeeIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CoffeeDescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CoffeePriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.StockAmountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.FirstTimeAddedTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ExtraDescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

