﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Vector3 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Vector3 o;
		if(matchType(l,1,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			o=new UnityEngine.Vector3(a1,a2,a3);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Single),typeof(System.Single))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Vector3(a1,a2);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Lerp(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 ret=UnityEngine.Vector3.Lerp(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Slerp(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 ret=UnityEngine.Vector3.Slerp(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OrthoNormalize(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3.OrthoNormalize(ref a1,ref a2);
				pushValue(l,a1);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3.OrthoNormalize(ref a1,ref a2,ref a3);
				pushValue(l,a1);
				pushValue(l,a2);
				pushValue(l,a3);
				return 3;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveTowards(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 ret=UnityEngine.Vector3.MoveTowards(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RotateTowards(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			UnityEngine.Vector3 ret=UnityEngine.Vector3.RotateTowards(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SmoothDamp(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.Vector3 ret=UnityEngine.Vector3.SmoothDamp(a1,a2,ref a3,a4,a5);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Vector3 ret=UnityEngine.Vector3.SmoothDamp(a1,a2,ref a3,a4);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				UnityEngine.Vector3 ret=UnityEngine.Vector3.SmoothDamp(a1,a2,ref a3,a4,a5,a6);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try{
			UnityEngine.Vector3 self=checkSelf<UnityEngine.Vector3>(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.Set(a1,a2,a3);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Scale(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 ret=UnityEngine.Vector3.Scale(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 self=checkSelf<UnityEngine.Vector3>(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.Scale(a1);
				setBack(l,self);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Cross(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 ret=UnityEngine.Vector3.Cross(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reflect(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 ret=UnityEngine.Vector3.Reflect(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Normalize(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 ret=UnityEngine.Vector3.Normalize(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2)){
				UnityEngine.Vector3 self=checkSelf<UnityEngine.Vector3>(l);
				self.Normalize();
				setBack(l,self);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dot(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.Vector3.Dot(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Project(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 ret=UnityEngine.Vector3.Project(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ProjectOnPlane(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 ret=UnityEngine.Vector3.ProjectOnPlane(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Angle(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.Vector3.Angle(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Distance(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.Vector3.Distance(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClampMagnitude(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 ret=UnityEngine.Vector3.ClampMagnitude(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Magnitude(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.Vector3.Magnitude(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SqrMagnitude(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.Vector3.SqrMagnitude(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Min(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 ret=UnityEngine.Vector3.Min(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Max(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 ret=UnityEngine.Vector3.Max(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Addition(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 ret=a1+a2;
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Subtraction(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 ret=a1-a2;
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_UnaryNegation(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 ret=-a1;
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Multiply(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 ret=a1*a2;
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.Single),typeof(UnityEngine.Vector3))){
				System.Single a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 ret=a1*a2;
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Division(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 ret=a1/a2;
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1==a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1!=a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kEpsilon(IntPtr l) {
		pushValue(l,UnityEngine.Vector3.kEpsilon);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		UnityEngine.Vector3 o = checkSelf<UnityEngine.Vector3>(l);
		pushValue(l,o.x);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		UnityEngine.Vector3 o = checkSelf<UnityEngine.Vector3>(l);
		System.Single v;
		checkType(l,2,out v);
		o.x=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		UnityEngine.Vector3 o = checkSelf<UnityEngine.Vector3>(l);
		pushValue(l,o.y);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		UnityEngine.Vector3 o = checkSelf<UnityEngine.Vector3>(l);
		System.Single v;
		checkType(l,2,out v);
		o.y=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_z(IntPtr l) {
		UnityEngine.Vector3 o = checkSelf<UnityEngine.Vector3>(l);
		pushValue(l,o.z);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_z(IntPtr l) {
		UnityEngine.Vector3 o = checkSelf<UnityEngine.Vector3>(l);
		System.Single v;
		checkType(l,2,out v);
		o.z=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalized(IntPtr l) {
		UnityEngine.Vector3 o = checkSelf<UnityEngine.Vector3>(l);
		pushValue(l,o.normalized);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_magnitude(IntPtr l) {
		UnityEngine.Vector3 o = checkSelf<UnityEngine.Vector3>(l);
		pushValue(l,o.magnitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sqrMagnitude(IntPtr l) {
		UnityEngine.Vector3 o = checkSelf<UnityEngine.Vector3>(l);
		pushValue(l,o.sqrMagnitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_zero(IntPtr l) {
		pushValue(l,UnityEngine.Vector3.zero);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_one(IntPtr l) {
		pushValue(l,UnityEngine.Vector3.one);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forward(IntPtr l) {
		pushValue(l,UnityEngine.Vector3.forward);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_back(IntPtr l) {
		pushValue(l,UnityEngine.Vector3.back);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_up(IntPtr l) {
		pushValue(l,UnityEngine.Vector3.up);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_down(IntPtr l) {
		pushValue(l,UnityEngine.Vector3.down);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_left(IntPtr l) {
		pushValue(l,UnityEngine.Vector3.left);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_right(IntPtr l) {
		pushValue(l,UnityEngine.Vector3.right);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Vector3");
		addMember(l,Lerp, "Lerp");
		addMember(l,Slerp, "Slerp");
		addMember(l,OrthoNormalize, "OrthoNormalize");
		addMember(l,MoveTowards, "MoveTowards");
		addMember(l,RotateTowards, "RotateTowards");
		addMember(l,SmoothDamp, "SmoothDamp");
		addMember(l,Set, "Set");
		addMember(l,Scale, "Scale");
		addMember(l,Cross, "Cross");
		addMember(l,Reflect, "Reflect");
		addMember(l,Normalize, "Normalize");
		addMember(l,Dot, "Dot");
		addMember(l,Project, "Project");
		addMember(l,ProjectOnPlane, "ProjectOnPlane");
		addMember(l,Angle, "Angle");
		addMember(l,Distance, "Distance");
		addMember(l,ClampMagnitude, "ClampMagnitude");
		addMember(l,Magnitude, "Magnitude");
		addMember(l,SqrMagnitude, "SqrMagnitude");
		addMember(l,Min, "Min");
		addMember(l,Max, "Max");
		addMember(l,op_Addition, "op_Addition");
		addMember(l,op_Subtraction, "op_Subtraction");
		addMember(l,op_UnaryNegation, "op_UnaryNegation");
		addMember(l,op_Multiply, "op_Multiply");
		addMember(l,op_Division, "op_Division");
		addMember(l,op_Equality, "op_Equality");
		addMember(l,op_Inequality, "op_Inequality");
		addMember(l,get_kEpsilon, "get_kEpsilon");
		addMember(l,get_x, "get_x");
		addMember(l,set_x, "set_x");
		addMember(l,get_y, "get_y");
		addMember(l,set_y, "set_y");
		addMember(l,get_z, "get_z");
		addMember(l,set_z, "set_z");
		addMember(l,get_normalized, "get_normalized");
		addMember(l,get_magnitude, "get_magnitude");
		addMember(l,get_sqrMagnitude, "get_sqrMagnitude");
		addMember(l,get_zero, "get_zero");
		addMember(l,get_one, "get_one");
		addMember(l,get_forward, "get_forward");
		addMember(l,get_back, "get_back");
		addMember(l,get_up, "get_up");
		addMember(l,get_down, "get_down");
		addMember(l,get_left, "get_left");
		addMember(l,get_right, "get_right");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Vector3));
		LuaDLL.lua_pop(l, 1);
	}
}
