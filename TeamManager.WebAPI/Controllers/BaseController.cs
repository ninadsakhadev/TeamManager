using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;
using TeamManager.WebAPI.Models;

namespace TeamManager.WebAPI.Controllers
{
    public class BaseController : ApiController
    {
        public void AddPagination<T>(IQueryable<T> collection, int page, int pageSize, string routeName, string sort = null)
        {
            var totalCount = collection.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var urlHelper = new UrlHelper(Request);
            var preLink = page > 1 ? urlHelper.Link(routeName,
                new
                {
                    page = page - 1,
                    pageSize = pageSize,
                    sort = sort
                }) : "";
            var nextLink = page < totalPages ? urlHelper.Link(routeName,
                new
                {
                    page = page + 1,
                    pageSize = pageSize,
                    sort = sort
                }) : "";
            var paginationHeader = new
            {
                currentPage = page,
                pageSize = pageSize,
                totalCount = totalCount,
                totalPages = totalPages,
                preLink = preLink,
                nextLink = nextLink
            };

            HttpContext.Current.Response.Headers.Add("X-Pagination", Newtonsoft.Json.JsonConvert.SerializeObject(paginationHeader));
        }
    }
}
