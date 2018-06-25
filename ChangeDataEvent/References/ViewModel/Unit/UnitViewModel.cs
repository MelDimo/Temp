using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseEvent;

namespace References.ViewModel.Unit
{
    public class UnitViewModel
    {
        ReferenceChanges referenceChanges;

        public UnitViewModel()
        {
            referenceChanges = ReferenceChanges.GetInstance;
            referenceChanges.OnReferenceChanged += ReferenceChanges_OnReferenceChanged;
            referenceChanges.ReferenceChanged(new EventParam()
            {
                ModuleNameFrom = "UnitViewModel",
                ModuleNameTo = string.Empty,
                Param = new object[] { }
            });
        }

        private void ReferenceChanges_OnReferenceChanged(EventParam param)
        {
            Debug.Print($"References.ViewModel.Unit.UnitViewModel recive changed: {param.ModuleNameTo}");
        }

        //ReferenceChanges

    }
}
