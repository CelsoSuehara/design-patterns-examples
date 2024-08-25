﻿namespace Composite.Component;

public abstract class HoraTrabalhada
{
    protected HoraTrabalhada()
    {
    }

    public string Nome { get; set; }
    public abstract int GetHoraTrabalhada();

    public virtual void Add(HoraTrabalhada component) 
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(HoraTrabalhada component)
    {
        throw new NotImplementedException();
    }
}
