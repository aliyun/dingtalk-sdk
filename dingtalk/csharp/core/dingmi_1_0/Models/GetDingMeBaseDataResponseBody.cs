// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class GetDingMeBaseDataResponseBody : TeaModel {
        /// <summary>
        /// 是否缓存
        /// </summary>
        [NameInMap("fromCache")]
        [Validation(Required=false)]
        public bool? FromCache { get; set; }

        /// <summary>
        /// 结果集
        /// </summary>
        [NameInMap("rawset")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Rawset { get; set; }

        /// <summary>
        /// 运行时间
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public long? Runtime { get; set; }

        /// <summary>
        /// 字段解释
        /// </summary>
        [NameInMap("tips")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tips { get; set; }

    }

}
