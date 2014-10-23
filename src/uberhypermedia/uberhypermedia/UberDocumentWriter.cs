using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UberHypermedia
{
    public abstract class UberDocumentWriter<TModel>
    {
        public abstract UberDocument Write(TModel model, Uri rootUri = null);
    }
}
