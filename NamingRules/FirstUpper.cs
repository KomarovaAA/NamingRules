using System;
// ReSharper disable All
#pragma warning disable CS0067

namespace First_upper
{
    public class Public_class
    {
        //classes + abstract methods + abstract events
        internal abstract class Internal_abstract_class
        {
            public abstract void Public_abstract_method(int Simple_parameter);
            internal abstract void Internal_abstract_method<Type_parameter>();
            protected abstract void Protected_abstract_method();
            protected internal abstract void Protected_internal_abstract_method();
            private protected abstract void Private_protected_abstract_method();
        }

        internal static class Internal_static_class
        {
        }

        protected abstract class Protected_abstract_class
        {
            public abstract event EventHandler Public_abstract_event;
            internal abstract event EventHandler Internal_abstract_event;
            protected abstract event EventHandler Protected_abstract_event;
            protected internal abstract event EventHandler Protected_internal_abstract_event;
            private protected abstract event EventHandler Private_protected_abstract_event;
        }

        protected static class Protected_static_class
        {
        }

        protected internal abstract class Protected_internal_abstract_class
        {
        }

        protected internal static class Protected_internal_static_class
        {
        }

        private protected abstract class Private_protected_abstract_class
        {
        }

        private protected static class Private_protected_static_class
        {
        }

        private abstract class Private_abstract_class
        {
        }

        private static class Private_static_class
        {
        }

        //structs
        public struct Public_struct
        {
        }

        public readonly struct Public_readonly_struct
        {
        }

        internal struct Internal_struct
        {
        }

        internal readonly struct Internal_readonly_struct
        {
        }

        protected struct Protected_struct
        {
        }

        protected readonly struct Protected_readonly_struct
        {
        }

        protected internal struct Protected_internal_struct
        {
        }

        protected internal readonly struct Protected_internal_readonly_struct
        {
        }

        private protected struct Private_protected_struct
        {
        }

        private protected readonly struct Private_protected_readonly_struct
        {
        }

        private struct Private_struct
        {
        }

        private readonly struct Private_readonly_struct
        {
        }

        //interfaces 
        public interface Public_interface
        {
        }

        internal interface Internal_interface
        {
        }

        protected interface Protected_interface
        {
        }

        protected internal interface Protected_internal_interface
        {
        }

        private protected interface Private_protected_interface
        {
        }

        private interface Private_interface
        {
        }

        //enums
        public enum Public_enum
        {
        }

        internal enum Internal_enum
        {
        }

        protected enum Protected_enum
        {
        }

        protected internal enum Protected_internal_enum
        {
        }

        private protected enum Private_protected_enum
        {
        }

        private enum Private_enum
        {
        }

        //properties
        public int Public_property { get; set; }
        internal int Internal_property { get; set; }
        protected int Protected_property { get; set; }
        protected internal int Protected_internal_property { get; set; }
        private protected int Private_protected_property { get; set; }
        private int Private_property { get; set; }

        //methods(+parameter, type parameter, local, local function)
        public void Public_method(int Simple_parameter)
        {
        }

        public async void Public_async_method(int Simple_parameter)
        {
        }

        public static void Public_static_method(int Simple_parameter)
        {
        }

        internal void Internal_method<Type_parameter>()
        {
        }

        internal async void Internal_async_method<Type_parameter>()
        {
        }

        internal static void Internal_static_method<Type_parameter>()
        {
        }

        protected void Protected_method()
        {
            var Local_variable = 1;

            void Local_function()
            {
            }

            ;
        }

        protected async void Protected_async_method()
        {
        }

        protected static void Protected_static_method()
        {
        }

        protected internal void Protected_internal_method()
        {
        }

        protected internal async void Protected_internal_async_method()
        {
        }

        protected internal static void Protected_internal_static_method()
        {
        }

        private protected void Private_protected_method()
        {
        }

        private protected async void Private_protected_async_method()
        {
        }

        private protected static void Private_protected_static_method()
        {
        }

        private void Private_method()
        {
        }

        private async void Private_async_method()
        {
        }

        private static void Private_static_method()
        {
        }

        //fields
        public int Public_field = 1;
        public const int Public_const_field = 1;
        public readonly int Public_readonly_field = 1;
        public static int Public_static_field = 1;
        internal int Internal_field = 2;
        internal const int Internal_const_field = 2;
        internal readonly int Internal_readonly_field = 2;
        internal static int Internal_static_field = 2;
        protected int Protected_field = 3;
        protected const int Protected_const_field = 3;
        protected readonly int Protected_readonly_field = 3;
        protected static int Protected_static_field = 3;
        protected internal int Protected_internal_field = 4;
        protected internal const int Protected_internal_const_field = 4;
        protected internal readonly int Protected_internal_readonly_field = 4;
        protected internal static int Protected_internal_static_field = 4;
        private protected int Private_protected_field = 5;
        private protected const int Private_protected_const_field = 5;
        private protected readonly int Private_protected_readonly_field = 5;
        private protected static int Private_protected_static_field = 5;
        private int Private_field = 6;
        private const int Private_const_field = 6;
        private readonly int Private_readonly_field = 6;
        private static int Private_static_field = 6;

        //events
        public event EventHandler Public_event;
        public static event EventHandler Public_static_event;
        internal event EventHandler Internal_event;
        internal static event EventHandler Internal_static_event;
        protected event EventHandler Protected_event;
        protected static event EventHandler Protected_static_event;
        protected internal event EventHandler Protected_internal_event;
        protected internal static event EventHandler Protected_internal_static_event;
        private protected event EventHandler Private_protected_event;
        private protected static event EventHandler Private_protected_static_event;
        private event EventHandler Private_event;
        private static event EventHandler Private_static_event;

        //delegate
        public delegate void Public_delegate();

        internal delegate void Internal_delegate();

        protected delegate void Protected_delegate();

        protected internal delegate void Protected_internal_delegate();

        private protected delegate void Private_protected_delegate();

        private delegate void Private_delegate();
    }
}