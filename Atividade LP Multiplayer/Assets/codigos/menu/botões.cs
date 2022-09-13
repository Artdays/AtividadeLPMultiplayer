using UnityEngine.SceneManagement;
using UnityEngine;

public class botões : MonoBehaviour
{
    
    public void labi()
    {
        SceneManager.LoadScene("labirinto");
    }

    public void tirinho()
    {
        SceneManager.LoadScene("tirinho");
    }

    public void credit()
    {
        SceneManager.LoadScene("creditos");
    }
   
}
