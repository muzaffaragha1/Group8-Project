using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class CreateTape : MonoBehaviour
    {

        public AudioSource myFx;
        public AudioClip spaceFx;
        public Button btn;
        public Text count;
        public int counter = 0;
        public Text states;
        public Text msg;
        public string theString;
        public InputField inputField;
        public GameObject cube;
        int charpos;
        int myPos;
        public RunTM turing;
        public char changeChar;
        public float pos = 0f;
        //public Animator anim;
        TuringMachine state = new TuringMachine();
        RegValidate re = new RegValidate();
        btnFx myAudio = new btnFx();
        //MeshRenderer meshRenderer;
        public Texture albedoTexture;
        public GameObject arrow;
        public Texture arrowTexture;
        public List<GameObject> boxes;
        public Text writeAlphabet;
        public Text readAlphabet;
        public Renderer cubeRenderer;
        public GameObject go;
        //public Animation cubeAnimation;

        public void spaceSound()
        {
            myFx.PlayOneShot(spaceFx);
        }

        //public GameObject newObject;
        //public Transform newPosition;
        //public TextMesh mytext;



        //RaycastHit hit;

        //public Transform target;

        //void CameraFocus()
        //{

        //    Vector3 pointOnside = target.position + new Vector3(2.0f, 0, 0);
        //    float aspect = (float)Screen.width / (float)Screen.height;
        //    float maxDistance = (target.localScale.y * 0.5f) / Mathf.Tan(Mathf.Deg2Rad * (Camera.main.fieldOfView / aspect));
        //    Camera.main.transform.position = Vector3.MoveTowards(pointOnside, target.position, -maxDistance);
        //    Camera.main.transform.LookAt(target.position);
        //}

        public void getString()
        {



            states.color = Color.green;

            string myString = inputField.text;
            theString = "Δ" + inputField.text + "Δ" + "Δ" + "Δ";
            bool validate = re.validatInput(myString);


            if (validate == false)
            {

                states.color = Color.red;
                states.text = "INVALID STRING ";

            }

            else
            {
                this.transform.position = new Vector3(2.5f, 0, -4.0f);
                myArrow();
                inputField.gameObject.SetActive(false);
                btn.gameObject.SetActive(false);
                char[] language = theString.ToCharArray();
                turing = new RunTM(state.add(), language, state.currentstate);

                if (theString.Length != 0)
                {
                    for (int i = 0; i < theString.Length; i++)
                    {
                        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        cube.name = "host" + i.ToString();
                        boxes.Add(cube);
                        cube.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
                        // cube.tag = "Cube";
                        //cube.AddComponent<Animator>().Play("ObjectAnimation");
                        cubeRenderer = cube.GetComponent<Renderer>();
                        //meshRenderer.material.SetTexture("_MainTex", albedoTexture);
                        //cubeRenderer.material.SetColor("_Color", Color.black);
                        cubeRenderer.material.SetTexture("_MainTex", albedoTexture);

                        go = new GameObject();
                        go.AddComponent<TextMesh>();

                        go.GetComponent<TextMesh>().text = language[i].ToString();
                        go.transform.position = new Vector3(-0.33f, 0.52f, -0.5f);
                        go.transform.parent = cube.transform;
                        go.GetComponent<TextMesh>().characterSize = 0.1f;
                        go.GetComponent<TextMesh>().fontSize = 100;
                        go.GetComponent<TextMesh>().color = Color.green;
                        cube.transform.position = new Vector3(pos, 0, 0);
                        pos = pos + 2.5f;
                    }
                }



                states.text = "CURRENT STATE : q0";
            }

        }

        public void Update()
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {

                spaceSound();
                //myAudio.ClickSound();
                executeTM();
                //  GameObject[] find = GameObject.FindGameObjectsWithTag("Cube");

            }
            //  myArrow();
        }

        public void executeTM()
        {
            if (turing.current_st() != null)
            {
                charpos = turing.currentPosition();
                changeChar = turing.nextState();
                GameObject changetxt = GameObject.Find("host" + charpos.ToString());

                GameObject rotate = GameObject.Find("host" + charpos.ToString());


                //rotate.transform.Rotate(-3.41f, -334.20f, -1.520f);

                //cube1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
                changetxt.GetComponentInChildren<TextMesh>().text = changeChar.ToString();
                readAlphabet.text = "Read Alphabet: " + turing._readChar().ToString();
                writeAlphabet.text = "Write Alphabet: " + changeChar.ToString();
                this.transform.position = new Vector3((charpos * 2.5f) + 2.5f, 0, -4f);

                //cubeRenderer.transform.position = new Vector3((charpos * 2.5f) + 2.5f, 0, -1);

                arrow.transform.position = new Vector3((charpos * 2.5f) + 2.5f, -1.214f, 0f);
                print(this.transform.position = new Vector3((charpos * 2.5f) + 2.5f, 0, -4f));
                counter = counter + 1;

                states.text = "CURRENT STATE : " + turing.current_st();
                print("current state: " + turing.current_st());
                print(counter.ToString());
                // count.text = "Count: " + counter.ToString();
            }
            if (turing.current_st() == "q17" && turing.last_Move() == Move.H)
            {
                Destroy(arrow);
                states.text = "CURRENT STATE : Accept";
                msg.text = "String accepted successfully";
                //resetCanvas();
            }
            else if (turing.current_st() != "q17" && turing.last_Move() == Move.H)
            {
                Destroy(arrow);
                states.text = "CURRENT STATE : Reject";
                msg.text = "String is rejected";

                //resetCanvas();

            }


        }

        public void myArrow()
        {
            arrow = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var cubeRenderer = arrow.GetComponent<Renderer>();
            cubeRenderer.material.SetTexture("_MainTex", arrowTexture);
            cubeRenderer.transform.position = new Vector3(2.5f, -1.214f, 0.015f);
            //cubeRenderer.transform.rotation = new Vector3(14.641f, -11.522f, 0.193f);
            //cubeRenderer.transform.Translate(14.641f, -11.522f, 0.193f);
            cubeRenderer.transform.localScale = new Vector3(0.8f, 0.8f, 0.5f);
        }

        public void resetCanvas()
        {
            foreach (var v in boxes)
            {
                Destroy(v);
            }
            Destroy(arrow);
            //count.text = "";

            inputField.gameObject.SetActive(true);
            btn.gameObject.SetActive(true);
            msg.text = "";
            states.text = "";
            inputField.text = "";
        }

    }
}
