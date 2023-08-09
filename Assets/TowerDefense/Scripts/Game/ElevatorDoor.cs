using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoor : MonoBehaviour
{
    public int allowPlayerId;
    public bool isOpen = false;
    public void OpenDoor(int idPlayer)
    {
        if (idPlayer == allowPlayerId)
        {
            if (isOpen) return;
            isOpen = true;
            StartCoroutine(OpenDoorIE());
        }
    }

    private IEnumerator OpenDoorIE()
    {
        while (transform.position.y < 5)
        {
            transform.position += Vector3.up * Time.deltaTime * 5;
            yield return null;
        }
        yield return new WaitForSeconds(2f);
        while (transform.position.y > 0)
        {
            transform.position += Vector3.down * Time.deltaTime * 5;
            yield return null;
        }
        isOpen = false;
    }
}
