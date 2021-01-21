namespace ArchiLogi.TP.Adapter
{
    public class DotEnvV2Parser : IDotEnvAdapter
    {
        private readonly DotEnvV2 _dotEnvV2;

        public DotEnvV2Parser(DotEnvV2 dotEnvV2)
        {
            _dotEnvV2 = dotEnvV2;
        }

        public string Get(string property)
        {
            return _dotEnvV2.Env[property];
        }
    }
}
