// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryCustomerByPageResponseBody : TeaModel {
        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// resultList
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryCustomerByPageResponseBodyList> List { get; set; }
        public class QueryCustomerByPageResponseBodyList : TeaModel {
            /// <summary>
            /// 客户Code
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 创建时间(单位MS)
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 客户描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 客户名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 状态：启用(valid), 停用(invalid), 删除(deleted)
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 用户自定义code
            /// </summary>
            [NameInMap("userDefineCode")]
            [Validation(Required=false)]
            public string UserDefineCode { get; set; }

        }

    }

}
