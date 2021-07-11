using UnityEngine;
using UnityEngine.AI;

public class Attendant : MonoBehaviour
{
    public NavMeshAgent nma = null;
    public Animator anim = null;
    public GameObject WaitSpot = null;
    public GameObject GasCap = null;
    private GameObject currTarget = null;

    private void Start()
    {
        GotoWait();
    }
    public void Update()
    {
        if (currTarget != null)
        {
            nma.SetDestination(currTarget.transform.position);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WaitSpot") == true)
        {
            anim.SetBool("run", false);
        }
        else if (other.CompareTag("GasCap") == true)
        {
            anim.SetBool("run", false);
            anim.SetTrigger("stand");
        }
    }
    public void GotoWait()
    {
        anim.SetBool("run", true);
        currTarget = WaitSpot;
    }
    public void GotoCar()
    {
        anim.SetBool("run", true);
        currTarget = GasCap;
    }
}
