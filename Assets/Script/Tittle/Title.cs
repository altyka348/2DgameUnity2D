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

        // �t�H���g�T�C�Y
        labelStyle.fontSize = 32;

        //�^�񒆂Ƀe�L�X�g���u��
        labelStyle.alignment = TextAnchor.MiddleCenter;


        GUIStyleState labelStyleState = new GUIStyleState();

        labelStyleState.textColor = Color.white;

        //.nomal�ŃI�u�W�F�N�g(�R���|�[�l���g�H)������ɌĂяo���ꂽ��\��
        labelStyle.normal = labelStyleState;



        //�^�C�g����ʂ̃��x���z�u
        GUI.Label(new Rect((Screen.width - 400) / 2,
                        (Screen.height - 200) / 2,
                        400,
                        60),
                        "DefanceOrder",
                        labelStyle);

        //�{�^�����x���̔z�u
        //START��ʂ���Main�ֈڍs�{�^��
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
            //Enter�L�[�ł̃V�[���ڍs������
        }

            

        

    }   

