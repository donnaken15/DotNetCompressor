﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetCompressor.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NetCompressor.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly asm = Assembly.GetExecutingAssembly();
        ///
        ///ResourceManager rm = new ResourceManager(&quot;resource&quot;, asm);
        ///byte[] appBytes = (byte[])rm.GetObject(&quot;%appname%&quot;);
        ///
        /////Loading App
        ///MemoryStream memStr = new MemoryStream(appBytes);
        ///var gStream = new %mode%;
        ///
        ///MemoryStream tAppBytes = new MemoryStream(%appsize%);
        ///gStream.CopyTo(tAppBytes);
        ///memStr.Dispose();
        ///gStream.Dispose();
        ///
        ///byte[] exe = tAppBytes.ToArray();
        ///tAppBytes.Dispose();
        ///
        /////End Loading App.
        /// </summary>
        public static string AppMethod {
            get {
                return ResourceManager.GetString("AppMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        /////nothing passed on yet.
        ///
        ///string pdb = Path.GetDirectoryName(asm.Location) + &apos;\\&apos; + Path.GetFileNameWithoutExtension(asm.Location) + &quot;.pdb&quot;;
        ///
        ///var assemb = File.Exists(pdb) ?
        ///	Assembly.Load(exe, File.ReadAllBytes(pdb)) :
        ///	Assembly.Load(exe);
        ///exe = null;
        ///GC.Collect();
        ///object passthru = null;
        ///
        ///try {
        ///	%ret%assemb.EntryPoint.Invoke(null, new object[] {args});
        ///} catch(Exception ex) {
        ///	%ret%assemb.EntryPoint.Invoke(null, new object[] {new string[0]});
        ///}
        ///.
        /// </summary>
        public static string AppMethodEnd {
            get {
                return ResourceManager.GetString("AppMethodEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [assembly: AssemblyTitle(&quot;&quot;)]
        ///[assembly: AssemblyDescription(&quot;&quot;)]
        ///[assembly: AssemblyConfiguration(&quot;&quot;)]
        ///[assembly: AssemblyCompany(&quot;&quot;)]
        ///[assembly: AssemblyProduct(&quot;&quot;)]
        ///[assembly: AssemblyCopyright(&quot;Copyright ©&quot;)]
        ///[assembly: AssemblyTrademark(&quot;&quot;)]
        ///[assembly: AssemblyCulture(&quot;&quot;)]
        ///
        ///// Version information for an assembly consists of the following four values:
        /////
        /////      Major Version
        /////      Minor Version 
        /////      Build Number
        /////      Revision
        /////
        ///// You can specify all the values or you can defa [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Assembly {
            get {
                return ResourceManager.GetString("Assembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] SharpCompress {
            get {
                object obj = ResourceManager.GetObject("SharpCompress", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
