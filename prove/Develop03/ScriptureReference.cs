using System;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

public class ScriptureR
{
    class Reference
    {
        private string _BOOK;
        private int _chapter;
        private int _sVerse;
        private int _eVerse;

        public Reference(string book, int chapter, int verse)
        {
            this._BOOK = book;
            this._chapter = chapter;
            this._sVerse = verse;
            this._eVerse = verse;
        }

        public Reference(string book, int chapter, int sVerse, int eVerse)
        {
            this._BOOK = book;
            this._chapter = chapter;
            this._sVerse = sVerse;
            this._eVerse = eVerse;
        }

        public override string ToString()
        {
            if (_sVerse == _eVerse)
                return $"{_BOOK} {_chapter}:{_sVerse}";
            else
                return $"{_BOOK} {_chapter}:{_sVerse}-{_eVerse}";
        }
    }
}