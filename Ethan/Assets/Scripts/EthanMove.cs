using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EthanMove : MonoBehaviour
{
    [SerializeField] Animator animator;
    bool agachar;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        agachar = false;
    }

    // Update is called once per frame
    void Update()
    {
        float despl = Input.GetAxis("Vertical");
        float giro = Input.GetAxis("Horizontal");


        animator.SetFloat("GiroCorrer", giro);
        animator.SetFloat("InicioCorrer", despl);

        if (Input.GetKey("Jump"))
            agachar = true;
        else agachar = false;

        if (agachar == false)
            animator.SetBool("Jump", false);

        if (agachar == true)
            animator.SetBool("Jump", true);
    }
}
