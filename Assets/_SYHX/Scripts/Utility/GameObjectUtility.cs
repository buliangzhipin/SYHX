﻿using UnityEngine;

public static class GameObjectExtension
{
    public static GameObject Create(this GameObject obj, GameObject parent)
    {
        return GameObject.Instantiate(obj, parent.transform.position, obj.transform.rotation, parent.transform);
    }
}
