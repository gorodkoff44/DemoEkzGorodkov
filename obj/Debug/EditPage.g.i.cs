﻿#pragma checksum "..\..\EditPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CCC6DF73F03D5EFB0F95C62A399BE1B7788EBE8982050204A6A18ED9FD70B607"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DemoEkzGorodkov;
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


namespace DemoEkzGorodkov {
    
    
    /// <summary>
    /// EditPage
    /// </summary>
    public partial class EditPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleTB;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CostTB;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DurationInSecondsTB;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTB;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DiscountTB;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MainImagePath;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
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
            System.Uri resourceLocater = new System.Uri("/DemoEkzGorodkov;component/editpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditPage.xaml"
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
            this.TitleTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CostTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DurationInSecondsTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DescriptionTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DiscountTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.MainImagePath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\EditPage.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

