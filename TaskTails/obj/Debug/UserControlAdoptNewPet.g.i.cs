﻿#pragma checksum "..\..\UserControlAdoptNewPet.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "01667E421FF11C8FCD40572EECF8CF8FAA528862EEE74067670D324E7BA0528D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using TaskTails;


namespace TaskTails {
    
    
    /// <summary>
    /// UserControlAdoptNewPet
    /// </summary>
    public partial class UserControlAdoptNewPet : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\UserControlAdoptNewPet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle FirstEgg;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UserControlAdoptNewPet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle SecondEgg;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UserControlAdoptNewPet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ThirdEgg;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UserControlAdoptNewPet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse EggOneSelected;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\UserControlAdoptNewPet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse EggTwoSelected;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\UserControlAdoptNewPet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse EggThreeSelected;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\UserControlAdoptNewPet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Adopt;
        
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
            System.Uri resourceLocater = new System.Uri("/TaskTails;component/usercontroladoptnewpet.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControlAdoptNewPet.xaml"
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
            this.FirstEgg = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 15 "..\..\UserControlAdoptNewPet.xaml"
            this.FirstEgg.Loaded += new System.Windows.RoutedEventHandler(this.EggOne_Loaded);
            
            #line default
            #line hidden
            
            #line 15 "..\..\UserControlAdoptNewPet.xaml"
            this.FirstEgg.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.EggOne_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SecondEgg = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 16 "..\..\UserControlAdoptNewPet.xaml"
            this.SecondEgg.Loaded += new System.Windows.RoutedEventHandler(this.EggTwo_Loaded);
            
            #line default
            #line hidden
            
            #line 16 "..\..\UserControlAdoptNewPet.xaml"
            this.SecondEgg.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.EggTwo_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ThirdEgg = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 17 "..\..\UserControlAdoptNewPet.xaml"
            this.ThirdEgg.Loaded += new System.Windows.RoutedEventHandler(this.EggThree_Loaded);
            
            #line default
            #line hidden
            
            #line 17 "..\..\UserControlAdoptNewPet.xaml"
            this.ThirdEgg.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.EggThree_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EggOneSelected = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 5:
            this.EggTwoSelected = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 6:
            this.EggThreeSelected = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 7:
            
            #line 33 "..\..\UserControlAdoptNewPet.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Adopt = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\UserControlAdoptNewPet.xaml"
            this.Adopt.Click += new System.Windows.RoutedEventHandler(this.Adopt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

