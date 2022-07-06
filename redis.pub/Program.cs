using redis.lib;
using StackExchange.Redis;

ISubscriber sub = RedisHelper.RedisConnection.GetSubscriber();
sub.Publish("receive", "=====start=====");

while(true)
{
    var input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        sub.Publish("receive", input);
        Console.WriteLine("send:" + input);
    }
}