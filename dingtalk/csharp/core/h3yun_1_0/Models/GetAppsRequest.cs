// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetAppsRequest : TeaModel {
        /// <summary>
        /// 查询类型。All=全部，Solution=以解决方案编码为条件来查询应用，AppCode=以应用编码为条件来查询
        /// </summary>
        [NameInMap("queryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// 待查询的编码数组。queryType参数为All时，此值可为空
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
