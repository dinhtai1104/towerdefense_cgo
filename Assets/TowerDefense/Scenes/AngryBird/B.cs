using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class B : MonoBehaviour
{
    public UnityEvent<int> eventAction;
    /*
        Remove các event không cần thiết
        Kiểm tra xem các event có đủ điều kiện để gọi hay không

        Chia các event nhỏ hơn để gọi các sự kiện cần thiết
    */
    public void CallActionA(int idPlayer)
    {
        eventAction.Invoke(idPlayer);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        int id = player.ID;
        CallActionA(id);
    }
}