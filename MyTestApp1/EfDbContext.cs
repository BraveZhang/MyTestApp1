using MyTestApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyTestApp1
{
    public class EfDbContext : DbContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public EfDbContext() : base("name=ConnectionString")
        {
            // 初始化数据策略 如果EF检测到数据库模型发生了改变，将更新模型
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EfDbContext>());
        }

        public DbSet<Blog> Blogs { get; set; }
        //public IDbSet<Blog> Blogs2 { get; set; }
    }
}
