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





}
