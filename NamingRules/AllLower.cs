using System;

namespace all_lower
{
    public class public_class
    {
        //classes + abstract methods + abstract events
        internal abstract class internal_abstract_class
        {
            public abstract void public_abstract_method(int simple_parameter);
            internal abstract void internal_abstract_method<type_parameter>();
            protected abstract void protected_abstract_method();
            protected internal abstract void protected_internal_abstract_method();
            private protected abstract void private_protected_abstract_method();
        }

        internal static class internal_static_class
        {
        }

        protected abstract class protected_abstract_class
        {
            public abstract event EventHandler public_abstract_event;
            internal abstract event EventHandler internal_abstract_event;
            protected abstract event EventHandler protected_abstract_event;
            protected internal abstract event EventHandler protected_internal_abstract_event;
            private protected abstract event EventHandler private_protected_abstract_event;
        }

        protected static class protected_static_class
        {
        }

        protected internal abstract class protected_internal_abstract_class
        {
        }

        protected internal static class protected_internal_static_class
        {
        }

        private protected abstract class private_protected_abstract_class
        {
        }

        private protected static class private_protected_static_class
        {
        }

        private abstract class private_abstract_class
        {
        }

        private static class private_static_class
        {
        }

        //structs
        public struct public_struct
        {
        }

        public readonly struct public_readonly_struct
        {
        }

        internal struct internal_struct
        {
        }

        internal readonly struct internal_readonly_struct
        {
        }

        protected struct protected_struct
        {
        }

        protected readonly struct protected_readonly_struct
        {
        }

        protected internal struct protected_internal_struct
        {
        }

        protected internal readonly struct protected_internal_readonly_struct
        {
        }

        private protected struct private_protected_struct
        {
        }

        private protected readonly struct private_protected_readonly_struct
        {
        }

        private struct private_struct
        {
        }

        private readonly struct private_readonly_struct
        {
        }

        //interfaces 
        public interface public_interface
        {
        }

        internal interface internal_interface
        {
        }

        protected interface protected_interface
        {
        }

        protected internal interface protected_internal_interface
        {
        }

        private protected interface private_protected_interface
        {
        }

        private interface private_interface
        {
        }

        //enums
        public enum public_enum
        {
        }

        internal enum internal_enum
        {
        }

        protected enum protected_enum
        {
        }

        protected internal enum protected_internal_enum
        {
        }

        private protected enum private_protected_enum
        {
        }

        private enum private_enum
        {
        }

        //properties
        public int public_property { get; set; }
        internal int internal_property { get; set; }
        protected int protected_property { get; set; }
        protected internal int protected_internal_property { get; set; }
        private protected int private_protected_property { get; set; }
        private int private_property { get; set; }

        //methods(+parameter, type parameter, local, local function)
        public void public_method(int simple_parameter)
        {
        }

        public async void public_async_method(int simple_parameter)
        {
        }

        public static void public_static_method(int simple_parameter)
        {
        }

        internal void internal_method<type_parameter>()
        {
        }

        internal async void internal_async_method<type_parameter>()
        {
        }

        internal static void internal_static_method<type_parameter>()
        {
        }

        protected void protected_method()
        {
            var local_variable = 1;

            void local_function()
            {
            }

            ;
        }

        protected async void protected_async_method()
        {
        }

        protected static void protected_static_method()
        {
        }

        protected internal void protected_internal_method()
        {
        }

        protected internal async void protected_internal_async_method()
        {
        }

        protected internal static void protected_internal_static_method()
        {
        }

        private protected void private_protected_method()
        {
        }

        private protected async void private_protected_async_method()
        {
        }

        private protected static void private_protected_static_method()
        {
        }

        private void private_method()
        {
        }

        private async void private_async_method()
        {
        }

        private static void private_static_method()
        {
        }

        //fields
        public int public_field = 1;
        public const int public_const_field = 1;
        public readonly int public_readonly_field = 1;
        public static int public_static_field = 1;
        internal int internal_field = 2;
        internal const int internal_const_field = 2;
        internal readonly int internal_readonly_field = 2;
        internal static int internal_static_field = 2;
        protected int protected_field = 3;
        protected const int protected_const_field = 3;
        protected readonly int protected_readonly_field = 3;
        protected static int protected_static_field = 3;
        protected internal int protected_internal_field = 4;
        protected internal const int protected_internal_const_field = 4;
        protected internal readonly int protected_internal_readonly_field = 4;
        protected internal static int protected_internal_static_field = 4;
        private protected int private_protected_field = 5;
        private protected const int private_protected_const_field = 5;
        private protected readonly int private_protected_readonly_field = 5;
        private protected static int private_protected_static_field = 5;
        private readonly int private_field = 6;
        private const int private_const_field = 6;
        private readonly int private_readonly_field = 6;
        private static int private_static_field = 6;

        //events
        public event EventHandler public_event;
        public static event EventHandler public_static_event;
        internal event EventHandler internal_event;
        internal static event EventHandler internal_static_event;
        protected event EventHandler protected_event;
        protected static event EventHandler protected_static_event;
        protected internal event EventHandler protected_internal_event;
        protected internal static event EventHandler protected_internal_static_event;
        private protected event EventHandler private_protected_event;
        private protected static event EventHandler private_protected_static_event;
        private event EventHandler private_event;
        private static event EventHandler private_static_event;

        //delegate
        public delegate void public_delegate();

        internal delegate void internal_delegate();

        protected delegate void protected_delegate();

        protected internal delegate void protected_internal_delegate();

        private protected delegate void private_protected_delegate();

        private delegate void private_delegate();
    }
}
