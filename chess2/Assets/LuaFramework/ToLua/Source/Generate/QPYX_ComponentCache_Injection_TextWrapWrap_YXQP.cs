﻿using System;
using LuaInterface;

public class QPYX_ComponentCache_Injection_TextWrapWrap_YXQP
{
	public static void QPYX_Register_YXQP(LuaState L_YXQP)	{
		L_YXQP.BeginClass(typeof(ComponentCache.Injection<TextWrap>), typeof(System.Object), "Injection_TextWrap");
		L_YXQP.RegFunction("New", QPYX__CreateComponentCache_Injection_TextWrap_YXQP);
		L_YXQP.RegFunction("__tostring", ToLua.op_ToString);		L_YXQP.RegVar("name", QPYX_get_name_YXQP, QPYX_set_name_YXQP);
		L_YXQP.RegVar("value", QPYX_get_value_YXQP, QPYX_set_value_YXQP);
		L_YXQP.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int QPYX__CreateComponentCache_Injection_TextWrap_YXQP(IntPtr L_YXQP)
	{
		try
		{
			int QPYX_count_YXQP = LuaDLL.lua_gettop(L_YXQP);
			if (QPYX_count_YXQP == 0)
			{
				ComponentCache.Injection<TextWrap> QPYX_obj_YXQP = new ComponentCache.Injection<TextWrap>();
				ToLua.PushObject(L_YXQP, QPYX_obj_YXQP);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L_YXQP, "invalid arguments to ctor method: ComponentCache.Injection<TextWrap>.New");
			}
		}
		catch (Exception e_YXQP)		{
			return LuaDLL.toluaL_exception(L_YXQP, e_YXQP);		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int QPYX_get_name_YXQP(IntPtr L_YXQP)
	{
		object QPYX_o_YXQP = null;
		try
		{
			QPYX_o_YXQP = ToLua.ToObject(L_YXQP, 1);			ComponentCache.Injection<TextWrap> QPYX_obj_YXQP = (ComponentCache.Injection<TextWrap>)QPYX_o_YXQP;
			string QPYX_ret_YXQP = QPYX_obj_YXQP.name;
			LuaDLL.lua_pushstring(L_YXQP, QPYX_ret_YXQP);
			return 1;
		}
		catch(Exception QPYX_e_YXQP)		{
			return LuaDLL.toluaL_exception(L_YXQP, QPYX_e_YXQP, QPYX_o_YXQP, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int QPYX_get_value_YXQP(IntPtr L_YXQP)
	{
		object QPYX_o_YXQP = null;
		try
		{
			QPYX_o_YXQP = ToLua.ToObject(L_YXQP, 1);			ComponentCache.Injection<TextWrap> QPYX_obj_YXQP = (ComponentCache.Injection<TextWrap>)QPYX_o_YXQP;
			TextWrap QPYX_ret_YXQP = QPYX_obj_YXQP.value;
			ToLua.Push(L_YXQP, QPYX_ret_YXQP);
			return 1;
		}
		catch(Exception QPYX_e_YXQP)		{
			return LuaDLL.toluaL_exception(L_YXQP, QPYX_e_YXQP, QPYX_o_YXQP, "attempt to index value on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int QPYX_set_name_YXQP(IntPtr L_YXQP)
	{
		object QPYX_o_YXQP = null;
		try
		{
			QPYX_o_YXQP = ToLua.ToObject(L_YXQP, 1);			ComponentCache.Injection<TextWrap> QPYX_obj_YXQP = (ComponentCache.Injection<TextWrap>)QPYX_o_YXQP;
			string QPYX_arg0_YXQP = ToLua.CheckString(L_YXQP, 2);
			QPYX_obj_YXQP.name = QPYX_arg0_YXQP;
			return 0;
		}
		catch(Exception QPYX_e_YXQP)		{
			return LuaDLL.toluaL_exception(L_YXQP, QPYX_e_YXQP, QPYX_o_YXQP, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int QPYX_set_value_YXQP(IntPtr L_YXQP)
	{
		object QPYX_o_YXQP = null;
		try
		{
			QPYX_o_YXQP = ToLua.ToObject(L_YXQP, 1);			ComponentCache.Injection<TextWrap> QPYX_obj_YXQP = (ComponentCache.Injection<TextWrap>)QPYX_o_YXQP;
			TextWrap QPYX_arg0_YXQP = (TextWrap)ToLua.CheckObject<TextWrap>(L_YXQP, 2);
			QPYX_obj_YXQP.value = QPYX_arg0_YXQP;
			return 0;
		}
		catch(Exception QPYX_e_YXQP)		{
			return LuaDLL.toluaL_exception(L_YXQP, QPYX_e_YXQP, QPYX_o_YXQP, "attempt to index value on a nil value");
		}
	}
}

