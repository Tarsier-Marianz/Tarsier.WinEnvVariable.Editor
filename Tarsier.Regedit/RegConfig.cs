namespace Tarsier.Regedit {
    public class RegConfig {
        private static RegistryControl reg = new RegistryControl();
        public static T Get<T>(string key) {
            T _temp = default(T);
            string dbConfig = reg.Read(key);
            if(!string.IsNullOrEmpty(dbConfig)) {
                _temp = dbConfig.DeserializeT<T>();
            }
            return _temp;
        }

        public static bool Set<T>(string key, T value) {
            return Set(key, value.SerializeT<T>());
        }

        public static bool Set(string key, string value) {
            try {
                reg.Write(key, value);
                return true;
            } catch {
                return false;
            }
        }
    }
}