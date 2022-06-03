using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entities.Enuns
{
    enum OrderStatus : int
    {
        PeddingPayMent = 0,
        Processing = 1,
        Shipped = 2,
        Delivered =3
    }
}
