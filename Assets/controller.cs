using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class controller : MonoBehaviour


{

    public GameObject object2Spawn;

    public TextMeshProUGUI textPlayerName;
    public TextMeshProUGUI textObjectCount;

    public List<GameObject> objects = new List<GameObject>();
   
    void Start()
    {
        UpdatePlayerName();
        UpdateObjectsCount();
    }

  
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPosition.z = 0;
            CreateObject(clickPosition);
        }
    }

    public void CreateObject(Vector3 spawnPosition)
    {
        GameObject obj = Instantiate(object2Spawn, spawnPosition, Quaternion.identity);
        objects.Add(obj);

        UpdateObjectsCount();
    }

    public void UpdatePlayerName()
    {
        textPlayerName.text = Menu.playerName;
    }

    public void UpdateObjectsCount()
    {
        textObjectCount.text = objects.Count.ToString();
    }
}
