using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

[Serializable]
public class StaminaValueNotAcceptedException : Exception
{
    public StaminaValueNotAcceptedException() : base("Stamina value not accepted")
    {
        
    }

    // SerializableConstructor
    protected StaminaValueNotAcceptedException(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
    {

    }
}
