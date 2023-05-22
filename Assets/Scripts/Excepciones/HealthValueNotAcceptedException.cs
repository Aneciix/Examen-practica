using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

[Serializable]
public class HealthValueNotAcceptedException : Exception
{
    public HealthValueNotAcceptedException() : base("Health value not accepted")
    {
        
    }

    // SerializableConstructor
    protected HealthValueNotAcceptedException(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
    {

    }
}
