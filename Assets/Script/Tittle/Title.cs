using UnityEngine;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //Debug.Log("Screen Width :" + Screen.width);
        //Debug.Log("Screen height :" + Screen.height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUIStyle labelStyle = new GUIStyle();

        // フォントサイズ
        labelStyle.fontSize = 32;

        //真ん中にテキスト仮置き
        labelStyle.alignment = TextAnchor.MiddleCenter;


        GUIStyleState labelStyleState = new GUIStyleState();

        labelStyleState.textColor = Color.white;

        //.nomalでオブジェクト(コンポーネント？)が正常に呼び出されたら表示
        labelStyle.normal = labelStyleState;



        //タイトル画面のラベル配置
        GUI.Label(new Rect((Screen.width - 400) / 2,
                        (Screen.height - 200) / 2,
                        400,
                        60),
                        "DefanceOrder",
                        labelStyle);

        //ボタンラベルの配置
        //START画面からMainへ移行ボタン
        if (GUI.Button(new Rect((Screen.width - 200) / 2,
                               (Screen.height - 40) / 2, 
                      200,
                      40),
                 "START"))
        {
            Application.LoadLevel("Main");

        }

          else if
                
             (Input.GetKey(KeyCode.Return))
            {
                Application.LoadLevel("Main");
                //Application.LoadScene("Main");
            }
            //Enterキーでのシーン移行未実装
        }

            

        

    }   

