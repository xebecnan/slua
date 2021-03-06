﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Event : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Event o;
		if(matchType(l,1)){
			o=new UnityEngine.Event();
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(UnityEngine.Event))){
			UnityEngine.Event a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Event(a1);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTypeForControl(IntPtr l) {
		try{
			UnityEngine.Event self=checkSelf<UnityEngine.Event>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.EventType ret=self.GetTypeForControl(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Use(IntPtr l) {
		try{
			UnityEngine.Event self=checkSelf<UnityEngine.Event>(l);
			self.Use();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PopEvent(IntPtr l) {
		try{
			UnityEngine.Event a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Event.PopEvent(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetEventCount(IntPtr l) {
		try{
			System.Int32 ret=UnityEngine.Event.GetEventCount();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int KeyboardEvent(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Event ret=UnityEngine.Event.KeyboardEvent(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rawType(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.rawType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.type);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		UnityEngine.EventType v;
		checkType(l,2,out v);
		o.type=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mousePosition(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.mousePosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mousePosition(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.mousePosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delta(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.delta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delta(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.delta=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_button(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.button);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_button(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.button=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modifiers(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.modifiers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_modifiers(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		UnityEngine.EventModifiers v;
		checkType(l,2,out v);
		o.modifiers=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressure(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.pressure);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressure(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		System.Single v;
		checkType(l,2,out v);
		o.pressure=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clickCount(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.clickCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clickCount(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.clickCount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_character(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.character);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_character(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		System.Char v;
		checkType(l,2,out v);
		o.character=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_commandName(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.commandName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_commandName(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		System.String v;
		checkType(l,2,out v);
		o.commandName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyCode(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.keyCode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyCode(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		UnityEngine.KeyCode v;
		checkType(l,2,out v);
		o.keyCode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shift(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.shift);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shift(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.shift=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_control(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.control);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_control(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.control=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alt(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.alt);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alt(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.alt=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_command(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.command);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_command(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.command=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_capsLock(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.capsLock);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_capsLock(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.capsLock=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numeric(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.numeric);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_numeric(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.numeric=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_functionKey(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.functionKey);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,UnityEngine.Event.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UnityEngine.Event v;
		checkType(l,2,out v);
		UnityEngine.Event.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isKey(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.isKey);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isMouse(IntPtr l) {
		UnityEngine.Event o = checkSelf<UnityEngine.Event>(l);
		pushValue(l,o.isMouse);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Event");
		addMember(l,GetTypeForControl, "GetTypeForControl");
		addMember(l,Use, "Use");
		addMember(l,PopEvent, "PopEvent");
		addMember(l,GetEventCount, "GetEventCount");
		addMember(l,KeyboardEvent, "KeyboardEvent");
		addMember(l,get_rawType, "get_rawType");
		addMember(l,get_type, "get_type");
		addMember(l,set_type, "set_type");
		addMember(l,get_mousePosition, "get_mousePosition");
		addMember(l,set_mousePosition, "set_mousePosition");
		addMember(l,get_delta, "get_delta");
		addMember(l,set_delta, "set_delta");
		addMember(l,get_button, "get_button");
		addMember(l,set_button, "set_button");
		addMember(l,get_modifiers, "get_modifiers");
		addMember(l,set_modifiers, "set_modifiers");
		addMember(l,get_pressure, "get_pressure");
		addMember(l,set_pressure, "set_pressure");
		addMember(l,get_clickCount, "get_clickCount");
		addMember(l,set_clickCount, "set_clickCount");
		addMember(l,get_character, "get_character");
		addMember(l,set_character, "set_character");
		addMember(l,get_commandName, "get_commandName");
		addMember(l,set_commandName, "set_commandName");
		addMember(l,get_keyCode, "get_keyCode");
		addMember(l,set_keyCode, "set_keyCode");
		addMember(l,get_shift, "get_shift");
		addMember(l,set_shift, "set_shift");
		addMember(l,get_control, "get_control");
		addMember(l,set_control, "set_control");
		addMember(l,get_alt, "get_alt");
		addMember(l,set_alt, "set_alt");
		addMember(l,get_command, "get_command");
		addMember(l,set_command, "set_command");
		addMember(l,get_capsLock, "get_capsLock");
		addMember(l,set_capsLock, "set_capsLock");
		addMember(l,get_numeric, "get_numeric");
		addMember(l,set_numeric, "set_numeric");
		addMember(l,get_functionKey, "get_functionKey");
		addMember(l,get_current, "get_current");
		addMember(l,set_current, "set_current");
		addMember(l,get_isKey, "get_isKey");
		addMember(l,get_isMouse, "get_isMouse");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Event));
		LuaDLL.lua_pop(l, 1);
	}
}
