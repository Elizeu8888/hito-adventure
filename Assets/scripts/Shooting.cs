using System.Collections;
using System.Collections.Generic;
using UnityEngine;








public class Shooting : MonoBehaviour
{

    public GameObject bulletprefab;
    public Transform fire;

    public float fireForce = 15f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown("f"))
        {
            DoShoot();
        }

    }


    void DoShoot()
    {



        GameObject bullet = Instantiate(bulletprefab, fire.position, fire.rotation);
        Vector2 gunLook = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(gunLook * fireForce, ForceMode2D.Impulse);






    }





}
