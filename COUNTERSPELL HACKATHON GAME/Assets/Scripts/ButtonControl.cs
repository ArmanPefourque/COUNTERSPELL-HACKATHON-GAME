using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonControl : MonoBehaviour
{
    public void NextScene(int sceneID) {
        SceneManager.LoadScene(sceneID);
    }
}
