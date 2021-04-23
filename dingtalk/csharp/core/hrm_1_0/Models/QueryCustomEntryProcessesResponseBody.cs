// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryCustomEntryProcessesResponseBody : TeaModel {
        /// <summary>
        /// 下次获取数据的起始游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 是否有更多
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 表单信息列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryCustomEntryProcessesResponseBodyList> List { get; set; }
        public class QueryCustomEntryProcessesResponseBodyList : TeaModel {
            [NameInMap("formId")]
            [Validation(Required=false)]
            public string FormId { get; set; }

            [NameInMap("formName")]
            [Validation(Required=false)]
            public string FormName { get; set; }

            [NameInMap("formDesc")]
            [Validation(Required=false)]
            public string FormDesc { get; set; }

            [NameInMap("shortUrl")]
            [Validation(Required=false)]
            public string ShortUrl { get; set; }

        }

    }

}
