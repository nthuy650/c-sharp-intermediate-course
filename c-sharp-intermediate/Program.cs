using Composition;
using Inheritance;

namespace c_sharp_intermediate;

class Program
{
    static void Main(string[] args)
    {
        var dbMigrator = new DbMigrator(new Logger());

        var logger = new Logger();

        var installer = new Installer(logger);

        dbMigrator.Migrate();
        installer.Install();
    }
}