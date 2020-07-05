using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetFriend1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    public Transform OnGetFriend()
    {
        GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombies");
        float distance = 0;
        int id = 0;


        distance = Vector3.Distance(transform.position, zombies[1].transform.position);
        if (distance < 0.5)
        {
            id = 3;
            string num = "zombie" + id.ToString();
            Debug.Log(num);
            (GameObject.Find(num).GetComponent("ZombiesMove") as MonoBehaviour).enabled = true;
            (GetComponent("MeetFriend") as MonoBehaviour).enabled = false;
        }

        return null;
    }
    void FixedUpdate()
    {
        OnGetFriend();
    }
}
