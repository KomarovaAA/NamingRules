using System;
using System.Reflection;

namespace PascalCase
{
    public class PublicClass
    {
        //classes + abstract methods + abstract events
        internal abstract class InternalAbstractClass
        {
            public abstract void PublicAbstractMethod(int SimpleParameter);
            internal abstract void InternalAbstractMethod<TypeParameter>();
            protected abstract void ProtectedAbstractMethod();
            protected internal abstract void ProtectedInternalAbstractMethod();
            private protected abstract void PrivateProtectedAbstractMethod();
        }

        internal static class InternalStaticClass
        {
        }

        protected abstract class ProtectedAbstractClass
        {
            public abstract event EventHandler PublicAbstractEvent;
            internal abstract event EventHandler InternalAbstractEvent;
            protected abstract event EventHandler ProtectedAbstractEvent;
            protected internal abstract event EventHandler ProtectedInternalAbstractEvent;
            private protected abstract event EventHandler PrivateProtectedAbstractEvent;
        }

        protected static class ProtectedStaticClass
        {
        }

        protected internal abstract class ProtectedInternalAbstractClass
        {
        }

        protected internal static class ProtectedInternalStaticClass
        {
        }

        private protected abstract class PrivateProtectedAbstractClass
        {
        }

        private protected static class PrivateProtectedStaticClass
        {
        }

        private abstract class PrivateAbstractClass
        {
        }

        private static class PrivateStaticClass
        {
        }

        public sealed class IdentityPublicSealedClass
        {
        }

        //structs
        public struct PublicStruct
        {
        }

        public readonly struct PublicReadonlyStruct
        {
        }

        internal struct InternalStruct
        {
        }

        internal readonly struct InternalReadonlyStruct
        {
        }

        protected struct ProtectedStruct
        {
        }

        protected readonly struct ProtectedReadonlyStruct
        {
        }

        protected internal struct ProtectedInternalStruct
        {
        }

        protected internal readonly struct ProtectedInternalReadonlyStruct
        {
        }

        private protected struct PrivateProtectedStruct
        {
        }

        private protected readonly struct PrivateProtectedReadonlyStruct
        {
        }

        private struct PrivateStruct
        {
        }

        private readonly struct PrivateReadonlyStruct
        {
        }

        //interfaces 
        public interface PublicInterface
        {
        }

        internal interface InternalInterface
        {
        }

        protected interface ProtectedInterface
        {
        }

        protected internal interface ProtectedInternalInterface
        {
        }

        private protected interface PrivateProtectedInterface
        {
        }

        private interface PrivateInterface
        {
        }

        //enums
        public enum PublicEnum
        {
        }

        internal enum InternalEnum
        {
        }

        protected enum ProtectedEnum
        {
        }

        protected internal enum ProtectedInternalEnum
        {
        }

        private protected enum PrivateProtectedEnum
        {
        }

        private enum PrivateEnum
        {
        }

        //properties
        public int PublicProperty { get; set; }
        internal int InternalProperty { get; set; }
        protected int ProtectedProperty { get; set; }
        protected internal int ProtectedInternalProperty { get; set; }
        private protected int PrivateProtectedProperty { get; set; }
        private int PrivateProperty { get; set; }

        //methods(+parameter, type parameter, local, local function)
        public void PublicMethod(int SimpleParameter)
        {
        }

        public async void PublicAsyncMethod(int SimpleParameter)
        {
        }

        public static void PublicStaticMethod(int SimpleParameter)
        {
        }

        internal void InternalMethod<TypeParameter>()
        {
        }

        internal async void InternalAsyncMethod<TypeParameter>()
        {
        }

        internal static void InternalStaticMethod<TypeParameter>()
        {
        }

        protected void ProtectedMethod()
        {
            var LocalVariable = 1;

            void LocalFunction()
            {
            }

            ;
        }

        protected async void ProtectedAsyncMethod()
        {
        }

        protected static void ProtectedStaticMethod()
        {
        }

        protected internal void ProtectedInternalMethod()
        {
        }

        protected internal async void ProtectedInternalAsyncMethod()
        {
        }

        protected internal static void ProtectedInternalStaticMethod()
        {
        }

        private protected void PrivateProtectedMethod()
        {
        }

        private protected async void PrivateProtectedAsyncMethod()
        {
        }

        private protected static void PrivateProtectedStaticMethod()
        {
        }

        private void PrivateMethod()
        {
        }

        private async void PrivateAsyncMethod()
        {
        }

        private static void PrivateStaticMethod()
        {
        }

        //fields
        public int PublicField = 1;
        public const int PublicConstField = 1;
        public readonly int PublicReadonlyField = 1;
        public static int PublicStaticField = 1;
        internal int InternalField = 2;
        internal const int InternalConstField = 2;
        internal readonly int InternalReadonlyField = 2;
        internal static int InternalStaticField = 2;
        protected int ProtectedField = 3;
        protected const int ProtectedConstField = 3;
        protected readonly int ProtectedReadonlyField = 3;
        protected static int ProtectedStaticField = 3;
        protected internal int ProtectedInternalField = 4;
        protected internal const int ProtectedInternalConstField = 4;
        protected internal readonly int ProtectedInternalReadonlyField = 4;
        protected internal static int ProtectedInternalStaticField = 4;
        private protected int PrivateProtectedField = 5;
        private protected const int PrivateProtectedConstField = 5;
        private protected readonly int PrivateProtectedReadonlyField = 5;
        private protected static int PrivateProtectedStaticField = 5;
        private int PrivateField = 6;
        private const int PrivateConstField = 6;
        private readonly int PrivateReadonlyField = 6;
        private static int PrivateStaticField = 6;

        //events
        public event EventHandler PublicEvent;
        public static event EventHandler PublicStaticEvent;
        internal event EventHandler InternalEvent;
        internal static event EventHandler InternalStaticEvent;
        protected event EventHandler ProtectedEvent;
        protected static event EventHandler ProtectedStaticEvent;
        protected internal event EventHandler ProtectedInternalEvent;
        protected internal static event EventHandler ProtectedInternalStaticEvent;
        private protected event EventHandler PrivateProtectedEvent;
        private protected static event EventHandler PrivateProtectedStaticEvent;
        private event EventHandler PrivateEvent;
        private static event EventHandler PrivateStaticEvent;

        //delegate
        public delegate void PublicDelegate();

        internal delegate void InternalDelegate();

        protected delegate void ProtectedDelegate();

        protected internal delegate void ProtectedInternalDelegate();

        private protected delegate void PrivateProtectedDelegate();

        private delegate void PrivateDelegate();
    }
}