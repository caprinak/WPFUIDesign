﻿#pragma checksum "..\..\..\..\ListControls\ComboBoxSelectionSample.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B6E6A10A0C25F1B695E88F8D05B59A9444997DA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MVVMFormBasic.ListControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace MVVMFormBasic.ListControls {
    
    
    /// <summary>
    /// ComboBoxSelectionSample
    /// </summary>
    public partial class ComboBoxSelectionSample : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\ListControls\ComboBoxSelectionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbColors;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\ListControls\ComboBoxSelectionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrevious;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\ListControls\ComboBoxSelectionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNext;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\ListControls\ComboBoxSelectionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBlue;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MVVMFormBasic;V1.0.0.0;component/listcontrols/comboboxselectionsample.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ListControls\ComboBoxSelectionSample.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cmbColors = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\..\..\ListControls\ComboBoxSelectionSample.xaml"
            this.cmbColors.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbColors_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnPrevious = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\ListControls\ComboBoxSelectionSample.xaml"
            this.btnPrevious.Click += new System.Windows.RoutedEventHandler(this.btnPrevious_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnNext = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\ListControls\ComboBoxSelectionSample.xaml"
            this.btnNext.Click += new System.Windows.RoutedEventHandler(this.btnNext_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnBlue = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\ListControls\ComboBoxSelectionSample.xaml"
            this.btnBlue.Click += new System.Windows.RoutedEventHandler(this.btnBlue_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

