//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Cef3
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Cef3.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefDomDocument : IDisposable
    {
        internal static CefDomDocument FromNative(cef_domdocument_t* ptr)
        {
            return new CefDomDocument(ptr);
        }
        
        internal static CefDomDocument FromNativeOrNull(cef_domdocument_t* ptr)
        {
            if (ptr == null) return null;
            return new CefDomDocument(ptr);
        }
        
        private cef_domdocument_t* _self;
        
        private CefDomDocument(cef_domdocument_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefDomDocument()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal int AddRef()
        {
            return cef_domdocument_t.add_ref(_self);
        }
        
        internal int Release()
        {
            return cef_domdocument_t.release(_self);
        }
        
        internal int RefCt
        {
            get { return cef_domdocument_t.get_refct(_self); }
        }
        
        internal cef_domdocument_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
