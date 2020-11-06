namespace Developer.MsSql.Fundamentals.Basics
{
    public class DatabaseMethods
    {
        public void AttachDatabase()
        {
            /* *** Correct Way to Attach Database ***

                        USE[master]
                        GO
                        CREATE DATABASE[DatabaseName] ON
                        (FILENAME = 'C:\...\MSSQL\DATA\DatabaseName.mdf'),
                        (FILENAME = 'C:\...\MSSQL\DATA\DatabaseName.ldf')
                        FOR ATTACH
                        GO

                    */

            // Access Denied Error: https://www.mssqltips.com/sqlservertip/4542/access-is-denied-error-when-attaching-a-sql-server-database/
        }


        public void ReconnectAndDropDatabase()
        {
            /*

            USE [master];
            GO 
            ALTER DATABASE DatabaseName 
            SET SINGLE_USER
            WITH ROLLBACK IMMEDIATE;
            GO
            DROP DATABASE [DatabaseName];

            */
        }
    }
}