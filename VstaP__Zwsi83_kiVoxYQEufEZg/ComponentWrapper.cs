﻿/* THIS IS AUTO-GENERATED CODE THAT WILL BE OVERWRITTEN! DO NOT EDIT!
*  Microsoft SQL Server Integration Services component wrapper
*  This module defines the base class for your component
*  THIS IS AUTO-GENERATED CODE THAT WILL BE OVERWRITTEN! DO NOT EDIT! */

using System;
using System.Data;
using Microsoft.SqlServer.Dts.Pipeline;
using Microsoft.SqlServer.Dts.Pipeline.Wrapper;
using Microsoft.SqlServer.Dts.Runtime.Wrapper;

public class UserComponent: ScriptComponent
{
    public Connections Connections;
    public Variables Variables;
    public UserComponent()
    {
        Connections = new Connections(this);
        Variables = new Variables(this);
    }

    public override void ProcessInput(int InputID, string InputName, PipelineBuffer Buffer, OutputNameMap OutputMap)
    {

        if (InputName.Equals(@"Entrada 0", StringComparison.Ordinal))
        {
            Entrada0_ProcessInput(new Entrada0Buffer(Buffer, GetColumnIndexes(InputID), OutputMap));
        }

    }

    public virtual void Entrada0_ProcessInput(Entrada0Buffer Buffer)
    {
        while (Buffer.NextRow())
        {
            Entrada0_ProcessInputRow(Buffer);
        }
    }

    public virtual void Entrada0_ProcessInputRow(Entrada0Buffer Row)
    {
    }

}

public class Connections
{
    ScriptComponent ParentComponent;

    public Connections(ScriptComponent Component)
    {
        ParentComponent = Component;
    }

}

public class Variables
{
    ScriptComponent ParentComponent;

    public Variables(ScriptComponent Component)
    {
        ParentComponent = Component;
    }

    public String connectStrin
    {
        get
        {
            return (String)(ParentComponent.ReadOnlyVariables["connectStrin"].GetValueWithContext(ScriptComponent.EvaluatorContext));
        }
    }

}
