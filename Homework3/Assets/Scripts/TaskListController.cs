using UnityEngine;

public class TaskListController : MonoBehaviour {
    [SerializeField]
    private Transform _itemPrefab;

    private int _itemCounter;


    // Use this for initialization
    void Start () {
        _itemCounter = 0;
	}

    public void AddItem() {
        //Instantiate new List item prefab with index
        Transform newItem = Instantiate(_itemPrefab);
        newItem.SetParent(transform, false);
        int index = _itemCounter;
        newItem.GetComponent<ItemController>().Initialize(_itemCounter++, null);
        //_itemCounter++;
    }

    public void OnDestroyItem(GameObject item)
    {
        Destroy(item);
    }
}
