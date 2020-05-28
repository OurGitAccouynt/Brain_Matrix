using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DueTime : MonoBehaviour
{

   public float nextUpdate=1;
   public int timemaze;
    public Text time;
    public Text time2;
    int newtime;
    public GameObject lose;

    private void Awake()
    {
        newtime = 1000;
    }
    void Update()
    {
        if (Time.time >= nextUpdate)
        {
            Debug.Log(Time.time + ">=" + nextUpdate);
          
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
           
            UpdateEverySecond();
        }
        time.text = timemaze.ToString();
        
        time2.text = newtime.ToString();
        if (newtime <= 0) 
        {
            lose.SetActive(true);


        }

    }

   
    void UpdateEverySecond()
    {
        timemaze++;
        newtime-=8;



    }

}