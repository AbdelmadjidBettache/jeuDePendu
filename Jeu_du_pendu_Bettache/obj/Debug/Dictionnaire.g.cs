﻿#pragma checksum "..\..\Dictionnaire.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AADEB98259123EF68130CD2D1A4B68B5BCC6DACC68DCE3F4898D97A4E033442E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Jeu_du_pendu_Bettache;
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


namespace Jeu_du_pendu_Bettache {
    
    
    /// <summary>
    /// Dictionnaire
    /// </summary>
    public partial class Dictionnaire : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Dictionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSupprimer;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Dictionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAccueil;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Dictionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgDictionnaire;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Dictionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox grAjouterMot;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Dictionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMot;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Dictionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbLangue;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Dictionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbNiveau;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Dictionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAjouter;
        
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
            System.Uri resourceLocater = new System.Uri("/Jeu_du_pendu_Bettache;component/dictionnaire.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Dictionnaire.xaml"
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
            
            #line 8 "..\..\Dictionnaire.xaml"
            ((Jeu_du_pendu_Bettache.Dictionnaire)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSupprimer = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Dictionnaire.xaml"
            this.btnSupprimer.Click += new System.Windows.RoutedEventHandler(this.btnSupprimer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAccueil = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Dictionnaire.xaml"
            this.btnAccueil.Click += new System.Windows.RoutedEventHandler(this.btnAccueil_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgDictionnaire = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.grAjouterMot = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 6:
            this.txtMot = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cbLangue = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\Dictionnaire.xaml"
            this.cbLangue.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbLangue_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbNiveau = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\Dictionnaire.xaml"
            this.cbNiveau.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbNiveau_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAjouter = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Dictionnaire.xaml"
            this.btnAjouter.Click += new System.Windows.RoutedEventHandler(this.btnAjouter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

