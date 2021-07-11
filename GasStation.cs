using UnityEngine;

public class GasStation : MonoBehaviour
{
    public Attendant attendant = null;

    private void OnTriggerEnter(Collider other)
    {
        //gas station trigger area - is hit
        attendant.GotoCar();
    }
}
