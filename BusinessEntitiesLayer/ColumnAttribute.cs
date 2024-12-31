using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitiesLayer
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string DataType { get; }
        public int Length { get; }
        public int Precision { get; }
        public int Scale { get; }

        // برای انواعی مانند NVARCHAR و INT
        public ColumnAttribute(string dataType, int length = 0)
        {
            DataType = dataType;
            Length = length;
        }

        // برای انواعی مانند DECIMAL
        public ColumnAttribute(string dataType, int precision, int scale)
        {
            DataType = dataType;
            Precision = precision;
            Scale = scale;
        }
    }
}
