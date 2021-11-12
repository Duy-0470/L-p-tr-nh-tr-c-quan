using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Dictionary.CustomControls
{
    public partial class DropdownList : Component
    {
        public DropdownList()
        {
            InitializeComponent();
        }

        public DropdownList(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
