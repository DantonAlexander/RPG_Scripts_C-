public class ChangeScene : MonoBehavour {

      public void loadNextScene(string sceneName){
          SceneManager.LoadScene (sceneName);
      }
}
