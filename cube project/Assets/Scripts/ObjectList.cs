using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectList : MonoBehaviour
{
    public List<GameObject> objList;

    private void Start()
    {
        foreach (GameObject obj in objList)
        {
            print(obj);
        }
        for (int i = 0; i < objList.Count;i++)
        {
            print(objList[i]);
        }
    }
   
}
