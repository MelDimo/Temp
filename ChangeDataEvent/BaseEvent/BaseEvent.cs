using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEvent
{
    public class EventParam
    {
        public string ModuleNameFrom { get; set; }
        public string ModuleNameTo { get; set; } // When empty - for all
        public object[] Param { get; set; }
    }

    public sealed class ReferenceChanges
    {
        public delegate void RefChanged(EventParam param);
        public event RefChanged OnReferenceChanged;

        private ReferenceChanges()
        {
            
        }

        private static readonly Lazy<ReferenceChanges> lazy = new Lazy<ReferenceChanges>(() => new ReferenceChanges());

        public static ReferenceChanges GetInstance { get { return lazy.Value; } }

        public void ReferenceChanged(EventParam param)
        {
            OnReferenceChanged(param);
        }

    }


}
