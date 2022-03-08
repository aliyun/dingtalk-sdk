// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksearch_1_0.Models
{
    public class BatchInsertSearchItemRequest : TeaModel {
        [NameInMap("searchItemModels")]
        [Validation(Required=false)]
        public List<BatchInsertSearchItemRequestSearchItemModels> SearchItemModels { get; set; }
        public class BatchInsertSearchItemRequestSearchItemModels : TeaModel {
            /// <summary>
            /// 数据项的脚注，长度不能超过64
            /// </summary>
            [NameInMap("footer")]
            [Validation(Required=false)]
            public string Footer { get; set; }

            /// <summary>
            /// 数据项的头像，长度不能超过512
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// 数据项的id，tabId和orgId相同的情况下，itemId唯一标识一条数据项，长度不能超过128
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// 数据项的移动端跳转url地址，若同时配置默认url和mobileUrl，移动端跳转链接优先使用mobileUrl
            /// </summary>
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            /// <summary>
            /// 数据项的PC端跳转url地址，若同时配置默认url和pcUrl，PC端跳转链接优先使用pcUrl
            /// </summary>
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

            /// <summary>
            /// 数据项的摘要，长度不能超过64
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// 数据项的标题，长度不能超过16
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 数据项的默认url地址，若mobileUrl或pcUrl没有配置，则使用该url地址，默认url和mobileUrl、pcUrl至少配置其中一个
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
