using se22m060_swe_ca.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace se22m060_swe_ca.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
