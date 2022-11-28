
    using System;
    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;

    public class TextEnigme : MonoBehaviour
    {
        [SerializeField] 
        private TMP_Text _title;

        private EnigmeHexa enigme;

        private void Start()
        {
            GameObject obj = GameObject.Find("Enigme");
            enigme = obj.GetComponent<EnigmeHexa>();
        }

        public void OnButtonClick()
        {
            if (_title != null)
            {
                if (_title.text.Length <= 9){
                    _title.text += "*";
                }
                else {
                    _title.text = "*";
                    enigme.index = 1;
                }
            }else {
                _title.text = string.Empty;
            }

        }
        public void OnButtonClickValidate() { 
            
            if (enigme.Validate()) {
                _title.text = "SUCCES   ";
            } 
            else {
                _title.text = "ECHEC     ";
            }
        }
    }