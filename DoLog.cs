using System.Diagnostics;

namespace AutofacDemoWCF
{
    public class DoLog
    {
        public void Write(string s) => Debug.Write(s);
    }
}