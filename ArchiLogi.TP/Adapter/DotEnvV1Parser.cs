using System;

namespace ArchiLogi.TP.Adapter
{
    public class DotEnvV1Parser : IDotEnvAdapter
    {
        private readonly DotEnvV1 _dotEnvV1;

        public DotEnvV1Parser(DotEnvV1 dotEnvV1)
        {
            _dotEnvV1 = dotEnvV1;
        }

        public string Get(string property)
        {
            return _dotEnvV1.GetType().GetProperty(property)?.GetValue(_dotEnvV1, null).ToString();
        }
    }
}
