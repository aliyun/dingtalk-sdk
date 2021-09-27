// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksearch_1_0.Models
{
    public class GetSearchItemResponseBody : TeaModel {
        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 数据项的id,tabId和orgId相同的情况下，itemId唯一标识一条数据项
        /// </summary>
        [NameInMap("itemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// 数据项的标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 数据项的脚注
        /// </summary>
        [NameInMap("footer")]
        [Validation(Required=false)]
        public string Footer { get; set; }

        /// <summary>
        /// 数据项的摘要
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// 数据项的头像
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// 数据项的跳转url地址
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
