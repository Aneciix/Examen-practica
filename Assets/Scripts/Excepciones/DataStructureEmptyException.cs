using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

[Serializable]
public class DataStructureEmptyException : Exception
{
    public DataStructureEmptyException() : base("The data structure is empty -_-")
    {
        
    }

    // SerializableConstructor
    protected DataStructureEmptyException(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
    {

    }
}
