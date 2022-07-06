using redis.lib;
using StackExchange.Redis;

var redis = RedisHelper.RedisConnection;        
ISubscriber sub = redis.GetSubscriber();        
sub.Subscribe("receive", (channel, message) =>  
{
    // 訂閱者接收到要處理的邏輯寫在這邊
    Console.WriteLine("channel: {0}, message: {1}", channel, message);
});

// 為了讓 console app 不要結束，做迴圈讓程式一直執行
while (true)
{
    Thread.Sleep(100);    
}