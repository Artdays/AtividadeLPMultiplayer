using UnityEngine.SceneManagement;
using UnityEngine;

public class todas : MonoBehaviour
{
        public static bool acabou;
    public GameObject tela, player;


    private void Awake()
    {
        acabou = false;

    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (acabou)
        {
            tela.SetActive(true);
            player.SetActive(true);

        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void exit()
    {
        SceneManager.LoadScene("menu");
    }
}
