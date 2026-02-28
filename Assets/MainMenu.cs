using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        // Chữ "Battle" phải khớp chính xác với tên Scene chơi game của bạn
        SceneManager.LoadScene("Battle"); 
    }
}