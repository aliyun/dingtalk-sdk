// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class BatchInsertBizObjectRequest : TeaModel {
        /// <summary>
        /// 待新增的业对象json数组
        /// </summary>
        [NameInMap("bizObjectJsonArray")]
        [Validation(Required=false)]
        public List<string> BizObjectJsonArray { get; set; }

        /// <summary>
        /// 是否是草稿数据。true=创建草稿数据，false=创建生效数据
        /// </summary>
        [NameInMap("isDraft")]
        [Validation(Required=false)]
        public bool? IsDraft { get; set; }

        /// <summary>
        /// 操作用户id
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 表单编码
        /// </summary>
        [NameInMap("schemaCode")]
        [Validation(Required=false)]
        public string SchemaCode { get; set; }

    }

}
