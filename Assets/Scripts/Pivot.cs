using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{

    public GameObject myPlayer;
    Transform a;

    // private void Update()
    // {
    //     if (Input.touchCount > 0)
    //     {
    //         Touch touch = Input.GetTouch(0);
    //         a.position = touch.position;
    //         Debug.Log("Touch: " + touch.position.x + "/" + touch.position.y);
    //     }
    // }

    private void FixedUpdate()
    {
        // if (Input.touchCount > 0)
        // {
        //     Touch touch = Input.GetTouch(0);
        // Debug.Log("a: " + a.position.x + "/" + a.position.y);
        // Vector3 diff = Camera.main.ScreenToWorldPoint(touch.position) - transform.position;
        //     if (Input.GetButtonDown("Fire1"))
        // {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        diff.Normalize();

        float rotationZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg + 180;
        float b = rotationZ > 360 ? rotationZ - 360 : rotationZ;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
        Debug.Log(myPlayer.transform.eulerAngles.y);
        // if (rotationZ < -90 || rotationZ > 90)
        // {



        //     if (myPlayer.transform.eulerAngles.y == 0)
        //     {


        //         transform.localRotation = Quaternion.Euler(180, 0, -rotationZ);


        //     }
        //     else if (myPlayer.transform.eulerAngles.y == 180)
        //     {


        //         transform.localRotation = Quaternion.Euler(180, 180, -rotationZ);


        //     }

        // }
        // }

    }

}
