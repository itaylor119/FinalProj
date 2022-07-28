using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;



namespace pubsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pubsController : ControllerBase
    {
        private readonly Repositories.authorDBRepo _auRepo;
        private readonly Repositories.bookDBRepo _bkRepo;
        private readonly Repositories.pubDBRepo _pubRepo;

        public pubsController(Repositories.authorDBRepo auRepo, Repositories.bookDBRepo bkRepo, Repositories.pubDBRepo pubRepo)
        {
            _auRepo = auRepo;
            _bkRepo = bkRepo;
            _pubRepo = pubRepo;
        }

        // GET: api/pubs/authors
        [HttpGet("authors")]
        public IEnumerable<Model.Author> Get()
        {
            return _auRepo.FindAll();
        }

        // GET: api/pubs/books
        [HttpGet("titles/authors/{id}")]
        public IList<Model.Book> GetAuBooks(string id)
        {
            return _bkRepo.FindFor(id);
        }

        // GET: api/pubs/books
        [HttpGet("titles")]
        public IList<Model.Book> GetallBooks(string id)
        {
            return _bkRepo.FindAll();
        }

        // GET: api/pubs/publishers
        [HttpGet("publishers")]
        public IEnumerable<Model.Publisher> GetPub()
        {
            return _pubRepo.FindAll();
        }

        // GET api/pubs/authors/1243-45-6789
        [HttpGet("authors/{id}")]
        public IActionResult Get(string id)
        {
            Model.Author au = _auRepo.Find(id);

            if (au == default(Model.Author)) return NotFound();

            return Ok(au); 
        }

        //GET api/pubs/books/ID
        [HttpGet("titles/{id}")]
        public IActionResult GetBook(string id)
        {
            Model.Book bk = _bkRepo.Find(id);

            if (bk == default(Model.Book)) return NotFound();

            return Ok(bk);
        }

        //GET api/pubs/books/ID
        [HttpGet("titles/{id}")]
        public IActionResult GetBookPub(string id)
        {
            string bk = _bkRepo.FindPub(id);

            return Ok(bk);
        }

        // GET api/pubs/publishers/ID
        [HttpGet("publishers/{id}")]
        public IActionResult GetPub(string id)
        {
            Model.Publisher pb = _pubRepo.Find(id);

            if (pb == default(Model.Publisher)) return NotFound();

            return Ok(pb);
        }

        // POST api/pubs/authors
        [HttpPost("authors")]
        public IActionResult Post(Model.Author au)
        {
            if (_auRepo.Create(au) == false)
                return BadRequest(); 

            return Ok(au); 
        }

        // POST api/pubs/books
        [HttpPost("titles")]
        public IActionResult PostBook(Model.Book bk)
        {
            if (_bkRepo.Add(bk) == false)
                return BadRequest();

            return Ok(bk);
        }

        // POST api/pubs/publishers
        [HttpPost("publishers")]
        public IActionResult PostPub(Model.Publisher pb)
        {
            if (_pubRepo.Create(pb) == false)
                return BadRequest();

            return Ok(pb);
        }

        // PUT api/pubs/authors
        [HttpPut("authors")]
        public IActionResult Put(Model.Author x)
        {
            if (_auRepo.Update(x) == false)
                return BadRequest();

            return Ok(x);
        }

        // PUT api/pubs/books
        [HttpPut("titles")]
        public IActionResult PutBook(Model.Book x)
        {
            if (_bkRepo.Update(x) == false)
                return BadRequest();

            return Ok(x);
        }

        // PUT api/pubs/publishers
        [HttpPut("publishers")]
        public IActionResult PutPub(Model.Publisher x)
        {
            if (_pubRepo.Update(x) == false)
                return BadRequest();

            return Ok(x);
        }

        // DELETE api/pubs/authors/123-45-6789
        [HttpDelete ("authors/{id}")]
        public IActionResult Delete(string id)
        {
            if(_auRepo.Delete(new Model.Author() { au_id = id } ) == false)
            {
                return BadRequest(); 
            }

            return Ok(id); 
        }

        // DELETE api/pubs/books/ID
        [HttpDelete("titles/{id}")]
        public IActionResult DeleteBook(string id)
        {
            if (_bkRepo.Delete(new Model.Book() { bk_title_id = id }) == false)
            {
                return BadRequest();
            }

            return Ok(id);
        }

        // DELETE api/pubs/publishers/ID
        [HttpDelete("publishers/{id}")]
        public IActionResult DeletePub(string id)
        {
            if (_pubRepo.Delete(new Model.Publisher() { pb_id = id }) == false)
            {
                return BadRequest();
            }

            return Ok(id);
        }

        // ---------Next are titleauthor methods---------

        // POST api/pubs/titles/ID/authors/ID
        [HttpPost("titles/{bid}/authors/{id}")]
        public IActionResult PostTA(string bid, string id)
        {
            if (_bkRepo.AddFor(_bkRepo.Find(bid), id) == false)
                return BadRequest();

            return Ok(id);
        }

        // DELETE api/pubs/titles/ID/authors/ID
        [HttpDelete("titles/{bid}/authors/{id}")]
        public IActionResult DeleteTA(string bid, string id)
        {
            if (_bkRepo.DeleteFor(_bkRepo.Find(bid), id) == false)
            {
                return BadRequest();
            }

            return Ok(id);
        }

        // DELETE api/pubs/titles/authors/ID
        [HttpDelete("titles/authors/{id}")]
        public IActionResult DeleteTA_A(string id)
        {
            if (_bkRepo.auDelete(id) == false)
            {
                return BadRequest();
            }

            return Ok(id);
        }
    }
}
