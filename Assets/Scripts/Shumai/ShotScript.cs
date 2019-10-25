using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    RaycastHit hit;
    float time;
    bool flag;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        //if()


        //Debug.Log(time);
        Shot();
    }

    void Shot()
    {
        Vector3 center = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Ray ray = Camera.main.ScreenPointToRay(center);
        float distance = 100;
        if (Physics.Raycast(ray, out hit, distance))
        {
            Debug.Log("出発点" + transform.position);
            Debug.Log("目標点" + hit.point);
            //Instantiate(sparks, hit.point, Quaternion.identity);
            //if (hit.collider.tag == "Enemy")
            //{
            //    hit.collider.SendMessage("Damage");
            //}
        }
    }

}