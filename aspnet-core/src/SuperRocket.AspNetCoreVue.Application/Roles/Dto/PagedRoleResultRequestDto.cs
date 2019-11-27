using Abp.Application.Services.Dto;

namespace SuperRocket.AspNetCoreVue.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

