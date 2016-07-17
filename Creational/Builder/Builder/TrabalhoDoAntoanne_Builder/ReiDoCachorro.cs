using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDoAntoanne_Builder
{

    internal class ReiDoCachorro4 : IConstrutorAbstrato4
    {
        Produto4 _produto;

        public ReiDoCachorro4()
        {
            _produto = new Produto4("ReiDoCachorro");
        }

        public void SetItemPrincipal()
        {
            _produto.Itemprincipal = ItemPrincipal.CachorroQuente;
        }

        public void SetAcompanhamento()
        {
            _produto.Acompanhamento = Acompanhamento.BatataFrita;
        }

        public void SetBebida()
        {
            _produto.Bebida = Bebida.Guarana;
        }

        public void SetBrinde()
        {
            _produto.Brinde = Brinde.BichoDePelucia;
        }

        public Produto4 Produto
        {
            get { return _produto; }
        }

    }
}
