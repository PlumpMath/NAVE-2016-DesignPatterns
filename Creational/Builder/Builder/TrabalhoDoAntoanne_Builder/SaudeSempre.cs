using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDoAntoanne_Builder
{

    internal class SaudeSempre4 : IConstrutorAbstrato4
    {
        Produto4 _produto;

        public SaudeSempre4()
        {
            _produto = new Produto4("SaudeSempre");
        }

        public void SetItemPrincipal()
        {
            _produto.Itemprincipal = ItemPrincipal.Salada;
        }

        public void SetAcompanhamento()
        {
            _produto.Acompanhamento = Acompanhamento.Maca;
        }

        public void SetBebida()
        {
            _produto.Bebida = Bebida.SucoDeLaranja;
        }

        public void SetBrinde()
        {
            _produto.Brinde = Brinde.JogoDaMemoria;
        }

        public Produto4 Produto
        {
            get { return _produto; }
        }

    }
}
