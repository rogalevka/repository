﻿#pragma checksum "..\..\..\Pages\ServicesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C96C805FAA2E33E57D43A14F4883DE82D396AAC6224EF02BCCC2D105CEE3FF34"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfService.Pages;


namespace WpfService.Pages {
    
    
    /// <summary>
    /// ServicesPage
    /// </summary>
    public partial class ServicesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboSortBy;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboDiscount;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BlockRecords;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewServices;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddService;
        
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
            System.Uri resourceLocater = new System.Uri("/Курсовая;component/pages/servicespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ServicesPage.xaml"
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
            
            #line 9 "..\..\..\Pages\ServicesPage.xaml"
            ((WpfService.Pages.ServicesPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboSortBy = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\Pages\ServicesPage.xaml"
            this.ComboSortBy.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboSortBy_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboDiscount = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\Pages\ServicesPage.xaml"
            this.ComboDiscount.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboDiscount_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Pages\ServicesPage.xaml"
            this.TBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BlockRecords = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.LViewServices = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.BtnAddService = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\Pages\ServicesPage.xaml"
            this.BtnAddService.Click += new System.Windows.RoutedEventHandler(this.BtnAddService_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 71 "..\..\..\Pages\ServicesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 72 "..\..\..\Pages\ServicesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

