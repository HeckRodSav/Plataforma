using UnityEngine;

public class ControleDoozy : MonoBehaviour
{
    public static Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }
}
