﻿/// Copyright 2016 by Samsung Electronics, Inc.,
///
/// This software is the confidential and proprietary information
/// of Samsung Electronics, Inc. ("Confidential Information"). You
/// shall not disclose such Confidential Information and shall use
/// it only in accordance with the terms of the license agreement
/// you entered into with Samsung.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class IoTConnectivity
    {
        internal static partial class Common
        {
            internal enum DataType
            {
                None = 0,
                Int,
                Bool,
                Double,
                String,
                ByteStr,
                Null,
                List,
                State
            }

            internal static partial class ResourceTypes
            {
                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                internal delegate bool ForeachCallback(string type, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_types_create")]
                internal static extern int Create(out IntPtr types);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_types_destroy")]
                internal static extern void Destroy(IntPtr types);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_types_add")]
                internal static extern int Add(IntPtr types, string type);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_types_remove")]
                internal static extern int Remove(IntPtr types, string type);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_types_foreach")]
                internal static extern int Foreach(IntPtr types, ForeachCallback cb, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_types_clone")]
                internal static extern int Clone(IntPtr src, out IntPtr dest);
            }

            internal static partial class ResourceInterfaces
            {
                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                internal delegate bool ForeachCallback(string iface, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_interfaces_create")]
                internal static extern int Create(out IntPtr ifaces);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_interfaces_destroy")]
                internal static extern void Destroy(IntPtr ifaces);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_interfaces_add")]
                internal static extern int Add(IntPtr ifaces, string iface);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_interfaces_remove")]
                internal static extern int Remove(IntPtr ifaces, string iface);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_interfaces_foreach")]
                internal static extern int Foreach(IntPtr ifaces, ForeachCallback cb, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_resource_interfaces_clone")]
                internal static extern int Clone(IntPtr src, out IntPtr dest);
            }

            internal static partial class State
            {
                internal delegate bool StateCallback(IntPtr state, string key, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_create")]
                internal static extern int Create(out IntPtr state);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_destroy")]
                internal static extern void Destroy(IntPtr state);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_clone")]
                internal static extern int Clone(IntPtr state, out IntPtr dest);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_add_int")]
                internal static extern int AddInt(IntPtr state, string key, int val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_add_bool")]
                internal static extern int AddBool(IntPtr state, string key, bool val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_add_double")]
                internal static extern int AddDouble(IntPtr state, string key, double val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_add_str")]
                internal static extern int AddStr(IntPtr state, string key, string val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_add_byte_str")]
                internal static extern unsafe int AddByteStr(IntPtr state, string key, byte[] val, int len);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_add_list")]
                internal static extern int AddList(IntPtr state, string key, IntPtr list);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_add_state")]
                internal static extern int AddState(IntPtr dest, string key, IntPtr src);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_add_null")]
                internal static extern int AddNull(IntPtr state, string key);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_get_int")]
                internal static extern int GetInt(IntPtr state, string key, out int val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_get_bool")]
                internal static extern int GetBool(IntPtr state, string key, out bool val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_get_double")]
                internal static extern int GetDouble(IntPtr state, string key, out double val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_get_str")]
                internal static extern int GetStr(IntPtr state, string key, out string val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_get_byte_str")]
                internal static extern int GetByteStr(IntPtr state, string key, out IntPtr value, out int size);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_get_list")]
                internal static extern int GetList(IntPtr state, string key, out IntPtr list);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_get_state")]
                internal static extern int GetState(IntPtr src, string key, out IntPtr dest);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_is_null")]
                internal static extern int IsNull(IntPtr state, string key, out bool isNull);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_remove")]
                internal static extern int Remove(IntPtr state, string key);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_get_type")]
                internal static extern int GetType(IntPtr state, string key, out DataType type);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_foreach")]
                internal static extern int Foreach(IntPtr state, StateCallback cb, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_state_get_keys_count")]
                internal static extern int GetKeysCount(IntPtr state, out int count);
            }

            internal static partial class Query
            {
                internal delegate bool QueryCallback(string key, string value, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_query_create")]
                internal static extern int Create(out IntPtr query);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_query_destroy")]
                internal static extern void Destroy(IntPtr query);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_query_get_resource_type")]
                internal static extern int GetResourceType(IntPtr query, out string resourceType);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_query_get_interface")]
                internal static extern int GetInterface(IntPtr query, out string resourceInterface);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_query_set_resource_type")]
                internal static extern int SetResourceType(IntPtr query, string resourceType);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_query_set_interface")]
                internal static extern int SetInterface(IntPtr query, string resourceInterface);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_query_add")]
                internal static extern int Add(IntPtr query, string key, string value);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_query_remove")]
                internal static extern int Remove(IntPtr query, string key);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_query_lookup")]
                internal static extern int Lookup(IntPtr query, string key, out string data);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_query_foreach")]
                internal static extern int Foreach(IntPtr query, QueryCallback cb, IntPtr userData);
            }

            internal static partial class Representation
            {
                internal delegate bool RepresentationChildrenCallback(IntPtr child, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_create")]
                internal static extern int Create(out IntPtr repr);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_destroy")]
                internal static extern void Destroy(IntPtr repr);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_clone")]
                internal static extern int Clone(IntPtr src, out IntPtr dest);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_set_uri_path")]
                internal static extern int SetUriPath(IntPtr repr, string uriPath);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_get_uri_path")]
                internal static extern int GetUriPath(IntPtr repr, out string uriPath);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_set_resource_types")]
                internal static extern int SetResourceTypes(IntPtr repr, IntPtr types);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_get_resource_types")]
                internal static extern int GetResourceTypes(IntPtr repr, out IntPtr types);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_set_resource_interfaces")]
                internal static extern int SetResourceInterfaces(IntPtr repr, IntPtr ifaces);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_get_resource_interfaces")]
                internal static extern int GetResourceInterfaces(IntPtr repr, out IntPtr ifaces);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_set_state")]
                internal static extern int SetState(IntPtr repr, IntPtr state);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_get_state")]
                internal static extern int GetState(IntPtr repr, out IntPtr state);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_add_child")]
                internal static extern int AddChild(IntPtr parent, IntPtr child);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_remove_child")]
                internal static extern int RemoveChild(IntPtr parent, IntPtr child);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_foreach_children")]
                internal static extern int ForeachChildren(IntPtr parent, RepresentationChildrenCallback cb, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_get_children_count")]
                internal static extern int GetChildrenCount(IntPtr parent, out int count);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_representation_get_nth_child")]
                internal static extern int GetNthChild(IntPtr parent, int pos, out IntPtr child);
            }

            internal static partial class Options
            {
                internal delegate bool OptionsCallback(ushort id, string data, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_options_create")]
                internal static extern int Create(out IntPtr options);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_options_destroy")]
                internal static extern void Destroy(IntPtr options);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_options_add")]
                internal static extern int Add(IntPtr options, ushort id, string data);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_options_remove")]
                internal static extern int Remove(IntPtr options, ushort id);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_options_lookup")]
                internal static extern int Lookup(IntPtr options, ushort id, out string data);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_options_foreach")]
                internal static extern int ForEach(IntPtr options, OptionsCallback cb, IntPtr userData);
            }

            internal static partial class List
            {
                internal delegate bool IntCallback(int pos, int value, IntPtr userData);

                internal delegate bool BoolCallback(int pos, bool value, IntPtr userData);

                internal delegate bool DoubleCallback(int pos, double value, IntPtr userData);

                internal delegate bool ByteStrCallback(int pos, byte[] value, int len, IntPtr userData);

                internal delegate bool StrCallback(int pos, string value, IntPtr userData);

                internal delegate bool ListCallback(int pos, IntPtr value, IntPtr userData);

                internal delegate bool StateCallback(int pos, IntPtr value, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_create")]
                internal static extern int Create(DataType type, out IntPtr list);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_destroy")]
                internal static extern void Destroy(IntPtr list);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_add_int")]
                internal static extern int AddInt(IntPtr list, int val, int pos);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_add_bool")]
                internal static extern int AddBool(IntPtr list, bool val, int pos);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_add_double")]
                internal static extern int AddDouble(IntPtr list, double val, int pos);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_add_str")]
                internal static extern int AddStr(IntPtr list, string val, int pos);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_add_byte_str")]
                internal static extern int AddByteStr(IntPtr list, byte[] val, int len, int pos);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_add_list")]
                internal static extern int AddList(IntPtr list, IntPtr val, int pos);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_add_state")]
                internal static extern int AddState(IntPtr list, IntPtr val, int pos);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_get_nth_int")]
                internal static extern int GetNthInt(IntPtr list, int pos, out int val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_get_nth_bool")]
                internal static extern int GetNthBool(IntPtr list, int pos, out bool val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_get_nth_double")]
                internal static extern int GetNthDouble(IntPtr list, int pos, out double val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_get_nth_str")]
                internal static extern int GetNthStr(IntPtr list, int pos, out string val);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_get_nth_byte_str")]
                internal static extern int GetNthByteStr(IntPtr list, int pos, out string val, out int len);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_get_nth_list")]
                internal static extern int GetNthList(IntPtr src, int pos, out IntPtr dest);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_get_nth_state")]
                internal static extern int GetNthState(IntPtr list, int pos, out IntPtr state);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_remove_nth")]
                internal static extern int RemoveNth(IntPtr list, int pos);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_get_type")]
                internal static extern int GetType(IntPtr list, out int type);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_get_length")]
                internal static extern int GetLength(IntPtr list, out int length);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_foreach_int")]
                internal static extern int ForeachInt(IntPtr list, IntCallback cb, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_foreach_bool")]
                internal static extern int ForeachBool(IntPtr list, BoolCallback cb, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_foreach_double")]
                internal static extern int ForeachDouble(IntPtr list, DoubleCallback cb, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_foreach_byte_str")]
                internal static extern int ForeachByteStr(IntPtr list, ByteStrCallback cb, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_foreach_str")]
                internal static extern int ForeachStr(IntPtr list, StrCallback cb, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_foreach_list")]
                internal static extern int ForeachList(IntPtr list, ListCallback cb, IntPtr userData);

                [DllImport(Libraries.IoTCon, EntryPoint = "iotcon_list_foreach_state")]
                internal static extern int ForeachState(IntPtr list, StateCallback cb, IntPtr userData);
            }
        }
    }
}
