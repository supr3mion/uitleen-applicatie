using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uitleen_applicatie
{
    public partial class mysql : Component
    {
        public mysql()
        {
            InitializeComponent();
        }

        public mysql(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
