/* THIS IS AUTO-GENERATED CODE THAT WILL BE OVERWRITTEN! DO NOT EDIT!
*  Microsoft SQL Server Integration Services buffer wrappers
*  This module defines classes for accessing data flow buffers
*  THIS IS AUTO-GENERATED CODE THAT WILL BE OVERWRITTEN! DO NOT EDIT! */



using System;
using System.Data;
using Microsoft.SqlServer.Dts.Pipeline;
using Microsoft.SqlServer.Dts.Pipeline.Wrapper;

public class Entrada0Buffer: ScriptBuffer

{
    public Entrada0Buffer(PipelineBuffer Buffer, int[] BufferColumnIndexes, OutputNameMap OutputMap)
        : base(Buffer, BufferColumnIndexes, OutputMap)
    {
    }

    public Int32 VentasID
    {
        get
        {
            return Buffer.GetInt32(BufferColumnIndexes[0]);
        }
    }
    public bool VentasID_IsNull
    {
        get
        {
            return IsNull(0);
        }
    }

    public Int32 FechaID
    {
        get
        {
            return Buffer.GetInt32(BufferColumnIndexes[1]);
        }
    }
    public bool FechaID_IsNull
    {
        get
        {
            return IsNull(1);
        }
    }

    public Int32 EmpleadoID
    {
        get
        {
            return Buffer.GetInt32(BufferColumnIndexes[2]);
        }
    }
    public bool EmpleadoID_IsNull
    {
        get
        {
            return IsNull(2);
        }
    }

    public String ClienteID
    {
        get
        {
            return Buffer.GetString(BufferColumnIndexes[3]);
        }
    }
    public bool ClienteID_IsNull
    {
        get
        {
            return IsNull(3);
        }
    }

    public Int32 ProductoID
    {
        get
        {
            return Buffer.GetInt32(BufferColumnIndexes[4]);
        }
    }
    public bool ProductoID_IsNull
    {
        get
        {
            return IsNull(4);
        }
    }

    public Int32 TransportistaID
    {
        get
        {
            return Buffer.GetInt32(BufferColumnIndexes[5]);
        }
    }
    public bool TransportistaID_IsNull
    {
        get
        {
            return IsNull(5);
        }
    }

    public Decimal Precio
    {
        get
        {
            return Buffer.GetDecimal(BufferColumnIndexes[6]);
        }
    }
    public bool Precio_IsNull
    {
        get
        {
            return IsNull(6);
        }
    }

    public Int16 Cantidad
    {
        get
        {
            return Buffer.GetInt16(BufferColumnIndexes[7]);
        }
    }
    public bool Cantidad_IsNull
    {
        get
        {
            return IsNull(7);
        }
    }

    new public bool NextRow()
    {
        return base.NextRow();
    }

    new public bool EndOfRowset()
    {
        return base.EndOfRowset();
    }

}
