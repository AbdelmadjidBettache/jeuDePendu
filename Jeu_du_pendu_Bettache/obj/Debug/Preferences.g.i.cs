﻿#pragma checksum "..\..\Preferences.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "297D6D9A01BEABB7EAC060D132F01ACC17B3F04A511A5659245426A53A469797"
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
    /// Preferences
    /// </summary>
    public partial class Preferences : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDictionnaire;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnregistrer;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox grLangue;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFranc;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbAng;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox grNiveauJeu;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFacile;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbDefficile;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbMoyen;
        
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
            System.Uri resourceLocater = new System.Uri("/Jeu_du_pendu_Bettache;component/preferences.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Preferences.xaml"
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
            this.btnDictionnaire = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Preferences.xaml"
            this.btnDictionnaire.Click += new System.Windows.RoutedEventHandler(this.btnDictionnaire_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnEnregistrer = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Preferences.xaml"
            this.btnEnregistrer.Click += new System.Windows.RoutedEventHandler(this.btnEnregistrer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.grLangue = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 4:
            this.rbFranc = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.rbAng = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.grNiveauJeu = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 7:
            this.rbFacile = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.rbDefficile = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.rbMoyen = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

