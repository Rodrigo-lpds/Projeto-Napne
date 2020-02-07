using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Add
{
    class Voz
    {
        public static SpeechSynthesizer synth = new SpeechSynthesizer();
       
        public static void select(string tr)
        {
            
            //    synth.SpeakAsyncCancelAll();

            //synth.SetOutputToNull();

            tr = tr.Replace("<--", "");
            tr = tr.Replace("-->", "");
            tr = tr.Replace("/", " divido por ");
            tr = tr.Replace("^", " elevado a ");
            tr = tr.Replace(">", " maior que ");
            tr = tr.Replace("<", " menor que ");
            tr = tr.Replace("*", " vezes ");
            tr = tr.Replace(">=", " maior ou igual a ");
            tr = tr.Replace("<=", "menor ou igual a ");
            tr = tr.Replace("sqr", " raíz quadrada de ");
            tr = tr.Replace("log", " log de ");
            tr = tr.Replace("fat", " fatorial de ");
            tr = tr.Replace("(", " abre parênteses ");
            tr = tr.Replace(")", " fecha parênteses ");
            tr = tr.Replace("{", " abre chaves ");
            tr = tr.Replace("}", " fecha chaves ");
            tr = tr.Replace("[", " abre colchetes ");
            tr = tr.Replace("]", " fecha colchetes ");
            tr = tr.Replace("~", " proporcional a ");
            tr = tr.Replace("~=", " aproximademente ");


            synth.SetOutputToDefaultAudioDevice();

            //Voz.synth.Speak(tr);
            Voz.synth.Speak(tr);
           
        }
    }
}
