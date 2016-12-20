using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using GamePlay.Dtos;
using GamePlay.Models;
using System.Data.Entity;


// While I used APIs, I would hopefully implement this application 
//as a single page application using APIs to build a site and a mobile app
//I will be learning: Angular, Backbone, and Ember
//I am learning more about RESTful API's
//Choosing between clientside and serverside processing has come up quite abit and I am learning more
//about when to use either and for which part of the website in relation to database side, and UI rendering 
namespace GamePlay.Controllers.api
{
    public class GamesController : ApiController
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<GameDto> GetGames()
        {
            return _context.Games
                .Include(m => m.Category)
                .ToList()
                .Select(Mapper.Map<GameModel, GameDto>);
        }

        public IHttpActionResult GetGame(int id)
        {
            var game = _context.Games.SingleOrDefault(c => c.Id == id);

            if (game == null)
                return NotFound();

            return Ok(Mapper.Map<GameModel, GameDto>(game));
        }

        [HttpPost]
        public IHttpActionResult CreateGame(GameDto gameDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var game = Mapper.Map<GameDto, GameModel>(gameDto);
            _context.Games.Add(game);
            _context.SaveChanges();

            gameDto.Id = game.Id;
            return Created(new Uri(Request.RequestUri + "/" + game.Id), gameDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateGame(int id, GameDto gameDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var gameInDb = _context.Games.SingleOrDefault(c => c.Id == id);

            if (gameInDb == null)
                return NotFound();

            Mapper.Map(gameDto, gameInDb);

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteGame(int id)
        {
            var gameInDb = _context.Games.SingleOrDefault(c => c.Id == id);

            if (gameInDb == null)
                return NotFound();

            _context.Games.Remove(gameInDb);
            _context.SaveChanges();

            return Ok();
        }
        
    }
}
