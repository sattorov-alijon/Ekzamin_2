using Tasc8;

var post1=new Post();
post1.Title="Norak";
post1.Description="Baroi sauru sayohat behtarin ast";
post1.LikeCount=0;
post1.Comment("Behtarin");
post1.Comment("Ajoib");
post1.Like();
post1.Like();
post1.Like();
post1.Like();


var post2=new Post();
post2.Title="Varzob";
post2.Description="Baroi sauru sayohat behtarin ast";
post2.LikeCount=0;
post2.Comment("Zur");
post2.Comment("Zebo");
post2.Like();
post2.Like();
post2.Like();
post2.Like();


var post3=new Post();
post3.Title="Qalai Hisor";
post3.Description="Makoni Tarikhi";
post3.LikeCount=0;
post3.Comment("Didan kardan darkor");
post3.Comment("Zebo");
post3.Like();
post3.Like();
post3.Like();
post3.Like();



var post4=new Post();
post4.Title="Hulbuk";
post4.Description="Makoni Tarikhi";
post4.LikeCount=0;
post4.Comment("Didan kardan darkor");
post4.Comment("Ajoib");
post4.Comment("Zebo");
post4.Like();
post4.Like();
post4.Like();
post4.Like();


var post5=new Post();
post5.Title="Kui KHojamumin";
post5.Description="Balandii kuh 1334m";
post5.LikeCount=0;
post5.Comment("Ba fikram in kuhi namak ast!");
post5.Comment("Chashmahoi ziyode dorad man didan kardam");
post5.Like();
post5.Like();
post5.Like();
post5.Like();




List<Post> Posts=new List<Post>();


Posts.Add(post2);


void posts(Post post)
{
    Posts.Add(post);
}




foreach (var item in Posts)
{
    System.Console.WriteLine(item.Title);
    System.Console.WriteLine(item.Description);
    System.Console.Write("number of Likes:  ");
    System.Console.WriteLine(item.LikeCount);
    System.Console.WriteLine(item.Comments);

}