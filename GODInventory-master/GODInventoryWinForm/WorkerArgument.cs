using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GODInventoryWinForm
{
    class WorkerArgument
    {
        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }
        public int OrderCount { get; set; }
        public int CurrentIndex { get; set; }

        public WorkerArgument() {
            HasError = false;
        }
    }
}
