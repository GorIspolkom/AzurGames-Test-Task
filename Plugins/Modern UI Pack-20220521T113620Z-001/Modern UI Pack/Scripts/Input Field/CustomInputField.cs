//using UnityEngine;
//using TMPro;
//using System.Collections;
//using Assets.Scripts.UI;
//using UnityEngine.EventSystems;

//namespace Michsky.UI.ModernUIPack
//{
//    [RequireComponent(typeof(TMP_InputField))]
//    [RequireComponent(typeof(Animator))]
//    public class CustomInputField : MonoBehaviour
//    {
//        [Header("Resources")]
//        public TMP_InputField inputText;
//        public StartButton startButton;
//        public Animator inputFieldAnimator;
        

//        // Hidden variables
//        private string inAnim = "In";
//        private string outAnim = "Out";

//        void Start()
//        {
//            if (inputText == null)
//                inputText = gameObject.GetComponent<TMP_InputField>();

//            if (inputFieldAnimator == null)
//                inputFieldAnimator = gameObject.GetComponent<Animator>();

//            inputText.onSelect.AddListener(delegate { if(!OnScreenKeyboard.Instance.isClicked) AnimateIn(); });
//            inputText.onEndEdit.AddListener(delegate { StartCoroutine(WaitForKeyboard()); });
//            UpdateState();
//        }

//        void OnEnable()
//        {
//            if (inputText == null)
//                return;

//            inputText.ForceLabelUpdate();
//            UpdateState();
//        }

//        public void AnimateIn() 
//        {
//            inputFieldAnimator.Play(inAnim);
//        }

//        public void AnimateOut()
//        {
//            if (inputText.text.Length == 0)
//                inputFieldAnimator.Play(outAnim);
//        }

//        public void UpdateState()
//        {
//            if (inputText.text.Length == 0)
//                AnimateOut();
//            else
//                AnimateIn();
//        }

//        private IEnumerator WaitForKeyboard()
//        {
//            yield return new WaitForSecondsRealtime(0.1f);
//            if (!OnScreenKeyboard.Instance.isClicked)
//            {
//                Debug.Log("AAAA");
//                UpdateState();
//                startButton.CheckInput(this);
//                if(OnScreenKeyboard.Instance.focus == inputText)
//                    OnScreenKeyboard.Instance.focus = null;
//            }
//            //else
//                //inputText.Select();
//        }
//    }
//}