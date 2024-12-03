using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Slider _image;
    private bool _loading = false;
    public GameObject _falsePanel;
    public GameObject _truePanel;

    private void OnEnable()
    {
        _loading = true;
    }

    private void Update()
    {
        if (!_loading) return;

        _image.value += 0.1f * Time.deltaTime;

        if (_image.value >= 1)
        {
            _truePanel.SetActive(true);
            _falsePanel.SetActive(false);
        }
    }
}
