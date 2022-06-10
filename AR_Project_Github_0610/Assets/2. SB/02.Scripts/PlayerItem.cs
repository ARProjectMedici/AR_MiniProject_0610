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
            collision.gameObject.SetActive(false);
            ItemManager.instance.OnKey();
        }
        else if (collision.gameObject.CompareTag("Door"))
        {
            if (ItemManager.instance.isKey == true)
            {
                //Ű�� �ִ� ���¿��� ���̶� �浹���� ��

                Debug.Log("���̶� �浹");

            }

        }
        else if (collision.gameObject.CompareTag("Seed"))
        {
            Debug.Log("�����̶� �浹");

            collision.gameObject.SetActive(false);

        }
        else if (collision.gameObject.CompareTag("WoodPlank"))
        {
            Debug.Log("���������̶� �浹");

            collision.gameObject.SetActive(false);

        }
    }


}
