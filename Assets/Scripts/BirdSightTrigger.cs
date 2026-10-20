using UnityEngine;

public class BirdSightTrigger : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim = GetComponentInParent<Animator>();

    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("NormalPipe") || collision.CompareTag("GoldPipe"))
        {
            //anim.SetFloat("y", );
        }
    }
}
