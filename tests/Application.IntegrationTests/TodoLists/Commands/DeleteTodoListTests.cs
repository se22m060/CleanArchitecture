using se22m060_swe_ca.Application.Common.Exceptions;
using se22m060_swe_ca.Application.TodoLists.Commands.CreateTodoList;
using se22m060_swe_ca.Application.TodoLists.Commands.DeleteTodoList;
using se22m060_swe_ca.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace se22m060_swe_ca.Application.IntegrationTests.TodoLists.Commands;

using static Testing;

public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
