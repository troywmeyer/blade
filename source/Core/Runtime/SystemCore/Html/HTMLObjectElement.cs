//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------
using System.Dom;
using System.Browser;

namespace System.Html
{
    public sealed class HTMLObjectElement : HTMLElement
    {
        internal HTMLObjectElement() { }

        [ScriptField]
        public HTMLFormElement form { get; private set; }

        [ScriptField]
        public string data { get; set; }

        [ScriptField]
        public string height { get; set; }

        [ScriptField]
        public string width { get; set; }

        [ScriptField]
        public string name { get; set; }

        [ScriptField]
        public string type { get; set; }

        [ScriptField]
        public string useMap { get; set; }

        [ScriptField]
        public Document contentDocument { get; private set; }

        [ScriptField]
        public Window contentWindow { get; private set; }
    }
}