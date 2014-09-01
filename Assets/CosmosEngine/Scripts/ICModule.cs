﻿//-------------------------------------------------------------------------
//
//      CosmosEngine - The Lightweight Unity3D Game Develop Framework
//
//                     Copyright © 2011-2014
//                   MrKelly <23110388@qq.com>
//              https://github.com/mr-kelly/CosmosEngine
//
//-------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
using System;

public interface ICModule
{
    IEnumerator Init();
    IEnumerator UnInit();
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class CModuleDependency : Attribute
{
    public CModuleDependency(Type dependencyType)
    {

    }
}