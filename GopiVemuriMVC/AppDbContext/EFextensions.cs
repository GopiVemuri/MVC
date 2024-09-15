using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace GopiVemuriMVC.AppDbContext
{
    //public class EFextensions
   public static class EFextensions
    {
        public static DbContextTransaction BegionTransation(this GopiDbContext context)
        {
            return context.Database.BeginTransaction();
        }

        public static IEnumerable<dynamic> Get<T>(this DbSet<T> Set, Expression<Func<T, bool>> predicate) where T : class
        {
            return Set.Where(predicate).ToList();
        }

        public static IEnumerable<dynamic> GetAll<T>(this DbSet<T> Set) where T : class
        {
            return Set.ToList();
        }

        public static IEnumerable<dynamic> GetAllOrderBy<T>(this DbSet<T> Set, Expression<Func<T, object>> keySelector) where T : class
        {
            return Set.OrderBy(keySelector).ToList();
        }

        public static IEnumerable<dynamic> GetAllOrderByDescending<T>(this DbSet<T> Set, Func<T, object> keySelector) where T : class
        {
            return Set.OrderByDescending(keySelector).ToList();
        }

        public static void AddAll<T>(this DbSet<T> Set, List<T> listEntity) where T : class
        {
            for (int i = 0; i < listEntity.Count; i++)
                Set.Add(listEntity[i]);
        }
        public static void Delete<T>(this DbSet<T> Set, T entity) where T : class
        {
            Set.Remove(entity);
        }

        public static void Commit(this GopiDbContext context)
        {
            context.SaveChanges();
        }

        public static void Update<T>(this GopiDbContext context, T entity) where T : class
        {
            //_Context.Entry(entity).State = EntityState.Modified;
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}