using System;
using System.Linq;

namespace Gridsum.DataflowEx
{
    using System.Collections.Immutable;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using Common.Logging;
    using System.Reflection;

    public static class Utils
    {
        public static string GetFriendlyName(this Type type)
        {
            return type.FullName;
        }

        public static bool IsNullableType(this Type type)
        {
            Type tmp;
            return IsNullableType(type, out tmp);
        }

        public static bool IsNullableType(this Type type, out Type innerValueType)
        {
            innerValueType = null;
            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                innerValueType = Nullable.GetUnderlyingType(type);
                return true;
            }
            return false;
        }
    }
}