using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ObjectPool : MonoBehaviour
{
   [SerializeField] private GameObject _container;
   
    private List<GameObject> _pool = new List<GameObject>();

    public static float score = 0;

    protected void Initialize(GameObject[] prefabs) //свич кейс? так же по названию сцены(стены текста получатся)
    {
        GameObject spawned0 = Instantiate(prefabs[0], _container.transform); // краб
        spawned0.SetActive(false);
        _pool.Add(spawned0); 

        GameObject spawned1 = Instantiate(prefabs[0], _container.transform);
        spawned1.SetActive(false);
        _pool.Add(spawned1);

        GameObject spawned2 = Instantiate(prefabs[0], _container.transform);
        spawned2.SetActive(false);
        _pool.Add(spawned2);

        GameObject spawned3 = Instantiate(prefabs[1], _container.transform); //зеленый с клешнями
        spawned3.SetActive(false);
        _pool.Add(spawned3);

        GameObject spawned4 = Instantiate(prefabs[1], _container.transform);
        spawned4.SetActive(false);
        _pool.Add(spawned4);

        GameObject spawned5 = Instantiate(prefabs[1], _container.transform);
        spawned5.SetActive(false);
        _pool.Add(spawned5);

        GameObject spawned6 = Instantiate(prefabs[2], _container.transform); //хилка
        spawned6.SetActive(false);
        _pool.Add(spawned6);

        GameObject spawned7 = Instantiate(prefabs[3], _container.transform); // осминог
        spawned7.SetActive(false);
        _pool.Add(spawned7);

        //GameObject spawned8 = Instantiate(prefabs[4], _container.transform); // кама пуля
        //spawned8.SetActive(false);
        //_pool.Add(spawned8);
    }
    
    protected bool TryGetObject(out GameObject result)
    {
        //score++;

        if (score % Score.hardMobs < 1)
        {
            //result = _pool.FirstOrDefault(p => p.name.ToString() == "Enemy3(Clone)"); //поменяй местами, хард не спавнится
            //return result != null;
            result = _pool.FirstOrDefault(p => p.name.ToString() == "HardEnemy(Clone)");
            return result != null;
        } 
        else if (score % Score.extraLives < 1)
        {
            //result = _pool.FirstOrDefault(p => p.name.ToString() == "HardEnemy(Clone)");
            //return result != null;
            result = _pool.FirstOrDefault(p => p.name.ToString() == "Enemy3(Clone)"); //поменяй местами, хард не спавнится
            return result != null;
        } 
        else
        {
            result = _pool.FirstOrDefault(p => p.activeSelf == false);
            return result != null;
        }
    }
}
