﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrozzleApplication {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class WordListErrors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WordListErrors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CrozzleApplication.WordListErrors", typeof(WordListErrors).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10001: non-alphabetic value ({0}) in field {1} of the wordlist.
        /// </summary>
        internal static string AlphabeticError {
            get {
                return ResourceManager.GetString("AlphabeticError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10004: the wordlist size ({0}) is more than the expected maximum ({1}).
        /// </summary>
        internal static string MaximumSizeError {
            get {
                return ResourceManager.GetString("MaximumSizeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10003: the wordlist size ({0}) is less than the expected minimum ({1}).
        /// </summary>
        internal static string MinimumSizeError {
            get {
                return ResourceManager.GetString("MinimumSizeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10002: missing word in field {0} of the wordlist.
        /// </summary>
        internal static string MissingWordError {
            get {
                return ResourceManager.GetString("MissingWordError", resourceCulture);
            }
        }
    }
}
