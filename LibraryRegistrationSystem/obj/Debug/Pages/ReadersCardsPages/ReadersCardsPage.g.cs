﻿#pragma checksum "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5926BC352D722AD809818C5DDC08D1DF02F3AC2156679EE0EC426F3122FDAEE0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryRegistrationSystem.Pages.ReadersCardsPages;
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


namespace LibraryRegistrationSystem.Pages.ReadersCardsPages {
    
    
    /// <summary>
    /// ReadersCardsPage
    /// </summary>
    public partial class ReadersCardsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 24 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStartYear;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEndYear;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBranch;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbDepartment;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReset;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddNew;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/LibraryRegistrationSystem;component/pages/readerscardspages/readerscardspage.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
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
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
            this.txtName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtStartYear = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
            this.txtStartYear.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtEndYear = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
            this.txtEndYear.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbBranch = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
            this.cmbBranch.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbBranch_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbDepartment = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
            this.cmbDepartment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbDepartment_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnReset = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
            this.btnReset.Click += new System.Windows.RoutedEventHandler(this.btnReset_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAddNew = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
            this.btnAddNew.Click += new System.Windows.RoutedEventHandler(this.btnAddNew_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnRemove = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
            this.btnRemove.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
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
            case 11:
            
            #line 82 "..\..\..\..\Pages\ReadersCardsPages\ReadersCardsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

