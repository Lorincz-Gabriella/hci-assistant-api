using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HCI.AIAssistant.API.Models.DTOs.AIAssistantController;

namespace HCI.AIAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AIAssistantController : ControllerBase
{
    [HttpPost("/message")]
    public async Task<ActionResult<AIAssistantControllerPostMessageResponseDTO>> PostMessageAsync(
    [FromBody] AIAssistantControllerPostMessageRequestDTO requestDTO)
{
    AIAssistantControllerPostMessageResponseDTO response = new()
    {
        TextMessage = $"You said : {requestDTO.TextMessage}"
    };
    return Ok(response);
}
}
