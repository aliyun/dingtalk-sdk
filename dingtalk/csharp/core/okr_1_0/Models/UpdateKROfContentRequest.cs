// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateKROfContentRequest : TeaModel {
        /// <summary>
        /// KR的内容。
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 待更新的划词 ID 列表。
        /// </summary>
        [NameInMap("updateQuoteList")]
        [Validation(Required=false)]
        public List<string> UpdateQuoteList { get; set; }

        /// <summary>
        /// 当前 KR ID。
        /// </summary>
        [NameInMap("krId")]
        [Validation(Required=false)]
        public string KrId { get; set; }

        /// <summary>
        /// 当前用户的userId。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
