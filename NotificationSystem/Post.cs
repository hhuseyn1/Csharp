namespace Postspace;
class Post {

    public int Id { get; set; } 
    public string? Content { get; set; }
    public DateTime CrTime{ get; set; }
    public int LikeCount { get; set; }
    public int ViewCount { get; set; }

    public Post(int Id,string Content,DateTime CrTime,int LikeCount,int ViewCount)
    {
        this.Id = Id;
        this.Content = Content;
        this.CrTime = CrTime;
        this.LikeCount = LikeCount;
        this.ViewCount = ViewCount;
    }

    public override string ToString()
    {
        return $@"Post Id: {Id}
Content: {Content}
Creation Time: {CrTime}
Like: {LikeCount}
View: {ViewCount}";   
}







}
