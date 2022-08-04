// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListHotDocsResponseBody : TeaModel {
        /// <summary>
        /// 热门文档列表。
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<DentryModel> Items { get; set; }

    }

}
