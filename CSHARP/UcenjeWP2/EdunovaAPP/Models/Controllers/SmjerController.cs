﻿using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
    /// <summary>
    /// Namjenjeno za CRUD operacije nad entitetom smjer u bazi
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController : ControllerBase
    {
        /// <summary>
        /// Kontest za rad s bazom koji će biti postavljen s pomoću Dependecy Injection-om
        /// </summary>
        private readonly EdunovaContext _context;
        /// <summary>
        /// Konstruktor klase koja prima Edunova kontext
        /// pomoću DI principa
        /// </summary>
        /// <param name="context"></param>
        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Dohvaća sve smjerove iz baze
        /// </summary>
        /// <remarks>
        /// Primjer upita
        /// 
        ///    GET api/v1/Smjer
        ///    
        /// </remarks>
        /// <returns>Smjerovi u bazi</returns>
        /// <response code="200">Sve OK</response>
        /// <response code="400">Zahtjev nije valjan</response>
        [HttpGet]
        public IActionResult Get()
        {
             if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var smjerovi = _context.Smjerovi.ToList();
                if (smjerovi==null || smjerovi.Count == 0)
                {
                    return new EmptyResult();
                }
                return new JsonResult(smjerovi);
            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable,
                    ex.Message);
            }
        }

        

    }
}
