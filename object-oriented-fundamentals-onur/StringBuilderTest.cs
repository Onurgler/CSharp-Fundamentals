using System.Text;

namespace object_oriented_fundamentals_onur
{
    public class StringBuilderTest
    {
        public StringBuilder Validate(Employ employ)
        {
            StringBuilder sb = new StringBuilder();
            bool flag = true;
            if (employ.empno <= 0)
            {
                sb.AppendLine("Employ No Invalid Enter > 0 value/n/r");
                flag = false;
            }
            if (employ.name.Length <= 4)
            {
                sb.AppendLine("Name must be min 5 chars/r/n");
                flag = false;
            }

            if (!employ.dept.Equals("Dotnet") || !employ.dept.Equals("Anguler"))
            {
                sb.AppendLine("Either Dotnet or Angular only allowed...");
                flag = false;
            }

            if (flag == true)
            {
                sb.AppendLine("All validations are Passed...");
            }

            return sb;
        }
    }
}