using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class script_executor 
{
    public abstract bool is_good { get; }

    public abstract bool init(params string[] args);

    public abstract bool run(string scriptfile);

    public abstract void call(string name);

    public abstract void update(float delta, float unscaled);

    public abstract void late_update(float delta, float unscaled);

    public abstract void fixed_update(float delta, float unscaled);

    public abstract mwt.scriptobject get(string name);

}
