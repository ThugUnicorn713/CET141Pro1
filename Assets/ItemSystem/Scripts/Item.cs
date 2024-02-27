using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Item : MonoBehaviour
{
    [SerializeField]
    public GameObject itemPrefab;
    [SerializeField]
    public Sprite icon;

    [SerializeField]
    public string itemName;
    [SerializeField]
    [TextArea(4, 16)]
    public string description;

    [SerializeField]
    public float weight = 0;
    [SerializeField]
    public int quantity = 1;
    [SerializeField]
    public int maxStackableQuantity = 1;   //for bundles of items, such as arrows or coins

    [SerializeField]
    public bool isStorable = false; //if false, item will be used when picked up
    [SerializeField]
    public bool isConsumable = true; // if ture, item will be destroyed (or quantity reduced) when used

    [SerializeField]
    bool isPickupOnCollision = false;
    private void Start()
    {
        if (isPickupOnCollision)
        {
            gameObject.GetComponent<Collider>().isTrigger = true;
        }

    }
    private void OnTriggerEnter(Collider collider)
    {
        if (isPickupOnCollision)
        {
                if (collider.tag == "Player")
                {
                    Interact();
                }
        }

    }

    public void Interact()
    {
        Debug.Log("Picked up " + transform.name);
        if (isStorable)
        {
            Store();
        }
        else
        {
            Use();
        }
    }

    void Store()
    {
        Debug.Log("Storing " + transform.name);
        //to do 
        Destroy(gameObject);

    }

    void Use()
    {
        if (isConsumable)
        {
            quantity--;
            if (quantity <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}