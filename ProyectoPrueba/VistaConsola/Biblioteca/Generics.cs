using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class BaseNode { } // Clase NO genérica
    class BaseNodeGeneric<T> { } // Clase genérica

    // concrete type
    class NodeConcrete<T> : BaseNode { }

    //closed constructed type
    class NodeClosed<T> : BaseNodeGeneric<int> { }

    //open constructed type 
    class NodeOpen<T> : BaseNodeGeneric<T> { }

    //No error
    class Node1 : BaseNodeGeneric<int> { }

    //Generates an error
    //class Node2 : BaseNodeGeneric<T> {}

    //Generates an error
    //class Node3 : T {}

    class BaseNodeMultiple<T, U> { }

    //No error
    class Node4<T> : BaseNodeMultiple<T, int> { }

    //No error
    class Node5<T, U> : BaseNodeMultiple<T, U> { }

    //Generates an error
    //class Node6<T> : BaseNodeMultiple<T, U> {}
}
