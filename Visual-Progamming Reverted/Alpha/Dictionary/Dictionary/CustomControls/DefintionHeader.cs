using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Dictionary.CustomControls
{
    public partial class DefintionHeader : Panel
    {
        public DefintionHeader()
        {
            InitializeComponent(new Classes.WordHeader());
        }

        public DefintionHeader(IContainer container)
        {
            container.Add(this);

            InitializeComponent(new Classes.WordHeader());
        }
    }
}
