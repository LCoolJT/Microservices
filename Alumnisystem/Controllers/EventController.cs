using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Alumnisystem.Controllers;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    private readonly ILogger<EventController> _logger;

    private List<Event> Events = new List<Event>();

    public EventController(ILogger<EventController> logger)
    {
        _logger = logger;
        _addexampleEvents();
    }

    private void _addexampleEvents()
    {
        Events.Add(new Event
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(0)),
            ID = 2,
            Name = "Homework1",
            Summary = "Event for Homework submission"
        }); 
        Events.Add(new Event
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(0)),
            ID = 1,
            Name = "Homework3",
            Summary = "Event for Homework submission"
        });
    }

    [HttpGet(Name = "/GetEvent")]
    public IEnumerable<Event> Get()
    {
        return Enumerable.Range(0, Events.Count -1).Select(index => Events[index])
        .ToArray();
    }

    /*[HttpGet(Name = "/AddEvent")]
    public void Add(int _fromnow, int _ID, String _Name, String _Summary)
    {
        for (int i = 0; i <= Events.Count; i++)
        {
            if (Events[i].ID == _ID)
            {
                return;
            }
        }
        Events.Add(new Event {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(_fromnow)),
            ID = _ID, 
            Name = _Name, 
            Summary = _Summary });
    }*/

    /*[HttpGet(Name = "RemEvent")]
    public void Rem(int _ID)
    {
        for(int i = 0; i <= Events.Count; i++)
        {
            if (Events[i].ID == _ID)
            {
                Events.RemoveAt(i);
                return;
            }
        }
    }*/
}