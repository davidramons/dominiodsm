
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using DominiolifetagGenNHibernate.Exceptions;
using DominiolifetagGenNHibernate.EN.Dominiolifetag;
using DominiolifetagGenNHibernate.CAD.Dominiolifetag;
using DominiolifetagGenNHibernate.CEN.Dominiolifetag;


namespace DominiolifetagGenNHibernate.CP.Dominiolifetag
{
public partial class EtiquetaCP : BasicCP
{
public EtiquetaCP() : base ()
{
}

public EtiquetaCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
