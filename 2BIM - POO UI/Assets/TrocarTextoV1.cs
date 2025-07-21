using UnityEngine;

public class TrocarTextoV1 : MonoBehaviour
{
    public string texto;
    public TextMeshProUGUI textoUI;
    
    public void TrocarTextoUI()
    {
        textoUI().text = texto;
        
    }
}
