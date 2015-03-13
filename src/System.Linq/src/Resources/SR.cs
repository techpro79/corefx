// Do not edit this file manually it is auto-generated during the build based on the .resx file for this project.
namespace System
{
    internal static partial class SR
    {
#pragma warning disable 0414
        private const string s_resourcesName = "System.Linq.resources"; // assembly Name + .resources
#pragma warning restore 0414

#if !DEBUGRESOURCES
        internal static string EmptyEnumerable {
              get { return SR.GetResourceString("EmptyEnumerable", null); }
        }
        internal static string InvalidOperation_EnumOpCantHappen {
              get { return SR.GetResourceString("InvalidOperation_EnumOpCantHappen", null); }
        }
        internal static string MoreThanOneElement {
              get { return SR.GetResourceString("MoreThanOneElement", null); }
        }
        internal static string MoreThanOneMatch {
              get { return SR.GetResourceString("MoreThanOneMatch", null); }
        }
        internal static string NoElements {
              get { return SR.GetResourceString("NoElements", null); }
        }
        internal static string NoMatch {
              get { return SR.GetResourceString("NoMatch", null); }
        }
#else
        internal static string EmptyEnumerable {
              get { return SR.GetResourceString("EmptyEnumerable", @"Enumeration yielded no results"); }
        }
        internal static string InvalidOperation_EnumOpCantHappen {
              get { return SR.GetResourceString("InvalidOperation_EnumOpCantHappen", @"Enumeration has either not started or has already finished."); }
        }
        internal static string MoreThanOneElement {
              get { return SR.GetResourceString("MoreThanOneElement", @"Sequence contains more than one element"); }
        }
        internal static string MoreThanOneMatch {
              get { return SR.GetResourceString("MoreThanOneMatch", @"Sequence contains more than one matching element"); }
        }
        internal static string NoElements {
              get { return SR.GetResourceString("NoElements", @"Sequence contains no elements"); }
        }
        internal static string NoMatch {
              get { return SR.GetResourceString("NoMatch", @"Sequence contains no matching element"); }
        }

#endif
    }
}