namespace Developer.MsSql.Fundamentals.Basics
{
    public class SchemaMethods
    {
        public void CreateSchema()
        {
            /*

            USE DatabaseName;
            GO
            CREATE SCHEMA schemaName;
            GO

            */
        }

        public void MoveTableToAnotherSchema()
        {
            /*
            USE DatabaseName;
            GO
            ALTER SCHEMA targetSchemaName TRANSFER sourceSchemaName.TableName;
            GO

            */
        }

        public void DropSchema()
        {
            /*
            USE DatabaseName;
            GO
            DROP SCHEMA schemaName;
            GO

            */

        }
    }
}