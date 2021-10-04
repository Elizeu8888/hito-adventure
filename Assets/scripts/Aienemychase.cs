using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aienemychase : MonoBehaviour
{
    public float speed;
    public float stoppingdistance;
    public float chaserange;
    private Transform target;
    private Animator anim;

    //public float distance;
    // Start is called before the first frame update
    void Start()
    {

        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        anim = target.GetComponent<Animator>();
        //distance = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(target.transform.position, transform.position) < chaserange )
        {

            

            if (Vector2.Distance(transform.position, target.position) > stoppingdistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            }
        }



    }




}
