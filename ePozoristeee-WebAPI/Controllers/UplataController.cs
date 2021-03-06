﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ePozoriste.Model;
using ePozoriste.Model.Requests;
using ePozoriste.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePozoriste.WebAPI.Controllers
{

    public class UplataController : BaseCRUDController<Model.Uplata, UplataSearchRequest, UplataUpsertRequest, UplataUpsertRequest>
    {
   
        public UplataController(ICRUDService<Uplata, UplataSearchRequest, UplataUpsertRequest, UplataUpsertRequest> service) : base(service)
        {
        }
    }
}