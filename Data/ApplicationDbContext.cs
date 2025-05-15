using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using api.Models;

namespace api.Data
{
    //? Class ApplicationDBContext kết thừa từ DbContext ( 1 class được tải từ  package entity framework core)
    //?     -> Kết nối DB
    //?     -> Quảng lý các Entity thông qua  " DbSet<>"
    //?     -> Thực hiện các thao tác như SaveChanges, Add, Remove hoặc Query trong LinQ

    //* Đây là phần Core của tầng Dữ liệu trong Application, là phần trung gian giữa System và DB 
    public class ApplicationDBContext : DbContext
    {
        //* Đây là Constructor

        //?  Constructor nhận parameter " dbContextOptions " kiểu DbContextOptions    
        //?  DbContextOptions chứa thông tin config connect đến với DB
        //?     -> ConnectString
        //?     -> Loại DB ( SQL Server, MySQL, PostgreSQL,...)
        //?  Constructor gọi constructor của class "base" (DbContext) và truyền dbContextOptions để tạo DbContext
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }


        //? DbSet properties
        //? DbSet<T> là 1 properties thuộc kiểu generic, đại diện cho 1 table trong DB
        //? DbSet ánh xạ tới 1 Table trong DB, <T> là 1 class Entity ( Stock và Comment là Entities)
        //? Tên của Properties "(Stocks / Comments)" thường tương ứng với Table name trong DB
        
        public DbSet<Stock> Stocks {get; set;}
        
        public DbSet<Comment> Comments {get; set;}


        
    }
}