using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour {

    [SerializeField]
    private Slider slider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        
	}

    public void ChangeBarWidth(float value)
    {
        Debug.Log(value);
        var bar = GetComponent<Scrollbar>();
        bar.value = value;
    }
}
