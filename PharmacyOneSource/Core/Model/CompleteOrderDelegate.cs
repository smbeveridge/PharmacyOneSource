using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public delegate IReceipt CompleteOrderDelegate(object sender, EventArgs args);
}
