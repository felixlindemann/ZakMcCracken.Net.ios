namespace ZakMcCracken.Net.CS
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ExitCodeContext : DbContext
    {
        // Der Kontext wurde für die Verwendung einer ExitCodeContext-Verbindungszeichenfolge aus der 
        // Konfigurationsdatei ('App.config' oder 'Web.config') der Anwendung konfiguriert. Diese Verbindungszeichenfolge hat standardmäßig die 
        // Datenbank 'ZakMcCracken.Net.CS.ExitCodeContext' auf der LocalDb-Instanz als Ziel. 
        // 
        // Wenn Sie eine andere Datenbank und/oder einen anderen Anbieter als Ziel verwenden möchten, ändern Sie die ExitCodeContext-Zeichenfolge 
        // in der Anwendungskonfigurationsdatei.
        public ExitCodeContext()
            : base("name=ExitCodeContext")
        {
        }

        // Fügen Sie ein 'DbSet' für jeden Entitätstyp hinzu, den Sie in das Modell einschließen möchten. Weitere Informationen 
        // zum Konfigurieren und Verwenden eines Code First-Modells finden Sie unter 'http://go.microsoft.com/fwlink/?LinkId=390109'.

        public DbSet<Domain.ExitCode> ExitCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Domain.Configurations.ExitCodeConfiguration());
        }

        //public class MyEntity
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //}
    }
}