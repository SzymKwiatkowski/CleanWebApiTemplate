using RestApiTemplate.Application.Common.Models;
using RestApiTemplate.Application.TodoItems.Commands.CreateTodoItem;
using RestApiTemplate.Application.TodoItems.Commands.DeleteTodoItem;
using RestApiTemplate.Application.TodoItems.Commands.UpdateTodoItem;
using RestApiTemplate.Application.TodoItems.Commands.UpdateTodoItemDetail;
using RestApiTemplate.Application.TodoItems.Queries.GetTodoItemsWithPagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestApiTemplate.Application.BoardTasks.Models;
using RestApiTemplate.Application.BoardTasks.Queries.GetBoardTasksList;
using RestApiTemplate.Application.BoardTasks.Queries.GetBoardTask;
using RestApiTemplate.Application.BoardTasks.Commands.CreateBoardTask;
using RestApiTemplate.Application.BoardTasks.Commands.UpdateBoardTask;
using RestApiTemplate.Application.BoardTasks.Commands.DeleteBoardTask;

namespace RestApiTemplate.WebUI.Controllers;

//[Authorize]
public class BoardTasksController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateBoardTaskCommand command)
    {
        return await Mediator.Send(command);
    }

    [HttpGet]
    public async Task<List<BoardTaskDto>> GetList()
    {
        return await Mediator.Send(new GetBoardTasksListQuery());
    }

    [HttpGet("{id}")]
    public async Task<List<BoardTaskDto>> GetTask(int id)
    {
        return await Mediator.Send(new GetBoardTaskQuery { TaskId = id });
    }

    [HttpPut]
    public async Task<ActionResult<BoardTaskDto>> Update(UpdateBoardTaskCommand command) 
    {
        return await Mediator.Send(command);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<int>> Delete(int id) 
    {
        return await Mediator.Send(new DeleteBoardTaskCommand { TaskId = id });
    }
}
