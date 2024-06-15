﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_list_value_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_list_value_t*, int> _is_valid;
        internal delegate* unmanaged<cef_list_value_t*, int> _is_owned;
        internal delegate* unmanaged<cef_list_value_t*, int> _is_read_only;
        internal delegate* unmanaged<cef_list_value_t*, cef_list_value_t*, int> _is_same;
        internal delegate* unmanaged<cef_list_value_t*, cef_list_value_t*, int> _is_equal;
        internal delegate* unmanaged<cef_list_value_t*, cef_list_value_t*> _copy;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, int> _set_size;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr> _get_size;
        internal delegate* unmanaged<cef_list_value_t*, int> _clear;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, int> _remove;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, CefValueType> _get_type;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, cef_value_t*> _get_value;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, int> _get_bool;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, int> _get_int;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, double> _get_double;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, cef_string_userfree*> _get_string;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, cef_binary_value_t*> _get_binary;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, cef_dictionary_value_t*> _get_dictionary;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, cef_list_value_t*> _get_list;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, cef_value_t*, int> _set_value;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, int> _set_null;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, int, int> _set_bool;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, int, int> _set_int;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, double, int> _set_double;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, cef_string_t*, int> _set_string;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, cef_binary_value_t*, int> _set_binary;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, cef_dictionary_value_t*, int> _set_dictionary;
        internal delegate* unmanaged<cef_list_value_t*, UIntPtr, cef_list_value_t*, int> _set_list;
        
        // Create
        [DllImport(libcef.DllName, EntryPoint = "cef_list_value_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_list_value_t* create();
        
        // AddRef
        
        public static void add_ref(cef_list_value_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_list_value_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_list_value_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_list_value_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // IsValid
        
        public static int is_valid(cef_list_value_t* self)
        {
            return self->_is_valid(self);
        }
        
        // IsOwned
        
        public static int is_owned(cef_list_value_t* self)
        {
            return self->_is_owned(self);
        }
        
        // IsReadOnly
        
        public static int is_read_only(cef_list_value_t* self)
        {
            return self->_is_read_only(self);
        }
        
        // IsSame
        
        public static int is_same(cef_list_value_t* self, cef_list_value_t* that)
        {
            return self->_is_same(self, that);
        }
        
        // IsEqual
        
        public static int is_equal(cef_list_value_t* self, cef_list_value_t* that)
        {
            return self->_is_equal(self, that);
        }
        
        // Copy
        
        public static cef_list_value_t* copy(cef_list_value_t* self)
        {
            return self->_copy(self);
        }
        
        // SetSize
        
        public static int set_size(cef_list_value_t* self, UIntPtr size)
        {
            return self->_set_size(self, size);
        }
        
        // GetSize
        
        public static UIntPtr get_size(cef_list_value_t* self)
        {
            return self->_get_size(self);
        }
        
        // Clear
        
        public static int clear(cef_list_value_t* self)
        {
            return self->_clear(self);
        }
        
        // Remove
        
        public static int remove(cef_list_value_t* self, UIntPtr index)
        {
            return self->_remove(self, index);
        }
        
        // GetType
        
        public static CefValueType get_type(cef_list_value_t* self, UIntPtr index)
        {
            return self->_get_type(self, index);
        }
        
        // GetValue
        
        public static cef_value_t* get_value(cef_list_value_t* self, UIntPtr index)
        {
            return self->_get_value(self, index);
        }
        
        // GetBool
        
        public static int get_bool(cef_list_value_t* self, UIntPtr index)
        {
            return self->_get_bool(self, index);
        }
        
        // GetInt
        
        public static int get_int(cef_list_value_t* self, UIntPtr index)
        {
            return self->_get_int(self, index);
        }
        
        // GetDouble
        
        public static double get_double(cef_list_value_t* self, UIntPtr index)
        {
            return self->_get_double(self, index);
        }
        
        // GetString
        
        public static cef_string_userfree* get_string(cef_list_value_t* self, UIntPtr index)
        {
            return self->_get_string(self, index);
        }
        
        // GetBinary
        
        public static cef_binary_value_t* get_binary(cef_list_value_t* self, UIntPtr index)
        {
            return self->_get_binary(self, index);
        }
        
        // GetDictionary
        
        public static cef_dictionary_value_t* get_dictionary(cef_list_value_t* self, UIntPtr index)
        {
            return self->_get_dictionary(self, index);
        }
        
        // GetList
        
        public static cef_list_value_t* get_list(cef_list_value_t* self, UIntPtr index)
        {
            return self->_get_list(self, index);
        }
        
        // SetValue
        
        public static int set_value(cef_list_value_t* self, UIntPtr index, cef_value_t* value)
        {
            return self->_set_value(self, index, value);
        }
        
        // SetNull
        
        public static int set_null(cef_list_value_t* self, UIntPtr index)
        {
            return self->_set_null(self, index);
        }
        
        // SetBool
        
        public static int set_bool(cef_list_value_t* self, UIntPtr index, int value)
        {
            return self->_set_bool(self, index, value);
        }
        
        // SetInt
        
        public static int set_int(cef_list_value_t* self, UIntPtr index, int value)
        {
            return self->_set_int(self, index, value);
        }
        
        // SetDouble
        
        public static int set_double(cef_list_value_t* self, UIntPtr index, double value)
        {
            return self->_set_double(self, index, value);
        }
        
        // SetString
        
        public static int set_string(cef_list_value_t* self, UIntPtr index, cef_string_t* value)
        {
            return self->_set_string(self, index, value);
        }
        
        // SetBinary
        
        public static int set_binary(cef_list_value_t* self, UIntPtr index, cef_binary_value_t* value)
        {
            return self->_set_binary(self, index, value);
        }
        
        // SetDictionary
        
        public static int set_dictionary(cef_list_value_t* self, UIntPtr index, cef_dictionary_value_t* value)
        {
            return self->_set_dictionary(self, index, value);
        }
        
        // SetList
        
        public static int set_list(cef_list_value_t* self, UIntPtr index, cef_list_value_t* value)
        {
            return self->_set_list(self, index, value);
        }
        
    }
}