﻿
using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.Domain.Queries
{
    public interface IClienteQuery
    {
       
        public List<ResponseGetCliente> GetCliente(string dato,string dato2,string dato3);
        


    }
}
