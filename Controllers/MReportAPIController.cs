using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MReportAPI.Data;

namespace MReportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MHAReportAPIController<THAEntity, THARepository> : ControllerBase
        where THAEntity : class, IHAuthEntity
        where THARepository : IAHRepository<THAEntity>
    {
        private readonly THARepository HArepository;

        public MHAReportAPIController(THARepository HArepository)
        {
            this.HArepository = HArepository;
        }

        //get by auth
        // GET: api/[Controlle]/Auth
        [HttpGet("Auth")]
        public async Task<ActionResult<THAEntity>> Auth()
        {
            string id = HttpContext.User.Identity.Name;
            var movie = await HArepository.Auth(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;

        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<THAEntity>>> Get()
        {
            return await HArepository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<THAEntity>> Get(int id)
        {
            var movie = await HArepository.Get(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }


        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, THAEntity movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }
            await HArepository.Update(movie);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<THAEntity>> Post(THAEntity movie)
        {
            await HArepository.Add(movie);
            return CreatedAtAction("Get", new { id = movie.Id }, movie);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<THAEntity>> Delete(int id)
        {
            var movie = await HArepository.Delete(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }
    }


    [Route("api/[controller]")]
    [ApiController]
    public abstract class MAReportAPIController<TAEntity, TARepository> : ControllerBase
        where TAEntity : class, IAuthEntity
        where TARepository : IARepository<TAEntity>
    {
        private readonly TARepository Arepository;

        public MAReportAPIController(TARepository Arepository)
        {
            this.Arepository = Arepository;
        }

        //get by auth
        // GET: api/[Controlle]/Auth
        [HttpGet("Auth")]
        public async Task<ActionResult<TAEntity>> Auth()
        {
            string id = HttpContext.User.Identity.Name;
            var movie = await Arepository.Auth(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;

        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TAEntity>>> Get()
        {
            return await Arepository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TAEntity>> Get(int id)
        {
            var movie = await Arepository.Get(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }


        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TAEntity movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }
            await Arepository.Update(movie);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TAEntity>> Post(TAEntity movie)
        {
            await Arepository.Add(movie);
            return CreatedAtAction("Get", new { id = movie.Id }, movie);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TAEntity>> Delete(int id)
        {
            var movie = await Arepository.Delete(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }
    }


    [Route("api/[controller]")]
    [ApiController]
    public abstract class MReportAPIController<TEntity,TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;
        //private MReportAPIContext context;

        public MReportAPIController(TRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var movie = await repository.Get(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }
        

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }
            await repository.Update(movie);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity movie)
        {
            await repository.Add(movie);
            return CreatedAtAction("Get", new { id = movie.Id }, movie);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var movie = await repository.Delete(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

    }
}
