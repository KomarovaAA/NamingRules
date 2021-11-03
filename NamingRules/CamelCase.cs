using System;
using System.Reflection;

namespace camelCase
{
    public class publicClass
    {
        //classes + abstract methods + abstract events
        internal abstract class internalAbstractClass
        {
            public abstract void publicAbstractMethod(int simpleParameter);
            internal abstract void internalAbstractMethod<typeParameter>();
            protected abstract void protectedAbstractMethod();
            protected internal abstract void protectedInternalAbstractMethod();
            private protected abstract void privateProtectedAbstractMethod();
        }

        internal static class internalStaticClass
        {
        }

        protected abstract class protectedAbstractClass
        {
            public abstract event EventHandler publicAbstractEvent;
            internal abstract event EventHandler internalAbstractEvent;
            protected abstract event EventHandler protectedAbstractEvent;
            protected internal abstract event EventHandler protectedInternalAbstractEvent;
            private protected abstract event EventHandler privateProtectedAbstractEvent;
        }

        protected static class protectedStaticClass
        {
        }

        protected internal abstract class protectedInternalAbstractClass
        {
        }

        protected internal static class protectedInternalStaticClass
        {
        }

        private protected abstract class privateProtectedAbstractClass
        {
        }

        private protected static class privateProtectedStaticClass
        {
        }

        private abstract class privateAbstractClass
        {
        }

        private static class privateStaticClass
        {
        }

        //structs
        public struct publicStruct
        {
        }

        public readonly struct publicReadonlyStruct
        {
        }

        internal struct internalStruct
        {
        }

        internal readonly struct internalReadonlyStruct
        {
        }

        protected struct protectedStruct
        {
        }

        protected readonly struct protectedReadonlyStruct
        {
        }

        protected internal struct protectedInternalStruct
        {
        }

        protected internal readonly struct protectedInternalReadonlyStruct
        {
        }

        private protected struct privateProtectedStruct
        {
        }

        private protected readonly struct privateProtectedReadonlyStruct
        {
        }

        private struct privateStruct
        {
        }

        private readonly struct privateReadonlyStruct
        {
        }

        //interfaces 
        public interface iPublicInterface
        {
        }

        internal interface iInternalInterface
        {
        }

        protected interface iProtectedInterface
        {
        }

        protected internal interface iProtectedInternalInterface
        {
        }

        private protected interface iPrivateProtectedInterface
        {
        }

        private interface iPrivateInterface
        {
        }

        //enums
        public enum publicEnum
        {
        }

        internal enum internalEnum
        {
        }

        protected enum protectedEnum
        {
        }

        protected internal enum protectedInternalEnum
        {
        }

        private protected enum privateProtectedEnum
        {
        }

        private enum privateEnum
        {
        }

        //properties
        public int publicProperty { get; set; }
        internal int internalProperty { get; set; }
        protected int protectedProperty { get; set; }
        protected internal int protectedInternalProperty { get; set; }
        private protected int privateProtectedProperty { get; set; }
        private int privateProperty { get; set; }

        //methods(+parameter, type parameter, local, local function)
        public void publicMethod(int simpleParameter)
        {
        }

        public async void publicAsyncMethod(int simpleParameter)
        {
        }

        public static void publicStaticMethod(int simpleParameter)
        {
        }

        internal void internalMethod<typeParameter>()
        {
        }

        internal async void internalAsyncMethod<typeParameter>()
        {
        }

        internal static void internalStaticMethod<typeParameter>()
        {
        }

        protected void protectedMethod()
        {
            var localVariable = 1;

            void localFunction()
            {
            }

            ;
        }

        protected async void protectedAsyncMethod()
        {
        }

        protected static void protectedStaticMethod()
        {
        }

        protected internal void protectedInternalMethod()
        {
        }

        protected internal async void protectedInternalAsyncMethod()
        {
        }

        protected internal static void protectedInternalStaticMethod()
        {
        }

        private protected void privateProtectedMethod()
        {
        }

        private protected async void privateProtectedAsyncMethod()
        {
        }

        private protected static void privateProtectedStaticMethod()
        {
        }

        private void privateMethod()
        {
        }

        private async void privateAsyncMethod()
        {
        }

        private static void privateStaticMethod()
        {
        }

        //fields
        public int publicField = 1;
        public const int publicConstField = 1;
        public readonly int publicReadonlyField = 1;
        public static int publicStaticField = 1;
        internal int internalField = 2;
        internal const int internalConstField = 2;
        internal readonly int internalReadonlyField = 2;
        internal static int internalStaticField = 2;
        protected int protectedField = 3;
        protected const int protectedConstField = 3;
        protected readonly int protectedReadonlyField = 3;
        protected static int protectedStaticField = 3;
        protected internal int protectedInternalField = 4;
        protected internal const int protectedInternalConstField = 4;
        protected internal readonly int protectedInternalReadonlyField = 4;
        protected internal static int protectedInternalStaticField = 4;
        private protected int privateProtectedField = 5;
        private protected const int privateProtectedConstField = 5;
        private protected readonly int privateProtectedReadonlyField = 5;
        private protected static int privateProtectedStaticField = 5;
        private int privateField = 6;
        private const int privateConstField = 6;
        private readonly int privateReadonlyField = 6;
        private static int privateStaticField = 6;

        //events
        public event EventHandler publicEvent;
        public static event EventHandler publicStaticEvent;
        internal event EventHandler internalEvent;
        internal static event EventHandler internalStaticEvent;
        protected event EventHandler protectedEvent;
        protected static event EventHandler protectedStaticEvent;
        protected internal event EventHandler protectedInternalEvent;
        protected internal static event EventHandler protectedInternalStaticEvent;
        private protected event EventHandler privateProtectedEvent;
        private protected static event EventHandler privateProtectedStaticEvent;
        private event EventHandler privateEvent;
        private static event EventHandler privateStaticEvent;

        //delegate
        public delegate void publicDelegate();

        internal delegate void internalDelegate();

        protected delegate void protectedDelegate();

        protected internal delegate void protectedInternalDelegate();

        private protected delegate void privateProtectedDelegate();

        private delegate void privateDelegate();
    }
}