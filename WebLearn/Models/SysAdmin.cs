using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 如果你做远程方法调用(RPC）时，比如，服务器端有个类A及对象a，客户端需要无视网络的存在，直接调用对象a。
    /// 这种情况下，就需要把类A设计为可序列化的，那么它的实例a也就可以实例化了。
    /// 说得简单点，在服务器的 命名空间中的对象a, 肯定不能直接被客户端的命名空间中的一个对象调用，这不可能，对吧。
    /// 但是如果你把服务器的对象a中的特征属性（不一定是所有属性）变成xml，传送到客户端，然后客户端用你给的特征属性可以模拟的生成一个对象a。
    /// 这个过程就是 rpc，而要把对象a变成xml，就是序列化，反之，把xml变成模拟对象a就是反序列化。
    /// </summary>
    [Serializable]
    public class SysAdmin
    {
        public int LoginId { set; get; }
        public string AdminName { get; set; }
        public string AdminPwd { get; set; }
    }
}