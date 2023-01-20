using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static bool ExtraLife()
    {
        if(ObjectPool.score ==1)
        {
            return true; 
        }
        else 
        { 
            return false;
        }
    }
    
}
