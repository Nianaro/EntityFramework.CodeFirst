namespace EntityFramework.CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Repository : DbContext
    {
        // Контекст настроен для использования строки подключения "Repository" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "EntityFramework.CodeFirst.Repository" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Repository" 
        // в файле конфигурации приложения.
        public Repository()
            : base("name=Repository")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Publications> Publications { get; set; }
    }
}