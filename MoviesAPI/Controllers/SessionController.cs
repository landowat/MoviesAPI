﻿using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Data;
using MoviesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SessionController : ControllerBase
{
    private MovieContext _context;
    private IMapper _mapper;

    public SessionController(MovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddSession(CreateSessionDto dto)
    {
        Session session = _mapper.Map<Session>(dto);
        _context.Sessions.Add(session);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetSessionsById), new { movieId = session.MovieId, cinemaId = session.CinemaId }, session);
    }

    [HttpGet]
    public IEnumerable<ReadSessionDto> GetSessions()
    {
        return _mapper.Map<List<ReadSessionDto>>(_context.Sessions.ToList());
    }

    [HttpGet("{movieId}/{cinemaId}")]
    public IActionResult GetSessionsById(int movieId, int cinemaId)
    {
        Session session = _context.Sessions.FirstOrDefault(session => session.MovieId == movieId && session.CinemaId == cinemaId);
        if (session != null)
        {
            ReadSessionDto sessionDto = _mapper.Map<ReadSessionDto>(session);

            return Ok(sessionDto);
        }
        return NotFound();
    }
}
