﻿#pragma checksum "C:\Users\Brian\documents\visual studio 2013\Projects\CortanaQuick\Cortana Quick\CortanaOverlay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F942E469568ED54A5B763EAA3B4D9A31"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Cortana_Quick {
    
    
    public partial class CortanaOverlay : System.Windows.Controls.Grid {
        
        internal System.Windows.Controls.Grid LayoutRootX;
        
        internal System.Windows.Controls.StackPanel MessagePanel;
        
        internal System.Windows.Shapes.Rectangle Cortana;
        
        internal System.Windows.Controls.TextBlock HeaderTextBlock;
        
        internal System.Windows.Controls.TextBlock MessageTextBlock;
        
        internal System.Windows.Controls.Button YesButton;
        
        internal System.Windows.Controls.Button NoButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Cortana%20Quick;component/CortanaOverlay.xaml", System.UriKind.Relative));
            this.LayoutRootX = ((System.Windows.Controls.Grid)(this.FindName("LayoutRootX")));
            this.MessagePanel = ((System.Windows.Controls.StackPanel)(this.FindName("MessagePanel")));
            this.Cortana = ((System.Windows.Shapes.Rectangle)(this.FindName("Cortana")));
            this.HeaderTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("HeaderTextBlock")));
            this.MessageTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("MessageTextBlock")));
            this.YesButton = ((System.Windows.Controls.Button)(this.FindName("YesButton")));
            this.NoButton = ((System.Windows.Controls.Button)(this.FindName("NoButton")));
        }
    }
}

