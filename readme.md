### 工具类：JPushUtil.cs
一个对外方法，用来发送通知！
public MessageResult sendNotification(HashSet<string> targets, TargetType targetType, string content) 
参数说明：
@targets：发送目标的hashset集合，在我们项目中可以表现为用户ID
@targetType：枚举类型，表示发送的方式，根据用户ID发送，可以选择ALIAS发送，更多选择如下：
	public enum TargetType   
    {
        TAG,//根据标签发送
        ALIAS,//根据别名发送
        REGISTRATIONID,//根据注册ID发送
        BROADCAST//广播放松
    }
@content：通知内容

### 测试类：program.cs

### 环境搭建：
1.导入官方提供的JPush C# sdk包，名称为：cn.jpush.api.dll
2.导入依赖包Newtonsoft.Json.dll，如果项目已存在，请忽略！