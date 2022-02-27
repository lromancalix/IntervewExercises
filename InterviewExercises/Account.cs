using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 URL: https://www.testdome.com/questions/c-sharp/account/32673?visibility=3&skillId=18&a=true
 Instructions:

    Each account on a website has a set of access flags that represent a users access.

    Update and extend the enum so that it contains three new access flags:

    A Writer access flag that is made up of the Submit and Modify flags.
    An Editor access flag that is made up of the Delete, Publish and Comment flags.
    An Owner access that is made up of the Writer and Editor flags.
    For example, the code below should print "False" as the Writer flag does not contain the Delete flag.

    Console.WriteLine(Access.Writer.HasFlag(Access.Delete))

 */

namespace InterviewExercises
{
   
    public class Account
    {

        [Flags]
        public enum Access
        {
            Delete = 1,
            Publish = 2,
            Submit = 4,
            Comment = 8,
            Modify = 16,
            //Addinig new roles
            Writer = Submit | Modify,
            Editor = Delete | Publish | Comment,
            Owner = Writer | Editor
        }

        public Account()
        {
            Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
        }

    }
}
