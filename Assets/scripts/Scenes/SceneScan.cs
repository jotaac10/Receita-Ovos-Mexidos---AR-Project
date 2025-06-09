using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneScan : MonoBehaviour
{
// Start is called before the first frame update
void Start()
{
}
// Update is called once per frame
void Update()
{
}
public void ChamaCenaScan()
{
UnityEngine.SceneManagement.SceneManager.LoadScene("Scan");
}
}