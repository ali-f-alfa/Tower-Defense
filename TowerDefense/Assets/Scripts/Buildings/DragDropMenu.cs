using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DragDropMenu : MonoBehaviour
{
    public GameObject towers;

    float zPosition;
    Vector3 offset;
    bool dragging;
    Vector3 startPosition;
    bool turnBack = false;

    public Camera mainCamera;
    [Space]
    [SerializeField]
    public UnityEvent OnBeginDrag;
    [SerializeField]
    public UnityEvent OnEndDrag;

    void Start()
    {
        zPosition = mainCamera.WorldToScreenPoint(transform.position).z;
        startPosition = transform.position;
    }

    void Update()
    {
        if (dragging)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zPosition);
            transform.position = mainCamera.ScreenToWorldPoint(position + new Vector3(offset.x, offset.y));
        }
    }

    void OnMouseDown()
    {
        if (!dragging)
        {
            BeginDragging();
        }
    }

    void OnMouseUp()
    {
        EndDragging();
    }

    public void BeginDragging()
    {
        if (this.gameObject.CompareTag("TowerMap"))
        {
            OnBeginDrag.Invoke();
            dragging = true;
            offset = mainCamera.WorldToScreenPoint(transform.position) - Input.mousePosition;
        }
    }

    public void EndDragging()
    {
        // If turn back
        if (turnBack)
        {

        }
        else
        {
            // Instantiate
            InstantiateTower();
        }
        transform.position = startPosition;
        OnEndDrag.Invoke();
        dragging = false;
    }

    public void InstantiateTower()
    {
        GameObject tower;
        tower = Instantiate(towers);
        tower.transform.position = new Vector3(transform.position.x, transform.position.y,  transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ItemSlot"))
        {
            turnBack = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("ItemSlot"))
        {
            turnBack = false;
        }
    }
}
