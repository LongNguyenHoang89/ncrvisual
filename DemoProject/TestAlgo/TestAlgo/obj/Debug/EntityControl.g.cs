#pragma checksum "D:\Working\MHST2010\Source\DemoProject\TestAlgo\TestAlgo\EntityControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "51C138B022DD25F3B2AC16956D96897F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
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


namespace TestAlgo {
    
    
    public partial class EntityControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid mainCanvas;
        
        internal System.Windows.Media.Animation.Storyboard highlightStoryboard;
        
        internal System.Windows.Media.Animation.ColorAnimation highlightAnimation;
        
        internal System.Windows.Media.Animation.Storyboard highlightSecondaryStoryboard;
        
        internal System.Windows.Media.Animation.ColorAnimation highlightSecondaryAnimation;
        
        internal System.Windows.Media.Animation.Storyboard unHighlightStoryboard;
        
        internal System.Windows.Media.Animation.ColorAnimation unHighlightAnimation;
        
        internal System.Windows.Controls.Border rectangle;
        
        internal System.Windows.Media.SolidColorBrush endStop;
        
        internal System.Windows.Controls.TextBlock titleBlock;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/TestAlgo;component/EntityControl.xaml", System.UriKind.Relative));
            this.mainCanvas = ((System.Windows.Controls.Grid)(this.FindName("mainCanvas")));
            this.highlightStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("highlightStoryboard")));
            this.highlightAnimation = ((System.Windows.Media.Animation.ColorAnimation)(this.FindName("highlightAnimation")));
            this.highlightSecondaryStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("highlightSecondaryStoryboard")));
            this.highlightSecondaryAnimation = ((System.Windows.Media.Animation.ColorAnimation)(this.FindName("highlightSecondaryAnimation")));
            this.unHighlightStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("unHighlightStoryboard")));
            this.unHighlightAnimation = ((System.Windows.Media.Animation.ColorAnimation)(this.FindName("unHighlightAnimation")));
            this.rectangle = ((System.Windows.Controls.Border)(this.FindName("rectangle")));
            this.endStop = ((System.Windows.Media.SolidColorBrush)(this.FindName("endStop")));
            this.titleBlock = ((System.Windows.Controls.TextBlock)(this.FindName("titleBlock")));
        }
    }
}
