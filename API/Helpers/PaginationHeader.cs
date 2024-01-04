namespace API.Helpers;

public class PaginationHeader
{
    public PaginationHeader(int curreentPage, int itemsPerPage,int totalItems, int totalPages)
    {
        CurrentPage =  curreentPage;
        ItemsPerPage = itemsPerPage;
        TotalItems = totalItems;
        TotalPages = totalPages;
    }

    public int CurrentPage { get; set; }
    public int ItemsPerPage { get; set; }
    public int TotalItems { get; set; }
    public int TotalPages { get; set; }
}
