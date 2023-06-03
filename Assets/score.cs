using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public int number = 1;
    private Text textComponent;
    private void Start()
    {
        textComponent = GetComponent<Text>(); // Lấy thành phần Text từ GameObject
        UpdateText(); // Cập nhật văn bản ban đầu
    }
    public void IncreaseNumber()
    {
        number++; // Tăng số lượng
        UpdateText(); // Cập nhật văn bản
    }
    private void UpdateText()
    {
        textComponent.text = number.ToString(); // Chuyển đổi số thành văn bản và hiển thị nó
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("rabbit")) // Kiểm tra va chạm với đối tượng B
        {
            IncreaseNumber(); // Hủy bỏ đối tượng A
        }
    }
     

    
}
