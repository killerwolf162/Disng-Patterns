using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool <T> where T : IPoolable
{
    private List<T> activePool = new List<T>();
    private List<T> inactivePool = new List<T>();

    public T AddNewItemToPool()
    {
        T instance = (T)Activator.CreateInstance(typeof(T));
        inactivePool.Add(instance);
        Debug.Log("A new item was added to the pool");
        return instance;
    }

    public T RequestObject()
    {
        if(inactivePool.Count > 0)
        {
            return ActivateItem(inactivePool[0]);
        }
        return ActivateItem(AddNewItemToPool());
    }

    public T ActivateItem(T item)
    {
        item.OnEnableObject();
        item.Active = true;
        if(inactivePool.Contains(item))
        {
            inactivePool.Remove(item);
        }
        inactivePool.Add(item);
        return item;
    }

    public void ReturnObjectToPool(T item)
    {
        if(activePool.Contains(item))
        {
            activePool.Remove(item);
        }
        item.OnDisableObject();
        item.Active = false;
        inactivePool.Add(item);
    }
}