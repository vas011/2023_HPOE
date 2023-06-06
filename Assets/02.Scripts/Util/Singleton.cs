using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = (T)FindObjectOfType(typeof(T));

                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    _instance = obj.AddComponent(typeof(T)) as T;
                    obj.name = typeof(T).ToString();
                    DontDestroyOnLoad(obj);
                }
            }
            return _instance;
        }
    }
}
