using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVMWpfApplication.Models
{
    internal class InfoModel
    {
        public string ParameterName { get; }

        public string Value { get; }

        public InfoModel(string parameterName, string value)
        {
            this.ParameterName = parameterName;
            this.Value = value;
        }
    }
}
