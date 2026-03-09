using UnityEngine;

public class ControlePlayer : MonoBehaviour
{
    Animator anim;
    Rigidbody rb;

    public static GameObject player;
    public static GameObject plataformaAtual;

    public static bool isDead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = this.GetComponent<Animator>();
        player = this.gameObject;
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isJumping", true);
            rb.AddForce(Vector3.up * 200);
        }
        else if(Input.GetKeyDown(KeyCode.M))
        {
            anim.SetBool("isMagic", true);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up * 90);
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up * -90);
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Translate(-0.1f, 0, 0);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Translate(0.1f, 0, 0);
        }
    }

    void StopJumping()
    {
        anim.SetBool("isJumping", false);
    }
    void StopMagic()
    {
        anim.SetBool("isMagic", false);
    }

    void OnCollisionEnter(Collision outro)
    {
        // Debug.Log(outro.gameObject.tag);

        if(outro.gameObject.tag == "Fogo")
        {
            anim.SetTrigger("isDead");
            isDead = true;
        }
        else
        {
            plataformaAtual = outro.gameObject;
        }
    }
}
