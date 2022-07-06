# C# Redis PUB/SUB Sample

## Introduction

用 C# 配合 StackExchange.Redis 套件實作簡單的 PUB/SUB 範例。

```shell
# 建立 Redis 資料庫
docker run --name some-redis -d -p 6379:6379 redis
```

redis.pub 專案是發佈者，redis.sub 專案是訂閱者。

兩者都執行後，於發佈者輸入字串，訂閱者也會即時收到
