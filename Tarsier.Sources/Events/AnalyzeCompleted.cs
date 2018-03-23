using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Tarsier.Sources.Enumeration;

namespace Tarsier.Sources.Events {
    public class AnalyzeCompleted:EventArgs {
        private AnalyzeResult result;
        private Exception error;
        public AnalyzeCompleted(AnalyzeResult result,Exception error) {
            this.result = result;
            this.error = error;
        }

        public AnalyzeResult Result {
            get {
                //base.RaiseExceptionIfNecessary();
                return result;
            }
        }
        public Exception Error {
            get {
                return error;
            }
        }
    }
}
