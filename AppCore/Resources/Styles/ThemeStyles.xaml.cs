using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore.Resources
{
    public partial class ThemeStyles : ResourceDictionary
    {
        public ThemeStyles()
        {
            this.MergedDictionaries.Add(new ThemeColors());
            InitializeComponent();
        }
        
    }
}
