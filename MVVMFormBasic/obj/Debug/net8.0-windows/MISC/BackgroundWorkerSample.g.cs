﻿#pragma checksum "..\..\..\..\MISC\BackgroundWorkerSample.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84FB06F39B5C80CD1A5B9A7574FDD8AFA8F70152"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MVVMFormBasic.MISC;
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


namespace MVVMFormBasic.MISC {
    
    
    /// <summary>
    /// BackgroundWorkerSample
    /// </summary>
    public partial class BackgroundWorkerSample : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\MISC\BackgroundWorkerSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDoSynchronousCalculation;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\MISC\BackgroundWorkerSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDoAsynchronousCalculation;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\MISC\BackgroundWorkerSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar pbCalculationProgress;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\MISC\BackgroundWorkerSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbResults;
        
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
            System.Uri resourceLocater = new System.Uri("/MVVMFormBasic;component/misc/backgroundworkersample.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MISC\BackgroundWorkerSample.xaml"
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
            this.btnDoSynchronousCalculation = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\MISC\BackgroundWorkerSample.xaml"
            this.btnDoSynchronousCalculation.Click += new System.Windows.RoutedEventHandler(this.btnDoSynchronousCalculation_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnDoAsynchronousCalculation = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\MISC\BackgroundWorkerSample.xaml"
            this.btnDoAsynchronousCalculation.Click += new System.Windows.RoutedEventHandler(this.btnDoAsynchronousCalculation_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pbCalculationProgress = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 4:
            this.lbResults = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

