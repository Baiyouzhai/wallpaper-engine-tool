using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.Model {

    /// <summary>
    /// L-left, R-right, O-open, C-close
    /// </summary>
    public enum IntervalType {
        LO, LC, RO, RC, LORO, LORC, LCRO, LCRC
    }

    public class IntervalValue {

        protected IntervalType type;
        protected decimal min;
        protected decimal max;
        
        public IntervalType Type { get => type; set => type = value; }
        public decimal Min { get => min; set => min = value; }
        public decimal Max { get => max; set => max = value; }

    }

}
