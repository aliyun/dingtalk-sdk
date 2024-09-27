// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class OkrObjectivesByUserRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dingOKR</para>
        /// </summary>
        [NameInMap("goodsCode")]
        [Validation(Required=false)]
        public string GoodsCode { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
