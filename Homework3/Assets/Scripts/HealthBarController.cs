using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour {

    public void ChangeBarWidth(float value)
    {
        var bar = GetComponent<Scrollbar>();
        bar.value = value;
    }
}
