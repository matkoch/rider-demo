using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Assistance
{
    public class Annotations
    {
        public void Entry ()
        {
            OperateOnNonNull(key: "test");
        }

        private void OperateOnNonNull ([NotNull] string key)
        {
        }

//        [NotNull]
        [CanBeNull]
        private object GetOrCreate ()
        {
            return null;
        }

        [ItemCanBeNull]
        private Task<object> GetOrCreateAsync ()
        {
            return Task.Run(() => new object());
        }

        [ItemCanBeNull]
        private IEnumerable<string> GetStrings ()
        {
            yield break;
        }

        [ContractAnnotation(contract: "null => null; notnull => notnull")]
        private string Transform (string a)
        {
            return a;
        }
    }
}