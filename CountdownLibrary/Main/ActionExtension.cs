using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    public static class ActionExtension {
        public static void NullSafeInvoke<T>(this Action<T> action, T obj) {
            if (action != null) {
                action.Invoke(obj);
            }
        }

        public static void NullSafeInvoke(this Action action) {
            if (action != null) {
                action.Invoke();
            }
        }
    }
}
