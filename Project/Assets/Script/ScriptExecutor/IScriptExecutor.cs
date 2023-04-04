using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IScriptExecutor 
{
    public abstract bool IsGood { get; }

    public abstract bool Init(params string[] args);

    public abstract bool Run(string scriptfile);

    public abstract void Call(string name);

    public abstract void Update(float delta, float unscaled);

    public abstract void LateUpdate(float delta, float unscaled);

    public abstract void FixedUpdate(float delta, float unscaled);

}
