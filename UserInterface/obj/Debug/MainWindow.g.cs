﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "94C50C6C26917F003313602CA4CFB554"
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


namespace UserInterface {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Menu;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser webBrowser;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider progressMusic;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextUserName;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextGroupName;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDownload;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonStopPlayer;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextFilter;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridAlbumCompositions;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock compositionName;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressBar;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSave;
        
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
            System.Uri resourceLocater = new System.Uri("/UserInterface;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.Menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            
            #line 20 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonSaveSelectCompositions);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 21 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuSaveAllCompositions);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuExitClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 25 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemClickHelp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.webBrowser = ((System.Windows.Controls.WebBrowser)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.webBrowser.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.WebBrowserNavigated);
            
            #line default
            #line hidden
            return;
            case 7:
            this.progressMusic = ((System.Windows.Controls.Slider)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.progressMusic.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.progressMusic_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TextUserName = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\MainWindow.xaml"
            this.TextUserName.KeyUp += new System.Windows.Input.KeyEventHandler(this.UserNameKeyUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TextGroupName = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\MainWindow.xaml"
            this.TextGroupName.KeyUp += new System.Windows.Input.KeyEventHandler(this.GroupNameKeyUp);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButtonDownload = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\MainWindow.xaml"
            this.ButtonDownload.Click += new System.Windows.RoutedEventHandler(this.ButtonDownload_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ButtonStopPlayer = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\MainWindow.xaml"
            this.ButtonStopPlayer.Click += new System.Windows.RoutedEventHandler(this.ButtonStopPlayer_OnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.TextFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 99 "..\..\MainWindow.xaml"
            this.TextFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextFilter_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.GridAlbumCompositions = ((System.Windows.Controls.DataGrid)(target));
            
            #line 106 "..\..\MainWindow.xaml"
            this.GridAlbumCompositions.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.AlbumCompositionsMouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 107 "..\..\MainWindow.xaml"
            this.GridAlbumCompositions.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GridAlbumCompositions_OnMouseRightPlayComposition);
            
            #line default
            #line hidden
            return;
            case 15:
            this.compositionName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 16:
            this.progressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 17:
            this.ButtonSave = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\MainWindow.xaml"
            this.ButtonSave.Click += new System.Windows.RoutedEventHandler(this.ButtonSaveSelectCompositions);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

