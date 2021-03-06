﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assitant<T>
{
    public T owner;
    public Assitant(T owner)
    {
        this.owner = owner;
    }
}

public class SAssitant<T>
{
    public T owner;
    public SAssitant() { }
    public virtual void SetOwner(T owner)
    {
        this.owner = owner;
    }
}

public class AssitantMonobehaviour<T> : MonoBehaviour
where T : Component
{
    [SerializeField] private T _owner;
    public T owner { get => _owner; }
}
