using System;
using System.Reflection;
using System.Threading.Tasks;

namespace PrefPascalCaseSuf
{
    public class PrefPublicClassSuf
    {
        //classes + abstract methods + abstract events
        internal abstract class PrefInternalAbstractClassSuf
        {
            public abstract void PrefPublicAbstractMethodSuf(int PrefSimpleParameterSuf);
            internal abstract void PrefInternalAbstractMethodSuf<PrefTypeParameterSuf>();
            protected abstract void PrefProtectedAbstractMethodSuf();
            protected internal abstract void PrefProtectedInternalAbstractMethodSuf();
            private protected abstract void PrefPrivateProtectedAbstractMethodSuf();
        }

        internal static class PrefInternalStaticClassSuf
        {
        }

        protected abstract class PrefProtectedAbstractClassSuf
        {
            public abstract event EventHandler PrefPublicAbstractEventSuf;
            internal abstract event EventHandler PrefInternalAbstractEventSuf;
            protected abstract event EventHandler PrefProtectedAbstractEventSuf;
            protected internal abstract event EventHandler PrefProtectedInternalAbstractEventSuf;
            private protected abstract event EventHandler PrefPrivateProtectedAbstractEventSuf;
        }

        protected static class PrefProtectedStaticClassSuf
        {
        }

        protected internal abstract class PrefProtectedInternalAbstractClassSuf
        {
        }

        protected internal static class PrefProtectedInternalStaticClassSuf
        {
        }

        private protected abstract class PrefPrivateProtectedAbstractClassSuf
        {
        }

        private protected static class PrefPrivateProtectedStaticClassSuf
        {
        }

        private abstract class PrefPrivateAbstractClassSuf
        {
        }

        private static class PrefPrivateStaticClassSuf
        {
        }

        //structs
        public struct PrefPublicStructSuf
        {
            public void PrefPublicAbstractMethodSuf(int PrefSimpleParameterSuf)
            {
            }

            internal void PrefInternalAbstractMethodSuf<PrefTypeParameterSuf>()
            {
            }
        }

        public readonly struct PrefPublicReadonlyStructSuf
        {
        }

        internal struct PrefInternalStructSuf
        {
        }

        internal readonly struct PrefInternalReadonlyStructSuf
        {
        }

        protected struct PrefProtectedStructSuf
        {
        }

        protected readonly struct PrefProtectedReadonlyStructSuf
        {
        }

        protected internal struct PrefProtectedInternalStructSuf
        {
        }

        protected internal readonly struct PrefProtectedInternalReadonlyStructSuf
        {
        }

        private protected struct PrefPrivateProtectedStructSuf
        {
        }

        private protected readonly struct PrefPrivateProtectedReadonlyStructSuf
        {
        }

        private struct PrefPrivateStructSuf
        {
        }

        private readonly struct PrefPrivateReadonlyStructSuf
        {
        }

        //interfaces 
        public interface PrefPublicInterfaceSuf
        {
            Task<string> PrefGetSuf();
        }

        internal interface PrefInternalInterfaceSuf
        {
        }

        protected interface PrefProtectedInterfaceSuf
        {
        }

        protected internal interface PrefProtectedInternalInterfaceSuf
        {
        }

        private protected interface PrefPrivateProtectedInterfaceSuf
        {
        }

        private interface PrefPrivateInterfaceSuf
        {
        }

        //enums
        public enum PrefPublicEnumSuf
        {
        }

        internal enum PrefInternalEnumSuf
        {
        }

        protected enum PrefProtectedEnumSuf
        {
        }

        protected internal enum PrefProtectedInternalEnumSuf
        {
        }

        private protected enum PrefPrivateProtectedEnumSuf
        {
        }

        private enum PrefPrivateEnumSuf
        {
        }

        //properties
        public int PrefPublicPropertySuf { get; set; }
        internal int PrefInternalPropertySuf { get; set; }
        protected int PrefProtectedPropertySuf { get; set; }
        protected internal int PrefProtectedInternalPropertySuf { get; set; }
        private protected int PrefPrivateProtectedPropertySuf { get; set; }
        private int PrefPrivatePropertySuf { get; set; }

        //methods(+parameter, type parameter, local, local function)
        public void PrefPublicMethodSuf(int PrefSimpleParameterSuf)
        {
        }

        public async void PrefPublicAsyncMethodSuf(int PrefSimpleParameterSuf)
        {
        }

        public static void PrefPublicStaticMethodSuf(int PrefSimpleParameterSuf)
        {
        }

        internal void PrefInternalMethodSuf<PrefTypeParameterSuf>()
        {
        }

        internal async void PrefInternalAsyncMethodSuf<PrefTypeParameterSuf>()
        {
        }

        internal static void PrefInternalStaticMethodSuf<PrefTypeParameterSuf>()
        {
        }

        protected void PrefProtectedMethodSuf()
        {
            var PrefLocalVariableSuf = 1;

            void PrefLocalFunctionSuf()
            {
            }

            ;
        }

        protected async void PrefProtectedAsyncMethodSuf()
        {
        }

        protected static void PrefProtectedStaticMethodSuf()
        {
        }

        protected internal void PrefProtectedInternalMethodSuf()
        {
        }

        protected internal async void PrefProtectedInternalAsyncMethodSuf()
        {
        }

        protected internal static void PrefProtectedInternalStaticMethodSuf()
        {
        }

        private protected void PrefPrivateProtectedMethodSuf()
        {
        }

        private protected async void PrefPrivateProtectedAsyncMethodSuf()
        {
        }

        private protected static void PrefPrivateProtectedStaticMethodSuf()
        {
        }

        private void PrefPrivateMethodSuf()
        {
        }

        private async void PrefPrivateAsyncMethodSuf()
        {
        }

        private static void PrefPrivateStaticMethodSuf()
        {
        }

        //fields
        public int PrefPublicFieldSuf = 1;
        public const int PrefPublicConstFieldSuf = 1;
        public readonly int PrefPublicReadonlyFieldSuf = 1;
        public static int PrefPublicStaticFieldSuf = 1;
        internal int PrefInternalFieldSuf = 2;
        internal const int PrefInternalConstFieldSuf = 2;
        internal readonly int PrefInternalReadonlyFieldSuf = 2;
        internal static int PrefInternalStaticFieldSuf = 2;
        protected int PrefProtectedFieldSuf = 3;
        protected const int PrefProtectedConstFieldSuf = 3;
        protected readonly int PrefProtectedReadonlyFieldSuf = 3;
        protected static int PrefProtectedStaticFieldSuf = 3;
        protected internal int PrefProtectedInternalFieldSuf = 4;
        protected internal const int PrefProtectedInternalConstFieldSuf = 4;
        protected internal readonly int PrefProtectedInternalReadonlyFieldSuf = 4;
        protected internal static int PrefProtectedInternalStaticFieldSuf = 4;
        private protected int PrefPrivateProtectedFieldSuf = 5;
        private protected const int PrefPrivateProtectedConstFieldSuf = 5;
        private protected readonly int PrefPrivateProtectedReadonlyFieldSuf = 5;
        private protected static int PrefPrivateProtectedStaticFieldSuf = 5;
        private int PrefPrivateFieldSuf = 6;
        private const int PrefPrivateConstFieldSuf = 6;
        private readonly int PrefPrivateReadonlyFieldSuf = 6;
        private static int PrefPrivateStaticFieldSuf = 6;

        //events
        public event EventHandler PrefPublicEventSuf;
        public static event EventHandler PrefPublicStaticEventSuf;
        internal event EventHandler PrefInternalEventSuf;
        internal static event EventHandler PrefInternalStaticEventSuf;
        protected event EventHandler PrefProtectedEventSuf;
        protected static event EventHandler PrefProtectedStaticEventSuf;
        protected internal event EventHandler PrefProtectedInternalEventSuf;
        protected internal static event EventHandler PrefProtectedInternalStaticEventSuf;
        private protected event EventHandler PrefPrivateProtectedEventSuf;
        private protected static event EventHandler PrefPrivateProtectedStaticEventSuf;
        private event EventHandler PrefPrivateEventSuf;
        private static event EventHandler PrefPrivateStaticEventSuf;

        //delegate
        public delegate void PrefPublicDelegateSuf();

        internal delegate void PrefInternalDelegateSuf();

        protected delegate void PrefProtectedDelegateSuf();

        protected internal delegate void PrefProtectedInternalDelegateSuf();

        private protected delegate void PrefPrivateProtectedDelegateSuf();

        private delegate void PrefPrivateDelegateSuf();
    }
}