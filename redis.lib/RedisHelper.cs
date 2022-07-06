using StackExchange.Redis;

namespace redis.lib;

public static class RedisHelper                                                  
{                                                                         
    private static ConnectionMultiplexer? _redis;                           
    public static ConnectionMultiplexer RedisConnection {                 
        get                                                               
        {                                                                 
            if (_redis != null) return _redis;                              
            _redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");           
            return _redis;                                                 
        }                                                                 
    }                                                                     
}