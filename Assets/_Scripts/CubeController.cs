using UnityEngine;
using UnityEngine.EventSystems;

public class CubeController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    Material material;
    Color initialColor;

    void Awake()
    {
        material = gameObject.GetComponent<MeshRenderer>().material;
        initialColor = material.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        material.color = Color.green;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        material.color = initialColor;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        material.color = new Color(1f - material.color.r, 1f - material.color.g, 1f - material.color.b);
    }
}
