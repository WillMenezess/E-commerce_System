using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP2
{
    class Pedidos
    {
        private int _PedidoId { get; set; }
        private float _ValorDoProduto { get; set; }
        private int _Quantidade { get; set; }
        private DateTime _DataEmissao;
        private string _DescricaoDoProduto { get; set; }

        public int PedidoId
        {
            get
            {
                return _PedidoId;
            }
            set
            {
                _PedidoId = value;
            }
        }
        public float ValorDoProduto
        {
            get
            {
                return _ValorDoProduto;
            }
            set
            {
                _ValorDoProduto = value;
            }
        }
        public int Quantidade
        {
            get
            {
                return _Quantidade;
            }
            set
            {
                _Quantidade = value;
            }
        }
        public DateTime DataEmissao
        {
            get
            {
                return _DataEmissao = DateTime.Now; 
            }
            set
            {
                _DataEmissao = value;
            }
        }
        public string DescricaoDoProduto
        {
            get
            {
                return _DescricaoDoProduto;
            }
            set
            {
                _DescricaoDoProduto = value;
            }
        }
    }
}
