using UnityEngine;

public class TaskListController : MonoBehaviour
{
    [SerializeField]
    private Transform _itemPrefab;

    private int _itemCounter;


    void Start()
    {
        _itemCounter = 0;
    }

    public void AddItem()
    {
        Transform newItem = Instantiate(_itemPrefab, transform);
        newItem.SetParent(transform, false);
        newItem.GetComponent<ItemController>().Initialize(_itemCounter++, null);
    }

    public void ResetItemCounter()
    {
        _itemCounter = 0;
    }
}
