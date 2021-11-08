using System;

// ReSharper disable UnusedMember.Global
// ReSharper disable CheckNamespace

namespace ALL_UPPER
{
    public class PUBLIC_CLASS
    {
        //classes + abstract methods + abstract events
        internal abstract class INTERNAL_ABSTRACT_CLASS
        {
            public abstract void PUBLIC_ABSTRACT_METHOD(int SIMPLE_PARAMETER);
            internal abstract void INTERNAL_ABSTRACT_METHOD<TYPE_PARAMETER>();
            protected abstract void PROTECTED_ABSTRACT_METHOD();
            protected internal abstract void PROTECTED_INTERNAL_ABSTRACT_METHOD();
            private protected abstract void PRIVATE_PROTECTED_ABSTRACT_METHOD();
        }

        internal static class INTERNAL_STATIC_CLASS
        {
        }

        protected abstract class PROTECTED_ABSTRACT_CLASS
        {
            public abstract event EventHandler PUBLIC_ABSTRACT_EVENT;
            internal abstract event EventHandler INTERNAL_ABSTRACT_EVENT;
            protected abstract event EventHandler PROTECTED_ABSTRACT_EVENT;
            protected internal abstract event EventHandler PROTECTED_INTERNAL_ABSTRACT_EVENT;
            private protected abstract event EventHandler PRIVATE_PROTECTED_ABSTRACT_EVENT;
        }

        protected static class PROTECTED_STATIC_CLASS
        {
        }

        protected internal abstract class PROTECTED_INTERNAL_ABSTRACT_CLASS
        {
        }

        protected internal static class PROTECTED_INTERNAL_STATIC_CLASS
        {
        }

        private protected abstract class PRIVATE_PROTECTED_ABSTRACT_CLASS
        {
        }

        private protected static class PRIVATE_PROTECTED_STATIC_CLASS
        {
        }

        private abstract class PRIVATE_ABSTRACT_CLASS
        {
        }

        private static class PRIVATE_STATIC_CLASS
        {
        }

        //structs
        public struct PUBLIC_STRUCT
        {
        }

        public readonly struct PUBLIC_READONLY_STRUCT
        {
        }

        internal struct INTERNAL_STRUCT
        {
        }

        internal readonly struct INTERNAL_READONLY_STRUCT
        {
        }

        protected struct PROTECTED_STRUCT
        {
        }

        protected readonly struct PROTECTED_READONLY_STRUCT
        {
        }

        protected internal struct PROTECTED_INTERNAL_STRUCT
        {
        }

        protected internal readonly struct PROTECTED_INTERNAL_READONLY_STRUCT
        {
        }

        private protected struct PRIVATE_PROTECTED_STRUCT
        {
        }

        private protected readonly struct PRIVATE_PROTECTED_READONLY_STRUCT
        {
        }

        private struct PRIVATE_STRUCT
        {
        }

        private readonly struct PRIVATE_READONLY_STRUCT
        {
        }

        //interfaces 
        public interface PUBLIC_INTERFACE
        {
        }

        internal interface INTERNAL_INTERFACE
        {
        }

        protected interface PROTECTED_INTERFACE
        {
        }

        protected internal interface PROTECTED_INTERNAL_INTERFACE
        {
        }

        private protected interface PRIVATE_PROTECTED_INTERFACE
        {
        }

        private interface PRIVATE_INTERFACE
        {
        }

        //enums
        public enum PUBLIC_ENUM
        {
        }

        internal enum INTERNAL_ENUM
        {
        }

        protected enum PROTECTED_ENUM
        {
        }

        protected internal enum PROTECTED_INTERNAL_ENUM
        {
        }

        private protected enum PRIVATE_PROTECTED_ENUM
        {
        }

        private enum PRIVATE_ENUM
        {
        }

        //properties
        public int PUBLIC_PROPERTY { get; set; }
        internal int INTERNAL_PROPERTY { get; set; }
        protected int PROTECTED_PROPERTY { get; set; }
        protected internal int PROTECTED_INTERNAL_PROPERTY { get; set; }
        private protected int PRIVATE_PROTECTED_PROPERTY { get; set; }
        private int PRIVATE_PROPERTY { get; set; }

        //methods(+parameter, type parameter, local, local function)
        public void PUBLIC_METHOD(int SIMPLE_PARAMETER)
        {
        }

        public async void PUBLIC_ASYNC_METHOD(int SIMPLE_PARAMETER)
        {
        }

        public static void PUBLIC_STATIC_METHOD(int SIMPLE_PARAMETER)
        {
        }

        internal void INTERNAL_METHOD<TYPE_PARAMETER>()
        {
        }

        internal async void INTERNAL_ASYNC_METHOD<TYPE_PARAMETER>()
        {
        }

        internal static void INTERNAL_STATIC_METHOD<TYPE_PARAMETER>()
        {
        }

        protected void PROTECTED_METHOD()
        {
            var LOCAL_VARIABLE = 1;

            void LOCAL_FUNCTION()
            {
            }

            ;
        }

        protected async void PROTECTED_ASYNC_METHOD()
        {
        }

        protected static void PROTECTED_STATIC_METHOD()
        {
        }

        protected internal void PROTECTED_INTERNAL_METHOD()
        {
        }

        protected internal async void PROTECTED_INTERNAL_ASYNC_METHOD()
        {
        }

        protected internal static void PROTECTED_INTERNAL_STATIC_METHOD()
        {
        }

        private protected void PRIVATE_PROTECTED_METHOD()
        {
        }

        private protected async void PRIVATE_PROTECTED_ASYNC_METHOD()
        {
        }

        private protected static void PRIVATE_PROTECTED_STATIC_METHOD()
        {
        }

        private void PRIVATE_METHOD()
        {
        }

        private async void PRIVATE_ASYNC_METHOD()
        {
        }

        private static void PRIVATE_STATIC_METHOD()
        {
        }

        //fields
        public int PUBLIC_FIELD = 1;
        public const int PUBLIC_CONST_FIELD = 1;
        public readonly int PUBLIC_READONLY_FIELD = 1;
        public static int PUBLIC_STATIC_FIELD = 1;
        internal int INTERNAL_FIELD = 2;
        internal const int INTERNAL_CONST_FIELD = 2;
        internal readonly int INTERNAL_READONLY_FIELD = 2;
        internal static int INTERNAL_STATIC_FIELD = 2;
        protected int PROTECTED_FIELD = 3;
        protected const int PROTECTED_CONST_FIELD = 3;
        protected readonly int PROTECTED_READONLY_FIELD = 3;
        protected static int PROTECTED_STATIC_FIELD = 3;
        protected internal int PROTECTED_INTERNAL_FIELD = 4;
        protected internal const int PROTECTED_INTERNAL_CONST_FIELD = 4;
        protected internal readonly int PROTECTED_INTERNAL_READONLY_FIELD = 4;
        protected internal static int PROTECTED_INTERNAL_STATIC_FIELD = 4;
        private protected int PRIVATE_PROTECTED_FIELD = 5;
        private protected const int PRIVATE_PROTECTED_CONST_FIELD = 5;
        private protected readonly int PRIVATE_PROTECTED_READONLY_FIELD = 5;
        private protected static int PRIVATE_PROTECTED_STATIC_FIELD = 5;
        private int PRIVATE_FIELD = 6;
        private const int PRIVATE_CONST_FIELD = 6;
        private readonly int PRIVATE_READONLY_FIELD = 6;
        private static int PRIVATE_STATIC_FIELD = 6;

        //events
        public event EventHandler PUBLIC_EVENT;
        public static event EventHandler PUBLIC_STATIC_EVENT;
        internal event EventHandler INTERNAL_EVENT;
        internal static event EventHandler INTERNAL_STATIC_EVENT;
        protected event EventHandler PROTECTED_EVENT;
        protected static event EventHandler PROTECTED_STATIC_EVENT;
        protected internal event EventHandler PROTECTED_INTERNAL_EVENT;
        protected internal static event EventHandler PROTECTED_INTERNAL_STATIC_EVENT;
        private protected event EventHandler PRIVATE_PROTECTED_EVENT;
        private protected static event EventHandler PRIVATE_PROTECTED_STATIC_EVENT;
        private event EventHandler PRIVATE_EVENT;
        private static event EventHandler PRIVATE_STATIC_EVENT;

        //delegate
        public delegate void PUBLIC_DELEGATE();

        internal delegate void INTERNAL_DELEGATE();

        protected delegate void PROTECTED_DELEGATE();

        protected internal delegate void PROTECTED_INTERNAL_DELEGATE();

        private protected delegate void PRIVATE_PROTECTED_DELEGATE();

        private delegate void PRIVATE_DELEGATE();
    }
}