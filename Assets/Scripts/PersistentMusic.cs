using UnityEngine;

public class PersistentMusic : MonoBehaviour
{
    private static PersistentMusic instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Giữ GameObject khi chuyển Scene
        }
        else
        {
            Destroy(gameObject); // Ngăn tạo nhạc trùng lặp khi load lại Scene
        }
    }
}
