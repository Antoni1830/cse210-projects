using System;
using System;
using System.Collections.Generic;

class ScriptureWord
    {
        private string _text;
        private bool _isHidden;

        public ScriptureWord(string text)
        {
            this._text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public string GetText()
        {
            return _text;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }
    }
