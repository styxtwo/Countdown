using System;

namespace Utilities.Extensions {
    public static class ActionExtensions {
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
