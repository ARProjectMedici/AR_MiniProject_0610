using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        //Ű�� �浹������
        if (collision.gameObject.CompareTag("Key"))
        {
            Debug.Log("Ű�� �浹");
            ItemManager.instance.isKey = true;
            StartCoroutine("IEOpenDoor");
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("Door"))
        {
            if (ItemManager.instance.isKey == true)
            {
                //Ű�� �ִ� ���¿��� ���̶� �浹���� ��

                Debug.Log("���̶� �浹");
                ItemManager.instance.Door.GetComponent<Animator>().SetTrigger("OpenDoor");
            }

        }
        else if (collision.gameObject.CompareTag("WoodPlank"))
        {
            Debug.Log("���������̶� �浹");
            if (ItemManager.instance.isKey == true && ItemManager.instance.isDoor == true)
            {
                ItemManager.instance.isWoodPlank = true;
                collision.gameObject.SetActive(false);
                ItemManager.instance.WoodPlankArrow.SetActive(true);
            }

        }
        else if (collision.gameObject.CompareTag("WoodPlankArea"))
        {

            if (ItemManager.instance.isWoodPlank == true)
            {
                ItemManager.instance.WoodPlankArrow.SetActive(false);
                ItemManager.instance.WoodPlankPutOff.GetComponentInChildren<ParticleSystem>().Play();
                ItemManager.instance.WoodPlankPutOff.SetActive(true);
            }
        }
        else if (collision.gameObject.CompareTag("Seed"))
        {
            Debug.Log("�����̶� �浹");
            ItemManager.instance.isSeed = true;
            collision.gameObject.SetActive(false);

        }
        else if (collision.gameObject.CompareTag("Beanstalk"))
        {

            if (ItemManager.instance.isSeed == true)
            {
                ItemManager.instance.Beanstalk.GetComponentInChildren<ParticleSystem>().Play();
                ItemManager.instance.Beanstalk.SetActive(true); 
            
            }
        }
    }


}
