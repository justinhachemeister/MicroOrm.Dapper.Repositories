using MicroOrm.Dapper.Repositories.SqlGenerator;
using MySqlConnector;
using Repositories.Base;

namespace Repositories.MySql.Tests;

public class MySqlConnectorDatabaseFixture()
    : DatabaseFixture(new TestDbContext(new MySqlConnection($"Server=localhost;Uid=root;Pwd={DotEnv.GetTestDbPass()}"), SqlProvider.MySQL));
