using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;
using System.Collections.Generic;


namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet, Route("GetAll")]

        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        }

        [HttpGet, Route("GetField")]
        public IActionResult GetFields()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFields();
            return Ok(persons);
        }

        [HttpGet, Route("GetByGender/{gender}")]
        public IActionResult GetByGender(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender(gender);
            return Ok(persons);

        }
        [HttpGet, Route("GetDifference/{gender}, {age}")]
        public IActionResult GetDifference(char gender, int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetDifference(gender, age);
            return Ok(persons);
        }
        [HttpGet, Route("GetByRage/{age1}, {age2}")]
        public IActionResult GetByAgeRage(int age1, int age2)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAgeRange(age1, age2);
            return Ok(persons);

        }
        [HttpGet, Route("GetJobs")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        }

        [HttpGet, Route("GetStartsWith/{word}")]
        public IActionResult GetStartsWith(string word)
        {
            var repository = new PersonRepository();
            var persons = GetStartsWith(word);
            return Ok(persons);
        }

        [HttpGet, Route("GetContains/{word}")]
        public IActionResult GetContains(string word)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains(word);
            return Ok(persons);



        }
        [HttpGet, Route("GetByList")]
        public IActionResult GetByList(List<int> ages)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByList(ages);
            return Ok(persons);
        }
        [HttpGet, Route("GetByAge/{age}")]
        public IActionResult GetByAge(int age)
        {
            var repository = new PersonRepository();

            var persosn = repository.GetByAge(age);
            return Ok(persosn);
        }
        [HttpGet, Route("GetByOrdered/{age}")]
        public IActionResult GetOrdered(int age)
        {
            var repository = new PersonRepository();

            var persosn = repository.GetOrdered(age);
            return Ok(persosn);
        }
        [HttpGet, Route("GetOrderedDesc/{age1}, {age2}")]
        public IActionResult GetOrderedDesc(int age1, int age2)
        {
            var repository = new PersonRepository();
            var persons = repository.GetOrderedDesc(age1, age2);
            return Ok(persons);
        }

        [HttpGet, Route("CountPerson/{gender}")]
        public IActionResult CountPerson(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.CountPerson(gender);
            return Ok(persons);
        }

        [HttpGet, Route("ExistPerson/{lastName}")]
        public IActionResult ExistPerson(string lastName)
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPerson(lastName);
            return Ok(persons);

        }
        [HttpGet, Route("GetFirst/{job}/{age}")]
        public IActionResult GetFirst(string job, int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetFirst(job, age);
            return Ok(persons);


        }

        [HttpGet, Route("TakePerson/{job}/{takeNumber}")]
        public IActionResult TakePerson(string job, int takeNumber)
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson(job, takeNumber);
            return Ok(persons);
        }

        [HttpGet, Route("SkipPerson/{job}/{skipNumber}")]
        public IActionResult SkipPerson(string job, int skipNumber)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson(job, skipNumber);
            return Ok(persons);

        }

        [HttpGet, Route("SkipTakePerson/{job}/{skipNumber}")]
        public IActionResult SkipTakePerson(string job, int skipNumber)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTakePerson(job, skipNumber);
            return Ok(persons);
        
        }


    }
}