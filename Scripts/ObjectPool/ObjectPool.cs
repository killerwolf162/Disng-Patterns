using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool <T> where T : IPoolable
{
    private List<T> _activePool = new List<T>();
    private List<T> _inactivePool = new List<T>();

    public T AddNewItemToPool()
    {
        T instance = (T)Activator.CreateInstance(typeof(T));
        _inactivePool.Add(instance);
        Debug.Log("A new item was added to the pool");
        return instance;
    }

    public T RequestObject()
    {
        if(_inactivePool.Count > 0)
        {
            return ActivateItem(_inactivePool[0]);
        }
        return ActivateItem(AddNewItemToPool());
    }

    public T ActivateItem(T item)
    {
        item.OnEnableObject();
        item.active = true;
        if(_inactivePool.Contains(item))
        {
            _inactivePool.Remove(item);
        }
        _inactivePool.Add(item);
        return item;
    }

    public void ReturnObjectToPool(T item)
    {
        if(_activePool.Contains(item))
        {
            _activePool.Remove(item);
        }
        item.OnDisableObject();
        item.active = false;
        _inactivePool.Add(item);
    }
}