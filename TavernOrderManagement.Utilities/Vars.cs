namespace TavernOrderManagement.Utilities
{
    public class Vars
    {
        public static class ConnStrings
        {
            public static string Db => $"DataSource={Vars.Db.FreshDb};Version=3;Foreign Keys=true;FailIfMissing=True;";
        }

        protected static class Db
        {
            public static readonly string FreshDb = @"tomDb";
        }
    }
}
