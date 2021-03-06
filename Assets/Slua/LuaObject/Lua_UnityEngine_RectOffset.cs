﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RectOffset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.RectOffset o;
		if(matchType(l,1)){
			o=new UnityEngine.RectOffset();
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			o=new UnityEngine.RectOffset(a1,a2,a3,a4);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		try{
			UnityEngine.RectOffset self=checkSelf<UnityEngine.RectOffset>(l);
			UnityEngine.Rect a1;
			checkType(l,2,out a1);
			UnityEngine.Rect ret=self.Add(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Remove(IntPtr l) {
		try{
			UnityEngine.RectOffset self=checkSelf<UnityEngine.RectOffset>(l);
			UnityEngine.Rect a1;
			checkType(l,2,out a1);
			UnityEngine.Rect ret=self.Remove(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_left(IntPtr l) {
		UnityEngine.RectOffset o = checkSelf<UnityEngine.RectOffset>(l);
		pushValue(l,o.left);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_left(IntPtr l) {
		UnityEngine.RectOffset o = checkSelf<UnityEngine.RectOffset>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.left=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_right(IntPtr l) {
		UnityEngine.RectOffset o = checkSelf<UnityEngine.RectOffset>(l);
		pushValue(l,o.right);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_right(IntPtr l) {
		UnityEngine.RectOffset o = checkSelf<UnityEngine.RectOffset>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.right=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_top(IntPtr l) {
		UnityEngine.RectOffset o = checkSelf<UnityEngine.RectOffset>(l);
		pushValue(l,o.top);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_top(IntPtr l) {
		UnityEngine.RectOffset o = checkSelf<UnityEngine.RectOffset>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.top=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bottom(IntPtr l) {
		UnityEngine.RectOffset o = checkSelf<UnityEngine.RectOffset>(l);
		pushValue(l,o.bottom);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bottom(IntPtr l) {
		UnityEngine.RectOffset o = checkSelf<UnityEngine.RectOffset>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.bottom=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontal(IntPtr l) {
		UnityEngine.RectOffset o = checkSelf<UnityEngine.RectOffset>(l);
		pushValue(l,o.horizontal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertical(IntPtr l) {
		UnityEngine.RectOffset o = checkSelf<UnityEngine.RectOffset>(l);
		pushValue(l,o.vertical);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RectOffset");
		addMember(l,Add, "Add");
		addMember(l,Remove, "Remove");
		addMember(l,get_left, "get_left");
		addMember(l,set_left, "set_left");
		addMember(l,get_right, "get_right");
		addMember(l,set_right, "set_right");
		addMember(l,get_top, "get_top");
		addMember(l,set_top, "set_top");
		addMember(l,get_bottom, "get_bottom");
		addMember(l,set_bottom, "set_bottom");
		addMember(l,get_horizontal, "get_horizontal");
		addMember(l,get_vertical, "get_vertical");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.RectOffset));
		LuaDLL.lua_pop(l, 1);
	}
}
