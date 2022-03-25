// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetCustomerTracksByRelationIdResponseBody : TeaModel {
        /// <summary>
        /// 是否还有下一页。
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一页的游标。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 数据列表。
        /// </summary>
        [NameInMap("resultList")]
        [Validation(Required=false)]
        public List<GetCustomerTracksByRelationIdResponseBodyResultList> ResultList { get; set; }
        public class GetCustomerTracksByRelationIdResponseBodyResultList : TeaModel {
            /// <summary>
            /// 动态内容。
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 操作人姓名。
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// 动态详情。
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public Dictionary<string, string> Detail { get; set; }

            /// <summary>
            /// 动态格式：markdown表示markdown格式，为空表示老格式
            /// </summary>
            [NameInMap("format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// 创建时间。
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 写入动态的三方应用身份信息。
            /// </summary>
            [NameInMap("isvInfo")]
            [Validation(Required=false)]
            public GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo IsvInfo { get; set; }
            public class GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo : TeaModel {
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }
                [NameInMap("orgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }
            };

            /// <summary>
            /// 动态标题。
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 动态类型。
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// 动态类型分组。
            /// </summary>
            [NameInMap("typeGroup")]
            [Validation(Required=false)]
            public int? TypeGroup { get; set; }

        }

    }

}
