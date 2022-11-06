using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVNRoute
{
    public string GetID();
    public void Go(VNFlowManager flowManager);
}
