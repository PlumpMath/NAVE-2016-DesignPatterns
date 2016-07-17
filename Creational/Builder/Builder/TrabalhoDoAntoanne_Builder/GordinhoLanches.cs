using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDoAntoanne_Builder
{

    internal class GordinhoLanches4 : IConstrutorAbstrato4
    {
        Produto4 _produto;

        public GordinhoLanches4()
        {
            _produto = new Produto4("GordinhoLanches");
        }

        public void SetItemPrincipal()
        {
            _produto.Itemprincipal = ItemPrincipal.Hamburguer;
        }

        public void SetAcompanhamento()
        {
            _produto.Acompanhamento = Acompanhamento.Nuggets;
        }

        public void SetBebida()
        {
            _produto.Bebida = Bebida.CocaCola;
        }

        public void SetBrinde()
        {
            _produto.Brinde = Brinde.Bonecx;
        }

        public Produto4 Produto
        {
            get { return _produto; }
        }
    }
}
