﻿#pragma checksum "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D55BF191154EE6901CA1504692A2CDD2EE0B5BFE7BC164D49A9082C0C3D1659D"
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
    /// EditReadersCardPage
    /// </summary>
    public partial class EditReadersCardPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtYear;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox listReaders;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox listDepartments;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCard;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGen;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/LibraryRegistrationSystem;component/pages/readerscardspages/editreaderscardpage." +
                    "xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml"
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
            this.txtYear = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.listReaders = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.listDepartments = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtCard = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnGen = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml"
            this.btnGen.Click += new System.Windows.RoutedEventHandler(this.btnGen_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\Pages\ReadersCardsPages\EditReadersCardPage.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

