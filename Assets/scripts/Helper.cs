using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Helper : MonoBehaviour
{

    public static void FaceLeft(GameObject user, bool faceleft)
    {
        if(faceleft == true)
        {
            user.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else 
        {
            user.transform.localScale = new Vector3(-1f, 1f, 1f);
        }



    }


    public static class Globals
    {
        public const int left = -1;
        public const int right = 1;
    }

    public static void MakeBullet( GameObject prefab, float xpos, float ypos, float xvel, float yvel)
    {
        GameObject instance = Instantiate(prefab, new Vector3(xpos, ypos, 0), Quaternion.identity);

        Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(xvel, yvel, 0);


    }
}
