using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDoAntoanne_Builder
{

    public enum ItemPrincipal
    {
        Hamburguer,
        CachorroQuente,
        Salada
    };

    public enum Acompanhamento
    {
        Nuggets,
        BatataFrita,
        Maca
    };

    public enum Bebida
    {
        CocaCola,
        Guarana,
        SucoDeLaranja
        
    };

    public enum Brinde
    {
        Bonecx,
        BichoDePelucia,
        JogoDaMemoria
    };


    internal class Produto4
    {
        string Lanche;
        ItemPrincipal itemPrincipal;
        Acompanhamento acompanhamento;
        Bebida bebida;
        Brinde brinde;

        public Produto4(string name)
        {
            Lanche = name;
        }
        public string lanche
        {
            get { return Lanche; }
        }
        public ItemPrincipal Itemprincipal
        {
            get { return itemPrincipal; }
            set { itemPrincipal = value; }
        }
        public Acompanhamento Acompanhamento
        {
            get { return acompanhamento; }
            set { acompanhamento = value; }
        }
        public Bebida Bebida
        {
            get { return bebida; }
            set { bebida = value; }
        }
        public Brinde Brinde
        {
            get { return brinde; }
            set { brinde = value; }
        }
        public override string ToString()
        {
            return string.Format("lanche: {0}\nItemprincipal: {1}\nAcompanhamento: {2}\nBebida: {3}\nBrinde: {4}",
                lanche, Itemprincipal, Acompanhamento, Bebida, Brinde);
        }
    }
}
