﻿#pragma checksum "..\..\AddNewDemand.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F91EF516A84458478575BEDF4D88C79015DA8A0B3FE49C133DADD779EE837B8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PracticApp;
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


namespace PracticApp {
    
    
    /// <summary>
    /// AddNewDemand
    /// </summary>
    public partial class AddNewDemand : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 108 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox clientID;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid2;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox iDComboBox1;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid3;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typeComboBox;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid4;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressTextBox;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid5;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox minPriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid6;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox maxPriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\AddNewDemand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label errorLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/PracticApp;component/addnewdemand.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddNewDemand.xaml"
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
            
            #line 8 "..\..\AddNewDemand.xaml"
            ((PracticApp.AddNewDemand)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DragAndMoveWindow);
            
            #line default
            #line hidden
            
            #line 8 "..\..\AddNewDemand.xaml"
            ((PracticApp.AddNewDemand)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 100 "..\..\AddNewDemand.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseWindow);
            
            #line default
            #line hidden
            return;
            case 3:
            this.clientID = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.grid2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.iDComboBox1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.grid3 = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.typeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.grid4 = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.addressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.grid5 = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.minPriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.grid6 = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            this.maxPriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.errorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            
            #line 189 "..\..\AddNewDemand.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

