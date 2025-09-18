using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(player);
            Debug.Log("Player has lost");
        }
        
        else if (collision.gameObject.CompareTag("Win"))
        {
            Destroy(player);
            Debug.Log("Player has won");
        }
    }
}